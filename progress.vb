Imports System.Drawing.Drawing2D
Public Class progress
    Private Sub progress_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim username As String = GetUsernameFromDatabase()

        ' Display the progress value when the user logs in
        Dim progressValue As Integer = GetProgressFromDatabase(username)

        ' Set the retrieved username and update the progress bar
        progressalphabet_asl.Value = progressValue

        MessageBox.Show($"Welcome, {username}! Your progress value is: {progressValue}")


        RoundLabel(Label7, 18)
        RoundLabel(Label8, 18)
        RoundLabel(Label9, 18)
        RoundLabel(Label10, 18)
        RoundLabel(Label11, 18)
        RoundLabel(Label12, 18)
        RoundLabel(Label13, 18)
        RoundLabel(Label14, 18)
        RoundLabel(Label15, 18)
        RoundLabel(Label16, 18)

    End Sub
    Private Sub RoundLabel(label As Label, radius As Integer)
        ' Create a GraphicsPath to define the rounded shape
        Dim roundedRect As New GraphicsPath()

        ' Add rounded rectangle to the GraphicsPath
        roundedRect.AddArc(0, 0, radius * 2, radius * 2, 180, 90) ' Top-left corner
        roundedRect.AddArc(label.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90) ' Top-right corner
        roundedRect.AddArc(label.Width - radius * 2, label.Height - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
        roundedRect.AddArc(0, label.Height - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

        ' Close the path
        roundedRect.CloseFigure()

        ' Set the label's Region property with the rounded shape
        label.Region = New Region(roundedRect)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Form3.Show()

    End Sub
End Class