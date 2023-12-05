Imports System.Drawing.Drawing2D
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form5
    Dim conn As New MySqlConnection("Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95")
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim reader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Show()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(Button1, 30)
        RoundButton(Button2, 30)
        RoundButton(Button3, 30)
        RoundButton(Button4, 30)
        RoundButton(btnA, 30)
        RoundButton(btnB, 30)
        RoundButton(btnC, 30)
        RoundButton(btnD, 30)
        RoundButton(btnE, 30)
        RoundButton(btnF, 30)
        RoundButton(btnG, 30)
        RoundButton(btnH, 30)
        RoundButton(btnI, 30)
        RoundButton(btnJ, 30)
        RoundButton(btnK, 30)
        RoundButton(btnL, 30)
        RoundButton(btnM, 30)
        RoundButton(btnN, 30)
        RoundButton(btnO, 30)
        RoundButton(btnP, 30)
        RoundButton(btnQ, 30)
        RoundButton(btnR, 30)
        RoundButton(btnS, 30)
        RoundButton(btnT, 30)
        RoundButton(btnU, 30)
        RoundButton(btnV, 30)
        RoundButton(btnW, 30)
        RoundButton(btnX, 30)
        RoundButton(btnY, 30)
        RoundButton(btnZ, 30)
        RoundButton(Button31, 30)
        RoundButton(Button32, 30)
        RoundButton(Button33, 30)
        RoundButton(Button34, 30)
        RoundButton(Button37, 30)
        RoundButton(Button38, 30)
        RoundButton(Button39, 30)
        RoundButton(Button40, 30)
        RoundButton(Button41, 30)
        RoundButton(Button42, 30)
        RoundButton(Button43, 30)
        RoundButton(Button44, 30)
        RoundButton(Button45, 30)
        RoundButton(Button46, 30)
        RoundButton(Button47, 30)
        RoundButton(Button48, 30)
        RoundButton(Button49, 30)
        RoundButton(Button50, 30)
        RoundButton(Button51, 30)
        RoundButton(Button52, 30)
        RoundButton(Button53, 30)
        RoundButton(Button54, 30)
        RoundButton(Button55, 30)
        RoundButton(Button56, 30)
        RoundPanel(Panel1, 30)
        RoundPanel(Panel2, 30)
        RoundPanel(Panel7, 30)
        RoundPanel(Panel8, 30)
        RoundPanel(Panel10, 30)
    End Sub

    Private Sub RoundButton(button As Button, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)

        button.Region = New Region(path)
    End Sub
    Private Sub RoundPanel(panel As Panel, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)

        panel.Region = New Region(path)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Form4.Show()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Show()

        Panel1.Hide()

        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click

        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel7.Show()
        Panel1.Hide()
        Panel2.Hide()

        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Panel8.Show()
        Panel7.Hide()
        Panel1.Hide()
        Panel2.Hide()

        Panel10.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel10.Show()
        Panel8.Hide()
        Panel7.Hide()
        Panel1.Hide()
        Panel2.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form7.Show()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnA.Click
        pnldescription.Show()

        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "A"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
        'getting an image
        query = "SELECT image_data FROM imagetable where id = 14;"

        cmd = New MySqlCommand(query, conn)
        conn.Open()
        reader = cmd.ExecuteReader()

        If reader.Read Then
            Dim imageData As Byte() = DirectCast(reader("image_data"), Byte())

            Dim ms As New MemoryStream(imageData)
            Dim image As Image = Image.FromStream(ms)

            File.WriteAllBytes("C:\\ProgramData\\MySQL\\MySQL Server 8.0\\Uploads\\JPG Sign Language\\A.jpg", imageData)
        End If

        picture.Image = Image.FromFile("C:\\ProgramData\\MySQL\\MySQL Server 8.0\\Uploads\\JPG Sign Language\\A.jpg")
        conn.Close()


        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "B"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "C"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "D"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "E"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "F"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "G"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "H"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "I"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "J"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "K"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "L"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "M"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "N"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "O"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "P"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "Q"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "R"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "S"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "T"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "U"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "V"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "W"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "X"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "Y"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "Z"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 130
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        Panel1.Hide()
        Panel2.Hide()
        Panel7.Hide()
        Panel8.Hide()
        Panel10.Hide()
    End Sub


End Class