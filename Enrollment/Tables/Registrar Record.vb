Public Class Form2

    Private Sub pwede()
        Me.txtRegID.Enabled = True
        Me.txtFirstName.Enabled = True
        Me.txtMiddleName.Enabled = True
        Me.txtLastName.Enabled = True
        Me.txtUsername.Enabled = True
        Me.txtPassword.Enabled = True
        Me.txtSearch.Enabled = True
        Me.dtpRegDate.Enabled = True
        Me.txtretypePassword.Enabled = True
    End Sub

    Private Sub dipwede()
        Me.txtRegID.Enabled = False
        Me.txtFirstName.Enabled = False
        Me.txtMiddleName.Enabled = False
        Me.txtLastName.Enabled = False
        Me.txtUsername.Enabled = False
        Me.txtPassword.Enabled = False
        Me.txtretypePassword.Enabled = False
        Me.dtpRegDate.Enabled = False
    End Sub

    Private Sub burahin()
        Me.txtRegID.Text = ""
        Me.txtFirstName.Text = ""
        Me.txtMiddleName.Text = ""
        Me.txtLastName.Text = ""
        Me.txtUsername.Text = ""
        Me.txtPassword.Text = ""
        Me.txtretypePassword.Text = ""
        Me.dtpRegDate.Value = Date.Today
        Me.txtSearch.Text = ""
    End Sub

    Private Sub itago()
        If dgvRegistrars.Columns.Contains("RegPassword") Then
            dgvRegistrars.Columns("RegPassword").Visible = False
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        connectReg("SELECT * FROM registrar_record")
        daReg.Fill(dsReg, rsReg, "registrar_record")
        dgvRegistrars.DataSource = dsReg.Tables("registrar_record").DefaultView
        Call itago()

        Call dipwede()
        btnSave.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ConnectReg("SELECT * FROM registrar_record WHERE RegLastName LIKE '" & Me.txtSearch.Text.Replace("'", "''") & "%'")
        dsReg.Tables("registrar_record").Clear()
        daReg.Fill(dsReg, rsReg, "registrar_record")
        dgvRegistrars.DataSource = dsReg.Tables("registrar_record").DefaultView
        Call itago()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call pwede()
        Call burahin()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        saveRecord = True
        txtRegID.Focus()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call pwede()
        Me.txtRegID.Enabled = False
        btnSave.Enabled = True
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        saveRecord = False
        Me.txtFirstName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Len(Me.txtRegID.Text) = 0 Then
            MsgBox("Please Enter Registrar ID!")
            Me.txtRegID.Focus()
        ElseIf Not IsNumeric(Me.txtRegID.Text) Then
            MsgBox("Registrar ID Must Be a Number!")
            Me.txtRegID.Focus()
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
                ConnectReg("SELECT * FROM registrar_record WHERE RegID='" & Me.txtRegID.Text & "'")

                If rsReg.EOF = False Then
                    MsgBox("Record Already Exists!")
                Else
                    ConnectReg("SELECT * FROM registrar_record WHERE RegUsername='" & user & "'")

                    If rsReg.EOF = False Then
                        MsgBox("Username Already Taken!")
                    Else
                        rsReg.AddNew()
                        rsReg("RegID").Value = Me.txtRegID.Text
                        rsReg("RegFirstName").Value = Me.txtFirstName.Text
                        rsReg("RegMiddleName").Value = Me.txtMiddleName.Text
                        rsReg("RegLastName").Value = Me.txtLastName.Text
                        rsReg("RegUsername").Value = Me.txtUsername.Text
                        rsReg("RegPassword").Value = Me.txtPassword.Text
                        rsReg("RegDate").Value = Me.dtpRegDate.Value.ToString("yyyy-MM-dd")
                        rsReg.Update()

                        MsgBox("Record Successfully Saved!")

                        ConnectReg("SELECT * FROM registrar_record")
                        dsReg.Tables("registrar_record").Clear()
                        daReg.Fill(dsReg, rsReg, "registrar_record")
                        dgvRegistrars.DataSource = dsReg.Tables("registrar_record").DefaultView
                        Call itago()

                        Call dipwede()

                        btnSave.Enabled = False
                        btnUpdate.Enabled = False
                        btnDelete.Enabled = False
                    End If
                End If
            Else
                ConnectReg("SELECT * FROM registrar_record WHERE RegUsername='" & user & "' AND RegID<>'" & Me.txtRegID.Text & "'")

                If rsReg.EOF = False Then
                    MsgBox("Username Already Taken!")
                Else
                    ConnectReg("SELECT * FROM registrar_record WHERE RegID='" & Me.txtRegID.Text & "'")

                    rsReg("RegFirstName").Value = Me.txtFirstName.Text
                    rsReg("RegMiddleName").Value = Me.txtMiddleName.Text
                    rsReg("RegLastName").Value = Me.txtLastName.Text
                    rsReg("RegUsername").Value = Me.txtUsername.Text
                    rsReg("RegPassword").Value = Me.txtPassword.Text
                    rsReg("RegDate").Value = Me.dtpRegDate.Value.ToString("yyyy-MM-dd")
                    rsReg.Update()

                    MsgBox("Record Successfully Edited!")

                    ConnectReg("SELECT * FROM registrar_record")
                    dsReg.Tables("registrar_record").Clear()
                    daReg.Fill(dsReg, rsReg, "registrar_record")
                    dgvRegistrars.DataSource = dsReg.Tables("registrar_record").DefaultView
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strAns As MsgBoxResult
        strAns = MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo)

        If strAns = MsgBoxResult.Yes Then
            ConnectReg("DELETE FROM registrar_record WHERE RegID='" & Me.txtRegID.Text & "'")
            ConnectReg("SELECT * FROM registrar_record")
            dsReg.Tables("registrar_record").Clear()
            daReg.Fill(dsReg, rsReg, "registrar_record")
            dgvRegistrars.DataSource = dsReg.Tables("registrar_record").DefaultView
            Call itago()

            Call burahin()
            Call dipwede()
            btnAdd.Enabled = True
            btnSave.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        ConnectReg("SELECT * FROM registrar_record")
        dsReg.Tables("registrar_record").Clear()
        daReg.Fill(dsReg, rsReg, "registrar_record")
        dgvRegistrars.DataSource = dsReg.Tables("registrar_record").DefaultView
        Call itago()
        Me.txtSearch.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call burahin()
        txtRegID.Focus()
    End Sub

    Private Sub dgvRegistrars_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistrars.CellContentClick

    End Sub

    Private Sub dgvRegistrars_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRegistrars.RowHeaderMouseClick
        Dim strer As String

        strer = dgvRegistrars.Rows(e.RowIndex).Cells("RegID").Value
        ConnectReg("SELECT * FROM registrar_record WHERE RegID ='" & strer & "'")

        If rsReg.EOF = False Then
            Me.txtRegID.Text = rsReg("RegID").Value & ""
            Me.txtFirstName.Text = rsReg("RegFirstName").Value & ""
            Me.txtMiddleName.Text = rsReg("RegMiddleName").Value & ""
            Me.txtLastName.Text = rsReg("RegLastName").Value & ""
            Me.txtUsername.Text = rsReg("RegUsername").Value & ""
            Me.txtPassword.Text = rsReg("RegPassword").Value & ""
            Me.txtretypePassword.Text = rsReg("RegPassword").Value & ""

            Dim d As Date
            If Date.TryParse(rsReg("RegDate").Value & "", d) Then
                Me.dtpRegDate.Value = d
            Else
                Me.dtpRegDate.Value = Date.Today
            End If

            Call dipwede()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class