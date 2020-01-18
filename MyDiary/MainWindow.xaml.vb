Class MainWindow
    Dim navService As NavigationService

    Private Sub Do_Login()
        MessageBox.Show(pwd.Password, usr.Text)
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Do_Login()
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        'Register Page = New Register()
        'Dim Page As Register
        'Page = New Register()
        'NavigationService.Navigate(Page)

        Dim f As New Register()
        Me.Close()
        f.Show()
    End Sub

    Private Sub Window_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Key = 6 Then
            Do_Login()
        End If
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        navService = NavigationService.GetNavigationService(Me)
    End Sub
End Class
