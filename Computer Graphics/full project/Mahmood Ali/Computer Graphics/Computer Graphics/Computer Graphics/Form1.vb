Public Class Form1

    Private P1, P2 As Point

    Private algorthomeSelected As Integer
    Private Sub Pic_Drawn_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic_Drawn.MouseDown
        P1 = e.Location
        Console.WriteLine(P1.ToString())
    End Sub

    Private Sub Pic_Drawn_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic_Drawn.MouseUp
        P2 = e.Location
        Console.WriteLine(P2.ToString())

        Select Case algorthomeSelected
            Case 1
                DrawLineDirect(P1, P2)
            Case 2
                DDA_LineAlgorithm(P1, P2)
            Case 3
                Bresenham_LineAlgorithms(P1, P2)
            Case 4
                Dim len = Math.Max(Math.Abs(P2.X - P1.X), Math.Abs(P2.Y - P1.Y))
                BresenhamCircule(len, P1.X, P1.Y)

        End Select




    End Sub


#Region "Line Alogrthom"

    Private Sub Bresenham_LineAlgorithms(p1 As Point, p2 As Point)

        Dim graph As Graphics = Pic_Drawn.CreateGraphics()



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

    Private Sub DDA_LineAlgorithm(p1 As Point, p2 As Point)

        Dim graph As Graphics = Pic_Drawn.CreateGraphics()



        Dim length, Dy, Dx, Xinc, Yinc, x, y

        Dy = p2.Y - p1.Y
        Dx = p2.X - p1.X

        length = Math.Max(Math.Abs(Dy), Math.Abs(Dx))

        Xinc = Dx / length
        Yinc = Dy / length

        ' MsgBox(Xinc & " " & Yinc)

        Dim Img As New Bitmap(1, 1)
        Img.SetPixel(0, 0, Color.Green)


        ' Dim x, y As Double
        x = p1.X + 0.5
        y = p1.Y + 0.5

        For i = 1 To length


            graph.DrawImage(Img, Convert.ToInt32(x), Convert.ToInt32(y))
            x += Xinc
            y += Yinc
            ' Threading.Thread.Sleep(2)



        Next

    End Sub


    Private Sub DrawLineDirect(Point1 As Point, Point2 As Point)

        Dim i, Dx, Dy, B, m, New_Y, New_X As Integer


        Dx = Point2.X - Point1.X
        Dy = Point2.Y - Point1.Y

        If (Dx = 0) Then
            m = 0
        Else
            m = Dy / Dx
        End If

        Dim g As Graphics = Pic_Drawn.CreateGraphics()
        Dim Img As New Bitmap(1, 1)
        Img.SetPixel(0, 0, Color.White)


        B = Point1.Y - (m * Point1.X)

        If (Dy > Dx) Then



            For i = Point1.X + 1 To Point2.X

                New_Y = B + m * i
                g.DrawImage(Img, i, Math.Round(New_Y))

            Next

            Console.WriteLine("First Dy>DX")
        Else

            If (m = 0) Then
                m = 1
            End If
            For i = Point1.Y + 1 To Point2.Y

                New_X = (i - B) / m

                g.DrawImage(Img, Math.Round(New_X), i)

            Next
            Console.WriteLine("Second  DX>DY")
        End If



    End Sub


