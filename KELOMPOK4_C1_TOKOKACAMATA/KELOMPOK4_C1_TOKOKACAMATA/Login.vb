Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs)
        koneksi()
    End Sub

    Private Sub BtnHomeLogin_Click(sender As Object, e As EventArgs) Handles BtnHomeLogin.Click
        PnlHome.Visible = True
        PnlAdmin.Visible = False
        PnlUser.Visible = False
    End Sub

    Private Sub BtnAdminLogin_Click(sender As Object, e As EventArgs) Handles BtnAdminLogin.Click
        PnlHome.Visible = False
        PnlAdmin.Visible = True
        PnlUser.Visible = False
    End Sub

    Private Sub BtnUserLogin_Click(sender As Object, e As EventArgs) Handles BtnUserLogin.Click
        PnlHome.Visible = False
        PnlAdmin.Visible = False
        PnlUser.Visible = True
    End Sub

    Private Sub BtnExitlogin_Click(sender As Object, e As EventArgs) Handles BtnExitLogin.Click
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
        TxtUsernameAdmin.Text = ""
        TxtPasswordAdmin.Text = ""

        TxtUsernameUser.Text = ""
        TxtPasswordUser.Text = ""
    End Sub

    Private Sub TxtUsernameAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsernameAdmin.KeyPress
        If e.KeyChar = Chr(13) Then TxtPasswordAdmin.Focus()
    End Sub

    Private Sub TxtPasswordAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPasswordAdmin.KeyPress
        If e.KeyChar = Chr(13) Then BtnLoginAdmin.Focus()
    End Sub

    Private Sub TxtUsernameUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsernameUser.KeyPress
        If e.KeyChar = Chr(13) Then TxtPasswordUser.Focus()
    End Sub

    Private Sub TxtPasswordUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPasswordUser.KeyPress
        If e.KeyChar = Chr(13) Then BtnLoginUser.Focus()
    End Sub


    Private Sub BtnCancelAdmin_Click(sender As Object, e As EventArgs) Handles BtnCancelAdmin.Click
        Clear()
    End Sub

    Private Sub BtnCancelUser_Click(sender As Object, e As EventArgs) Handles BtnCancelUser.Click
        Clear()
    End Sub

    Private Sub BtnLoginAdmin_Click(sender As Object, e As EventArgs) Handles BtnLoginAdmin.Click
        Call koneksi()
        CMD = New MySqlCommand("Select * From tbadmin Where UsernameAdmin = '" & TxtUsernameAdmin.Text & "' and PasswordAdmin = '" & TxtPasswordAdmin.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Me.Visible = False
            MenuAdmin.Show()
            RD.Close()

        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Periksa kembali username dan password anda!", "Warning",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUsernameAdmin.Focus()
            TxtUsernameAdmin.Text = ""
            TxtPasswordAdmin.Text = ""
        End If
    End Sub

    Private Sub BtnLoginUser_Click(sender As Object, e As EventArgs) Handles BtnLoginUser.Click
        Call koneksi()
        CMD = New MySqlCommand("Select * From tbuser Where UsernameUser = '" & TxtUsernameUser.Text & "' and PasswordUser = '" & TxtPasswordUser.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Me.Visible = False
            MenuUser.Show()
            RD.Close()

        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Periksa kembali username dan password anda!", "Warning",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUsernameUser.Focus()
            TxtUsernameUser.Text = ""
            TxtPasswordUser.Text = ""
        End If
    End Sub


    Private Sub BtnRegisterUser_Click(sender As Object, e As EventArgs) Handles BtnRegisterUser.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub PnlUser_Paint(sender As Object, e As PaintEventArgs) Handles PnlUser.Paint
        SetWatermark(TxtUsernameUser, "Masukkan Username")
        SetWatermark(TxtPasswordUser, "Masukkan Password")
    End Sub

    Private Sub PnlAdmin_Paint(sender As Object, e As PaintEventArgs) Handles PnlAdmin.Paint
        SetWatermark(TxtUsernameAdmin, "Masukkan Username")
        SetWatermark(TxtPasswordAdmin, "Masukkan Password")
    End Sub

    Private Sub PBUser_Click(sender As Object, e As EventArgs) Handles PBUser.Click
        'Tampilkan Password yang tersembunyi
        'Show Password
        If TxtPasswordUser.UseSystemPasswordChar = True Then
            'Hide
            TxtPasswordUser.UseSystemPasswordChar = False
        Else
            'Show
            TxtPasswordUser.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PBAdmin_Click(sender As Object, e As EventArgs) Handles PBAdmin.Click
        'Tampilkan Password yang tersembunyi
        'Show Password
        If TxtPasswordAdmin.UseSystemPasswordChar = True Then
            'Hide
            TxtPasswordAdmin.UseSystemPasswordChar = False
        Else
            'Show
            TxtPasswordAdmin.UseSystemPasswordChar = True
        End If
    End Sub
End Class