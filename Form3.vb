Imports System.Drawing.Drawing2D
Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundPanel(pnlMenu, 30)

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()

    End Sub



    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        'pnlMenu.Hide()
        If pnlMenu.Width > 0 Then
            decreaseTimer.Enabled = True
        End If
    End Sub
    Private Sub RoundPanel(panel As Panel, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)

        panel.Region = New Region(path)
    End Sub



    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

        'pnlMenu.Width = 266
        pnlMenu.Visible = True
        If pnlMenu.Width > 266 Then
            decreaseTimer.Enabled = True
        Else
            increaseTimer.Enabled = True
        End If

    End Sub

    Private Sub decreaseTimer_Tick(sender As Object, e As EventArgs) Handles decreaseTimer.Tick
        If pnlMenu.Width > 0 Then
            pnlMenu.Width -= 100
        Else
            decreaseTimer.Enabled = False
        End If
    End Sub

    Private Sub increaseTimer_Tick(sender As Object, e As EventArgs) Handles increaseTimer.Tick
        If pnlMenu.Width < 266 Then
            pnlMenu.Width += 100
        Else
            increaseTimer.Enabled = False
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        progress.Show()
        Me.Hide()

    End Sub
End Class