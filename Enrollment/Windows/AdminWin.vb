Public Class AdminWin

    Dim Stud As New frmStudent()
    Dim Assess As New Assessment_Table()
    Dim Cash As New Cashier_Record()
    Dim Reg As New Form2()
    Dim Adm As New Admin_Record()
    Dim Pay As New Payment_Form()

    Private Sub LoadFormInPanel(childForm As Form)
        Panel1.Controls.Clear()

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        Panel1.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub StudentInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentM.Click
        LoadFormInPanel(Stud)
    End Sub

    Private Sub RegistrarM_Click(sender As Object, e As EventArgs) Handles RegistrarM.Click
        LoadFormInPanel(Reg)
    End Sub

    Private Sub CashierM_Click(sender As Object, e As EventArgs) Handles CashierM.Click
        LoadFormInPanel(Cash)
    End Sub

    Private Sub PaymentM_Click(sender As Object, e As EventArgs) Handles PaymentM.Click
        LoadFormInPanel(Pay)
    End Sub

    Private Sub AssessmentM_Click(sender As Object, e As EventArgs) Handles AssessmentM.Click
        LoadFormInPanel(Assess)
    End Sub

    Private Sub AdminM_Click(sender As Object, e As EventArgs) Handles AdminM.Click
        LoadFormInPanel(Adm)
    End Sub

    Private Sub AdminWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblWelcome.Text = "Welcome, " & strUser
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class