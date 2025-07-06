Imports System.Data.Odbc
Public Class Menu_Transaksi

    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader
    Dim adapter As OdbcDataAdapter
    Dim dt As DataTable
    Dim subtotal As Integer = 0
    Dim total As Integer = 0

    Sub koneksi()
        conn = New OdbcConnection("Dsn=db_FinalProject;Database=db_kopvani;Uid=root;Pwd=")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub autoGenerateFaktur()
        cmd = New OdbcCommand("SELECT MAX(FAKTUR_PESANAN) FROM tbl_transaksi", conn)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            Dim faktur As String
            If IsDBNull(dr(0)) Then
                faktur = "F001"
            Else
                faktur = "F" & (CInt(dr(0).Substring(1)) + 1).ToString("D3")
            End If
            txtFaktur.Text = faktur
        End If
    End Sub
    Sub ClearInputs()
        ' Bersihkan semua textbox dan combo box kecuali faktur pesanan
        txtHarga.Clear()
        txtJumlah.Clear()
        txtJumlahUang.Clear()
        txtKembalian.Clear()
        txtJenisMenu.Clear()
        cmbNamaMenu.SelectedIndex = -1 ' Reset ComboBox
    End Sub
    Sub loadMenu()
        Try
            Dim query As String = "
            SELECT 'menu' AS Source, KODE_MENU AS KODE, NAMA_MENU AS NAMA, HARGA_MENU AS HARGA, JENIS_MENU AS JENIS 
            FROM tbl_menu 
            UNION 
            SELECT 'paket' AS Source, NULL AS KODE, NAMA_PAKET AS NAMA, HARGA_PAKET AS HARGA, 'Paket' AS JENIS 
            FROM tbl_paketmenu"
            adapter = New OdbcDataAdapter(query, conn)
            dt = New DataTable()
            adapter.Fill(dt)
            cmbNamaMenu.DataSource = dt
            cmbNamaMenu.DisplayMember = "NAMA" ' Menampilkan Nama Menu/Paket
            cmbNamaMenu.ValueMember = "KODE"  ' Nilai berupa kode menu (bisa NULL untuk paket)
        Catch ex As Exception
            MsgBox("Gagal Memuat Data Menu dan Paket: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        autoGenerateFaktur()
        loadMenu()
        dgvDetailTransaksi.Columns.Add("NAMA_MENU", "Nama Menu")
        dgvDetailTransaksi.Columns.Add("JENIS_MENU", "Jenis Menu")
        dgvDetailTransaksi.Columns.Add("HARGA", "Harga")
        dgvDetailTransaksi.Columns.Add("JUMLAH", "Jumlah")
        dgvDetailTransaksi.Columns.Add("SUB_TOTAL", "Subtotal")
        txtJenisMenu.ReadOnly = True ' Set txtJenisMenu menjadi read-only
        ClearInputs()
    End Sub

    Private Sub cmbNamaMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNamaMenu.SelectedIndexChanged
        Try
            If cmbNamaMenu.SelectedValue IsNot Nothing Then
                Dim selectedRow As DataRowView = CType(cmbNamaMenu.SelectedItem, DataRowView)
                Dim jenis As String = selectedRow("JENIS").ToString()

                txtJenisMenu.Text = jenis
                txtHarga.Text = selectedRow("HARGA").ToString()

                ' Jika jenis adalah 'menu', ambil detail berdasarkan KODE_MENU
                If jenis <> "Paket" And Not IsDBNull(selectedRow("KODE")) Then
                    cmd = New OdbcCommand("SELECT JENIS_MENU FROM tbl_menu WHERE KODE_MENU = ?", conn)
                    cmd.Parameters.AddWithValue("?", selectedRow("KODE").ToString())
                    dr = cmd.ExecuteReader()
                    If dr.Read() Then
                        txtJenisMenu.Text = dr("JENIS_MENU").ToString()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat memilih menu/paket: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        If txtHarga.Text <> "" And txtJumlah.Text <> "" Then
            subtotal = CInt(txtHarga.Text) * CInt(txtJumlah.Text)
            txtSubtotal.Text = subtotal.ToString()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' Validasi input
        If txtNamaPembeli.Text.Trim() = "" Then
            MsgBox("Nama pembeli harus diisi.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        If cmbNamaMenu.SelectedIndex = -1 Then
            MsgBox("Pilih menu terlebih dahulu.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        If txtJumlah.Text.Trim() = "" OrElse Not IsNumeric(txtJumlah.Text) OrElse CInt(txtJumlah.Text) <= 0 Then
            MsgBox("Jumlah pesanan harus diisi dengan angka yang valid.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        If txtSubtotal.Text <> "" Then
            dgvDetailTransaksi.Rows.Add(cmbNamaMenu.Text, txtJenisMenu.Text, txtHarga.Text, txtJumlah.Text, txtSubtotal.Text)
            total += subtotal
            txtTotal.Text = total.ToString()

            ' Kosongkan input
            txtJumlah.Clear()
            txtSubtotal.Clear()
        End If
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        ' Validasi input
        If txtTotal.Text.Trim() = "" Then
            MsgBox("Total transaksi belum dihitung.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        If txtJumlahUang.Text.Trim() = "" OrElse Not IsNumeric(txtJumlahUang.Text) Then
            MsgBox("Jumlah uang harus diisi dengan angka yang valid.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        Dim jumlahUang As Integer = CInt(txtJumlahUang.Text)
        Dim kembalian As Integer = jumlahUang - total

        If jumlahUang < total Then
            MsgBox("Jumlah uang tidak mencukupi untuk melakukan pembayaran.", MsgBoxStyle.Critical, "Error")
            Return
        ElseIf jumlahUang = total Then
            MsgBox("Pembayaran berhasil. Uang pas diterima.", MsgBoxStyle.Information, "Informasi")
        Else
            txtKembalian.Text = kembalian.ToString()
            MsgBox("Pembayaran berhasil. Kembalian sebesar " & kembalian.ToString() & ".", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Bersihkan input terlebih dahulu
        ClearInputs()

        ' Pastikan faktur baru dibuat terlebih dahulu
        cmd = New OdbcCommand("INSERT INTO tbl_transaksi (FAKTUR_PESANAN, NAMA_PEMBELI, TOTAL_PEMBELIAN, TANGGAL) VALUES (?,?,?,?)", conn)
        cmd.Parameters.AddWithValue("?", txtFaktur.Text)
        cmd.Parameters.AddWithValue("?", txtNamaPembeli.Text)
        cmd.Parameters.AddWithValue("?", txtTotal.Text)
        cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        cmd.ExecuteNonQuery()

        ' Tambahkan semua item dari DataGridView ke tbl_detailtransaksi
        For Each row As DataGridViewRow In dgvDetailTransaksi.Rows
            If Not row.IsNewRow Then
                Dim kodeMenu As Object = Nothing
                ' Periksa apakah menu atau paket
                cmd = New OdbcCommand("SELECT KODE_MENU FROM tbl_menu WHERE NAMA_MENU = ?", conn)
                cmd.Parameters.AddWithValue("?", row.Cells("NAMA_MENU").Value.ToString())
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    kodeMenu = dr("KODE_MENU").ToString()
                End If
                dr.Close()

                ' Simpan ke tbl_detailtransaksi
                cmd = New OdbcCommand("INSERT INTO tbl_detailtransaksi (FAKTUR_PESANAN, KODE_MENU, JUMLAH, SUB_TOTAL) VALUES (?,?,?,?)", conn)
                cmd.Parameters.AddWithValue("?", txtFaktur.Text)
                cmd.Parameters.AddWithValue("?", If(kodeMenu IsNot Nothing, kodeMenu, DBNull.Value))
                cmd.Parameters.AddWithValue("?", row.Cells("JUMLAH").Value.ToString())
                cmd.Parameters.AddWithValue("?", row.Cells("SUB_TOTAL").Value.ToString())
                cmd.ExecuteNonQuery()
            End If
        Next

        ' Reset form setelah berhasil disimpan
        MessageBox.Show("Transaksi berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        dgvDetailTransaksi.Rows.Clear()
        ClearInputs()
        txtTotal.Clear()
        txtNamaPembeli.Clear()

        ' Reset variabel total
        total = 0

        ' Buat faktur baru
        autoGenerateFaktur()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles btnCetakStruk.Click
        Form_CetakTransaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Menu_Login.Show()
        Me.Hide()
    End Sub
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs)
        Menu_KelolaMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Menu_AktivitasTransaksi.Show()
        Me.Hide()
    End Sub

End Class