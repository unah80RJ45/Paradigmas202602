Public Class Materia
    Private nombreMateria As String
    Private unidades As Integer

    Public Sub Nombre()
        MsgBox(nombreMateria)
    End Sub
    Public Function UV() As Integer
        Return unidades
    End Function
    Public Sub New(nombre As String, uv As Integer)
        nombreMateria = nombre
        unidades = uv
    End Sub
End Class
