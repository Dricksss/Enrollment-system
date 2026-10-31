Public Class Admin_Record
    Private Sub pwede()
        Me.txtAdminID.Enabled = True
        Me.txtFirstName.Enabled = True
        Me.txtMiddleName.Enabled = True
        Me.txtLastName.Enabled = True
        Me.txtUsername.Enabled = True
        Me.txtPassword.Enabled = True
        Me.txtretypePassword.Enabled = True
        Me.txtSearch.Enabled = True
    End Sub

    Private Sub dipwede()
        Me.txtAdminID.Enabled = False
        Me.txtFirstName.Enabled = False
        Me.txtMiddleName.Enabled = False
        Me.txtLastName.Enabled = False
        Me.txtUsername.Enabled = False
        Me.txtPassword.Enabled = False
        Me.txtretypePassword.Enabled = False

    End Sub

    Private Sub burahin()
        Me.txtAdminID.Text = ""
        Me.txtFirstName.Text = ""
        Me.txtMiddleName.Text = ""
        Me.txtLastName.Text = ""
        Me.txtUsername.Text = ""
        Me.txtPassword.Text = ""
        Me.txtretypePassword.Text = ""
        Me.txtSearch.Text = ""
    End Sub

    Private Sub itago()
        If dgvAdmin.Columns.Contains("AdminPassword") Then
            dgvAdmin.Columns("AdminPassword").Visible = False
        End If
    End Sub
    Private Sub Admin_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        connectAdmin("SELECT * FROM Admin_record")
        If dsAdm.Tables.Contains("Admin_record") Then
            dsAdm.Tables("Admin_record").Clear()
        End If
        daAdm.Fill(dsAdm, rsAdm, "Admin_record")
        dgvAdmin.DataSource = dsAdm.Tables("Admin_record").DefaultView
        Call itago()

        Call dipwede()
        btnSave.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call pwede()
        Call burahin()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        saveRecord = True
        txtAdminID.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cid As Integer

        If Len(Me.txtAdminID.Text) = 0 Then
            MsgBox("Please Enter Admin ID!")
            Me.txtAdminID.Focus()
        ElseIf Not Integer.TryParse(Me.txtAdminID.Text.Trim(), cid) Then
            MsgBox("Admin ID Must Be a Number!")
            Me.txtAdminID.Focus()
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
                connectAdmin("SELECT * FROM Admin_record WHERE AdminID='" & cid & "'")

                If rsAdm.EOF = False Then
                    MsgBox("Record Already Exists!")
                Else
                    connectAdmin("SELECT * FROM Admin_record WHERE AdminUsername='" & user & "'")

                    If rsAdm.EOF = False Then
                        MsgBox("Username Already Taken!")
                    Else
                        rsAdm.AddNew()
                        rsAdm("AdminID").Value = cid
                        rsAdm("AdminFname").Value = Me.txtFirstName.Text.Trim()
                        rsAdm("AdminMname").Value = Me.txtMiddleName.Text.Trim()
                        rsAdm("AdminLname").Value = Me.txtLastName.Text.Trim()
                        rsAdm("AdminUsername").Value = Me.txtUsername.Text.Trim()
                        rsAdm("AdminPassword").Value = Me.txtPassword.Text
                        rsAdm.Update()

                        MsgBox("Record Successfully Saved!")

                        connectAdmin("SELECT * FROM Admin_record")
                        dsAdm.Tables("Admin_record").Clear()
                        daAdm.Fill(dsAdm, rsAdm, "Admin_record")
                        dgvAdmin.DataSource = dsAdm.Tables("Admin_record").DefaultView
                        Call itago()

                        Call dipwede()

                        btnSave.Enabled = False
                        btnUpdate.Enabled = False
                        btnDelete.Enabled = False
                    End If
                End If
            Else
                connectAdmin("SELECT * FROM Admin_record WHERE AdminUsername='" & user & "' AND AdminID<>'" & cid & "'")

                If rsAdm.EOF = False Then
                    MsgBox("Username Already Taken!")
                Else
                    connectAdmin("SELECT * FROM Admin_record WHERE AdminID='" & cid & "'")

                    rsAdm("AdminFname").Value = Me.txtFirstName.Text.Trim()
                    rsAdm("AdminMname").Value = Me.txtMiddleName.Text.Trim()
                    rsAdm("AdminLname").Value = Me.txtLastName.Text.Trim()
                    rsAdm("AdminUsername").Value = Me.txtUsername.Text.Trim()
                    rsAdm("AdminPassword").Value = Me.txtPassword.Text
                    rsAdm.Update()

                    MsgBox("Record Successfully Edited!")

                    connectAdmin("SELECT * FROM Admin_record")
                    dsAdm.Tables("Admin_record").Clear()
                    daAdm.Fill(dsAdm, rsAdm, "Admin_record")
                    dgvAdmin.DataSource = dsAdm.Tables("Admin_record").DefaultView
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
        Me.txtAdminID.Enabled = False
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
            connectAdmin("DELETE FROM Admin_record WHERE AdminID='" & Me.txtAdminID.Text & "'")
            connectAdmin("SELECT * FROM Admin_record")
            dsAdm.Tables("Admin_record").Clear()
            daAdm.Fill(dsAdm, rsAdm, "Admin_record")
            dgvAdmin.DataSource = dsAdm.Tables("Admin_record").DefaultView
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
        txtAdminID.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim s As String = Me.txtSearch.Text.Replace("'", "''")
        connectAdmin("SELECT * FROM Admin_record WHERE AdminLname LIKE '" & s & "%' OR AdminFname LIKE '" & s & "%'")
        dsAdm.Tables("Admin_record").Clear()
        daAdm.Fill(dsAdm, rsAdm, "Admin_record")
        dgvAdmin.DataSource = dsAdm.Tables("Admin_record").DefaultView
        Call itago()
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        connectAdmin("SELECT * FROM Admin_record")
        dsAdm.Tables("Admin_record").Clear()
        daAdm.Fill(dsAdm, rsAdm, "Admin_record")
        dgvAdmin.DataSource = dsAdm.Tables("Admin_record").DefaultView
    End Sub

    Private Sub dgvAdmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdmin.CellContentClick

    End Sub

    Private Sub dgvAdmin_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAdmin.RowHeaderMouseClick
        Dim strer As String

        strer = dgvAdmin.Rows(e.RowIndex).Cells("AdminID").Value
        connectAdmin("SELECT * FROM Admin_record WHERE AdminID ='" & strer & "'")

        If rsAdm.EOF = False Then
            Me.txtAdminID.Text = rsAdm("AdminID").Value & ""
            Me.txtFirstName.Text = rsAdm("AdminFName").Value & ""
            Me.txtMiddleName.Text = rsAdm("AdminMName").Value & ""
            Me.txtLastName.Text = rsAdm("AdminLName").Value & ""
            Me.txtUsername.Text = rsAdm("AdminUsername").Value & ""
            Me.txtPassword.Text = rsAdm("AdminPassword").Value & ""
            Me.txtretypePassword.Text = rsAdm("AdminPassword").Value & ""

            Call dipwede()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        End If
    End Sub
End Class