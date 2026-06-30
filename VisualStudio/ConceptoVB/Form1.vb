Imports System.Drawing.Text

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mat As New Materia("Paradigmas", 4)

        mat.Nombre()
        MsgBox("UV: " & mat.UV)
    End Sub
End Class
