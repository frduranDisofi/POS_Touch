Namespace be
    Public Class archivo_txt
        Public lineas As New Hashtable

        Public ReadOnly Property cant_lineas() As Integer
            Get
                Return lineas.Count
            End Get
        End Property

    End Class

End Namespace

