Public Class Pembayaran
    Public Property id_pembayaran As Integer
    Public Property id_penjualan As Integer?
    Public Property metode_pembayaran As String
    Public Property amount As Decimal?
    Public Property kembalian As Decimal?
    Public Property tanggal_pembayaran As DateTime?
    Public Property waktu_pembayaran As TimeSpan?
    Public Property keterangan As String
End Class