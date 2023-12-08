Imports System.Drawing.Drawing2D
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form5
    Dim conn As New MySqlConnection("Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95")
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim reader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnalphabet.Click
        Panel1.Show()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(btnalphabet, 30)
        RoundButton(btnnumbers, 30)
        RoundButton(btnwords, 30)
        RoundButton(btnphrases, 30)
        RoundButton(Button5, 30)
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
        RoundPanel(pnlnumbers, 30)
        RoundPanel(pnlwords, 30)
        RoundPanel(Panel8, 30)
        RoundPanel(pnlphrases, 30)
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





    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        pnldescription.Show()




        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnwords.Click
        pnlwords.Show()
        Panel1.Hide()
        pnlnumbers.Hide()

        Panel8.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Panel8.Show()
        pnlwords.Hide()
        Panel1.Hide()
        pnlnumbers.Hide()

        pnlphrases.Hide()

    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Favorites.Show()


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

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "A.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If

        ' Hide other panels
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "B.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "C.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "D.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "E.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "F.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "G.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "H.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "I.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "J.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "K.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "L.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "M.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "N.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "O.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "P.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "Q.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "R.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "S.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "T.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "U.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "V.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "W.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "X.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "Y.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
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
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "Z.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Label14_Click_1(sender As Object, e As EventArgs) Handles addtofave.Click
        Dim button As New Button

        button.Text = lbldesc.Text
        button.Size = New Size(731, 73)
        button.BackColor = Color.FromArgb(0, 74, 173)


        If Favorites.Panel1.Controls.Count < 0 Then
            Favorites.Panel1.Controls.Add(button)
        End If



    End Sub
    Public Sub AddNewButton()
        Dim buttonCounter As Integer = 0
        ' Create a new button
        Dim newButton As New Button()
        buttonCounter += 1

        ' Set properties for the new button
        newButton.Text = lbldesc.Text
        newButton.Size = New Size(731, 73)
        newButton.BackColor = Color.FromArgb(0, 74, 173)

        ' Set the location of the new button under the last button added
        If buttonCounter > 1 Then
            ' Adjust the Y-coordinate based on the height and spacing
            newButton.Location = New Point(Panel1.Controls(Panel1.Controls.Count + 1).Left + 15, Panel1.Controls(Panel1.Controls.Count + 1).Bottom + 10)
        Else
            ' If it's the first button, set a default location
            newButton.Location = New Point(15, 13)
        End If

        ' Add the new button to the panel
        Favorites.Panel1.Controls.Add(newButton)
    End Sub

    Public Function loadImage(imagename As String)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imagePath As String = Path.Combine(folderPath, imagename)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            pbimage.Image = Image.FromFile(imagePath)
        Else
            Console.WriteLine("Image not found.")
        End If

        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnldescription.Hide()

    End Function

    Private Sub cmbphrases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbphrases.SelectedIndexChanged
        Select Case cmbphrases.SelectedItem.ToString()
            Case "Thank You"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Extend your fingers and thumb. Touch your fingers to your chin and bring your fingers forward. It is almost like you are blowing a kiss out, to thank the person - but the sign is a bit lower."
                'lbldescription.Font = New Font(lbldescription.Font.FontFamily, 13)
            Case "You're Welcome"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "It is signed the same way as Thank you. Take your flat, open, dominant hand, and starting from your chin, take your hand out as it arcs down and away from your face. It is as if you are acknowledging that your baby has thanked you, so you are mirroring the polite gesture back, like thanking them for thanking you!"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 12)
            Case "How much?"
                loadImage("HOW MUCH.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "First by starting with both your closed hands, four fingers touching the thumb on either side of your body, facing up. Then move your hands upward, with palms still facing up and fingers opening wide, and make a questioning face."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Goodbye"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Same as the traditional gesture for the word. Open your palm, folding down your fingers, then open your palm again."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 13)
            Case "Hello"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Make the sign by extending your fingers and cross your thumb in front of your palm. Now take the hand, starting with your hand in front of your ear, and extend it outward and away from your body."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Good Morning"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "You combine the signs for good and morning."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 16)
            Case "Good Night"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Combine the signs for good and night."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 16)
            Case "Excuse me"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "You set up the sign by taking your non-dominant hand palm facing the sky, then brush along your palm with the fingertips of the dominant hand. It is also the sign for pardon me or forgive me."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Please"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Take your dominant hand with fingers extended and held together, and thumb extended and sticking out. Take the hand with palm facing in and rub it in a circle on your chest."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Sorry"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Make your hand into a fist and rub it in a circular motion across your chest. It is like you are rubbing around your heart because you are truly sorry."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "I love you"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Put up your thumb, index finger and pinkie finger, while keeping your ring finger and your middle finger down. Hold the hand out, palm facing away from you and move it back and forth slightly."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "You look beautiful"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Start with your dominant hand open, thumb pointing at your chin and fingers pointing up. You complete the sign by rolling your fingers across the front of your face in clockwise fashion, ending with your fingers and thumb together around your chin area.
