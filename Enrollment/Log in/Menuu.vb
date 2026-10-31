Public Class Menuu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Admin.Click
        Me.Hide()
        AdminLog.show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Me.Hide()
        RegistrarLog.show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Cashier.Click
        Me.Hide()
        CashierLog.show()
    End Sub

    Private Sub Menuu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class