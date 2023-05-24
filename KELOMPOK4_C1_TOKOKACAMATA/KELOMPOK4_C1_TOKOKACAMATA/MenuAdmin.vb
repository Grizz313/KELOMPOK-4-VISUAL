Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class MenuAdmin

    Public Gambar As String
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BHome.Click
        PnlHome.Visible = True
        PnlTambah.Visible = False
        PnlData.Visible = False
        PnlUser.Visible = False
        PnlPembelian.Visible = False
    End Sub

    Private Sub BTambahProduk_Click(sender As Object, e As EventArgs) Handles BTambahProduk.Click
        PnlHome.Visible = False
        PnlTambah.Visible = True
        PnlData.Visible = False
        PnlUser.Visible = False
        PnlPembelian.Visible = False

    End Sub

    Private Sub BDataProduk_Click(sender As Object, e As EventArgs) Handles BDataProduk.Click
        PnlHome.Visible = False
        PnlTambah.Visible = False
        PnlData.Visible = True
        PnlUser.Visible = False
        PnlPembelian.Visible = False

    End Sub

    Private Sub BUser_Click(sender As Object, e As EventArgs) Handles BUser.Click
        PnlHome.Visible = False
        PnlTambah.Visible = False
        PnlData.Visible = False
        PnlUser.Visible = True
        PnlPembelian.Visible = False
    End Sub

    Private Sub BPemesanan_Click(sender As Object, e As EventArgs) Handles BPemesanan.Click
        PnlHome.Visible = False
        PnlTambah.Visible = False
        PnlData.Visible = False
        PnlUser.Visible = False
        PnlPembelian.Visible = True
    End Sub

    Sub AutoNumber()

        Call Koneksi()
        CMD = New MySqlCommand("select max(idkcmt) from tbkcmt", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        On Error GoTo Err
        If RD.HasRows Then
            Lid.Text = Format(Val(RD.Item(0)) + 1, "0")
        End If

        RD.Close()

        Exit Sub
Err:
        Lid.Text = "1"

    End Sub

    Sub ResetAutoNumber()

        Call Koneksi()
        CMD = New MySqlCommand("select max(idkcmt) from tbkcmt", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        On Error GoTo Err
        If RD.HasRows Then
            Lid.Text = Format(Val(RD.Item(0)) - 1, "0")
        End If

        RD.Close()

        Exit Sub
Err:
        Lid.Text = "1"

    End Sub

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Buka As String
        'Notif Selamat Datang'
        Buka = MessageBox.Show("Selamat Datang!", "TOKO KACAMATA ASRAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Koneksi()
        Lihatdatakacamata()
        LihatDataUser()
        LihatDataPembelian()
        SetGrid2()
        SetGrid3()
        AutoNumber()
    End Sub

    Sub Lihatdatakacamata()
        DA = New MySqlDataAdapter("Select * From tbkcmt", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbkcmt")
        DGVProdukKcmt.DataSource = DS.Tables("tbkcmt")
        DGVProdukKcmt.Refresh()
    End Sub

    Sub LihatDataUser()
        DA = New MySqlDataAdapter("Select KodeUser,NamaUser,StatusUser,UsernameUser From tbuser", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbuser")
        DGVUser.DataSource = DS.Tables("tbuser")
        DGVUser.Refresh()
    End Sub

    Sub LihatDataPembelian()
        DA = New MySqlDataAdapter("Select * From tbdatapembelian", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbdatapembelian")
        DGVPembelian.DataSource = DS.Tables("tbdatapembelian")
        DGVPembelian.Refresh()
    End Sub

    Sub SetGrid2()
        DGVUser.Columns(0).HeaderText = "Kode User"
        DGVUser.Columns(1).HeaderText = "Nama User"
        DGVUser.Columns(2).HeaderText = "Status User"
        DGVUser.Columns(3).HeaderText = "Username Kacamata"
    End Sub

    Sub SetGrid3()
        DGVPembelian.Columns(0).HeaderText = "Id Pembeli"
        DGVPembelian.Columns(1).HeaderText = "Id Produk"
        DGVPembelian.Columns(2).HeaderText = "Nama Pembeli"
        DGVPembelian.Columns(3).HeaderText = "Nomor HP"
        DGVPembelian.Columns(4).HeaderText = "Alamat Pembeli"
        DGVPembelian.Columns(5).HeaderText = "Detail Tambahan"
        DGVPembelian.Columns(6).HeaderText = "Nama Produk"
    End Sub

    Private Function CheckData()
        If TBNama.Text = "" Then
            MessageBox.Show("Nama Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBNama.Focus()
        ElseIf TBHarga.Text = "" Then
            MessageBox.Show("Harga Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBHarga.Focus()
        ElseIf TBGaransi.Text = "" Then
            MessageBox.Show("Garansi Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBGaransi.Focus()
        ElseIf TBUkuran.Text = "" Then
            MessageBox.Show("Ukuran Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBUkuran.Focus()
        ElseIf CBJenis.Text = "" Then
            MessageBox.Show("Jenis Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CBJenis.Focus()
        ElseIf PBGambar.Image Is Nothing Then
            MessageBox.Show("Gambar Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PBTambahGambar.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Sub Clear()
        TBNama.Text = ""
        TBHarga.Text = ""
        TBGaransi.Text = ""
        TBUkuran.Text = ""
        CBJenis.Text = ""
        PBGambar.Image = Nothing
    End Sub

    Private Sub DGVProdukKcmt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProdukKcmt.CellClick
        Dim i As Integer
        i = Me.DGVProdukKcmt.CurrentRow.Index

        Dim idxrow As Integer
        Dim selectedRow As DataGridViewRow
        selectedRow = DGVProdukKcmt.Rows(e.RowIndex)
        idxrow = e.RowIndex
        Dim id As Integer = selectedRow.Cells(0).Value
        Dim gmb As String = selectedRow.Cells(6).Value
        Dim location As String = "C:\Users\Asus\OneDrive\Documents\SEMESTER 4\PRAKTIKUM VISUAL\PA VISUAL\GambarProduk\" & gmb & ""
        Dim query As String = "Select * from tbkcmt where idkcmt = '" & id & "'"
        Dim cmdsql As MySqlCommand = New MySqlCommand(query, CONN)
        PBProdukAdmin.Image = Image.FromFile(location)

        cmdsql.ExecuteNonQuery()

        With DGVProdukKcmt.Rows.Item(i)
            Me.Lid.Text = .Cells(0).Value
            Me.TBNama.Text = .Cells(1).Value
            Me.TBHarga.Text = .Cells(2).Value
            Me.TBGaransi.Text = .Cells(3).Value
            Me.TBUkuran.Text = .Cells(4).Value
            Me.CBJenis.Text = .Cells(5).Value
        End With
    End Sub

    Private Sub DGVUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUser.CellContentClick
        Dim i As Integer
        i = Me.DGVUser.CurrentRow.Index
        With DGVUser.Rows.Item(i)
            Register.TxtKodeUser.Text = .Cells(0).Value
            Register.TxtNamaUser.Text = .Cells(1).Value
            Register.TxtStatusUser.Text = .Cells(2).Value
            Register.TxtUsernameUser.Text = .Cells(3).Value
        End With
    End Sub

    Private Sub DGVPembelian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPembelian.CellContentClick
        Dim i As Integer
        i = Me.DGVPembelian.CurrentRow.Index
        With DGVPembelian.Rows.Item(i)
            MenuUser.LGenPem.Text = .Cells(0).Value
            MenuUser.CBProduk.Text = .Cells(1).Value
            MenuUser.Txtnamapembeli.Text = .Cells(2).Value
            MenuUser.Txtnomorhp.Text = .Cells(3).Value
            MenuUser.Txtalamatpembeli.Text = .Cells(4).Value
            MenuUser.TxtTambahan.Text = .Cells(5).Value
            MenuUser.Txtnamaproduk.Text = .Cells(6).Value
        End With
    End Sub

    Private Sub TxtCariProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCariProduk.KeyPress

        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbkcmt where idkcmt like '%" & TxtCariProduk.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then

                DA = New MySqlDataAdapter("Select * From tbkcmt where idkcmt like '%" & TxtCariProduk.Text & "%'", CONN)
                DS = New DataSet
                RD.Close()
                DA.Fill(DS, "produk")
                DGVProdukKcmt.DataSource = DS.Tables("produk")
                DGVPembelian.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data Tidak ditemukan!")
            End If
        End If
    End Sub

    Private Sub TxtCariUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCariUser.KeyPress

        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbuser where kodeuser like '%" & TxtCariUser.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then

                DA = New MySqlDataAdapter("Select * From tbuser where kodeuser like '%" & TxtCariUser.Text & "%'", CONN)
                DS = New DataSet
                RD.Close()
                DA.Fill(DS, "user")
                DGVUser.DataSource = DS.Tables("user")
                DGVUser.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data Tidak ditemukan!")
            End If
        End If
    End Sub

    Private Sub TxtCariPembelian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCariPembelian.KeyPress

        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbdatapembelian where NamaPembeli like '%" & TxtCariPembelian.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then

                DA = New MySqlDataAdapter("Select * From tbdatapembelian where NamaPembeli like '%" & TxtCariPembelian.Text & "%'", CONN)
                DS = New DataSet
                RD.Close()
                DA.Fill(DS, "pembeli")
                DGVPembelian.DataSource = DS.Tables("pembeli")
                DGVPembelian.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Nama Pembeli Tidak ditemukan!")
            End If
        End If
    End Sub


    Private Sub PBTambah_Click(sender As Object, e As EventArgs) Handles PBTambah.Click


        If CheckData() = True Then

            Dim ms As New MemoryStream
            PBGambar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

            CMD = New MySqlCommand("Select * From tbkcmt where idkcmt='" & Lid.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "insert into tbkcmt (idkcmt, namakcmt, hargakcmt, garansikcmt, ukurankcmt, Jeniskcmt, Gambarkcmt) Values ('" & Lid.Text & "' , '" & TBNama.Text & "' , '" & TBHarga.Text & "' , '" & TBGaransi.Text & "', '" & TBUkuran.Text & "', '" & CBJenis.Text & "', '" & Gambar & "')"
                PBGambar.Image.Save("C:\Users\Asus\OneDrive\Documents\SEMESTER 4\PRAKTIKUM VISUAL\PA VISUAL\GambarProduk\" & Gambar & "")
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "INFO")
                AutoNumber()
            Else
                MsgBox("Data not found")
            End If
            RD.Close()

        End If

        Lihatdatakacamata()
        Clear()
    End Sub

    Private Sub PBClear_Click(sender As Object, e As EventArgs) Handles PBClear.Click
        Clear()
        TBNama.Focus()
    End Sub

    Private Sub PBTambahGambar_Click(sender As Object, e As EventArgs) Handles PBTambahGambar.Click

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PBGambar.Image = Image.FromFile(OpenFileDialog1.FileName)
            Gambar = Path.GetFileName(OpenFileDialog1.FileName)
        End If
        RD.Close()
    End Sub
    Private Sub PBExit_Click(sender As Object, e As EventArgs) Handles PBExit.Click
        Dim close As String
        close = MessageBox.Show("Yakin Nih Mau Keluar?", "Selamat Tinggal",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub PBReturn_Click(sender As Object, e As EventArgs) Handles PBReturn.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub PBHapus_Click(sender As Object, e As EventArgs) Handles PBHapus.Click
        If TxtCariProduk.Text = "" Then
            MsgBox("Masukkan data yang ingin dihapus!")
            TxtCariProduk.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus Data dengan id " & TxtCariProduk.Text &
                               " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbkcmt Where idkcmt = '" & TxtCariProduk.Text & "'", CONN)

                Dim imagePath As String = "C:\Users\Asus\OneDrive\Documents\SEMESTER 4\PRAKTIKUM VISUAL\PA VISUAL\GambarProduk\"

                If File.Exists(imagePath) Then
                    Try
                        File.Delete(imagePath)
                        MessageBox.Show("Image deleted successfully.")
                    Catch ex As Exception
                        MessageBox.Show("An error occurred while deleting the image.")
                    End Try
                Else
                    MessageBox.Show("Image does not exist.")
                End If

                CMD.ExecuteNonQuery()
                Call Clear()
                Call Lihatdatakacamata()
                AutoNumber()
            Else
                Call Clear()
            End If
        End If
    End Sub

    Private Sub PBHapusUser_Click(sender As Object, e As EventArgs) Handles PBHapusUser.Click
        If TxtCariUser.Text = "" Then
            MsgBox("Masukkan data yang ingin dihapus!")
            TxtCariUser.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus Data dengan kode " & TxtCariUser.Text &
                               " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbuser Where kodeuser = '" & TxtCariUser.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call Clear()
                Call LihatDataUser()
            Else
                Call Clear()
            End If
        End If
    End Sub

    Private Sub TBHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBHarga.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Then
            e.Handled = False
        ElseIf Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Inputan Harus berupa Angka!", "Warning",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub PBUbahProduk_Click(sender As Object, e As EventArgs) Handles PBUbahProduk.Click
        EditProduk.Show()
        Me.Hide()
    End Sub

End Class