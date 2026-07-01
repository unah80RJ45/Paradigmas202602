Public Class Movimiento
    Private nombreBanco As String
    Public ReadOnly Property Banco As String
        Get
            Return nombreBanco
        End Get
    End Property
    Public Property Cuenta As String
    Public Property Valor As Double
    Public Overridable Sub MostrarDatos()
        MsgBox(Valor, MsgBoxStyle.Information, Banco & Cuenta)
    End Sub
    Public Sub MostarDatos(dato As String)

    End Sub
    Public Sub MostarDAtos(nombre As String, val As Double)

    End Sub
    Public Sub New(ban As String, cta As String, val As String)
        nombreBanco = ban
        Cuenta = cta
        Valor = val
    End Sub
End Class
