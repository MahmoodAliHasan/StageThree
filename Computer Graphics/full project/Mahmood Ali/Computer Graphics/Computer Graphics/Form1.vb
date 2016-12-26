
Imports System.Threading
Imports MaterialSkin
Public Class Form1

    Private P1, P2 As Point
    Private graph As MyGraphics
    Private algorthomeSelected As Integer = 3

    Private list As New List(Of Point)
    Private Sub Pic_Drawn_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic_Drawn.MouseDown
        P1 = e.Location
        Console.WriteLine(P1.ToString())


        If (algorthomeSelected = 6) Then
            list.Add(P1)
            Dim graph As Graphics = Pic_Drawn.CreateGraphics()
            graph.FillRectangle(Brushes.Green, P1.X, P1.Y, 2, 2)
        End If


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
                graph.DrawLine(P1, P2)
            Case 4
                Dim len = Math.Max(Math.Abs(P2.X - P1.X), Math.Abs(P2.Y - P1.Y))
                graph.BresenhamCircule(len, P1.X, P1.Y)

            Case 5
                Dim lenX = Math.Abs(P2.X - P1.X)
                Dim lenY = Math.Abs(P2.Y - P1.Y)
                graph.DrawEllipse(P1.X, P1.Y, lenX, lenY, Brushes.Green)


        End Select




    End Sub


#Region "Line Alogrthom"



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





    Private Sub DirectLineToolStripMenuItem_Click(sender As Object, e As EventArgs)
        algorthomeSelected = 1
        lblAlgorthemSelected.Text = "Line Diect"
    End Sub

    Private Sub DDAToolStripMenuItem_Click(sender As Object, e As EventArgs)
        algorthomeSelected = 2
        lblAlgorthemSelected.Text = "Algorithm : Line Different Digtal Analysis"
    End Sub

    Private Sub BrasLineToolStripMenuItem_Click(sender As Object, e As EventArgs)
        algorthomeSelected = 3
        lblAlgorthemSelected.Text = "Line Bresenham "
    End Sub
    Private Sub BresenhamCirculeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        '  BresenhamCircule(100, Pic_Drawn.Width / 2, Pic_Drawn.Height / 2)
        algorthomeSelected = 4
        lblAlgorthemSelected.Text = "Algorithm : Circule Bresenham"
    End Sub


    Private Sub Pic_Drawn_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic_Drawn.MouseMove
        lblCurrentLocation.Text = e.Location.X & "," & e.Location.Y & " px"
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim materialSkinManger As MaterialSkinManager = MaterialSkinManager.Instance
        materialSkinManger.AddFormToManage(Me)
        materialSkinManger.ColorScheme = New ColorScheme(Primary.Green600, Primary.Green700, Primary.Green700, Accent.Amber400, TextShade.BLACK)

        lblAlgorthemSelected.Text = "Algorithm Selected : Bresenham Line"


        MainMenuStrip.Renderer = New ToolStripProfessionalRenderer(New MyProfessinalColorTable)

        graph = New MyGraphics(Pic_Drawn)





    End Sub


#Region "Home Wroke"


    Private Sub DrawHome()

        Dim half_Hight As Integer = Pic_Drawn.Height / 2
        Dim half_Width As Integer = Pic_Drawn.Width / 2

        Dim LinePoinDownR As Point = New Point(half_Width - 100, Pic_Drawn.Height - 10)
        Dim LinePointDownL As Point = New Point(half_Width + 100, Pic_Drawn.Height - 10)
        graph.DrawLine(LinePointDownL, LinePoinDownR)

        Dim LinePointUpR As Point = New Point(half_Width - 100, half_Hight)
        Dim LinePointUpL As Point = New Point(half_Width + 100, half_Hight)
        graph.DrawLine(LinePointUpL, LinePointUpR)


        graph.DrawLine(LinePointDownL, LinePointUpL)
        graph.DrawLine(LinePoinDownR, LinePointUpR)

        Dim topPoint As Point = New Point(half_Width, half_Hight - 100)

        graph.DrawLine(LinePointUpR, topPoint)
        graph.DrawLine(LinePointUpL, topPoint)


    End Sub
    Private Sub DrawDiamond()
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
    Private Sub DrawFan()
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

    Private Sub DrawTree()


        Dim Xc, Yc, TRH_TRW As Integer
        Xc = Pic_Drawn.Width / 2
        Yc = Pic_Drawn.Height - 50
        TRH_TRW = 100

        For i = 0 To 2

            Dim centerPoint As Point = New Point(Xc, Yc)

            Dim leftPoint As New Point(Xc - TRH_TRW, Yc)
            Dim rightPoint As New Point(Xc + TRH_TRW, Yc)
            Dim topPoint As New Point(Xc, Yc - TRH_TRW)


            graph.DrawLine(leftPoint, rightPoint)
            graph.DrawLine(leftPoint, topPoint)
            graph.DrawLine(rightPoint, topPoint)

            graph.DrawLine(New Point(Xc + 15, Yc), New Point(Xc + 15, Yc + 15))
            graph.DrawLine(New Point(Xc - 15, Yc), New Point(Xc - 15, Yc + 15))


            Yc -= TRH_TRW
            TRH_TRW -= 20

        Next


    End Sub


    Private Sub DrawFrog()

        Dim Xc As Integer = Pic_Drawn.Width / 2
        Dim Yc As Integer = Pic_Drawn.Height / 2

        graph.DrawEllipse(Xc, Yc, 200, 160, Brushes.LightGreen)

        'الوجنات
        graph.DrawEllipse(Xc + 90, Yc + 60, 20, 20, Brushes.Red)
        graph.DrawEllipse(Xc - 90, Yc + 60, 20, 20, Brushes.Red)
        'العيون
        graph.DrawEllipse(Xc + 70, Yc - 150, 50, 50, Brushes.White)
        graph.DrawEllipse(Xc - 70, Yc - 150, 50, 50, Brushes.White)
        'البؤبؤ
        graph.DrawEllipse(Xc + 60, Yc - 140, 20, 20, Brushes.Blue)
        graph.DrawEllipse(Xc - 60, Yc - 140, 20, 20, Brushes.Blue)
        'الفم
        graph.DrawEllipse(Xc, Yc + 100, 20, 30, Brushes.LightPink)
        graph.DrawLine(New Point(Xc + 5, Yc + 75), New Point(Xc + 5, Yc + 135))



    End Sub

    Private Sub DrawSmile()
        Dim Xc As Integer = Pic_Drawn.Width / 2
        Dim Yc As Integer = Pic_Drawn.Height / 2

        graph.BresenhamCircule(100, Xc, Yc)

        graph.BresenhamCircule(10, Xc + 50, Yc - 15)
        graph.BresenhamCircule(10, Xc - 50, Yc - 15)

        graph.DrawLine(New Point(Xc - 40, Yc + 50), New Point(Xc + 40, Yc + 50))

    End Sub

    Private Sub DrawFrogSystem()
        Dim graph As Graphics = Pic_Drawn.CreateGraphics()

        Dim Xc As Integer = Pic_Drawn.Width / 2
        Dim Yc As Integer = Pic_Drawn.Height / 2

        graph.FillEllipse(Brushes.Green, Xc - 50, Yc - 50, 100, 100)




    End Sub

