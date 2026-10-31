Public Class RegWindow

    Dim Stud As New frmStudent()
    Dim Assess As New Assessment_Table()

    Private Sub LoadFormInPanel(childForm As Form)
        Panel1.Controls.Clear()

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        Panel1.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub RegWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblWelcome.Text = "Welcome, " & strUser
    End Sub

    Private Sub StudentRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentRecordsToolStripMenuItem.Click
        LoadFormInPanel(Stud)
    End Sub

    Private Sub AssessmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssessmentToolStripMenuItem.Click
        LoadFormInPanel(Assess)
    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub
End Class