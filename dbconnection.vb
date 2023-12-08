Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module dbconnection
    Public Function strconection() As MySqlConnection
        Return New MySqlConnection("Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95")
    End Function
    Public strcon As MySqlConnection = strconection()
    Public result As String
    Public cmd As New MySqlCommand
    Public dt As New DataTable
    Public da As New MySqlDataAdapter


    Public Sub signup(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Account Creation Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Account Has Been Created!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()

        End Try
    End Sub
    Public Function IsUsernameExists(username As String) As Boolean
        Try
            strcon.Open()

            If strcon.State = ConnectionState.Open Then

                Dim usernames As String = Form2.txtuname.Text

                Dim insertQuery As String = "SELECT * FROM accounts WHERE username = @Username "

                Dim command As New MySqlCommand(insertQuery, strcon)
                command.Parameters.AddWithValue("@Username", usernames)
                Dim a = command.ExecuteReader()

                If a.HasRows Then
                    Return True
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strcon.Close()

        End Try
    End Function
    Public Sub TransferProgressToDatabase(username As String, progressValue As Integer)

        Try
            strcon.Open()

            ' Update the 'progress_value' column in the 'user_progress' table
            Dim query As String = "UPDATE accounts SET progress_data_alphabet = @progressValue WHERE username = @username"
            Dim command As New MySqlCommand(query, strcon)
            command.Parameters.AddWithValue("@progressValue", progressValue)
            command.Parameters.AddWithValue("@username", username)

            ' Execute the query
            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error transferring progress value to database: " & ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Function GetUsernameFromDatabase() As String
        Dim username As String = ""

        Try
            strcon.Open()

            ' Retrieve the username from the 'user_progress' table (you might adjust this query based on your actual schema)
            Dim query As String = "SELECT username FROM accounts LIMIT 1"
            Dim command As New MySqlCommand(query, strcon)

            ' Execute the query and get the result
            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                username = reader.GetString("username")
            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving username from database: " & ex.Message)
        Finally
            strcon.Close()
        End Try

        Return username
    End Function

    Public Function GetProgressFromDatabase(username As String) As Integer
        Dim progressValue As Integer = 0

        Try
            strcon.Open()

            ' Retrieve the 'progress_value' from the 'user_progress' table
            Dim query As String = "SELECT progress_data_alphabet FROM accounts WHERE username = @username"
            Dim command As New MySqlCommand(query, strcon)
            command.Parameters.AddWithValue("@username", username)

            ' Execute the query and get the result
            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                progressValue = reader.GetInt32("progress_data_alphabet")
            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving progress value from database: " & ex.Message)
        Finally
            strcon.Close()
        End Try

        Return progressValue
    End Function

End Module