#End Region


    Private Sub HouseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HouseToolStripMenuItem1.Click
        DrawHome()
    End Sub

    Private Sub DiamondToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiamondToolStripMenuItem.Click
        DrawDiamond()
    End Sub

    Private Sub FanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FanToolStripMenuItem.Click
        DrawFan()
    End Sub

    Private Sub TreeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TreeToolStripMenuItem1.Click
        DrawTree()
    End Sub

    Private Sub DirectLineToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DirectLineToolStripMenuItem1.Click
        algorthomeSelected = 1
        lblAlgorthemSelected.Text = "Algorithm Selected : Direct Line"
    End Sub

    Private Sub DifferentDigitalLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DifferentDigitalLineToolStripMenuItem.Click
        algorthomeSelected = 2
        lblAlgorthemSelected.Text = "Algorithm Selected : Different Digital Line"
    End Sub

    Private Sub BresenhamLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BresenhamLineToolStripMenuItem.Click

        algorthomeSelected = 3
        lblAlgorthemSelected.Text = "Algorithm Selected : Bresenham Line"
    End Sub

    Private Sub EllipseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EllipseToolStripMenuItem.Click
        algorthomeSelected = 5
        lblAlgorthemSelected.Text = "Algorithm Selected : Bresenham Ellipse"
        'DrawFrogSystem()

    End Sub



    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        DrawFrog()
        '  DrawSmile()
        'DrawFrogSystem()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        DrawSmile()
    End Sub

    Private Sub QuizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuizToolStripMenuItem.Click

        Dim Xc, Yc, width, height, bottom As Integer


        Xc = Pic_Drawn.Width / 2
        Yc = Pic_Drawn.Height / 2

        bottom = Pic_Drawn.Height - 50
        For i = 1 To 5


            Dim topPoint As New Point(Xc, Yc - height)

            Dim leftPoint As New Point(Xc - width, bottom)
            Dim righPoint As New Point(Xc + height, bottom)

            graph.DrawLine(leftPoint, righPoint)
            graph.DrawLine(leftPoint, topPoint)
            graph.DrawLine(righPoint, topPoint)

            width += 50
            height += 50

        Next




    End Sub

    Private Sub CustomPolygonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomPolygonToolStripMenuItem.Click

        algorthomeSelected = 6
        lblAlgorthemSelected.Text = "Algorithm Selected : Custom Polygon"

        If (list.Count = 0) Then
            Exit Sub
        End If


        Dim i
        For i = 0 To list.Count - 2
            graph.DrawLine(list(i), list(i + 1))
        Next
        graph.DrawLine(list(i), list(0))
        list.Clear()

    End Sub



    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Pic_Drawn.Image = Nothing
    End Sub

    Private Sub Circle_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Circle_ToolStripMenuItem.Click
        algorthomeSelected = 4
        lblAlgorthemSelected.Text = "Algorithm Selected : Bresenham Circle"
    End Sub

    Private Sub Elllipse_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Elllipse_ToolStripMenuItem.Click
        algorthomeSelected = 5
        lblAlgorthemSelected.Text = "Algorithm Selected : Bresenham Ellipse"
    End Sub

    Private Sub QuizToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuizToolStripMenuItem1.Click


        ' Drawing by Ali Hasan

        Dim Xc, Yc, W_H As Integer

        W_H = 50

        Xc = Pic_Drawn.Width / 2
        Yc = Pic_Drawn.Height - 50

        For i = 0 To 4

            graph.DrawLine(Xc + W_H, Yc, Xc - W_H, Yc)
            graph.DrawLine(Xc + W_H, Yc, Xc, Yc - W_H)
            graph.DrawLine(Xc - W_H, Yc, Xc, Yc - W_H)

            W_H += 50
            Xc += 30

        Next




    End Sub

    Private Sub ExamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamToolStripMenuItem.Click
        MsgBox("الله يستر ")
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        End
    End Sub








End Class
