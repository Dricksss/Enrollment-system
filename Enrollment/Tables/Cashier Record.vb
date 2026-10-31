Public Class Cashier_Record

    Private Sub Cashier_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        connectCash("SELECT * FROM cashier_record")
        If dsCash.Tables.Contains("cashier_record") Then
            dsCash.Tables("cashier_record").Clear()
        End If
        daCash.Fill(dsCash, rsCash, "cashier_record")
        dgvCashier.DataSource = dsCash.Tables("cashier_record").DefaultView
        Call itago()

        Call dipwede()
        btnSave.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim s As String = Me.txtSearch.Text.Replace("'", "''")
        connectCash("SELECT * FROM cashier_record WHERE CashierLname LIKE '" & s & "%' OR CashierFname LIKE '" & s & "%'")
        dsCash.Tables("cashier_record").Clear()
        daCash.Fill(dsCash, rsCash, "cashier_record")
        dgvCashier.DataSource = dsCash.Tables("cashier_record").DefaultView
        Call itago()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cid As Integer

        If Len(Me.txtCashierID.Text) = 0 Then
            MsgBox("Please Enter Cashier ID!")
            Me.txtCashierID.Focus()
        ElseIf Not Integer.TryParse(Me.txtCashierID.Text.Trim(), cid) Then
            MsgBox("Cashier ID Must Be a Number!")
            Me.txtCashierID.Focus()
        ElseIf Len(Me.txtLastName.Text) = 0 Then
            MsgBox("Please Enter Last Name!")
            Me.txtLastName.Focus()
        ElseIf Len(Me.txtFirstName.Text) = 0 Then
            MsgBox("Please Enter First Name!")
            Me.txtFirstName.Focus()
        ElseIf Len(Me.txtMiddleName.Text) = 0 Then
            MsgBox("Please Enter Middle Name!")
            Me.txtMiddleName.Focus()
        ElseIf Len(Me.txtUsername.Text) = 0 Then
            MsgBox("Please Enter Username!")
            Me.txtUsername.Focus()
        ElseIf Len(Me.txtPassword.Text) = 0 Then
            MsgBox("Please Enter Password!")
            Me.txtPassword.Focus()
        ElseIf Len(Me.txtRetypePassword.Text) = 0 Then
            MsgBox("Please Retype Password!")
            Me.txtRetypePassword.Focus()
        ElseIf Not Me.txtPassword.Text.Equals(Me.txtRetypePassword.Text) Then
            MsgBox("Passwords Do Not Match!")
            Me.txtRetypePassword.Text = ""
            Me.txtRetypePassword.Focus()
        Else
            Dim user As String = Me.txtUsername.Text.Trim().Replace("'", "''")

            If saveRecord = True Then
                connectCash("SELECT * FROM cashier_record WHERE CashierID='" & cid & "'")

                If rsCash.EOF = False Then
                    MsgBox("Record Already Exists!")
                Else
                    connectCash("SELECT * FROM cashier_record WHERE CashierUsername='" & user & "'")

                    If rsCash.EOF = False Then
                        MsgBox("Username Already Taken!")
                    Else
                        rsCash.AddNew()
                        rsCash("CashierID").Value = cid
                        rsCash("CashierFname").Value = Me.txtFirstName.Text.Trim()
                        rsCash("CashierMname").Value = Me.txtMiddleName.Text.Trim()
                        rsCash("CashierLname").Value = Me.txtLastName.Text.Trim()
                        rsCash("CashierUsername").Value = Me.txtUsername.Text.Trim()
                        rsCash("CashierPassword").Value = Me.txtPassword.Text
                        rsCash.Update()

                        MsgBox("Record Successfully Saved!")

                        connectCash("SELECT * FROM cashier_record")
                        dsCash.Tables("cashier_record").Clear()
                        daCash.Fill(dsCash, rsCash, "cashier_record")
                        dgvCashier.DataSource = dsCash.Tables("cashier_record").DefaultView
                        Call itago()

                        Call dipwede()

                        btnSave.Enabled = False
                        btnUpdate.Enabled = False
                        btnDelete.Enabled = False
                    End If
                End If
            Else
                connectCash("SELECT * FROM cashier_record WHERE CashierUsername='" & user & "' AND CashierID<>'" & cid & "'")

                If rsCash.EOF = False Then
                    MsgBox("Username Already Taken!")
                Else
                    connectCash("SELECT * FROM cashier_record WHERE CashierID='" & cid & "'")

                    rsCash("CashierFname").Value = Me.txtFirstName.Text.Trim()
                    rsCash("CashierMname").Value = Me.txtMiddleName.Text.Trim()
                    rsCash("CashierLname").Value = Me.txtLastName.Text.Trim()
                    rsCash("CashierUsername").Value = Me.txtUsername.Text.Trim()
                    rsCash("CashierPassword").Value = Me.txtPassword.Text
                    rsCash.Update()

                    MsgBox("Record Successfully Edited!")

                    connectCash("SELECT * FROM cashier_record")
                    dsCash.Tables("cashier_record").Clear()
                    daCash.Fill(dsCash, rsCash, "cashier_record")
                    dgvCashier.DataSource = dsCash.Tables("cashier_record").DefaultView
                    Call itago()

                    Call dipwede()

                    btnAdd.Enabled = True
                    btnSave.Enabled = False
                    btnUpdate.Enabled = False
                    btnDelete.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call pwede()
        Me.txtCashierID.Enabled = False
        btnSave.Enabled = True
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        saveRecord = False
        Me.txtFirstName.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strAns As MsgBoxResult
        strAns = MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo)

        If strAns = MsgBoxResult.Yes Then
            connectCash("DELETE FROM cashier_record WHERE CashierID='" & Me.txtCashierID.Text & "'")
            connectCash("SELECT * FROM cashier_record")
            dsCash.Tables("cashier_record").Clear()
            daCash.Fill(dsCash, rsCash, "cashier_record")
            dgvCashier.DataSource = dsCash.Tables("cashier_record").DefaultView
            Call itago()

            Call burahin()
            Call dipwede()
            btnAdd.Enabled = True
            btnSave.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call burahin()
        txtCashierID.Focus()
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        connectCash("SELECT * FROM cashier_record")
        dsCash.Tables("cashier_record").Clear()
        daCash.Fill(dsCash, rsCash, "cashier_record")
        dgvCashier.DataSource = dsCash.Tables("cashier_record").DefaultView
        Call itago()
        Me.txtSearch.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call pwede()
        Call burahin()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        saveRecord = True
        txtCashierID.Focus()
    End Sub

    Private Sub dgvCashier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashier.CellContentClick

    End Sub

    Private Sub dgvCashier_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCashier.RowHeaderMouseClick
        Dim strer As String

        strer = dgvCashier.Rows(e.RowIndex).Cells("CashierID").Value
        connectCash("SELECT * FROM cashier_record WHERE CashierID ='" & strer & "'")

        If rsCash.EOF = False Then
            Me.txtCashierID.Text = rsCash("CashierID").Value & ""
            Me.txtFirstName.Text = rsCash("CashierFname").Value & ""
            Me.txtMiddleName.Text = rsCash("CashierMname").Value & ""
            Me.txtLastName.Text = rsCash("CashierLname").Value & ""
            Me.txtUsername.Text = rsCash("CashierUsername").Value & ""
            Me.txtPassword.Text = rsCash("CashierPassword").Value & ""
            Me.txtretypePassword.Text = rsCash("CashierPassword").Value & ""

            Call dipwede()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub pwede()
        Me.txtCashierID.Enabled = True
        Me.txtFirstName.Enabled = True
        Me.txtMiddleName.Enabled = True
        Me.txtLastName.Enabled = True
        Me.txtUsername.Enabled = True
        Me.txtPassword.Enabled = True
        Me.txtSearch.Enabled = True
        Me.txtretypePassword.Enabled = True
    End Sub

    Private Sub dipwede()
        Me.txtCashierID.Enabled = False
        Me.txtFirstName.Enabled = False
        Me.txtMiddleName.Enabled = False
        Me.txtLastName.Enabled = False
        Me.txtUsername.Enabled = False
        Me.txtPassword.Enabled = False
        Me.txtretypePassword.Enabled = False
    End Sub

    Private Sub burahin()
        Me.txtCashierID.Text = ""
        Me.txtFirstName.Text = ""
        Me.txtMiddleName.Text = ""
        Me.txtLastName.Text = ""
        Me.txtUsername.Text = ""
        Me.txtPassword.Text = ""
        Me.txtretypePassword.Text = ""
        Me.txtSearch.Text = ""
    End Sub

    Private Sub itago()
        If dgvCashier.Columns.Contains("CashierPassword") Then
            dgvCashier.Columns("CashierPassword").Visible = False
        End If
    End Sub
End Class