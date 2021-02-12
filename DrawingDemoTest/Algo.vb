Module Algo
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
        Dim dx = x2 - x1, dy = y2 - y1, x As Single = x1, y As Single = y1
        Dim x_inc, y_inc
        Dim m As Single

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
        Form1.BMP.SetPixel(x, Math.Round(y), Color.FromArgb(R, G, B))
        If Math.Abs(dx) >= Math.Abs(dy) Then
            m = dy / dx
            If x1 > x2 And (y1 <= y2 Or y1 >= y2) Then
                m = -m
            End If
            While x < x2 Or x > x2
                x += x_inc
                y += m
                Form1.BMP.SetPixel(x, Math.Round(y), Color.FromArgb(R, G, B))
            End While
        ElseIf Math.Abs(dx) <= Math.Abs(dy) Then
            m = dx / dy
            If y1 > y2 And (x1 <= x2 Or x1 >= x2) Then
                m = -m
            End If
            While y < y2 Or y > y2
                y += y_inc
                x += m
                Form1.BMP.SetPixel(Math.Round(x), y, Color.FromArgb(R, G, B))
            End While
        End If
        Form1.PictureBox1.Image = Form1.BMP
    End Sub
    Public Sub MidPoint(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, R As Integer, G As Integer, B As Integer)
        Dim dx As Integer, dy As Integer, x As Integer, y As Integer
        Dim p As Integer, dR, dUR, d, dL, dUL, dU

        dx = x2 - x1
        dy = y2 - y1
        x = x1
        y = y1
        If Math.Abs(dx) >= Math.Abs(dy) Then
            If x1 < x2 And y1 <= y2 Then         'Case 9 MidPoint
                dR = 2 * dy
                dUR = 2 * (dy - dx)
                d = 2 * dy - dx
                Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                While x < x2
                    If d > 0 Then
                        x += 1
                        y += 1
                        d += dUR
                    Else
                        x += 1
                        d += dR
                    End If
                    Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                End While
            ElseIf x1 > x2 And y1 < y2 Then         'Case 12 Midpoint
                dL = -2 * dy
                dUL = -2 * (dy + dx)
                d = (-2 * dy) + dx
                Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                While x > x2
                    If d < 0 Then
                        x -= 1
                        y += 1
                        d += dUL
                    Else
                        x -= 1
                        d += dL
                    End If
                    Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                End While
            ElseIf x1 > x2 And y1 >= y2 Then         'Case 13 Midpoint
                dL = -2 * dy
                dUL = -2 * (dy - dx)
                d = (-2 * dy) + dx
                Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                While x > x2
                    If d > 0 Then
                        x -= 1
                        y -= 1
                        d += dUL
                    Else
                        x -= 1
                        d += dL
                    End If
                    Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                End While
            ElseIf x1 < x2 And y1 > y2 Then         'Case 16 Midpoint
                dR = 2 * dy
                dUR = 2 * (dy + dx)
                d = 2 * dy + dx
                Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                While x < x2
                    If d < 0 Then
                        x += 1
                        y -= 1
                        d += dUR
                    Else
                        x += 1
                        d += dR
                    End If
                    Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                End While
            End If
        ElseIf Math.Abs(dy) > Math.Abs(dx) Then
            If x1 <= x2 And y1 < y2 Then             'Case 10 Midpoint
                dU = 2 * -dx
                dUR = 2 * (dy - dx)
                d = dy - 2 * dx
                Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                While y < y2
                    If d < 0 Then
                        x += 1
                        y += 1
                        d += dUR
                    Else
                        y += 1
                        d += dU
                    End If
                    Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                End While
            ElseIf x1 > x2 And y1 < y2 Then         'Case 11 Midpoint
                dU = 2 * -dx
                dUL = -2 * (dy + dx)
                d = -dy - 2 * dx
                Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                While y < y2
                    If d > 0 Then
                        x -= 1
                        y += 1
                        d += dUL
                    Else
                        y += 1
                        d += dU
                    End If
                    Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                End While
            ElseIf x1 >= x2 And y1 > y2 Then         'Case 14 Midpoint
                dU = 2 * dx
                dUL = 2 * (-dy + dx)
                d = -dy + 2 * dx
                Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                While y > y2
                    If d < 0 Then
                        x -= 1
                        y -= 1
                        d += dUL
                    Else
                        y -= 1
                        d += dU
                    End If
                    Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                End While
            ElseIf x1 < x2 And y1 > y2 Then         'Case 15 Midpoint
                dU = 2 * dx
                dUR = 2 * (dy + dx)
                d = dy + 2 * dx
                Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                While y > y2
                    If d > 0 Then
                        x += 1
                        y -= 1
                        d += dUR
                    Else
                        y -= 1
                        d += dU
                    End If
                    Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                End While
            End If
        End If
        Form1.PictureBox1.Image = Form1.BMP
    End Sub
    Public Sub Test(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, R As Integer, G As Integer, B As Integer)
        Dim dx As Integer, dy As Integer, x As Integer, y As Integer
        Dim dR, dUR, d
        Dim t_dy, t_dx, x_inc, y_inc, i, dif

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
        Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
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
            Form1.BMP.SetPixel(x, y + 1, Color.FromArgb(R, G, B))
            Form1.BMP.SetPixel(x, y + 2, Color.FromArgb(R, G, B))
            Form1.BMP.SetPixel(x, y + 3, Color.FromArgb(R, G, B))
            Form1.BMP.SetPixel(x, y + 4, Color.FromArgb(R, G, B))
            While x < x2 Or x > x2
                If d > 0 Then
                    If Form1.chkbxPattern.Checked Then
                        If x < x2 Then                          'Dotted for x1 < x2
                            If x_inc = 1 Then
                                x_inc = 2
                                d += dUR
                                y += y_inc
                            ElseIf x_inc = 2 And dif = 0 Then
                                x_inc = 2
                                dif += 1
                                d += dUR
                                y += y_inc
                            ElseIf x_inc = 2 And dif = 1 Then
                                x_inc = 1
                                dif -= 1
                            End If
                            x += x_inc
                            If x >= x2 Then
                                x -= 1
                            End If
                        End If
                        If x > x2 Then                      'Dotted for x1 > x2
                            If x_inc = -1 Then
                                x_inc = -2
                                d += dUR
                                y += y_inc
                            ElseIf x_inc = -2 And dif = 0 Then
                                x_inc = -2
                                dif += 1
                                d += dUR
                                y += y_inc
                            ElseIf x_inc = -2 And dif = 1 Then
                                x_inc = -1
                                dif -= 1
                            End If
                            x += x_inc
                            If x <= x2 Then
                                x += 1
                            End If
                        End If
                        If d > 0 Then
                            d += dUR
                            y += y_inc
                        Else
                            d += dR
                        End If
                    Else
                        x += x_inc
                        y += y_inc
                        d += dUR
                    End If
                Else
                    If Form1.chkbxPattern.Checked Then
                        If x < x2 Then
                            If x_inc = 1 Then
                                x_inc = 2
                                d += dR

                            ElseIf x_inc = 2 And dif = 0 Then
                                x_inc = 2
                                dif += 1
                                d += dR
                            ElseIf x_inc = 2 And dif = 1 Then
                                x_inc = 1
                                dif -= 1
                            End If
                            x += x_inc
                            If x >= x2 Then
                                x -= 1
                            End If
                        End If
                        If x > x2 Then                      'Dotted for x1 > x2
                            If x_inc = -1 Then
                                x_inc = -2
                                d += dUR
                                y += y_inc
                            ElseIf x_inc = -2 And dif = 0 Then
                                x_inc = -2
                                dif += 1
                                d += dUR
                                y += y_inc
                            ElseIf x_inc = -2 And dif = 1 Then
                                x_inc = -1
                                dif -= 1
                            End If
                            x += x_inc
                            If x <= x2 Then
                                x += 1
                            End If
                        End If
                        If d > 0 Then
                            d += dUR
                            y += y_inc
                        Else
                            d += dR
                        End If

                    Else
                        x += x_inc
                        d += dR
                    End If
                End If
                Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
                Form1.BMP.SetPixel(x, y + 1, Color.FromArgb(R, G, B))
                Form1.BMP.SetPixel(x, y + 2, Color.FromArgb(R, G, B))
                Form1.BMP.SetPixel(x, y + 3, Color.FromArgb(R, G, B))
                Form1.BMP.SetPixel(x, y + 4, Color.FromArgb(R, G, B))
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
                Form1.BMP.SetPixel(x, y, Color.FromArgb(R, G, B))
            End While
        End If
            Form1.PictureBox1.Image = Form1.BMP
    End Sub

    Sub Clear()
        For i As Integer = 0 To Form1.BMP.Width - 1
            For j As Integer = 0 To Form1.BMP.Height - 1
                Form1.BMP.SetPixel(i, j, Color.Transparent)
            Next
        Next
        Form1.PictureBox1.Image = Form1.BMP
    End Sub
End Module
