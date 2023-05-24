<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Pnlup = New System.Windows.Forms.Panel()
        Me.BtnAdminLogin = New System.Windows.Forms.Button()
        Me.BtnUserLogin = New System.Windows.Forms.Button()
        Me.BtnExitLogin = New System.Windows.Forms.Button()
        Me.BtnHomeLogin = New System.Windows.Forms.Button()
        Me.PnlHome = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PnlUser = New System.Windows.Forms.Panel()
        Me.PBUser = New System.Windows.Forms.PictureBox()
        Me.BtnCancelUser = New System.Windows.Forms.Button()
        Me.BtnRegisterUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPasswordUser = New System.Windows.Forms.TextBox()
        Me.TxtUsernameUser = New System.Windows.Forms.TextBox()
        Me.BtnLoginUser = New System.Windows.Forms.Button()
        Me.PnlAdmin = New System.Windows.Forms.Panel()
        Me.PBAdmin = New System.Windows.Forms.PictureBox()
        Me.BtnCancelAdmin = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPasswordAdmin = New System.Windows.Forms.TextBox()
        Me.TxtUsernameAdmin = New System.Windows.Forms.TextBox()
        Me.BtnLoginAdmin = New System.Windows.Forms.Button()
        Me.Pnlup.SuspendLayout()
        Me.PnlHome.SuspendLayout()
        Me.PnlUser.SuspendLayout()
        CType(Me.PBUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlAdmin.SuspendLayout()
        CType(Me.PBAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnlup
        '
        Me.Pnlup.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Pnlup.BackgroundImage = CType(resources.GetObject("Pnlup.BackgroundImage"), System.Drawing.Image)
        Me.Pnlup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pnlup.Controls.Add(Me.BtnAdminLogin)
        Me.Pnlup.Controls.Add(Me.BtnUserLogin)
        Me.Pnlup.Controls.Add(Me.BtnExitLogin)
        Me.Pnlup.Controls.Add(Me.BtnHomeLogin)
        Me.Pnlup.Controls.Add(Me.PnlHome)
        Me.Pnlup.Controls.Add(Me.PnlUser)
        Me.Pnlup.Controls.Add(Me.PnlAdmin)
        Me.Pnlup.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnlup.Location = New System.Drawing.Point(0, 0)
        Me.Pnlup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pnlup.Name = "Pnlup"
        Me.Pnlup.Size = New System.Drawing.Size(1323, 766)
        Me.Pnlup.TabIndex = 2
        '
        'BtnAdminLogin
        '
        Me.BtnAdminLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdminLogin.FlatAppearance.BorderSize = 0
        Me.BtnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdminLogin.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAdminLogin.Location = New System.Drawing.Point(501, 25)
        Me.BtnAdminLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAdminLogin.Name = "BtnAdminLogin"
        Me.BtnAdminLogin.Size = New System.Drawing.Size(146, 57)
        Me.BtnAdminLogin.TabIndex = 12
        Me.BtnAdminLogin.Text = "ADMIN"
        Me.BtnAdminLogin.UseVisualStyleBackColor = False
        '
        'BtnUserLogin
        '
        Me.BtnUserLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnUserLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUserLogin.FlatAppearance.BorderSize = 0
        Me.BtnUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUserLogin.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUserLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnUserLogin.Location = New System.Drawing.Point(698, 25)
        Me.BtnUserLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUserLogin.Name = "BtnUserLogin"
        Me.BtnUserLogin.Size = New System.Drawing.Size(146, 57)
        Me.BtnUserLogin.TabIndex = 11
        Me.BtnUserLogin.Text = "USER"
        Me.BtnUserLogin.UseVisualStyleBackColor = False
        '
        'BtnExitLogin
        '
        Me.BtnExitLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnExitLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExitLogin.FlatAppearance.BorderSize = 0
        Me.BtnExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExitLogin.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExitLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnExitLogin.Location = New System.Drawing.Point(877, 25)
        Me.BtnExitLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExitLogin.Name = "BtnExitLogin"
        Me.BtnExitLogin.Size = New System.Drawing.Size(146, 57)
        Me.BtnExitLogin.TabIndex = 10
        Me.BtnExitLogin.Text = "EXIT"
        Me.BtnExitLogin.UseVisualStyleBackColor = False
        '
        'BtnHomeLogin
        '
        Me.BtnHomeLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnHomeLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHomeLogin.FlatAppearance.BorderSize = 0
        Me.BtnHomeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHomeLogin.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHomeLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnHomeLogin.Location = New System.Drawing.Point(295, 25)
        Me.BtnHomeLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnHomeLogin.Name = "BtnHomeLogin"
        Me.BtnHomeLogin.Size = New System.Drawing.Size(146, 57)
        Me.BtnHomeLogin.TabIndex = 9
        Me.BtnHomeLogin.Text = "HOME"
        Me.BtnHomeLogin.UseVisualStyleBackColor = False
        '
        'PnlHome
        '
        Me.PnlHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PnlHome.BackgroundImage = CType(resources.GetObject("PnlHome.BackgroundImage"), System.Drawing.Image)
        Me.PnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlHome.Controls.Add(Me.Label11)
        Me.PnlHome.Controls.Add(Me.Label10)
        Me.PnlHome.Location = New System.Drawing.Point(0, 92)
        Me.PnlHome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlHome.Name = "PnlHome"
        Me.PnlHome.Size = New System.Drawing.Size(1324, 674)
        Me.PnlHome.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(468, 226)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(406, 73)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "SELAMAT DATANG"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Poppins", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(252, 327)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(832, 99)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "SILAHKAN PILIH MENU LOGIN"
        '
        'PnlUser
        '
        Me.PnlUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PnlUser.BackgroundImage = CType(resources.GetObject("PnlUser.BackgroundImage"), System.Drawing.Image)
        Me.PnlUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlUser.Controls.Add(Me.PBUser)
        Me.PnlUser.Controls.Add(Me.BtnCancelUser)
        Me.PnlUser.Controls.Add(Me.BtnRegisterUser)
        Me.PnlUser.Controls.Add(Me.Label1)
        Me.PnlUser.Controls.Add(Me.Label2)
        Me.PnlUser.Controls.Add(Me.Label5)
        Me.PnlUser.Controls.Add(Me.TxtPasswordUser)
        Me.PnlUser.Controls.Add(Me.TxtUsernameUser)
        Me.PnlUser.Controls.Add(Me.BtnLoginUser)
        Me.PnlUser.Location = New System.Drawing.Point(0, 92)
        Me.PnlUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlUser.Name = "PnlUser"
        Me.PnlUser.Size = New System.Drawing.Size(1324, 674)
        Me.PnlUser.TabIndex = 50
        '
        'PBUser
        '
        Me.PBUser.BackColor = System.Drawing.Color.Transparent
        Me.PBUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBUser.Image = Global.KELOMPOK4_C1_TOKOKACAMATA.My.Resources.Resources.eyes
        Me.PBUser.Location = New System.Drawing.Point(882, 332)
        Me.PBUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PBUser.Name = "PBUser"
        Me.PBUser.Size = New System.Drawing.Size(30, 31)
        Me.PBUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBUser.TabIndex = 51
        Me.PBUser.TabStop = False
        '
        'BtnCancelUser
        '
        Me.BtnCancelUser.BackColor = System.Drawing.Color.Black
        Me.BtnCancelUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelUser.FlatAppearance.BorderSize = 0
        Me.BtnCancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelUser.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelUser.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCancelUser.Location = New System.Drawing.Point(785, 469)
        Me.BtnCancelUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCancelUser.Name = "BtnCancelUser"
        Me.BtnCancelUser.Size = New System.Drawing.Size(183, 64)
        Me.BtnCancelUser.TabIndex = 49
        Me.BtnCancelUser.Text = "Cancel"
        Me.BtnCancelUser.UseVisualStyleBackColor = False
        '
        'BtnRegisterUser
        '
        Me.BtnRegisterUser.BackColor = System.Drawing.Color.Black
        Me.BtnRegisterUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegisterUser.FlatAppearance.BorderSize = 0
        Me.BtnRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegisterUser.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegisterUser.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnRegisterUser.Location = New System.Drawing.Point(556, 469)
        Me.BtnRegisterUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRegisterUser.Name = "BtnRegisterUser"
        Me.BtnRegisterUser.Size = New System.Drawing.Size(183, 64)
        Me.BtnRegisterUser.TabIndex = 48
        Me.BtnRegisterUser.Text = "Register"
        Me.BtnRegisterUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(360, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(542, 99)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "FORM LOGIN USER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(419, 284)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 42)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(421, 164)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 42)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Username"
        '
        'TxtPasswordUser
        '
        Me.TxtPasswordUser.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswordUser.Location = New System.Drawing.Point(426, 327)
        Me.TxtPasswordUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPasswordUser.Name = "TxtPasswordUser"
        Me.TxtPasswordUser.Size = New System.Drawing.Size(448, 43)
        Me.TxtPasswordUser.TabIndex = 40
        Me.TxtPasswordUser.UseSystemPasswordChar = True
        '
        'TxtUsernameUser
        '
        Me.TxtUsernameUser.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsernameUser.Location = New System.Drawing.Point(426, 207)
        Me.TxtUsernameUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtUsernameUser.Name = "TxtUsernameUser"
        Me.TxtUsernameUser.Size = New System.Drawing.Size(448, 43)
        Me.TxtUsernameUser.TabIndex = 39
        '
        'BtnLoginUser
        '
        Me.BtnLoginUser.BackColor = System.Drawing.Color.Black
        Me.BtnLoginUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLoginUser.FlatAppearance.BorderSize = 0
        Me.BtnLoginUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoginUser.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoginUser.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLoginUser.Location = New System.Drawing.Point(320, 469)
        Me.BtnLoginUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLoginUser.Name = "BtnLoginUser"
        Me.BtnLoginUser.Size = New System.Drawing.Size(183, 64)
        Me.BtnLoginUser.TabIndex = 10
        Me.BtnLoginUser.Text = "Login"
        Me.BtnLoginUser.UseVisualStyleBackColor = False
        '
        'PnlAdmin
        '
        Me.PnlAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PnlAdmin.BackgroundImage = CType(resources.GetObject("PnlAdmin.BackgroundImage"), System.Drawing.Image)
        Me.PnlAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlAdmin.Controls.Add(Me.PBAdmin)
        Me.PnlAdmin.Controls.Add(Me.BtnCancelAdmin)
        Me.PnlAdmin.Controls.Add(Me.Label9)
        Me.PnlAdmin.Controls.Add(Me.Label3)
        Me.PnlAdmin.Controls.Add(Me.Label4)
        Me.PnlAdmin.Controls.Add(Me.TxtPasswordAdmin)
        Me.PnlAdmin.Controls.Add(Me.TxtUsernameAdmin)
        Me.PnlAdmin.Controls.Add(Me.BtnLoginAdmin)
        Me.PnlAdmin.Location = New System.Drawing.Point(0, 92)
        Me.PnlAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlAdmin.Name = "PnlAdmin"
        Me.PnlAdmin.Size = New System.Drawing.Size(1324, 674)
        Me.PnlAdmin.TabIndex = 2
        '
        'PBAdmin
        '
        Me.PBAdmin.BackColor = System.Drawing.Color.Transparent
        Me.PBAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBAdmin.Image = Global.KELOMPOK4_C1_TOKOKACAMATA.My.Resources.Resources.eyes
        Me.PBAdmin.Location = New System.Drawing.Point(882, 332)
        Me.PBAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PBAdmin.Name = "PBAdmin"
        Me.PBAdmin.Size = New System.Drawing.Size(30, 31)
        Me.PBAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBAdmin.TabIndex = 52
        Me.PBAdmin.TabStop = False
        '
        'BtnCancelAdmin
        '
        Me.BtnCancelAdmin.BackColor = System.Drawing.Color.Black
        Me.BtnCancelAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelAdmin.FlatAppearance.BorderSize = 0
        Me.BtnCancelAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelAdmin.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelAdmin.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCancelAdmin.Location = New System.Drawing.Point(678, 469)
        Me.BtnCancelAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCancelAdmin.Name = "BtnCancelAdmin"
        Me.BtnCancelAdmin.Size = New System.Drawing.Size(183, 64)
        Me.BtnCancelAdmin.TabIndex = 49
        Me.BtnCancelAdmin.Text = "Cancel"
        Me.BtnCancelAdmin.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Poppins", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(360, 55)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(594, 99)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "FORM LOGIN ADMIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(419, 284)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 42)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 164)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 42)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Username"
        '
        'TxtPasswordAdmin
        '
        Me.TxtPasswordAdmin.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswordAdmin.Location = New System.Drawing.Point(426, 327)
        Me.TxtPasswordAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPasswordAdmin.Name = "TxtPasswordAdmin"
        Me.TxtPasswordAdmin.Size = New System.Drawing.Size(448, 43)
        Me.TxtPasswordAdmin.TabIndex = 40
        Me.TxtPasswordAdmin.UseSystemPasswordChar = True
        '
        'TxtUsernameAdmin
        '
        Me.TxtUsernameAdmin.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsernameAdmin.Location = New System.Drawing.Point(426, 207)
        Me.TxtUsernameAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtUsernameAdmin.Name = "TxtUsernameAdmin"
        Me.TxtUsernameAdmin.Size = New System.Drawing.Size(448, 43)
        Me.TxtUsernameAdmin.TabIndex = 39
        '
        'BtnLoginAdmin
        '
        Me.BtnLoginAdmin.BackColor = System.Drawing.Color.Black
        Me.BtnLoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLoginAdmin.FlatAppearance.BorderSize = 0
        Me.BtnLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoginAdmin.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoginAdmin.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLoginAdmin.Location = New System.Drawing.Point(464, 469)
        Me.BtnLoginAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLoginAdmin.Name = "BtnLoginAdmin"
        Me.BtnLoginAdmin.Size = New System.Drawing.Size(183, 64)
        Me.BtnLoginAdmin.TabIndex = 10
        Me.BtnLoginAdmin.Text = "Login"
        Me.BtnLoginAdmin.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pnlup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Login"
        Me.Pnlup.ResumeLayout(False)
        Me.PnlHome.ResumeLayout(False)
        Me.PnlHome.PerformLayout()
        Me.PnlUser.ResumeLayout(False)
        Me.PnlUser.PerformLayout()
        CType(Me.PBUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlAdmin.ResumeLayout(False)
        Me.PnlAdmin.PerformLayout()
        CType(Me.PBAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnlup As Panel
    Friend WithEvents BtnAdminLogin As Button
    Friend WithEvents BtnUserLogin As Button
    Friend WithEvents BtnExitLogin As Button
    Friend WithEvents BtnHomeLogin As Button
    Friend WithEvents PnlHome As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PnlUser As Panel
    Friend WithEvents BtnCancelUser As Button
    Friend WithEvents BtnRegisterUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUsernameUser As TextBox
    Friend WithEvents BtnLoginUser As Button
    Friend WithEvents PnlAdmin As Panel
    Friend WithEvents BtnCancelAdmin As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPasswordAdmin As TextBox
    Friend WithEvents TxtUsernameAdmin As TextBox
    Friend WithEvents BtnLoginAdmin As Button
    Friend WithEvents PBUser As PictureBox
    Friend WithEvents TxtPasswordUser As TextBox
    Friend WithEvents PBAdmin As PictureBox
End Class
