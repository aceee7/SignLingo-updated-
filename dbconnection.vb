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
End Module
