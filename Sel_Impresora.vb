Imports System.Management
Public Class Sel_Impresora
    Private impresora_Default As String
    Private search As ManagementObjectSearcher
    Private results As ManagementObjectCollection

    Public Function lista_impresoras() As ArrayList
        Dim listaout As New ArrayList
        For Each printer As ManagementObject In results
            listaout.Add(printer("Name").ToString.Trim)
        Next
        Return listaout
    End Function
    Public Sub New()
        search = New ManagementObjectSearcher("select * from win32_printer")
        results = search.Get
    End Sub
End Class
