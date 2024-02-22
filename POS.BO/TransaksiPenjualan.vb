Public Class TransaksiPenjualan
    Public Property id_penjualan As Integer
    Public Property tanggal_penjualan As DateTime?
    Public Property waktu_penjualan As TimeSpan?
    Public Property total_penjualan As Integer?
    Public Property id_pelanggaan As Integer?
    Public Property id_meja As Integer?
    Public Property status_penjualan As String
    Public Property id_pembayaran As Integer?
End Class