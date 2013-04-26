Public Class Menu
    <System.Runtime.InteropServices.DllImport("User32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function
    Dim graphics As Graphics
    Dim paddle As Paddle
    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        graphics = Me.CreateGraphics
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        'For i = 0 To 6.28318 Step 0.01
        'graphics.DrawRectangle(Pens.Black, CInt(300 + (120 * Math.Cos(i))), CInt(300 + (60 * Math.Sin(i))), 1, 1)
        'Next
        'Dim xpos, ypos As Long
        'Dim dir, speed As Double
        'xpos += speed * Math.Cos(dir * Math.PI / 180)
        'ypos += speed * Math.Cos(dir * Math.PI / 180)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        movement(Me.Height)
        drawpaddle(Me.Height, Me.Width)
    End Sub

    Public Sub movement(ByVal height As Integer)
        If GetAsyncKeyState(Keys.Up) And paddle.y > 0 Then
            paddle.y -= paddle.speed
        End If
        If GetAsyncKeyState(Keys.Down) And paddle.y + 50 < height Then
            paddle.x += paddle.speed
        End If
    End Sub

    Public Sub drawpaddle(ByVal height As Integer, ByVal length As Integer)
        graphics.FillRectangle(Brushes.Black, paddle.x, paddle.y, CInt(length / 10), CInt(height / 5))
    End Sub
End Class