#End Region



    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Pic_Drawn.Image = Nothing
    End Sub

    Private Sub DirectLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectLineToolStripMenuItem.Click
        algorthomeSelected = 1
    End Sub

    Private Sub DDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DDAToolStripMenuItem.Click
        algorthomeSelected = 2
    End Sub

    Private Sub BrasLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrasLineToolStripMenuItem.Click
        algorthomeSelected = 3
    End Sub
    Private Sub BresenhamCirculeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BresenhamCirculeToolStripMenuItem.Click
        '  BresenhamCircule(100, Pic_Drawn.Width / 2, Pic_Drawn.Height / 2)
        algorthomeSelected = 4
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub




    Private Sub Pic_Drawn_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic_Drawn.MouseMove
        lblCurrentLocation.Text = e.Location.X & "," & e.Location.Y & " px"
    End Sub



    Private Sub BresenhamCircule(ByVal radius As Integer, ByVal Xc As Single, ByVal Yc As Single)
        Dim graph As Graphics = Pic_Drawn.CreateGraphics
        Dim img1, img2, img3, img4, img5, img6, img7, img8 As New Bitmap(1, 1)

        img1.SetPixel(0, 0, Color.Green)
        img2.SetPixel(0, 0, Color.Yellow)
        img3.SetPixel(0, 0, Color.Red)
        img4.SetPixel(0, 0, Color.Orange)
        img5.SetPixel(0, 0, Color.Blue)
        img6.SetPixel(0, 0, Color.AliceBlue)
        img7.SetPixel(0, 0, Color.DarkGreen)
        img8.SetPixel(0, 0, Color.LawnGreen)

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
            graph.DrawImage(img2, Xc + x, Yc - y)
            graph.DrawImage(img3, Xc - x, Yc - y)
            graph.DrawImage(img4, Xc - y, Yc - x)

            graph.DrawImage(img5, Xc - y, Yc + x)
            graph.DrawImage(img6, Xc - x, Yc + y)
            graph.DrawImage(img7, Xc + x, Yc + y)
            graph.DrawImage(img8, Xc + y, Yc + x)


        End While


    End Sub


