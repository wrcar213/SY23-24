Class MainWindow
    Private Sub DrawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingCanvas.MouseMove
        Dim el As New Ellipse
        el.Width = WidthSlider.Value
        el.Height = HeightSlider.Value
        el.Fill = ColorRectangle1.Fill
        Dim p As Point = Mouse.GetPosition(DrawingCanvas)
        Canvas.SetLeft(el, p.X)
        Canvas.SetTop(el, p.Y)
        If e.LeftButton = MouseButtonState.Pressed Then
            DrawingCanvas.Children.Add(el)
        End If
    End Sub

    Private Sub ColorRectangle1_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ColorRectangle1_Copy.MouseDown, ColorRectangle1_Copy2.MouseDown, ColorRectangle1_Copy3.MouseDown, ColorRectangle1_Copy4.MouseDown, ColorRectangle1_Copy5.MouseDown, ColorRectangle1_Copy6.MouseDown, ColorRectangle1_Copy7.MouseDown, ColorRectangle1_Copy1.MouseDown
        ColorRectangle1.Fill = sender.Fill
    End Sub
End Class
