Public Class Form1
    Public Red, Green, Blue As Integer
    Public BMP As New Drawing.Bitmap(1000, 1000)
    Dim x1, y1, x2, y2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicBoxColour.BackColor = Drawing.Color.FromArgb(Red, Green, Blue)
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = BMP
    End Sub

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        If RadDDA.Checked Then
            Algo.DDA(NumX1.Value, NumY1.Value, NumX2.Value, NumY2.Value, Red, Green, Blue)
        ElseIf RadMidPoint.Checked Then
            Algo.MidPoint(NumX1.Value, NumY1.Value, NumX2.Value, NumY2.Value, Red, Green, Blue)
        ElseIf radTest.Checked Then
            Algo.Test(NumX1.Value, NumY1.Value, NumX2.Value, NumY2.Value, Red, Green, Blue)
        End If

    End Sub
    Private Sub NumRed_ValueChanged(sender As Object, e As EventArgs) Handles NumRed.ValueChanged
        Red = Convert.ToInt32(NumRed.Value)
        PicBoxColour.BackColor = Drawing.Color.FromArgb(Red, Green, Blue)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Algo.Clear()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim sfdpi As New SaveFileDialog()
        Dim path As String = "E:\CGA\"
        Dim dir As String = System.IO.Path.GetDirectoryName(path)
        Dim title As String = "CGA"
        Dim btn = MessageBoxButtons.YesNo
        Dim ico = MessageBoxIcon.Information

        Try
            If Not System.IO.Directory.Exists(dir) Then
                System.IO.Directory.CreateDirectory(dir)
            End If
            With sfdpi
                .Title = "Save Image As"
                .Filter = "Jpg, Jpeg Images|*.jpg;*jpeg|PNG Image|*.png|BMP Image|*.bmp"
                .AddExtension = True
                .DefaultExt = ".jpg"
                .FileName = "CGA-.jpg"
                .ValidateNames = True
                .OverwritePrompt = True
                .InitialDirectory = dir
                .RestoreDirectory = True

                If .ShowDialog = DialogResult.OK Then
                    If .FilterIndex = 1 Then
                        PictureBox1.Image.Save(sfdpi.FileName, Imaging.ImageFormat.Jpeg)
                    ElseIf .FilterIndex = 2 Then
                        PictureBox1.Image.Save(sfdpi.FileName, Imaging.ImageFormat.Png)
                    ElseIf .FilterIndex = 3 Then
                        PictureBox1.Image.Save(sfdpi.FileName, Imaging.ImageFormat.Bmp)
                    Else
                        Return
                    End If
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("Error: Saving Image Failed -->" & ex.Message.ToString())
        Finally
            sfdpi.Dispose()
        End Try
    End Sub
    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            PictureBox1.ImageLocation = TextBox1.Text
        End If
    End Sub
    Private Sub NumGreen_ValueChanged(sender As Object, e As EventArgs) Handles NumGreen.ValueChanged
        Green = Convert.ToInt32(NumGreen.Value)
        PicBoxColour.BackColor = Drawing.Color.FromArgb(Red, Green, Blue)
    End Sub
    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        x2 = e.X
        y2 = e.Y
        NumX2.Value = x2
        NumY2.Value = y2
        If RadDDA.Checked Then
            Algo.DDA(NumX1.Value, NumY1.Value, NumX2.Value, NumY2.Value, Red, Green, Blue)
        ElseIf RadMidPoint.Checked Then
            Algo.MidPoint(NumX1.Value, NumY1.Value, NumX2.Value, NumY2.Value, Red, Green, Blue)
        ElseIf radTest.Checked Then
            Algo.Test(NumX1.Value, NumY1.Value, NumX2.Value, NumY2.Value, Red, Green, Blue)
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        x1 = e.X
        y1 = e.Y
        NumX1.Value = x1
        NumY1.Value = y1
    End Sub
    Private Sub NumBlue_ValueChanged(sender As Object, e As EventArgs) Handles NumBlue.ValueChanged
        Blue = Convert.ToInt32(NumBlue.Value)
        PicBoxColour.BackColor = Drawing.Color.FromArgb(Red, Green, Blue)
    End Sub
    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        Color_Palate.colorPal(255, 0, 0)
    End Sub
    Private Sub btnOrange_Click(sender As Object, e As EventArgs) Handles btnOrange.Click
        Color_Palate.colorPal(255, 128, 0)
    End Sub
    Private Sub btnYellow_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        Color_Palate.colorPal(255, 255, 0)
    End Sub
    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        Color_Palate.colorPal(0, 255, 0)
    End Sub
    Private Sub btnAqua_Click(sender As Object, e As EventArgs) Handles btnAqua.Click
        Color_Palate.colorPal(0, 255, 255)
    End Sub
    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        Color_Palate.colorPal(0, 0, 255)
    End Sub
    Private Sub btnPink_Click(sender As Object, e As EventArgs) Handles btnPink.Click
        Color_Palate.colorPal(255, 0, 255)
    End Sub
    Private Sub btnLGray_Click(sender As Object, e As EventArgs) Handles btnLGray.Click
        Color_Palate.colorPal(192, 192, 192)
    End Sub
    Private Sub btnDGray_Click(sender As Object, e As EventArgs) Handles btnDGray.Click
        Color_Palate.colorPal(128, 128, 128)
    End Sub
    Private Sub btnBrown_Click(sender As Object, e As EventArgs) Handles btnBrown.Click
        Color_Palate.colorPal(128, 64, 0)
    End Sub
    Private Sub btnBlack_Click(sender As Object, e As EventArgs) Handles btnBlack.Click
        Color_Palate.colorPal(0, 0, 0)
    End Sub
    Private Sub BtnWhite_Click(sender As Object, e As EventArgs) Handles BtnWhite.Click
        Color_Palate.colorPal(255, 255, 255)
    End Sub
End Class
