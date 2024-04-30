Class MainWindow

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim d As Integer
        Dim m As Integer
        m = Cal1.SelectedDate.Value.Month
        d = Cal1.SelectedDate.Value.Day
        If m = 1 And d > 20 Then
            Label1.Content = "Aquarius ♒️"
        End If
        If m = 2 And d > 18 Then
            Label1.Content = "Aquarius ♒️"
        End If
        If m = 2 And d > 19 Then
            Label1.Content = "Pisces ♓️"
        End If
        If m = 3 And d < 20 Then
            Label1.Content = "Pisces ♓️"
        End If
        If m = 3 And d > 21 Then
            Label1.Content = "Aries ♈️"
        End If
        If m = 4 And d < 19 Then
            Label1.Content = "Aries ♈️"
        End If
        If m = 4 And d > 20 Then
            Label1.Content = "Taurus ♉️"
        End If
        If m = 5 And d < 20 Then
            Label1.Content = "Taurus ♉️"
        End If
        If m = 5 And d > 21 Then
            Label1.Content = "Gemini ♊️"
        End If
        If m = 6 And d < 20 Then
            Label1.Content = "Gemini ♊️"
        End If
        If m = 6 And d > 21 Then
            Label1.Content = "Cancer ♋️"
        End If
        If m = 7 And d < 22 Then
            Label1.Content = "Cancer ♋️"
        End If
        If m = 7 And d > 23 Then
            Label1.Content = "Leo ♌️"
        End If
        If m = 8 And d < 22 Then
            Label1.Content = "Leo ♌️"
        End If
        If m = 8 And d > 23 Then
            Label1.Content = "Virgo ♍️"
        End If
        If m = 9 And d < 22 Then
            Label1.Content = "Virgo ♍️"
        End If
        If m = 9 And d > 23 Then
            Label1.Content = "Libra ♎️"
        End If
        If m = 10 And d < 22 Then
            Label1.Content = "Libra ♎️"
        End If
        If m = 10 And d > 23 Then
            Label1.Content = "Scorpio ♏️"
        End If
        If m = 11 And d < 21 Then
            Label1.Content = "Scorpio ♏️"
        End If
        If m = 11 And d > 22 Then
            Label1.Content = "Sagittarius ♐️"
        End If
        If m = 12 And d < 21 Then
            Label1.Content = "Sagittarius ♐️"
        End If
        If m = 12 And d > 22 Then
            Label1.Content = "Capricorn ♑️"
        End If
        If m = 1 And d < 19 Then
            Label1.Content = "Capricorn ♑️"
        End If
    End Sub
End Class
