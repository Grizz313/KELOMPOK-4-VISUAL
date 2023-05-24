Public Class StrukPembelian

    Private Sub PBReturn_Click(sender As Object, e As EventArgs) Handles PBReturn.Click
        MenuUser.Show()
        Me.Hide()
    End Sub

    Private Sub StrukPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MenuUser.Hasil1.Text = Nama
        'StrukPembelian.Hasil2.Text = Produk
        'StrukPembelian.Hasil3.Text = Alamat
        'StrukPembelian.Hasil4.Text = HP
        'StrukPembelian.Hasil5.Text = Harga
        'StrukPembelian.Hasil6.Text = Metode
    End Sub
End Class