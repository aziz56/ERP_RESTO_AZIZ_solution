Imports BO
Imports pos.BO
Public Interface IMasterPelanggan
    Inherits ICrud(Of MasterPelanggan)
    Function GetAllPelanggan() As List(Of MasterPelanggan)
    Function Create(ByVal obj As MasterPelanggan)
    Function Update(ByVal obj As MasterPelanggan)
    Function Delete(ByVal obj As MasterPelanggan)


End Interface



