Imports System.Drawing.Drawing2D
Public Class Form4

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        Form3.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(Button1, 30)
        RoundButton(Button2, 30)
    End Sub
    Private Sub RoundButton(button As Button, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)

        button.Region = New Region(path)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()

    End Sub
End Class