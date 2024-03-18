Public Class Form1
    Dim WithEvents CS As New CoinSlot
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles FiftyButton.Click
        CS.InsertNickel()
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles OHButton.Click
        CS.InsertDime()
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles HTButton.Click
        CS.InsertQuarter()
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TButton.Click
        CS.InsertDollar()
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub CRbutton_Click(sender As Object, e As EventArgs) Handles CRbutton.Click
        CS.CoinReturn()
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub CS_CoinReturnEvent(D As Integer, Q As Integer, Di As Integer, N As Integer) Handles CS.CoinReturnEvent
        If D > 0 Then
            DollarPB.Visible = True
        Else
            DollarPB.Visible = False
        End If

    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Select Case idTextBox.Text
            Case ProductControl1.productID
                CS.buy(ProductControl1)

            Case ProductControl2.productID
                CS.buy(ProductControl2)

            Case ProductControl3.productID
                CS.buy(ProductControl3)

            Case ProductControl4.productID
                CS.buy(ProductControl4)

            Case ProductControl5.productID
                CS.buy(ProductControl5)

            Case ProductControl6.productID
                CS.buy(ProductControl6)

            Case ProductControl7.productID
                CS.buy(ProductControl7)

            Case ProductControl8.productID
                CS.buy(ProductControl8)

            Case ProductControl9.productID
                CS.buy(ProductControl9)

            Case ProductControl10.productID
                CS.buy(ProductControl10)

            Case ProductControl11.productID
                CS.buy(ProductControl11)

            Case ProductControl12.productID
                CS.buy(ProductControl12)

            Case ProductControl13.productID
                CS.buy(ProductControl13)

            Case ProductControl14.productID
                CS.buy(ProductControl14)

            Case ProductControl15.productID
                CS.buy(ProductControl15)

            Case ProductControl16.productID
                CS.buy(ProductControl16)

            Case Else
        End Select
        Label1.Text = CS.total.ToString("c2")
    End Sub

    Private Sub CS_buyevent(p As Image) Handles CS.buyevent
        ProductPictureBox.Image = p
    End Sub

    Private Sub ProductControl1_Load(sender As Object, e As EventArgs) Handles ProductControl1.Load

    End Sub

    Private Sub TakeButton_Click(sender As Object, e As EventArgs) Handles TakeButton.Click
        ProductPictureBox.Image = Nothing
    End Sub
End Class
