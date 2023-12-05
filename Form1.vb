Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95")
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim reader As MySqlDataReader
    Private Sub Login()
        query = "SELECT username, pass FROM accounts WHERE username = @username AND pass = @pass"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", Me.username.Text)
        cmd.Parameters.AddWithValue("@pass", Me.password.Text)
        conn.Open()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Try
            If reader.HasRows Then
                MsgBox("Login Successful")
                Form3.Show()
                Me.Hide()
            Else
                MsgBox("Invalid username or password")
                Me.Show()

            End If
            reader.Close()

        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        Finally
            cleardata()
        End Try

        conn.Close()
    End Sub
    Private Sub cleardata()
        username.Clear()
        password.Clear()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Hide()
        Form8.Show()

    End Sub
End Class
