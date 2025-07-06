Imports System.Data.Odbc
Public Class Menu_Login
    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Dim rd As OdbcDataReader

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
    Private Sub Menu_Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtpassword.UseSystemPasswordChar = True
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Trim() = "" Then
            MsgBox("Username tidak boleh kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        If txtpassword.Text.Trim() = "" Then
            MsgBox("Password tidak boleh kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        Try
            ' Pastikan koneksi terbuka
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Query dengan parameter
            Dim queryLogin As String = "SELECT role FROM tbl_user WHERE USERNAME = ? AND PASSWORD = ?"
            cmd = New OdbcCommand(queryLogin, conn)

            ' Menambahkan parameter berdasarkan urutan
            cmd.Parameters.AddWithValue("@p1", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@p2", txtpassword.Text.Trim())

            ' Eksekusi query
            rd = cmd.ExecuteReader()

            ' Cek apakah data ditemukan
            If rd.HasRows Then
                rd.Read()
                Dim userType As String = rd("role").ToString()

                MsgBox("Login berhasil sebagai " & userType, MsgBoxStyle.Information, "Informasi")

                If userType = "Kasir" Then
                    Menu_Transaksi.Show()
                    Me.Hide()
                ElseIf userType = "Owner" Then
                    HalamanOwner.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Username atau Password salah", MsgBoxStyle.Exclamation, "Peringatan")
            End If
            rd.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    ' Checkbox untuk melihat password
    Private Sub cbLihatPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbLihatPassword.CheckedChanged
        txtpassword.UseSystemPasswordChar = Not cbLihatPassword.Checked
    End Sub

End Class
