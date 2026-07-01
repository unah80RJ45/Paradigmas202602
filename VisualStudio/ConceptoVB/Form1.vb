Imports System.Drawing.Text

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mat As New Materia("Paradigmas", 4)

        mat.Nombre()
        'MsgBox("UV: " & mat.UV)
    End Sub

    Private Sub cmdCheque_Click(sender As Object, e As EventArgs) Handles cmdCheque.Click
        Dim chk As New Cheque("Banco ABC", "20-1000-123", 1000, "Juan Perez")
        chk.MostrarDatos()
    End Sub
End Class
