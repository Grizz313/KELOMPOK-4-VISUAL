Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class MenuUser

    Sub AutoNumberUser()

        Call Koneksi()
        CMD = New MySqlCommand("select max(idPembeli) from tbdatapembelian", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        On Error GoTo Err
        If RD.HasRows Then
            LGenPem.Text = Format(Val(RD.Item(0)) + 1, "0")
        End If

        RD.Close()

        Exit Sub
Err:
        LGenPem.Text = "1"

    End Sub
    Private Sub MenuUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Buka As String
        'Notif Selamat Datang'
        Buka = MessageBox.Show("Selamat Datang!", "Silahkan Membeli Produk Kami", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Koneksi()
        Lihatdatakacamata()
        Lihatdataproduk()
        Lihatdata4()
        Clear()
        SetGrid4()
        AutoNumberUser()
        Txtnamaproduk.ReadOnly = True
        Txtharga.ReadOnly = True

    End Sub

    Private Sub BtnHomeProduk_Click(sender As Object, e As EventArgs) Handles BtnHomeProduk.Click
        PnlHomeProduk.Visible = True
        PnlPemesanan.Visible = False
        PnlRiwayat.Visible = False
        PnlProduk.Visible = False
    End Sub

    Private Sub BtnProduk_Click(sender As Object, e As EventArgs) Handles BtnProduk.Click
        PnlHomeProduk.Visible = False
        PnlPemesanan.Visible = False
        PnlRiwayat.Visible = False
        PnlProduk.Visible = True
    End Sub

    Private Sub BtnRiwayat_Click(sender As Object, e As EventArgs) Handles BtnRiwayat.Click
        PnlHomeProduk.Visible = False
        PnlPemesanan.Visible = False
        PnlRiwayat.Visible = True
        PnlProduk.Visible = False
    End Sub

    Private Sub BtnPesan_Click(sender As Object, e As EventArgs) Handles BtnPesan.Click
        PnlHomeProduk.Visible = False
        PnlPemesanan.Visible = True
        PnlRiwayat.Visible = False
        PnlProduk.Visible = False
    End Sub

    Sub Lihatdatakacamata()
        CMD = New MySqlCommand("Select idkcmt,hargakcmt from tbkcmt", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            CBProduk.Items.Add(RD.Item(0))
        Loop
        RD.Close()
    End Sub

    Sub Lihatdataproduk()
        DA = New MySqlDataAdapter("Select * From tbkcmt", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbkcmt")
        DGVProduk.DataSource = DS.Tables("tbkcmt")
        DGVProduk.Refresh()
    End Sub

    Sub Lihatdata4()
        DA = New MySqlDataAdapter("Select * From tbdatapembelian", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbdatapembelian")
        DataGridView4.DataSource = DS.Tables("tbdatapembelian")
        DataGridView4.Refresh()
    End Sub



    Sub SetGrid4()
        DataGridView4.Columns(0).HeaderText = "Id Pembeli"
        DataGridView4.Columns(1).HeaderText = "Id Produk"
        DataGridView4.Columns(2).HeaderText = "Nama Pembeli"
        DataGridView4.Columns(3).HeaderText = "Nomor HP"
        DataGridView4.Columns(4).HeaderText = "Alamat Pembeli"
        DataGridView4.Columns(5).HeaderText = "Detail Tambahan"
        DataGridView4.Columns(6).HeaderText = "Nama Produk"
        DataGridView4.Columns(7).HeaderText = "Total Harga"
        DataGridView4.Columns(8).HeaderText = "Metode Pembayaran"
    End Sub

    Private Function CheckDataProduk()
        If Txtnamapembeli.Text = "" Then
            MessageBox.Show("Data Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Txtnamapembeli.Focus()
        ElseIf Txtnomorhp.Text = "" Then
            MessageBox.Show("Data Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Txtnomorhp.Focus()
        ElseIf Txtalamatpembeli.Text = "" Then
            MessageBox.Show("Data Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Txtalamatpembeli.Focus()
        ElseIf TxtTambahan.Text = "" Then
            MessageBox.Show("Data Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtTambahan.Focus()
        ElseIf Txtnamaproduk.Text = "" Then
            MessageBox.Show("Data Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Txtnamaproduk.Focus()
        ElseIf CBProduk.Text = "" Then
            MessageBox.Show("Data Gaboleh Kosong Harus Diisi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CBProduk.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Sub Clear()
        Txtnamapembeli.Text = ""
        Txtnomorhp.Text = ""
        Txtalamatpembeli.Text = ""
        TxtTambahan.Text = ""
        CBProduk.Text = ""
        Txtnamaproduk.Text = ""
        Txtharga.Text = ""
        RBCOD.Checked = False
        RBTransfer.Checked = False
        RBKredit.Checked = False
        Txtnamapembeli.Focus()
    End Sub

    Private Sub TxtCariProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCariProduk.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbdatapembelian where idPembeli like '%" & TxtCariProduk.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then

                DA = New MySqlDataAdapter("Select * From tbdatapembelian where idPembeli like '%" & TxtCariProduk.Text & "%'", CONN)
                DS = New DataSet
                RD.Close()
                DA.Fill(DS, "kcmt")
                DataGridView4.DataSource = DS.Tables("kcmt")
                DataGridView4.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data Tidak ditemukan!")
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Clear()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        If CheckDataProduk() = True Then
            CMD = New MySqlCommand("Select * From tbdatapembelian where idPembeli= '" & LGenPem.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            Dim Metode As String
            If RBCOD.Checked Then
                Metode = "COD"
            ElseIf RBTransfer.Checked Then
                Metode = "Transfer"
            ElseIf RBKredit.Checked Then
                Metode = "Kredit/Debit"
            End If

            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "insert into tbdatapembelian(idPembeli, idkcmt, NamaPembeli, NoHP, AlamatPembeli, DetailTambahan, NamaProduk, TotalHarga, MetodePembayaran) values
                                        ('" & LGenPem.Text & "','" & CBProduk.Text & "','" & Txtnamapembeli.Text & "',
                                         '" & Txtnomorhp.Text & "','" & Txtalamatpembeli.Text & "','" & TxtTambahan.Text & "','" & Txtnamaproduk.Text & "','" & Txtharga.Text & "','" & Metode & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Pembelian Berhasil!", MsgBoxStyle.Information, "Information")
                AutoNumberUser()
            Else
                MsgBox("Terjadi Kesalahan", MsgBoxStyle.Exclamation)
            End If

            Dim Produk As String = Txtnamaproduk.Text
            Dim Nama As String = Txtnamapembeli.Text
            Dim Alamat As String = Txtalamatpembeli.Text
            Dim HP As String = Txtnomorhp.Text
            Dim Harga As String = Txtharga.Text

            StrukPembelian.Hasil1.Text = Nama
            StrukPembelian.Hasil2.Text = Produk
            StrukPembelian.Hasil3.Text = Alamat
            StrukPembelian.Hasil4.Text = HP
            StrukPembelian.Hasil5.Text = Harga
            StrukPembelian.Hasil6.Text = Metode

            Dim MenuUser As New StrukPembelian
            StrukPembelian.Show()
            Me.Hide()

            RD.Close()
            Call Lihatdatakacamata()
            Call Lihatdata4()
            Call Clear()
            Txtnamapembeli.Focus()
            StrukPembelian.Show()
        End If
    End Sub

    Private Sub CBProduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProduk.SelectedIndexChanged

        CMD = New MySqlCommand("Select * From tbkcmt where idkcmt='" & CBProduk.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows = True Then

            Txtnamaproduk.Text = RD.Item(1)
            Txtharga.Text = RD.Item(2) * NJumlah.Text
        Else
            MsgBox("Id Produk tidak terdaftar")
        End If
        RD.Close()

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        Dim i As Integer
        i = Me.DataGridView4.CurrentRow.Index
        With DataGridView4.Rows.Item(i)
            Me.LGenPem.Text = .Cells(0).Value
            Me.CBProduk.Text = .Cells(1).Value
            Me.Txtnamapembeli.Text = .Cells(2).Value
            Me.Txtnomorhp.Text = .Cells(3).Value
            Me.Txtalamatpembeli.Text = .Cells(4).Value
            Me.TxtTambahan.Text = .Cells(5).Value
            Me.Txtnamaproduk.Text = .Cells(6).Value
            Me.Txtharga.Text = .Cells(7).Value
            Me.RBCOD.Text = .Cells(8).Value
            Me.RBTransfer.Text = .Cells(8).Value
            Me.RBKredit.Text = .Cells(8).Value
        End With
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim close As String
        close = MessageBox.Show("Yakin Nih Mau Keluar?", "Selamat Tinggal",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub BStruk_Click(sender As Object, e As EventArgs)
        StrukPembelian.Show()
        Me.Hide()
    End Sub

    Private Sub PBHapus_Click(sender As Object, e As EventArgs) Handles PBHapus.Click
        If TxtCariProduk.Text = "" Then
            MsgBox("Masukkan NamaPembeli yang akan dihapus!")
            TxtCariProduk.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus riwayat pembelian dengan nama " & TxtCariProduk.Text &
                               " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbdatapembelian Where NamaPembeli = '" & TxtCariProduk.Text & "'", CONN)
                CMD.ExecuteNonQuery()

                Call Clear()
                Call Lihatdata4()
                Call Lihatdatakacamata()
            Else
                Call Clear()
            End If
        End If
    End Sub

    Private Sub Txtnomorhp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnomorhp.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Then
            e.Handled = False
        ElseIf Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Inputan Harus berupa Angka!", "Warning",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BPesan_Click(sender As Object, e As EventArgs) Handles BPesan.Click
        PnlHomeProduk.Visible = False
        PnlPemesanan.Visible = True
        PnlRiwayat.Visible = False
        PnlProduk.Visible = False
    End Sub

    Private Sub DGVProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProduk.CellClick
        Dim i As Integer
        i = Me.DGVProduk.CurrentRow.Index

        Dim idxrow As Integer
        Dim selectedRow As DataGridViewRow
        selectedRow = DGVProduk.Rows(e.RowIndex)
        idxrow = e.RowIndex
        Dim id As Integer = selectedRow.Cells(0).Value
        Dim gmb As String = selectedRow.Cells(6).Value
        Dim location As String = "C:\Users\Asus\OneDrive\Documents\SEMESTER 4\PRAKTIKUM VISUAL\PA VISUAL\GambarProduk\" & gmb & ""
        Dim query As String = "Select * from tbkcmt where idkcmt = '" & id & "'"
        Dim cmdsql As MySqlCommand = New MySqlCommand(query, CONN)
        PBProdukKcmt.Image = Image.FromFile(location)

        cmdsql.ExecuteNonQuery()

        With DGVProduk.Rows.Item(i)
            MenuAdmin.Lid.Text = .Cells(0).Value
            MenuAdmin.TBNama.Text = .Cells(1).Value
            MenuAdmin.TBHarga.Text = .Cells(2).Value
            MenuAdmin.TBGaransi.Text = .Cells(3).Value
            MenuAdmin.TBUkuran.Text = .Cells(4).Value
            MenuAdmin.CBJenis.Text = .Cells(5).Value
        End With
    End Sub

    Private Sub TProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TProduk.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbkcmt where idkcmt like '%" & TProduk.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then

                DA = New MySqlDataAdapter("Select * From tbkcmt where idkcmt like '%" & TProduk.Text & "%'", CONN)
                DS = New DataSet
                RD.Close()
                DA.Fill(DS, "produk")
                DGVProduk.DataSource = DS.Tables("produk")
                DGVProduk.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data Tidak ditemukan!")
            End If
        End If
    End Sub

End Class