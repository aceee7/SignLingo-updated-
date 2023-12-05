Imports MySql.Data.MySqlClient
Public Class Form2
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Private Sub cleardata()
        txte_mail.Clear()
        txtuname.Clear()
        txtpass.Clear()
        txtfname.Clear()
        txtlname.Clear()
        txtage.Clear()

    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

        Me.Close()
        Form1.Show()

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim txtgender As String = ""
        If rbmale.Checked Then
            txtgender = "Male"
        ElseIf rbfemale.Checked Then
            txtgender = "Female"

        End If
        Try
            If txte_mail.Text = "" Or txtuname.Text = "" Or txtpass.Text = "" Or lbldate.Text = "" Or
                txtfname.Text = "" Or txtlname.Text = "" Or txtage.Text = "" Or txtgender = "" Then

                MessageBox.Show("All Fields are required", "NOTICE!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim userExists As Boolean = IsUsernameExists(txtuname.Text)
                If userExists Then
                    MessageBox.Show("Account already exist", "NOTICE!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    signup("INSERT INTO accounts (email,username,pass,date_entered,firstname,lastname,age,gender) 
                    VALUES ('" & txte_mail.Text & "','" & txtuname.Text & "','" & txtpass.Text & "','" & lbldate.Text & "',
                    '" & txtfname.Text & "','" & txtlname.Text & "','" & txtage.Text & "','" & txtgender & "')")

                End If





            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            cleardata()
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim currentDateTime As String = DateTime.Now.ToString("yyyy-MM-dd")
        lbldate.Text = currentDateTime
    End Sub


End Class