"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "What?"
                loadImage("WHAT.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Turn up your open hands, with fingers spread apart and hands slightly curved and relaxed. Move both hands back and forth simultaneously while furrowing your brow as you question, What?"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "When?"
                loadImage("WHEN.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Close both your hands in fists and sticking only your index fingers out. Your non-dominant index finger stands vertically and doesn't move, while your dominant index finger twists in a small circle above the non-dominant index, until it finally touches the tip of the index finger to rest. It is like you are zeroing in on a more precise date or time, until you finally reach it.
"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 11)
            Case "Where?"
                loadImage("WHERE.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Stick your dominant index finger out and wiggling it sideways. It's also important to furrow your brow - a facial cue that you are asking your baby a question - as you ask and sign, Where Is...?"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Why?"
                loadImage("WHY.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Take your dominant hand and make the ASL sign for the letter 'Y' at the side of your head. A variant of this sign is to wiggle your middle finger up and down with the rest of your fingers spread out, palm facing the side of your head. A third alternative is still to make the letter 'Y', but after pulling your hand a bit further down your dominant side.
"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 11)
            Case "Who?"
                loadImage("WHO.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Form the ASL letter 'L' with your dominant hand, touch your thumb to your chin, and wiggle the longer 'L' leg up and down as you furrow your brow and ask your baby, Who?"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "How?"
                loadImage("HOW.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Close both hands with thumbs extending out and upward. Have both hands meet by touching knuckles and move your dominant hand back and forth as if opening a lock, while keeping your non-dominant fist steady."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Don't know"
                loadImage("DON_T KNOW.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Shrug your shoulders. Alternatively, you can point to your forehead with your dominant hand with fingers together and move your hand away from you, while slightly shaking your head to show negation."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Don't want"
                loadImage("DON_T WANT.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Looks like you don't want something and are pushing it away.  Starting with your hands with palms upward and fingers curved, turn your hands over and push your hands away."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Help"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Place your closed-fist, dominant 'A' hand on top of your non-dominant open palm, and move both hands upwards."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "How are you?"
                loadImage("HOW ARE YOU.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Form curved hands shapes on both hands, palms down and/or slightly back and point towards the person, ASL gesture for You"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "I'm fine"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Bring your flat right hand up to your chin. Then extend the hand outward. I'm fine."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "My name is..."
                loadImage("MY NAME IS.jpg")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Place your right hand over your heart. Extend the index and middle finger on both hands. Put right fingers on top of left ones. Then  Finger spell your name."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "What is your name?"
                loadImage("WHAT IS YOUR NAME.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Put open right hand up in front of you, then bring forward.  And then extend the index and middle finger on both hands. Put right fingers on top of left ones. Tap twice. Then place both hands out in front of you, palms up. Shake them and use a questioning expression on your face."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 11)
            Case "Again"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Flatten out your leading hand, bend your second hand at a right angle, then tap it against the middle of the palm of your first hand."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Yes"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Looks a head nodding yes. You take your hand and make it into a fist, holding it at about shoulder height, then make your fist bob back and forth."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "No"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Looks like a mouth saying no. Take your index finger together with your middle finger and tap them together with your thumb."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Later"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Take your dominant hand and start with an 'L'-sign, with your index finger and thumb extend at right angles. Take your non-dominant hand and hold it up flat, facing your 'L' hand, with your 'L' hand's thumb sticking to the palm of your other hand. Hold your non-dominant, open flat hand steady as you pivot your 'L' hand 90 degrees, over and down."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 11)
            Case "Now"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Form both hands into the ASL letter Y sign, with your thumb and pinkie fingers extended and your three middle fingers curled in on each hand. Starting with your hands up, bring them down to your hip level."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Happy Birthday"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".jpg")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "This is a two-part sign. First start with the sign for happy by brushing a flat hand over your heart a couple of times. Next sign birthday by touching the middle finger of one hand first to your chin, then to your chest."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Congratulations"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".jpg")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Palm-down dominant hand is interlocked with palm-up non-dominant hand, moves down twice."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Merry Christmas"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".jpg")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Plan a handshake, thumbs up on your chest twice with upwards movement then draw a ‘C’. You open your index finger curve it and hold it in front of your mouth and swipe it twice for merry. You can also sign language for the word ‘happy’. By showing your hands upwards and rubbing palms together in a way that sounds like a clap."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 11)
            Case "Happy New Year"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".jpg")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Pick up your hand and rub it upwards on your chest twice. Open both hands and take the left one upwards going parallel as a sign of ‘new’. For ‘year’ make a fist of your hands and tap the fist above another first."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
        End Select
    End Sub

    Private Sub btnphrases_Click(sender As Object, e As EventArgs) Handles btnphrases.Click
        pnlphrases.Show()
        Panel8.Hide()
        pnlwords.Hide()
        Panel1.Hide()
        pnlnumbers.Hide()
        pnldescription.Hide()

    End Sub

    Private Sub btnnumbers_Click(sender As Object, e As EventArgs) Handles btnnumbers.Click
        pnlnumbers.Show()

        pnldescription.Hide()
        Panel1.Hide()
        pnlwords.Hide()
        Panel8.Hide()
        pnlphrases.Hide()
    End Sub
    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click
        Dim username As String = GetUsernameFromDatabase()
        IncrementProgressBarAlphabet(1)

        ' Transfer the updated progress value to MySQL Workbench
        TransferProgressToDatabase(username, progress.progressalphabet_asl.Value)

        ' Display the updated progress value
        MessageBox.Show($"Progress value updated: {progress.progressalphabet_asl.Value}")
    End Sub

    Private Sub IncrementProgressBarAlphabet(incrementValue As Integer)
        ' Ensure the progress value is within the valid range (0 to 100)
        Dim newValue As Integer = 0
        If lblLetter.Text = "ALPHABET" Then
            newValue = progress.progressalphabet_asl.Value + incrementValue
            If newValue > 27 Then newValue = 27
            If newValue < 0 Then newValue = 0
        End If


        ' Update the progress bar
        progress.progressalphabet_asl.Value = newValue
    End Sub
End Class