Public Class Form1
    Public Red, Green, Blue As Integer
    Public BMP As New Drawing.Bitmap(500, 400)
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
    Private Sub NumBlue_ValueChanged(sender As Object, e As EventArgs) Handles NumBlue.ValueChanged
        Blue = Convert.ToInt32(NumBlue.Value)
        PicBoxColour.BackColor = Drawing.Color.FromArgb(Red, Green, Blue)
    End Sub

End Class
