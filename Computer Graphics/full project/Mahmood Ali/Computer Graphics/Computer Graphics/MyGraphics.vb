Public Class MyGraphics

    Dim graph As Graphics

    Private pic_Drawn As PictureBox
    Public Sub New(pic_Drawn As PictureBox)
        graph = pic_Drawn.CreateGraphics()
        Me.pic_Drawn = pic_Drawn
    End Sub


    Public Sub DrawEllipse(Xc As Integer, Yc As Integer, RX As Integer, RY As Integer)

        ' Dim graph As Graphics = Pic_Drawn.CreateGraphics()
        Dim img As New Bitmap(5, 5)
        img.SetPixel(4, 4, Color.Green)

        ' graph.DrawEllipse(Pens.PaleGreen, Xc, Yc, RX, RY)

        'Dim SystemGraphics As Graphics = pic_Drawn.CreateGraphics()
        'Dim x1, y1 As Single
        'x1 = Xc - RX
        'y1 = Yc - RY

        'SystemGraphics.FillEllipse(Brush, x1, y1, RX * 2, RY * 2)


        Dim Sqrx, Sqry, Dx, Dy, P, X, Y As Single

        Sqrx = RX * RX
        Sqry = RY * RY

        X = 0
        Y = RY

        Dx = 2 * Sqry * X
        Dy = 2 * Sqrx * Y

        P = Sqry - (Sqrx * RY) + (0.25 * Sqrx)

        'Region1 
        Do Until (Dx > Dy)

            graph.DrawImage(img, Xc + X, Yc + Y)
            graph.DrawImage(img, Xc + X, Yc - Y)
            graph.DrawImage(img, Xc - X, Yc - Y)
            graph.DrawImage(img, Xc - X, Yc + Y)
            X += 1
            Dx = Dx + 2 * Sqry

            If (P < 0) Then

                P = P + Dx + Sqry
            Else
                Y -= 1
                Dy = Dy - 2 * Sqrx

                P = P + Dx - Dy + Sqry

            End If
        Loop

        P = Sqry * (X + 0.5) * (X + 0.5) + Sqrx * (Y - 1) * (Y - 1) - Sqrx * Sqry


        'Region 2
        Do Until (Y = 0)

            graph.DrawImage(img, Xc + X, Yc + Y)
            graph.DrawImage(img, Xc + X, Yc - Y)
            graph.DrawImage(img, Xc - X, Yc - Y)
            graph.DrawImage(img, Xc - X, Yc + Y)

            Y -= 1
            Dy = Dy - 2 * Sqrx

            If (P > 0) Then

                P = P + Sqrx - Dy

            Else
                X += 1
                Dx = Dx + 2 * Sqry
                P = P + Sqrx - Dy + Dx

            End If

        Loop


    End Sub

    Public Sub DrawEllipse(Xc As Integer, Yc As Integer, RX As Integer, RY As Integer, ByRef brush As Brush)

        ' Dim graph As Graphics = Pic_Drawn.CreateGraphics()
        Dim img As New Bitmap(5, 5)
        img.SetPixel(4, 4, Color.Green)

        ' graph.DrawEllipse(Pens.PaleGreen, Xc, Yc, RX, RY)

        Dim SystemGraphics As Graphics = pic_Drawn.CreateGraphics()
        Dim x1, y1 As Single
        x1 = Xc - RX
        y1 = Yc - RY

        SystemGraphics.FillEllipse(brush, x1, y1, RX * 2, RY * 2)


        Dim Sqrx, Sqry, Dx, Dy, P, X, Y As Single

        Sqrx = RX * RX
        Sqry = RY * RY

        X = 0
        Y = RY

        Dx = 2 * Sqry * X
        Dy = 2 * Sqrx * Y

        P = Sqry - (Sqrx * RY) + (0.25 * Sqrx)

        'Region1 
        Do Until (Dx > Dy)

            graph.DrawImage(img, Xc + X, Yc + Y)
            graph.DrawImage(img, Xc + X, Yc - Y)
            graph.DrawImage(img, Xc - X, Yc - Y)
            graph.DrawImage(img, Xc - X, Yc + Y)
            X += 1
            Dx = Dx + 2 * Sqry

            If (P < 0) Then

                P = P + Dx + Sqry
            Else
                Y -= 1
                Dy = Dy - 2 * Sqrx

                P = P + Dx - Dy + Sqry

            End If
        Loop

        P = Sqry * (X + 0.5) * (X + 0.5) + Sqrx * (Y - 1) * (Y - 1) - Sqrx * Sqry


        'Region 2
        Do Until (Y = 0)

            graph.DrawImage(img, Xc + X, Yc + Y)
            graph.DrawImage(img, Xc + X, Yc - Y)
            graph.DrawImage(img, Xc - X, Yc - Y)
            graph.DrawImage(img, Xc - X, Yc + Y)

            Y -= 1
            Dy = Dy - 2 * Sqrx

            If (P > 0) Then

                P = P + Sqrx - Dy

            Else
                X += 1
                Dx = Dx + 2 * Sqry
                P = P + Sqrx - Dy + Dx

            End If

        Loop


    End Sub

    Public Sub DrawLine(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)

        Dim Dy, Dx, P, s1, s2, temp, change, x, y

        Dim P1 As New Point(x1, y1)
        Dim P2 As New Point(x2, y2)

        Dy = Math.Abs(p2.Y - p1.Y)
        Dx = Math.Abs(p2.X - p1.X)

        P = 2 * (Dy - Dx)

        s1 = Math.Sign(p2.X - p1.X)
        s2 = Math.Sign(p2.Y - p1.Y)


        Dim Img As New Bitmap(1, 1)
        Img.SetPixel(0, 0, Color.Green)


        If (Dy > Dx) Then
            temp = Dx
            Dx = Dy
            Dy = temp
            change = 1

        Else
            change = 0
        End If


        x = p1.X
        y = p1.Y


        For i = 1 To Dx

            graph.DrawImage(Img, x, y)
            If (P >= 0) Then
                If (change = 1) Then
                    x = x + s1
                Else
                    y = y + s2
                End If

                P = P + 2 * (Dy - Dx)
            Else
                P = P + 2 * Dy
            End If
            If (change = 1) Then
                y = y + s2
            Else
                x = x + s1
            End If
            ' Console.WriteLine(x & "   graph.DrawImage(Img, x, y)
        Next

    End Sub

    Public Sub DrawLine(p1 As Point, p2 As Point)

        Dim Dy, Dx, P, s1, s2, temp, change, x, y

        Dy = Math.Abs(p2.Y - p1.Y)
        Dx = Math.Abs(p2.X - p1.X)

        P = 2 * (Dy - Dx)

        s1 = Math.Sign(p2.X - p1.X)
        s2 = Math.Sign(p2.Y - p1.Y)


        Dim Img As New Bitmap(1, 1)
        Img.SetPixel(0, 0, Color.Green)


        If (Dy > Dx) Then
            temp = Dx
            Dx = Dy
            Dy = temp
            change = 1

        Else
            change = 0
        End If


        x = p1.X
        y = p1.Y


        For i = 1 To Dx

            graph.DrawImage(Img, x, y)
            If (P >= 0) Then
                If (change = 1) Then
                    x = x + s1
                Else
                    y = y + s2
                End If

                P = P + 2 * (Dy - Dx)
            Else
                P = P + 2 * Dy
            End If
            If (change = 1) Then
                y = y + s2
            Else
                x = x + s1
            End If
            ' Console.WriteLine(x & "   graph.DrawImage(Img, x, y)
        Next

    End Sub

    Public Sub BresenhamCircule(ByVal radius As Integer, ByVal Xc As Single, ByVal Yc As Single)
        Dim img1, img2, img3, img4, img5, img6, img7, img8 As New Bitmap(1, 1)

        img1.SetPixel(0, 0, Color.Green)


        Dim x, y, p As Single
        x = 0
        y = radius
        p = 1 - radius

        While (x < y)
            x += 1
            If (p < 0) Then

                p = p + 2 * x + 1
            Else
                y -= 1
                p = p + 2 * (x - y) + 1

            End If

            graph.DrawImage(img1, Xc + y, Yc - x)
            graph.DrawImage(img1, Xc + x, Yc - y)
            graph.DrawImage(img1, Xc - x, Yc - y)
            graph.DrawImage(img1, Xc - y, Yc - x)

            graph.DrawImage(img1, Xc - y, Yc + x)
            graph.DrawImage(img1, Xc - x, Yc + y)
            graph.DrawImage(img1, Xc + x, Yc + y)
            graph.DrawImage(img1, Xc + y, Yc + x)


        End While


    End Sub

End Class
