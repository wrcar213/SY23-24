Public Class Clicker
    Public Property count As Integer
    Public Property Increment As Integer = 1
    Public Sub Click()
        count = count + 1
    End Sub
    Public Sub reset()
        count = 0
    End Sub
End Class
