Public Class RegistrarLog

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

            connectReg("SELECT * FROM Registrar_record WHERE RegUsername='" & user & "' " & _
                       "AND RegPassword=BINARY '" & pass & "'")

            If rsReg.EOF = False Then
                MsgBox("Username and Password Verified!")
                strUser = rsReg("RegLastname").Value & ", " & rsReg("RegFirstname").Value & " " & rsReg("RegMiddlename").Value

                UserRole = "Registrar"
                Me.Username.Text = ""
                Me.Password.Text = ""
                Me.Hide()
                RegWindow.Show()

                
            Else
                MsgBox("Invalid User ID and Password!")
                Me.Username.Text = ""
                Me.Password.Text = ""
                Me.Username.Focus()
            End If
        End If
    End Sub

    Private Sub RegistrarLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()

        

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
        Menuu.Show()
    End Sub
End Class