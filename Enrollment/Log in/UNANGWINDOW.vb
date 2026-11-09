Public Class UNANGWINDOW

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        If Password.Text = "123456" Then
            Password.Text = ""
            Me.Hide()
            Menuu.Show()
        End If
    End Sub

    Private Sub UNANGWINDOW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class