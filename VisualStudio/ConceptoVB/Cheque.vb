Public Class Cheque
    Inherits Movimiento

    Public Property Beneficiario As String

    Public Overrides Sub MostrarDatos()
        'MyBase.MostrarDatos()
        MsgBox(Beneficiario, MsgBoxStyle.Information, "Beneficiario")
    End Sub
    Public Sub New(banco As String, cuenta As String, valor As Double, ben As String)
        MyBase.New(banco, cuenta, valor)
        Beneficiario = ben
    End Sub
End Class
