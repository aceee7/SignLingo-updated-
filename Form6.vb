Imports System.Drawing.Drawing2D
Public Class Form6
    Private Sub RoundPanel(panel As Panel, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)

        panel.Region = New Region(path)
    End Sub
    Private Sub RoundButton(button As Button, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)

        button.Region = New Region(path)
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundPanel(Panel1, 30)
        RoundButton(Button1, 30)
        RoundButton(Button2, 30)
        RoundButton(Button3, 30)
        RoundButton(Button4, 30)
        RoundButton(Button5, 30)
        RoundButton(Button6, 30)
        RoundButton(Button7, 30)
        RoundButton(Button8, 30)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel2.Show()
        Panel1.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Show()
        Panel2.Hide()
        Panel1.Hide()

    End Sub
End Class