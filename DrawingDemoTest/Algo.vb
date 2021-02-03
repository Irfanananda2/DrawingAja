﻿Module Algo
    Public Sub case1_8(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, R As Integer, G As Integer, B As Integer)
        Dim dx = Math.Abs(x2 - x1), dy = Math.Abs(y2 - y1)
        If x1 <= x2 And y1 = y2 Then                                     'Case 1
            For i As Integer = x1 To x2
                Form1.BMP.SetPixel(i, y1, Color.FromArgb(R, G, B))
            Next
        ElseIf y1 < y2 And x1 = x2 Then                                 'Case 2
            For j As Integer = y1 To y2
                Form1.BMP.SetPixel(x1, j, Color.FromArgb(R, G, B))
            Next
        ElseIf x1 > x2 And y1 = y2 Then                                 'Case 3
            For i As Integer = x2 To x1
                Form1.BMP.SetPixel(i, y1, Color.FromArgb(R, G, B))
            Next
        ElseIf y1 > y2 And x1 = x2 Then                                 'Case 4
            For j As Integer = y2 To y1
                Form1.BMP.SetPixel(x1, j, Color.FromArgb(R, G, B))
            Next
        ElseIf x1 < x2 And y1 < y2 And dx = dy Then                     'Case 5
            Dim j = y1
            For i As Integer = x1 To x2
                Form1.BMP.SetPixel(i, j, Color.FromArgb(R, G, B))
                j += 1
            Next
        ElseIf x1 > x2 And y1 < y2 And dx = dy Then                     'Case 6
            Dim i = x1
            For j As Integer = y1 To y2
                Form1.BMP.SetPixel(i, j, Color.FromArgb(R, G, B))
                i -= 1
            Next
        ElseIf x1 > x2 And y1 > y2 And dx = dy Then                     'Case 7
            Dim j = y1
            Dim l = x1
            For i As Integer = x2 To x1
                Form1.BMP.SetPixel(l, j, Color.FromArgb(R, G, B))
                j -= 1
                l -= 1
            Next
        ElseIf x1 < x2 And y1 > y2 And dx = dy Then                     'Case 8
            Dim j = y1
            For i As Integer = x1 To x2
                Form1.BMP.SetPixel(i, j, Color.FromArgb(R, G, B))
                j -= 1
            Next
        End If
    End Sub
    Public Sub DDA(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, R As Integer, G As Integer, B As Integer)
        Dim dx = Math.Abs(x2 - x1), dy = Math.Abs(y2 - y1)
        Dim m As Single
        case1_8(x1, y1, x2, y2, R, G, B)
        If dx > dy Then
            m = dy / dx
            Dim j As Single = y1
            If x1 < x2 And y1 < y2 Then         'Case 9
                For i As Integer = x1 To x2
                    Form1.BMP.SetPixel(i, Math.Round(j), Color.FromArgb(R, G, B))
                    j += m
                Next
            ElseIf x1 > x2 And y1 < y2 Then     'Case 12
                Dim l As Single = x1
                For i As Integer = x2 To x1
                    Form1.BMP.SetPixel(l, Math.Round(j), Color.FromArgb(R, G, B))
                    j += m
                    l -= 1
                Next
            ElseIf x1 > x2 And y1 > y2 Then     'Case 13
                Dim l As Single = x1
                For i As Integer = x2 To x1
                    Form1.BMP.SetPixel(l, Math.Round(j), Color.FromArgb(R, G, B))
                    j -= m
                    l -= 1
                Next
            ElseIf x1 < x2 And y1 > y2 Then     'Case 16
                For i As Integer = x1 To x2
                    Form1.BMP.SetPixel(i, j, Color.FromArgb(R, G, B))
                    j -= m
                Next
            End If
        ElseIf dy > dx Then
            m = dx / dy
            Dim i As Single = x1
            If x1 < x2 And y1 < y2 Then         'Case 10
                For j As Integer = y1 To y2
                    Form1.BMP.SetPixel(Math.Round(i), j, Color.FromArgb(R, G, B))
                    i += m
                Next
            ElseIf x1 > x2 And y1 < y2 Then     'Case 11
                For j As Integer = y1 To y2
                    Form1.BMP.SetPixel(Math.Round(i), j, Color.FromArgb(R, G, B))
                    i -= m
                Next
            ElseIf x1 > x2 And y1 > y2 Then     'Case 14
                Dim l As Single = y1
                For j As Integer = y2 To y1
                    Form1.BMP.SetPixel(Math.Round(i), l, Color.FromArgb(R, G, B))
                    i -= m
                    l -= 1
                Next
            ElseIf x1 < x2 And y1 > y2 Then     'Case 15
                Dim l As Single = y1
                For j As Integer = y2 To y1
                    Form1.BMP.SetPixel(Math.Round(i), l, Color.FromArgb(R, G, B))
                    i += m
                    l -= 1
                Next
            End If
        End If
        Form1.PictureBox1.Image = Form1.BMP
    End Sub
    Public Sub MidPoint(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, R As Integer, G As Integer, B As Integer)

    End Sub
    Sub Clear()
        For i As Integer = 0 To Form1.BMP.Width - 1
            For j As Integer = 0 To Form1.BMP.Height - 1
                Form1.BMP.SetPixel(i, j, Color.White)
            Next
        Next
        Form1.PictureBox1.Image = Form1.BMP
    End Sub
End Module