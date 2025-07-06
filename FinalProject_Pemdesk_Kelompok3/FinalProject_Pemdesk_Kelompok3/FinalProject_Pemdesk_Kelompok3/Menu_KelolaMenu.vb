Imports System.Data.Odbc
Public Class Menu_KelolaMenu

    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Dim rd As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet

    ' Method untuk menghubungkan ke database
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

    ' Method untuk membersihkan form
    Sub BersihkanForm()
        txtNamaMenu.Text = ""
        txtHargaMenu.Text = ""
        txtPersediaan.Text = ""
        cmbJenisMenu.Text = ""
    End Sub

    ' Method untuk membersihkan form jenis menu
    Sub BersihkanFormJenis()
        txtJenisMenu.Text = ""
    End Sub

    ' Method untuk menampilkan data ke DataGridView
    ' Method untuk menampilkan data ke DataGridView (tanpa kolom KODE_MENU)
    Sub TampilkanData()
        Try
            koneksi()
            da = New OdbcDataAdapter("SELECT tbl_jenismenu.JENIS_MENU, tbl_menu.NAMA_MENU, " &
                                 "tbl_menu.HARGA_MENU, tbl_menu.PERSEDIAAN " &
                                 "FROM tbl_menu " &
                                 "JOIN tbl_jenismenu ON tbl_menu.JENIS_MENU = tbl_jenismenu.JENIS_MENU", conn)
            ds = New DataSet()
            da.Fill(ds, "tbl_menu")
            DataGridView1.DataSource = ds.Tables("tbl_menu")

            ' Format ulang DataGridView
            With DataGridView1
                .Columns("JENIS_MENU").HeaderText = "Jenis Menu"
                .Columns("NAMA_MENU").HeaderText = "Nama Menu"
                .Columns("HARGA_MENU").HeaderText = "Harga Menu"
                .Columns("PERSEDIAAN").HeaderText = "Persediaan"
            End With

            conn.Close()
        Catch ex As Exception
            MsgBox("Gagal menampilkan data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' Event saat cell pada DataGridView diklik
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            ' Dapatkan baris yang diklik
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Isi data dari DataGridView ke TextBox dan ComboBox
            cmbJenisMenu.Text = row.Cells("JENIS_MENU").Value.ToString()
            txtNamaMenu.Text = row.Cells("NAMA_MENU").Value.ToString()
            txtHargaMenu.Text = row.Cells("HARGA_MENU").Value.ToString()
            txtPersediaan.Text = row.Cells("PERSEDIAAN").Value.ToString()
        End If
    End Sub


    ' Method untuk menampilkan data Jenis Menu di ComboBox
    Sub TampilkanJenisMenu()
        Try
            koneksi()
            cmd = New OdbcCommand("SELECT JENIS_MENU FROM tbl_jenismenu", conn)
            rd = cmd.ExecuteReader()
            cmbJenisMenu.Items.Clear()
            While rd.Read()
                cmbJenisMenu.Items.Add(rd("JENIS_MENU"))
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox("Gagal menampilkan jenis menu: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' Event saat form dimuat
    Private Sub KelolaMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
        TampilkanJenisMenu()
    End Sub

    ' Event untuk menambahkan jenis menu
    Private Sub btnTambahJenis_Click(sender As Object, e As EventArgs) Handles btnTambahJenis.Click
        If txtJenisMenu.Text = "" Then
            MsgBox("Jenis menu belum diisi!", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Try
                koneksi()

                ' Periksa apakah JENIS_MENU sudah ada
                cmd = New OdbcCommand("SELECT COUNT(*) FROM tbl_jenismenu WHERE JENIS_MENU = '" & txtJenisMenu.Text & "'", conn)
                Dim count As Integer = cmd.ExecuteScalar()

                If count > 0 Then
                    MsgBox("Jenis menu sudah ada! Data tidak ditambahkan.", MsgBoxStyle.Information, "Informasi")
                Else
                    ' Jika belum ada, tambahkan data baru
                    cmd = New OdbcCommand("INSERT INTO tbl_jenismenu (JENIS_MENU) VALUES ('" & txtJenisMenu.Text & "')", conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Jenis menu berhasil ditambahkan!", MsgBoxStyle.Information, "Informasi")
                End If

                BersihkanFormJenis()
                TampilkanJenisMenu()
                conn.Close()
            Catch ex As Exception
                MsgBox("Gagal menambahkan jenis menu: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    ' Event Simpan Data
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaMenu.Text = "" Or txtHargaMenu.Text = "" Or cmbJenisMenu.Text = "" Or txtPersediaan.Text = "" Then
            MsgBox("Data belum lengkap! Silakan isi semua kolom.", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Try
                koneksi()

                ' Periksa apakah data dengan NAMA_MENU sudah ada
                cmd = New OdbcCommand("SELECT COUNT(*) FROM tbl_menu WHERE NAMA_MENU = '" & txtNamaMenu.Text & "'", conn)
                Dim count As Integer = cmd.ExecuteScalar()

                If count > 0 Then
                    MsgBox("Menu sudah ada! Data tidak ditambahkan.", MsgBoxStyle.Information, "Informasi")
                Else
                    ' Jika belum ada, tambahkan data baru
                    cmd = New OdbcCommand("INSERT INTO tbl_menu (JENIS_MENU, NAMA_MENU, HARGA_MENU, PERSEDIAAN) " &
                                          "VALUES ('" & cmbJenisMenu.Text & "', '" & txtNamaMenu.Text & "', '" & txtHargaMenu.Text & "', '" & txtPersediaan.Text & "')", conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
                End If

                BersihkanForm()
                TampilkanData()
                conn.Close()
            Catch ex As Exception
                MsgBox("Gagal menyimpan data: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    ' Event Delete Data
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Pilih data yang ingin dihapus pada tabel!", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Try
                koneksi()
                Dim kodeMenu As String = DataGridView1.SelectedRows(0).Cells("KODE_MENU").Value.ToString()
                cmd = New OdbcCommand("DELETE FROM tbl_menu WHERE KODE_MENU = '" & kodeMenu & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information, "Informasi")
                BersihkanForm()
                TampilkanData()
                conn.Close()
            Catch ex As Exception
                MsgBox("Gagal menghapus data: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtNamaMenu.Text = "" Or txtHargaMenu.Text = "" Or cmbJenisMenu.Text = "" Or txtPersediaan.Text = "" Then
            MsgBox("Data belum lengkap! Silakan isi semua kolom.", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Try
                koneksi()
                cmd = New OdbcCommand("UPDATE tbl_menu SET JENIS_MENU = '" & cmbJenisMenu.Text &
                                  "', HARGA_MENU = '" & txtHargaMenu.Text &
                                  "', PERSEDIAAN = '" & txtPersediaan.Text &
                                  "' WHERE NAMA_MENU = '" & txtNamaMenu.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diperbarui!", MsgBoxStyle.Information, "Informasi")
                BersihkanForm()
                TampilkanData()
                conn.Close()
            Catch ex As Exception
                MsgBox("Gagal memperbarui data: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
    Private Sub btnToLogin_Click(sender As Object, e As EventArgs) Handles btnToLogin.Click
        If MsgBox("Yakin ingin logout?", MsgBoxStyle.YesNo, "Konfirmasi Logout") = MsgBoxResult.Yes Then
            ' Bersihkan TextBox pada Form Login
            Menu_Login.txtUsername.Text = ""
            Menu_Login.txtPassword.Text = ""
            Menu_Login.cbLihatPassword.Checked = False
            Menu_Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnToKelolaMenu_Click(sender As Object, e As EventArgs) Handles btnToKelolaMenu.Click
        MsgBox("Anda berada di Halaman Kelola Menu!", MsgBoxStyle.Information, "Informasi")
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)
        Menu_Transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs)
        Menu_AktivitasTransaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs)
        Menu_Login.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Menu_Kelolapaket.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton4_Click_1(sender As Object, e As EventArgs) Handles btnToLogin.Click
        Menu_Login.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton1_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Menu_KelolaUser.Show()
        Me.Hide()
    End Sub
End Class