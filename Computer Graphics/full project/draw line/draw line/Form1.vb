Imports System.Threading

Public Class Form1

    Dim x1, x2, y1, y2 As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Labelx.Text = e.Location.X
        Labely.Text = e.Location.Y
    End Sub
    Dim flag As Boolean = True
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If flag = True Then
            TextBoxX1.Text = Labelx.Text
            TextBoxY1.Text = Labely.Text
            flag = False
        ElseIf flag = False Then
            TextBoxX2.Text = Labelx.Text
            TextBoxY2.Text = Labely.Text
            flag = True
        End If
    End Sub

    Private Sub DirectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectToolStripMenuItem.Click

    End Sub

    Private Sub DDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DDAToolStripMenuItem.Click

        x1 = Int32.Parse(TextBoxX1.Text)
        x2 = Int32.Parse(TextBoxX2.Text)
        y1 = Int32.Parse(TextBoxY1.Text)
        y2 = Int32.Parse(TextBoxY2.Text)

        DrawnLineDDA(x1, x2, y1, y2)
    End Sub

    Private Sub BresenhumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BresenhumToolStripMenuItem.Click

        x1 = Int32.Parse(TextBoxX1.Text)
        x2 = Int32.Parse(TextBoxX2.Text)
        y1 = Int32.Parse(TextBoxY1.Text)
        y2 = Int32.Parse(TextBoxY2.Text)

        BresenhumLine(x1, x2, y1, y2)
    End Sub


    Private Sub DrawnLineDDA(ByVal x1 As Integer, ByVal x2 As Integer, ByVal y1 As Integer, ByVal y2 As Integer)
        ListBox1.Items.Add(x1.ToString + "   " + y1.ToString)
        ListBox1.Items.Add(x2.ToString + "   " + y2.ToString)

        Dim graph As Graphics = PictureBox1.CreateGraphics()


        Dim length, Dy, Dx, Xinc, Yinc

        Dy = x2 - x1
        Dx = y2 - y1


        length = Math.Max(Math.Abs(Dy), Math.Abs(Dx))

        Xinc = Dx / length
        Yinc = Dy / length



        Dim Img As New Bitmap(1, 1)
        Img.SetPixel(0, 0, Color.Green)


        Dim x, y As Double
        x = x1 + 0.5
        y = y1 + 0.5

        For i = 1 To length

            graph.DrawImage(Img, Convert.ToInt32(x), Convert.ToInt32(y))
            x += Xinc
            y += Yinc
            Threading.Thread.Sleep(5)

        Next
    End Sub


    Private Sub BresenhumLine(ByVal x1 As Integer, ByVal x2 As Integer, ByVal y1 As Integer, ByVal y2 As Integer)

        ListBox1.Items.Add(x1.ToString + "   " + y1.ToString)
        ListBox1.Items.Add(x2.ToString + "   " + y2.ToString)
        Dim dx, dy, p, s1, s2, temp, chang As Integer


        Dim x, y As Integer

        Dim graph As Graphics = PictureBox1.CreateGraphics

        Dim image As New Bitmap(1, 1)
        image.SetPixel(0, 0, Color.Red)

        dx = Math.Abs(x2 - x1)
        dy = Math.Abs(y2 - y1)

        p = 2 * (dy - dx)

        s1 = Math.Sign(x2 - x1)
        s2 = Math.Sign(y2 - y1)

        x = x1
        y = y1

        If (dy > dx) Then
            temp = dx
            dx = dy
            dy = dx
            chang = 1
        Else
            chang = 0
        End If

        For i = 1 To dx

            graph.DrawImage(image, x, y)
            If (p >= 0) Then
                If (chang = 1) Then
                    x = x + s1
                Else
                    y = y + s2
                End If

                p = p + 2 * (dy - dx)
            Else
                p = p + 2 * dy
            End If
            If (chang = 1) Then
                y = y + s2
            Else
                x = x + s1
            End If
            ' Console.WriteLine(x & "   graph.DrawImage(Img, x, y)
        Next
    End Sub

    Private Sub HouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HouseToolStripMenuItem.Click
        BresenhumLine(15, 70, 70, 15)
        BresenhumLine(70, 15, 115, 70)
        BresenhumLine(15, 70, 120, 70)
        BresenhumLine(15, 70, 15, 130)
        BresenhumLine(120, 70, 120, 130)
        BresenhumLine(15, 130, 120, 130)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        PictureBox1.Image = Nothing
    End Sub


End Class
