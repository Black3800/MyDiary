Public Class Register
    Private Sub Do_Register()
        MessageBox.Show(usr.Text & " " & pwd.Password, "Register")
        Dim w As New MainWindow()
        w.Show()
        Me.Close()
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Do_Register()
    End Sub

    Private Sub Window_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Key = 6 Then
            Do_Register()
        End If
    End Sub
End Class
