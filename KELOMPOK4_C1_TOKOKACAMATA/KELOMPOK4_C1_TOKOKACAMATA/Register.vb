Imports MySql.Data.MySqlClient

Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        PnlHome.Visible = True
        PnlUser.Visible = False
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        PnlHome.Visible = False
        PnlUser.Visible = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim close As String
        close = MessageBox.Show("Yakin Nih Mau Keluar?", "Selamat Tinggal",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Sub Clear()
        TxtUsernameUser.Text = ""
        TxtPasswordUser.Text = ""
        TxtKodeUser.Text = ""
        TxtStatusUser.Text = ""
        TxtNamaUser.Text = ""
    End Sub

    Private Sub BtnLoginUser_Click(sender As Object, e As EventArgs) Handles BtnLoginUser.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCancelUser_Click(sender As Object, e As EventArgs) Handles BtnCancelUser.Click
        clear()
    End Sub

    Private Sub BtnRegisterUser_Click(sender As Object, e As EventArgs) Handles BtnRegisterUser.Click
        If TxtUsernameUser.Text = "" Or TxtPasswordUser.Text = "" Or TxtKodeUser.Text = "" Or TxtStatusUser.Text = "" Or TxtNamaUser.Text = "" Then
            MsgBox("Data Belum Lengkap")
            TxtPasswordUser.Focus()
            Exit Sub
        Else

            CMD = New MySqlCommand("Select * From tbuser where KodeUser='" & TxtKodeUser.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()

            If RD.HasRows Then

                MsgBox("Username Sudah Ada!")

            ElseIf Not RD.HasRows Then
                Dim Simpan As String = "insert into tbuser(KodeUser, StatusUser, UsernameUser, PasswordUser, NamaUser)values ('" & TxtKodeUser.Text & "','" & TxtStatusUser.Text & "','" & TxtUsernameUser.Text & "','" & TxtPasswordUser.Text & "','" & TxtNamaUser.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Berhasil Register!", MsgBoxStyle.Information, "TerimaKasih!")

            End If
            Call clear()
            TxtUsernameUser.Focus()
        End If
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Login.Show()
        Me.Hide()
    End Sub

End Class