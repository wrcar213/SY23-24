Public Class ProductControl
    Public Property productID As String
    Public Property productPrice As Decimal
    Public Property productImage As Image
    Public Property productCount As Integer
    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDlabel.Text = productID
        PriceLabel.Text = productPrice.ToString("c2")
        PictureBox1.Image = productImage
    End Sub
    Sub Buy()
        If productCount > 0 Then
            productCount = productCount - 1
        End If
        If productCount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class