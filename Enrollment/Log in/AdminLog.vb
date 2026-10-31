Public Class AdminLog

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        If Len(Me.Username.Text) = 0 Then
            MsgBox("Please Enter Username!")
            Me.Username.Focus()
        ElseIf Len(Me.Password.Text) = 0 Then
            MsgBox("Please Enter Password!")
            Me.Password.Focus()
        Else
            Dim user As String = Me.Username.Text.Trim().Replace("\", "\\").Replace("'", "''")
            Dim pass As String = Me.Password.Text.Replace("\", "\\").Replace("'", "''")

            connectAdmin("SELECT * FROM admin_record WHERE AdminUsername='" & user & "' " & _
                       "AND AdminPassword=BINARY '" & pass & "'")

            If rsAdm.EOF = False Then
                MsgBox("Username and Password Verified!")
                strUser = rsAdm("AdminLname").Value & ", " & rsAdm("AdminFname").Value & " " & rsAdm("AdminMname").Value
                Me.Hide()
                AdminWin.Show()
            Else
                MsgBox("Invalid User ID and Password!")
                Me.Username.Text = ""
                Me.Password.Text = ""
                Me.Username.Focus()
            End If
        End If
    End Sub

    Private Sub AdminLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
    End Sub
End Class