Module Algo
    Public Sub DDA(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, R As Integer, G As Integer, B As Integer, LL As Integer, BL As Integer, LW As Integer)
        Dim dx = x2 - x1, dy = y2 - y1, x As Single = x1, y As Single = y1
        Dim x_inc, y_inc
        Dim m As Single
        Dim i As Integer = 1, j As Integer = 1
        Dim total_Line_Length = LL + BL

        If x1 < x2 Then
            x_inc = 1
        ElseIf x1 > x2 Then
            x_inc = -1
        End If
        If y1 < y2 Then
            y_inc = 1
        ElseIf y1 > y2 Then
            y_inc = -1
        End If
        DrawingLine.BMP.SetPixel(x, Math.Round(y), Color.FromArgb(R, G, B))
        While j < LW                                                                '1st set for weight line
            If Math.Abs(dx) >= Math.Abs(dy) Then
                DrawingLine.BMP.SetPixel(x, Math.Round(y + j), Color.FromArgb(R, G, B))
            ElseIf Math.Abs(dy) >= Math.Abs(dx) Then
                DrawingLine.BMP.SetPixel(Math.Round(x + j), y, Color.FromArgb(R, G, B))
            End If

            j += 1
        End While
        j = 1
        If Math.Abs(dx) >= Math.Abs(dy) Then
            m = dy / dx
            If x1 > x2 And (y1 <= y2 Or y1 >= y2) Then                              'Case 12 and 13
                m = -m
            End If
            While x < x2 Or x > x2
                x += x_inc
                y += m
                If LL > 0 And BL > 0 Then                                           'Dotted Algorithm
                    If i < LL Then
                        DrawingLine.BMP.SetPixel(x, Math.Round(y), Color.FromArgb(R, G, B))
                        While j < LW                                                'Dotted + Weight Algorithm
                            DrawingLine.BMP.SetPixel(x, Math.Round(y + j), Color.FromArgb(R, G, B))
                            j += 1
                        End While
                        j = 1
                    ElseIf i = total_Line_Length Then
                        i = -1
                    End If
                    i += 1
                Else
                    DrawingLine.BMP.SetPixel(x, Math.Round(y), Color.FromArgb(R, G, B))
                    While j < LW                                                    'Weight Algorithm
                        DrawingLine.BMP.SetPixel(x, Math.Round(y + j), Color.FromArgb(R, G, B))
                        j += 1
                    End While
                    j = 1
                End If
            End While
        ElseIf Math.Abs(dx) <= Math.Abs(dy) Then
            m = dx / dy
            If y1 > y2 And (x1 <= x2 Or x1 >= x2) Then                              'Case 14 and 15
                m = -m
            End If
            While y < y2 Or y > y2
                y += y_inc
                x += m
                If LL > 0 And BL > 0 Then                                           'Dotted Algorithm
                    If i < LL Then
                        DrawingLine.BMP.SetPixel(Math.Round(x), y, Color.FromArgb(R, G, B))
                        While j < LW                                                'Dotted + Weight Algorithm
                            DrawingLine.BMP.SetPixel(Math.Round(x + j), y, Color.FromArgb(R, G, B))
                            j += 1
                        End While
                        j = 1
                    ElseIf i = total_Line_Length Then
                        i = -1
                    End If
                    i += 1
                Else
                    DrawingLine.BMP.SetPixel(Math.Round(x), y, Color.FromArgb(R, G, B))
                    While j < LW                                                    'Weight Algorithm
                        DrawingLine.BMP.SetPixel(Math.Round(x + j), y, Color.FromArgb(R, G, B))
                        j += 1
                    End While
                    j = 1
                End If
            End While
        End If
        DrawingLine.BMP = DrawingLine.PictureBox1.Image
        DrawingLine.PictureBox1.Image = DrawingLine.BMP
    End Sub
    Public Sub Midpoint(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, R As Integer, G As Integer, B As Integer, LL As Integer, BL As Integer, LW As Integer)
        Dim dx As Integer, dy As Integer, x As Integer, y As Integer
        Dim dR, dUR, d
        Dim t_dy, t_dx, x_inc, y_inc
        Dim i As Integer = 1, j As Integer = 1
        Dim total_Line_Length = LL + BL

        dx = x2 - x1
        dy = y2 - y1
        x = x1
        y = y1

        If x1 < x2 Then
            t_dy = dy
            x_inc = 1
        ElseIf x1 > x2 Then
            t_dy = -dy
            x_inc = -1
        End If
        If y1 < y2 Then
            t_dx = dx
            y_inc = 1
        ElseIf y1 > y2 Then
            t_dx = -dx
            y_inc = -1
        End If
        DrawingLine.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
        While j < LW                                                                '1st set for weight line
            If Math.Abs(dx) >= Math.Abs(dy) Then
                DrawingLine.BMP.SetPixel(x, y + j, Color.FromArgb(R, G, B))
            ElseIf Math.Abs(dy) >= Math.Abs(dx) Then
                DrawingLine.BMP.SetPixel(x + j, y, Color.FromArgb(R, G, B))
            End If

            j += 1
        End While
        j = 1

        If Math.Abs(dx) >= Math.Abs(dy) Then
            dR = 2 * t_dy
            dUR = 2 * (t_dy - t_dx)
            If dR < 0 Then
                dR = -dR
            End If
            If dUR > 0 Then
                dUR = -dUR
            End If
            d = 2 * t_dy - t_dx
            While x < x2 Or x > x2
                If d > 0 Then
                    x += x_inc
                    y += y_inc
                    d += dUR
                Else
                    x += x_inc
                    d += dR
                End If
                If LL > 0 And BL > 0 Then                                           'Dotted Algorithm
                    If i < LL Then
                        DrawingLine.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                        While j < LW                                                'Dotted + Weight Algorithm
                            DrawingLine.BMP.SetPixel(x, y + j, Color.FromArgb(R, G, B))
                            j += 1
                        End While
                        j = 1
                    ElseIf i = total_Line_Length Then
                        i = -1
                    End If
                    i += 1
                Else
                    DrawingLine.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))               'Normal Line
                    While j < LW                                                    'Weight Algorithm
                        DrawingLine.BMP.SetPixel(x, y + j, Color.FromArgb(R, G, B))
                        j += 1
                    End While
                    j = 1
                End If
            End While
        ElseIf Math.Abs(dy) > Math.Abs(dx) Then
            dR = 2 * -t_dx
            dUR = 2 * (t_dy - t_dx)
            If dR > 0 Then
                dR = -dR
            End If
            If dUR < 0 Then
                dUR = -dUR
            End If
            d = t_dy - 2 * t_dx
            While y < y2 Or y > y2
                If d < 0 Then
                    x += x_inc
                    y += y_inc
                    d += dUR
                Else
                    y += y_inc
                    d += dR
                End If
                If LL > 0 And BL > 0 Then                                           'Dotted Algorithm
                    If i < LL Then
                        DrawingLine.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                        While j < LW                                                'Dotted + Weight Algorithm
                            DrawingLine.BMP.SetPixel(x + j, y, Color.FromArgb(R, G, B))
                            j += 1
                        End While
                        j = 1
                    ElseIf i = total_Line_Length Then
                        i = -1
                    End If
                    i += 1
                Else
                    DrawingLine.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))               'Normal Line
                    While j < LW                                                    'Weight Algorithm
                        DrawingLine.BMP.SetPixel(x + j, y, Color.FromArgb(R, G, B))
                        j += 1
                    End While
                    j = 1
                End If
            End While
        End If
        DrawingLine.BMP = DrawingLine.PictureBox1.Image
        DrawingLine.PictureBox1.Image = DrawingLine.BMP
    End Sub

    Sub Clear()
        For i As Integer = 0 To DrawingLine.BMP.Width - 1
            For j As Integer = 0 To DrawingLine.BMP.Height - 1
                DrawingLine.BMP.SetPixel(i, j, Color.Transparent)
            Next
        Next
        DrawingLine.PictureBox1.Image = DrawingLine.BMP
    End Sub
End Module
