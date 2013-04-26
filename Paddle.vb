Public Class Paddle
    <System.Runtime.InteropServices.DllImport("User32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function
    Public speed, width, height, x, y As Integer
    Private pencil As Graphics
    Public Sub movement(ByVal height As Integer, ByVal length As Integer)
        speed = Menu.ComboBox1.Text
        If GetAsyncKeyState(Keys.Up) And y > 0 Then
            y -= speed
        End If
        If GetAsyncKeyState(Keys.Down) And y + 50 < height Then
            x += speed
        End If
    End Sub
    Public Sub drawpaddle(ByVal height As Integer, ByVal length As Integer)
        width = length \ 10
        height = length \ 5
        pencil.FillRectangle(Brushes.Black, x, y, width, height)
    End Sub
End Class
