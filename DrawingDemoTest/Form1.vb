Public Class Form1
    Public Red, Green, Blue As Integer
    Public BMP As New Drawing.Bitmap(500, 400)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicBoxColour.BackColor = Drawing.Color.FromArgb(Red, Green, Blue)
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = BMP
    End Sub

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        Algo.DDA(NumX1.Value, NumY1.Value, NumX2.Value, NumY2.Value, Red, Green, Blue)
    End Sub
    Private Sub NumRed_ValueChanged(sender As Object, e As EventArgs) Handles NumRed.ValueChanged
        Red = Convert.ToInt32(NumRed.Value)
        PicBoxColour.BackColor = Drawing.Color.FromArgb(Red, Green, Blue)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Algo.Clear()
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