#Region "Home Wroke"

    Private Sub HouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HouseToolStripMenuItem.Click
        ' Pic_Drawn.Image = Nothing

        Dim half_Hight As Integer = Pic_Drawn.Height / 2
        Dim half_Width As Integer = Pic_Drawn.Width / 2

        Dim LinePoinDownR As Point = New Point(half_Width - 100, Pic_Drawn.Height - 10)
        Dim LinePointDownL As Point = New Point(half_Width + 100, Pic_Drawn.Height - 10)
        Bresenham_LineAlgorithms(LinePointDownL, LinePoinDownR)

        Dim LinePointUpR As Point = New Point(half_Width - 100, half_Hight)
        Dim LinePointUpL As Point = New Point(half_Width + 100, half_Hight)
        Bresenham_LineAlgorithms(LinePointUpL, LinePointUpR)


        Bresenham_LineAlgorithms(LinePointDownL, LinePointUpL)
        Bresenham_LineAlgorithms(LinePoinDownR, LinePointUpR)

        Dim topPoint As Point = New Point(half_Width, half_Hight - 100)

        Bresenham_LineAlgorithms(LinePointUpR, topPoint)
        Bresenham_LineAlgorithms(LinePointUpL, topPoint)




    End Sub
    Private Sub DrawDimonsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiomonsToolStripMenuItem.Click
        'Pic_Drawn.Image = Nothing

        Dim half_Hight As Integer = Pic_Drawn.Height / 2
        Dim half_Width As Integer = Pic_Drawn.Width / 2


        Dim startPiont As Point = New Point(half_Width, Pic_Drawn.Height - 10)
        Dim medilLine_R As Point = New Point(half_Width + 150, half_Hight)
        DDA_LineAlgorithm(startPiont, medilLine_R)

        Dim medilLine_L As Point = New Point(half_Width - 150, half_Hight)
        DDA_LineAlgorithm(startPiont, medilLine_L)

        Dim smailLine_R As Point = New Point(half_Width + 115, half_Hight + 20)
        DDA_LineAlgorithm(startPiont, smailLine_R)

        Dim smailLine_L As Point = New Point(half_Width - 115, half_Hight + 20)
        DDA_LineAlgorithm(startPiont, smailLine_L)

        Dim longLine_R As Point = New Point(half_Width + 100, half_Hight - 40)
        DDA_LineAlgorithm(startPiont, longLine_R)

        Dim longLine_L As Point = New Point(half_Width - 100, half_Hight - 40)
        DDA_LineAlgorithm(startPiont, longLine_L)


        DDA_LineAlgorithm(medilLine_L, longLine_L)
        DDA_LineAlgorithm(longLine_R, longLine_L)
        DDA_LineAlgorithm(medilLine_R, longLine_R)


        DDA_LineAlgorithm(smailLine_L, medilLine_L)
        DDA_LineAlgorithm(smailLine_R, medilLine_R)
        DDA_LineAlgorithm(smailLine_R, smailLine_L)

    End Sub

    Private Sub Question1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Question1ToolStripMenuItem.Click
        Exam_Question1()
    End Sub

    Private Sub Exam_Question1()
        Dim graph As Graphics = Pic_Drawn.CreateGraphics
        Dim img1, img2, img3, img4 As New Bitmap(4, 4)

        img1.SetPixel(2, 2, Color.Yellow)
        img2.SetPixel(2, 2, Color.Green)
        img3.SetPixel(2, 2, Color.Blue)
        img4.SetPixel(2, 2, Color.Red)


        Dim x, y, p As Single

        Dim radius, Xc, Yc As Integer

        Xc = Pic_Drawn.Width / 2
        Yc = Pic_Drawn.Height / 2
        radius = 30



        For i = 1 To 3


            p = 2 * (1 - radius)
            x = 0
            y = radius

            While (x < y)
                x += 1
                If (p < 0) Then
                    p = p + 2 * x + 1
                Else
                    y -= 1
                    p = p + 2 * (x - y) + 1

                End If

                graph.DrawImage(img1, Xc + y, Yc - x)
                graph.DrawImage(img2, Xc - x, Yc - y)
                graph.DrawImage(img1, Xc - y, Yc + x)
                graph.DrawImage(img2, Xc + x, Yc + y)

            End While

            radius += 15
        Next

        radius = 75
        For i = 1 To 3


            p = 2 * (1 - radius)
            x = 0
            y = radius

            While (x < y)
                x += 1
                If (p < 0) Then
                    p = p + 2 * x + 1
                Else
                    y -= 1
                    p = p + 2 * (x - y) + 1

                End If

                graph.DrawImage(img3, Xc + x, Yc - y)
                graph.DrawImage(img4, Xc - y, Yc - x)
                graph.DrawImage(img3, Xc - x, Yc + y)
                graph.DrawImage(img4, Xc + y, Yc + x)

            End While

            radius += 15
        Next



    End Sub

    Private Sub Question2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Question2ToolStripMenuItem.Click
        Exam_Question2()
    End Sub

    Private Sub Exam_Question2()
        Dim graph As Graphics = Pic_Drawn.CreateGraphics()
        Dim img As New Bitmap(1, 1)
        img.SetPixel(0, 0, Color.Green)


        Dim Xc, Yc, TRH As Integer
        Xc = Pic_Drawn.Width / 2
        Yc = Pic_Drawn.Height - 50
        TRH = 100

        For i = 0 To 2

            Dim centerPoint As Point = New Point(Xc, Yc)

            Dim endLine1 As New Point(Xc + TRH, Yc)
            Bresenham_LineAlgorithms(centerPoint, endLine1)

            Dim endLine2 As New Point(Xc, Yc - TRH)
            Bresenham_LineAlgorithms(endLine1, endLine2)

            Dim startSmallLine As New Point(Xc + 10, Yc)
            Dim endSmallLine As New Point(Xc + 10, Yc + 15)
            Bresenham_LineAlgorithms(startSmallLine, endSmallLine)


            Dim endLineL1 As New Point(Xc - TRH, Yc)
            Bresenham_LineAlgorithms(centerPoint, endLineL1)

            Dim endLineL2 As New Point(Xc, Yc - TRH)
            Bresenham_LineAlgorithms(endLineL1, endLineL2)

            Dim startSmallLineL As New Point(Xc - 10, Yc)
            Dim endSmallLineL As New Point(Xc - 10, Yc + 15)
            Bresenham_LineAlgorithms(startSmallLineL, endSmallLineL)

            Yc -= TRH
            TRH -= 20

        Next




    End Sub



#End Region

End Class
