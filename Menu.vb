Public Class Menu
    Private graphics As Graphics
    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        graphics = Me.CreateGraphics
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'For i = 0 To 6.28318 Step 0.01
        'graphics.DrawRectangle(Pens.Black, CInt(300 + (120 * Math.Cos(i))), CInt(300 + (60 * Math.Sin(i))), 1, 1)
        'Next
        Dim xpos, ypos As Long
        Dim dir, speed As Double
        xpos += speed * Math.Cos(dir * Math.PI / 180)
        ypos += speed * Math.Cos(dir * Math.PI / 180)
    End Sub
End Class
