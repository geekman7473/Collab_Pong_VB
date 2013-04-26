Public Class Paddle
    Public speed, width, height, x, y As New Integer
    Public Sub dostuff()
        speed = Menu.ComboBox1.Text
        width = Menu.Width / 10
        height = Menu.Height / 5
        x = Menu.Width / 10
        y = Menu.Height / 5
    End Sub
End Class
