Public Class TransaksiReservasi
    Public Property id_reservasi As Integer
    Public Property id_pelanggan As Integer?
    Public Property tanggal_reservasi As DateTime?
    Public Property jam_reservasi As TimeSpan?
    Public Property jumlah_orang As Integer?
    Public Property keterangan As String
    Public Property status_reservasi As String
End Class