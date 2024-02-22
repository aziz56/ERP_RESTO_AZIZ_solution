Imports BO
Imports pos.BO
Public Interface IMasterMenu
    Inherits ICrud(Of MasterMenu)
    Function GetByNamaMenu(ByVal nama_menu As String) As List(Of MasterMenu)
    Function GetByHargaMenu(ByVal harga_menu As Integer) As List(Of MasterMenu)
    Function GetByDeskripsiMenu(ByVal deskripsi_menu As String) As List(Of MasterMenu)

End Interface
