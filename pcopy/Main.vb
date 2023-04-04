Public Class Main
    Dim DrawBitmap As Bitmap
    Dim formGraphics As System.Drawing.Graphics
    Dim FilesName As String
    Dim drawOn As Boolean = False

    'Dim brushSize As Integer = 10 'default brush size = 10px

    'Selection of drawing tools
    Dim Eraser As Boolean = False
    Dim Brush As Boolean = False
    Dim AddText As Boolean = False

    'Brush Settings
    Dim myBrush As New SolidBrush(Color.Black) 'declares the brush color variable with a default colour of black
    Dim myBrushSize As Integer = 10 ' Brush Size, default 10

    'Eraser Settings
    Dim myEraser As New SolidBrush(Color.White)
    Dim myEraserSize As Integer = 10

    'Label to add text to image
    Dim myTextBox As New Label
    Dim textCol As New SolidBrush(Color.Black)

    Dim c As Color
    Dim d As Color

    Dim r As Integer
    Dim g As Integer
    Dim b As Integer
    Dim grey As Integer
    Dim z As Bitmap
    Public Property myValue As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawBitmap = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        formGraphics = Graphics.FromImage(DrawBitmap)

        For x As Integer = 0 To pbCanvas.Width - 1  'makes every single pixel on pbcanvas to white (basically clear)
            For y As Integer = 0 To pbCanvas.Height - 1
                DrawBitmap.SetPixel(x, y, Color.White)
            Next
            pbCanvas.Image = DrawBitmap
        Next
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.InitialDirectory = "c:\Pictures"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "image files (*.jpg, *.png, *.bmp)|*.jpg; *.png; *.bmp"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbCanvas.Image = Image.FromFile(OpenFileDialog1.FileName)
            DrawBitmap = Image.FromFile(OpenFileDialog1.FileName)
            formGraphics = Graphics.FromImage(DrawBitmap)
        Else : Try
            Catch argEx As ArgumentException
            End Try
        End If
    End Sub

    Public Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If FilesName = "" Then
            SaveAsToolStripMenuItem_Click(sender, e)
        Else
            pbCanvas.Image.Save(FilesName, System.Drawing.Imaging.ImageFormat.Png)
            'FilesName = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Filter = "JPG|*.jpg|BMP|*.bmp|GIF|*.gif|PNG|*.png"
        If (SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And (SaveFileDialog1.FileName.Length) > 0 Then
            pbCanvas.Image.Save(SaveFileDialog1.FileName)
            FilesName = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub pbCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles pbCanvas.MouseMove
        lblX.Text = "X=" & e.X
        lblY.Text = "Y=" & e.Y

        'c = CType(pbCanvas.Image, Bitmap).GetPixel(e.X, e.Y) 'Exceptions encountered
        'Exception Handling
        If e.X > pbCanvas.Width - 1 Then
            If e.Y > pbCanvas.Height Then
                c = CType(pbCanvas.Image, Bitmap).GetPixel(pbCanvas.Width - 1, pbCanvas.Height - 1)
            ElseIf e.Y < pbCanvas.Top + 1 Then
                c = CType(pbCanvas.Image, Bitmap).GetPixel(pbCanvas.Width - 1, pbCanvas.Top + 1)
            Else
                c = CType(pbCanvas.Image, Bitmap).GetPixel(pbCanvas.Width - 1, e.Y)
            End If
        ElseIf e.X < pbCanvas.Left + 1 Then
            If e.Y > pbCanvas.Height - 1 Then
                c = CType(pbCanvas.Image, Bitmap).GetPixel(pbCanvas.Left + 1, pbCanvas.Height - 1)
            ElseIf e.Y < pbCanvas.Top + 1 Then
                c = CType(pbCanvas.Image, Bitmap).GetPixel(pbCanvas.Left + 1, pbCanvas.Top + 1)
            Else
                c = CType(pbCanvas.Image, Bitmap).GetPixel(pbCanvas.Left + 1, e.Y)
            End If
        ElseIf e.Y > pbCanvas.Height - 1 Then
            If e.X > pbCanvas.Width - 1 Then
                c = CType(pbCanvas.Image, Bitmap).GetPixel(pbCanvas.Width - 1, pbCanvas.Height - 1)
            ElseIf e.X < pbCanvas.Left + 1 Then
                c = CType(pbCanvas.Image, Bitmap).GetPixel(pbCanvas.Left + 1, pbCanvas.Height - 1)
            Else
                c = CType(pbCanvas.Image, Bitmap).GetPixel(e.X, pbCanvas.Height - 1)
            End If
        ElseIf e.Y < pbCanvas.Top + 1 Then
            If e.X > pbCanvas.Width - 1 Then
                c = CType(pbCanvas.Image, Bitmap).GetPixel(pbCanvas.Width - 1, pbCanvas.Top + 1)
            ElseIf e.X < pbCanvas.Left + 1 Then
                c = CType(pbCanvas.Image, Bitmap).GetPixel(pbCanvas.Left, pbCanvas.Top + 1)
            Else
                c = CType(pbCanvas.Image, Bitmap).GetPixel(e.X, pbCanvas.Top + 1)
            End If
        Else
            c = CType(pbCanvas.Image, Bitmap).GetPixel(e.X, e.Y)
        End If


        lblR.Text = "R=" & Val(c.R)
        lblG.Text = "G=" & Val(c.G)
        lblB.Text = "B=" & Val(c.B)

        'Drawing
        Dim drawPoint As Point
        drawPoint.X = e.X - (myBrushSize / 2)
        drawPoint.Y = e.Y - (myBrushSize / 2)


        If drawOn = True Then

            If Brush = True Then
                formGraphics.FillEllipse(myBrush, drawPoint.X, drawPoint.Y, myBrushSize, myBrushSize) 'draws a filled circle
                pbCanvas.Image = DrawBitmap
            End If
            If Eraser = True Then
                formGraphics.FillEllipse(myEraser, drawPoint.X, drawPoint.Y, myEraserSize, myEraserSize)
                pbCanvas.Image = DrawBitmap
            End If

        End If
    End Sub

    Private Sub trkbrContrast_Scroll(sender As Object, e As EventArgs) Handles trkbrContrast.Scroll
        z = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        myValue = trkbrContrast.Value
        For x = 0 To pbCanvas.Width - 1
            For y = 0 To pbCanvas.Height - 1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y)
                r = c.R + myValue
                g = c.G + myValue
                b = c.B + myValue

                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0

                d = Color.FromArgb(255, r, g, b)
                z.SetPixel(x, y, d)
            Next
        Next
        pbCanvas.Image = z
        trkbrContrast.Value = 0
    End Sub

    Private Sub trkbrContrast_MouseDown(sender As Object, e As MouseEventArgs) Handles trkbrContrast.MouseDown
        z = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        If e.Button = MouseButtons.Right Then
            'https://stackoverflow.com/questions/21854102/how-to-create-a-visual-basic-dialog-box-that-users-can-input-text/21854230
            myValue = InputBox("Enter Value", "Please enter a value between -255 and 255", "0")
            For x = 0 To pbCanvas.Width - 1
                For y = 0 To pbCanvas.Height - 1
                    c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y)
                    r = c.R + myValue
                    g = c.G + myValue
                    b = c.B + myValue

                    If r > 255 Then r = 255
                    If g > 255 Then g = 255
                    If b > 255 Then b = 255
                    If r < 0 Then r = 0
                    If g < 0 Then g = 0
                    If b < 0 Then b = 0

                    d = Color.FromArgb(255, r, g, b)
                    z.SetPixel(x, y, d)
                Next
            Next
            pbCanvas.Image = z
            trkbrContrast.Value = 0
        Else
        End If
    End Sub

    Private Sub trkbrRedLvl_Scroll(sender As Object, e As EventArgs) Handles trkbrRedLvl.Scroll
        z = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        myValue = trkbrContrast.Value
        For x = 0 To pbCanvas.Width - 1
            For y = 0 To pbCanvas.Height - 1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y)
                r = c.R + trkbrRedLvl.Value
                g = c.G
                b = c.B

                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0

                d = Color.FromArgb(255, r, g, b)
                z.SetPixel(x, y, d)
            Next
        Next
        pbCanvas.Image = z
        trkbrRedLvl.Value = 0
    End Sub

    Private Sub trkbrGreenLvl_Scroll(sender As Object, e As EventArgs) Handles trkbrGreenLvl.Scroll
        z = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        For x = 0 To pbCanvas.Width - 1
            For y = 0 To pbCanvas.Height - 1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y)
                r = c.R
                g = c.G + trkbrGreenLvl.Value
                b = c.B

                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0

                d = Color.FromArgb(255, r, g, b)
                z.SetPixel(x, y, d)
            Next
        Next
        pbCanvas.Image = z
        trkbrGreenLvl.Value = 0
    End Sub
    Private Sub trkbrBlueLvl_Scroll(sender As Object, e As EventArgs) Handles trkbrBlueLvl.Scroll
        z = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        For x = 0 To pbCanvas.Width - 1
            For y = 0 To pbCanvas.Height - 1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y)
                r = c.R
                g = c.G
                b = c.B + trkbrBlueLvl.Value

                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0

                d = Color.FromArgb(255, r, g, b)
                z.SetPixel(x, y, d)
            Next
        Next
        pbCanvas.Image = z
        trkbrBlueLvl.Value = 0
    End Sub

    Private Sub NegativeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegativeToolStripMenuItem.Click
        z = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        For x = 0 To pbCanvas.Width - 1
            For y = 0 To pbCanvas.Height - 1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y)
                r = c.R
                g = c.G
                b = c.B

                d = Color.FromArgb(255, 255 - r, 255 - g, 255 - b)
                z.SetPixel(x, y, d)
            Next
        Next
        pbCanvas.Image = z
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        z = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        For x = 0 To pbCanvas.Width - 1
            For y = 0 To pbCanvas.Height - 1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y)
                r = c.R
                g = c.G
                b = c.B
                grey = (r + g + b) / 3
                d = Color.FromArgb(255, grey, grey, grey)
                z.SetPixel(x, y, d)
            Next
        Next
        pbCanvas.Image = z
    End Sub

    Private Sub BlurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlurToolStripMenuItem.Click
        z = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        For x = 1 To pbCanvas.Width - 2
            For y = 1 To pbCanvas.Height - 2

                r = 0
                g = 0
                b = 0

                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y)
                r = r + c.R
                g = g + c.G
                b = b + c.B
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x - 1, y - 1)
                r = r + c.R
                g = g + c.G
                b = b + c.B
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y - 1)
                r = r + c.R
                g = g + c.G
                b = b + c.B
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x + 1, y - 1)
                r = r + c.R
                g = g + c.G
                b = b + c.B
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x - 1, y)
                r = r + c.R
                g = g + c.G
                b = b + c.B
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x + 1, y)
                r = r + c.R
                g = g + c.G
                b = b + c.B
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x - 1, y + 1)
                r = r + c.R
                g = g + c.G
                b = b + c.B
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y + 1)
                r = r + c.R
                g = g + c.G
                b = b + c.B
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x + 1, y + 1)
                r = r + c.R
                g = g + c.G
                b = b + c.B

                r = r / 9
                g = g / 9
                b = b / 9

                d = Color.FromArgb(255, r, g, b)
                z.SetPixel(x, y, d)
            Next
        Next
        pbCanvas.Image = z
    End Sub

    Private Sub EdgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdgeToolStripMenuItem.Click
        z = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        For x = 1 To pbCanvas.Width - 2
            For y = 1 To pbCanvas.Height - 2

                r = 0
                g = 0
                b = 0

                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y)
                r = r + c.R * 8
                g = g + c.G * 8
                b = b + c.B * 8
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x - 1, y - 1)
                r = r + c.R * -1
                g = g + c.G * -1
                b = b + c.B * -1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y - 1)
                r = r + c.R * -1
                g = g + c.G * -1
                b = b + c.B * -1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x + 1, y - 1)
                r = r + c.R * -1
                g = g + c.G * -1
                b = b + c.B * -1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x - 1, y)
                r = r + c.R * -1
                g = g + c.G * -1
                b = b + c.B * -1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x + 1, y)
                r = r + c.R * -1
                g = g + c.G * -1
                b = b + c.B * -1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x - 1, y + 1)
                r = r + c.R * -1
                g = g + c.G * -1
                b = b + c.B * -1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x, y + 1)
                r = r + c.R * -1
                g = g + c.G * -1
                b = b + c.B * -1
                c = CType(pbCanvas.Image, Bitmap).GetPixel(x + 1, y + 1)
                r = r + c.R * -1
                g = g + c.G * -1
                b = b + c.B * -1

                If r < 0 Then r = 0
                If r > 255 Then r = 255
                If g < 0 Then g = 0
                If g > 255 Then g = 255
                If b < 0 Then b = 0
                If b > 255 Then b = 255
                'r = r / 9
                'g = g / 9
                'b = b / 9

                d = Color.FromArgb(255, r, g, b)
                z.SetPixel(x, y, d)
            Next
        Next
        pbCanvas.Image = z
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        DrawBitmap = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        formGraphics = Graphics.FromImage(DrawBitmap)

        For x As Integer = 0 To pbCanvas.Width - 1
            For y As Integer = 0 To pbCanvas.Height - 1
                DrawBitmap.SetPixel(x, y, Color.White)
            Next
            pbCanvas.Image = DrawBitmap
        Next
    End Sub

    Private Sub TSbtnBrush_Click(sender As Object, e As EventArgs) Handles TSbtnBrush.Click

        'Set brush as active tool
        Brush = True
        Eraser = False
        AddText = False

        ' Picking colour of brush https://stackoverflow.com/questions/9287391/vb-pop-color-picker
        Dim cDialog As New ColorDialog()
        cDialog.Color = myBrush.Color ' initial selection is current color.

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            myBrush.Color = cDialog.Color ' update with user selected color.
        End If

    End Sub

    Private Sub TSbtnEraser_Click(sender As Object, e As EventArgs) Handles TSbtnEraser.Click

        'Set Eraser as active tool
        Brush = False
        Eraser = True
        AddText = False
    End Sub

    Private Sub pbCanvas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbCanvas.MouseDown
        If Brush = True Then
            drawOn = True
        End If

        If Eraser = True Then
            drawOn = True
        End If

        If AddText = True Then
            drawOn = True

            'https://stackoverflow.com/questions/46021397/adding-text-in-an-image-vb-net
            z = New Bitmap(pbCanvas.Width, pbCanvas.Height)
            z = pbCanvas.Image
            Using formGraphics = Graphics.FromImage(z)
                'formGraphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                formGraphics.DrawString(myTextBox.Text, myTextBox.Font, textCol, e.X, e.Y)

            End Using
            pbCanvas.Image = z
        End If
    End Sub

    Private Sub pbCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbCanvas.MouseUp
        drawOn = False
        AddText = False
    End Sub

    Private Sub TSbtnAddText_Click(sender As Object, e As EventArgs) Handles TSbtnAddText.Click

        If (FontDialog1.ShowDialog() = DialogResult.OK) Then
            AddText = True
            myTextBox.Font = FontDialog1.Font
            myTextBox.Text = InputBox("Please write your text below", "Add Text", "Type here...")
        End If

        Dim cDialog As New ColorDialog()
        If (cDialog.ShowDialog() = DialogResult.OK) Then
            textCol.Color = cDialog.Color 'update with user selected color.
        End If

    End Sub

End Class
