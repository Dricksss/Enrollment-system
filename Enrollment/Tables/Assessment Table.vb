Public Class Assessment_Table

    Private tuitionTotal As Decimal = 0
    Private miscTotal As Decimal = 0
    Private otherTotal As Decimal = 0

    Private Sub kuwenta()
        tuitionTotal = 0
        miscTotal = 0
        otherTotal = 0
        If cmbTuition.Text = ("₱26,573.42 (Fixed)") Then
            tuitionTotal = 26573.42
        End If

        ' *** Miscellaneous fees: REPLACE the amounts ***
        If Me.chkAthletic.Checked Then miscTotal += 300
        If Me.chkAudio.Checked Then miscTotal += 200
        If Me.chkGuidance.Checked Then miscTotal += 580
        If Me.chkID.Checked Then miscTotal += 300
        If Me.chkInsurance.Checked Then miscTotal += 120
        If Me.chkLibrary.Checked Then miscTotal += 650
        If Me.chkMedical.Checked Then miscTotal += 220
        If Me.chkPublication.Checked Then miscTotal += 110
        If Me.chkRegistration.Checked Then miscTotal += 950

        ' *** Other fees: REPLACE the amounts ***
        If Me.chkAcademic.Checked Then otherTotal += 100
        If Me.chkAnswer.Checked Then otherTotal += 90
        If Me.chkComputer.Checked Then otherTotal += 45
        If Me.chkCSC.Checked Then otherTotal += 100
        If Me.chkDepartmental.Checked Then otherTotal += 100
        If Me.chkInternet.Checked Then otherTotal += 400
        If Me.chkPrisaa.Checked Then otherTotal += 100
        If Me.chkStudent.Checked Then otherTotal += 350
        If Me.chkTest.Checked Then otherTotal += 180

        Me.txtTotal.Text = (tuitionTotal + miscTotal + otherTotal).ToString("N2")
    End Sub

    Private Sub Fee_Changed(sender As Object, e As EventArgs) Handles _
        chkAthletic.CheckedChanged, chkAudio.CheckedChanged, chkGuidance.CheckedChanged, _
        chkID.CheckedChanged, chkInsurance.CheckedChanged, chkLibrary.CheckedChanged, _
        chkMedical.CheckedChanged, chkPublication.CheckedChanged, chkRegistration.CheckedChanged, _
        chkAcademic.CheckedChanged, chkAnswer.CheckedChanged, chkComputer.CheckedChanged, _
        chkCSC.CheckedChanged, chkDepartmental.CheckedChanged, chkInternet.CheckedChanged, _
        chkPrisaa.CheckedChanged, chkStudent.CheckedChanged, chkTest.CheckedChanged, _
        cmbTuition.TextChanged
        Call kuwenta()
    End Sub


    Private Sub pwede()
        Me.txtStudentID.Enabled = True
        Me.cmbTuition.Enabled = True
        Me.grpMisc.Enabled = True
        Me.grpOther.Enabled = True
        Me.txtSearch.Enabled = True
    End Sub

    Private Sub dipwede()
        Me.txtStudentID.Enabled = False
        Me.cmbTuition.Enabled = False
        Me.grpMisc.Enabled = False
        Me.grpOther.Enabled = False
    End Sub

    Private Sub burahin()
        Me.txtStudentID.Text = ""
        Me.cmbTuition.SelectedIndex = -1
        Me.cmbTuition.Text = ""

        Me.chkAthletic.Checked = False
        Me.chkAudio.Checked = False
        Me.chkGuidance.Checked = False
        Me.chkID.Checked = False
        Me.chkInsurance.Checked = False
        Me.chkLibrary.Checked = False
        Me.chkMedical.Checked = False
        Me.chkPublication.Checked = False
        Me.chkRegistration.Checked = False

        Me.chkAcademic.Checked = False
        Me.chkAnswer.Checked = False
        Me.chkComputer.Checked = False
        Me.chkCSC.Checked = False
        Me.chkDepartmental.Checked = False
        Me.chkInternet.Checked = False
        Me.chkPRISAA.Checked = False
        Me.chkStudent.Checked = False
        Me.chkTest.Checked = False

        Me.txtTotal.Text = "0.00"
        Me.txtBalance.Text = ""
        Me.btnSelectMisc.Text = "Select All"
        Me.btnSelectOther.Text = "Select All"
        Me.txtSearch.Text = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        connectAssess("SELECT * FROM assessment_table WHERE StudentID LIKE '" & Me.txtSearch.Text.Replace("'", "''") & "%'")
        dsAss.Tables("assessment_table").Clear()
        daAss.Fill(dsAss, rsAss, "assessment_table")
        dgvAssessment.DataSource = dsAss.Tables("assessment_table").DefaultView
    End Sub

    Private Sub Assessment_Table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        connectAssess("SELECT * FROM assessment_table")
        If dsAss.Tables.Contains("assessment_table") Then
            dsAss.Tables("assessment_table").Clear()
        End If
        daAss.Fill(dsAss, rsAss, "assessment_table")
        dgvAssessment.DataSource = dsAss.Tables("assessment_table").DefaultView

        Call burahin()
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
        txtStudentID.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim StudID As Integer
        Dim saved As Boolean = False

        Call kuwenta()

        If Len(Me.txtStudentID.Text) = 0 Then
            MsgBox("Please Enter Student ID!")
            Me.txtStudentID.Focus()
        ElseIf Not Integer.TryParse(Me.txtStudentID.Text.Trim(), StudID) Then
            MsgBox("Student ID Must Be a Number!")
            Me.txtStudentID.Focus()
        ElseIf tuitionTotal <= 0 Then
            MsgBox("Please Select the Tuition Fee!")
            Me.cmbTuition.Focus()

            'hiwalay
        Else
            Dim tuiText As String = tuitionTotal.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)
            Dim miscText As String = miscTotal.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)
            Dim othText As String = otherTotal.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)

            connectAssess("SELECT * FROM student_record WHERE StudentID='" & StudID & "'")

            If rsAss.EOF = True Then
                MsgBox("Student ID Not Found!")
                Me.txtStudentID.Focus()
            Else
                If saveRecord = True Then
                    connectAssess("SELECT * FROM assessment_table WHERE StudentID='" & StudID & "'")

                    If rsAss.EOF = False Then
                        MsgBox("This Student Already Has an Assessment!")
                    Else
                        rsAss.AddNew()
                        rsAss("StudentID").Value = StudID
                        rsAss("Tuition").Value = tuiText
                        rsAss("Miscellaneous").Value = miscText
                        rsAss("Otherfee").Value = othText
                        rsAss.Update()

                        MsgBox("Record Successfully Saved!")
                        saved = True
                    End If

                Else
                    connectAssess("SELECT * FROM assessment_table WHERE StudentID='" & StudID & "'")

                    If rsAss.EOF = True Then
                        MsgBox("This assessment no longer exists. It may have been deleted.")
                        Return
                    End If

                    Dim oldMisc As Decimal
                    Dim oldOther As Decimal
                    Decimal.TryParse(rsAss("Miscellaneous").Value & "", oldMisc)
                    Decimal.TryParse(rsAss("Otherfee").Value & "", oldOther)

                    If (miscTotal = 0 AndAlso oldMisc > 0) OrElse (otherTotal = 0 AndAlso oldOther > 0) Then
                        If MsgBox("One of the fee groups has no ticked fees, so it will be saved as 0.00. Continue?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
                            Return
                        End If
                    End If

                    rsAss("Tuition").Value = tuiText
                    rsAss("Miscellaneous").Value = miscText
                    rsAss("Otherfee").Value = othText
                    rsAss.Update()

                    MsgBox("Record Successfully Edited!")
                    saved = True
                End If
            End If
        End If

        If saved = True Then
            connectAssess("SELECT * FROM assessment_table")
            dsAss.Tables("assessment_table").Clear()
            daAss.Fill(dsAss, rsAss, "assessment_table")
            dgvAssessment.DataSource = dsAss.Tables("assessment_table").DefaultView

            Call dipwede()

            ' balance = total fees minus the payments recorded for this student
            Dim paid As Decimal = 0
            connectAssess("SELECT IFNULL(SUM(CAST(Amount AS DECIMAL(10,2))), 0) AS TotalPaid " & _
                        "FROM payment_table WHERE StudentID='" & StudID & "'")
            If rsAss.EOF = False Then
                paid = CDec(rsAss("TotalPaid").Value)
            End If
            Me.txtBalance.Text = (tuitionTotal + miscTotal + otherTotal - paid).ToString("N2")

            btnAdd.Enabled = True
            btnSave.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call pwede()
        Me.txtStudentID.Enabled = False
        btnSave.Enabled = True
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        saveRecord = False
        Me.cmbTuition.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strAns As MsgBoxResult
        strAns = MsgBox("Do you really want to delete this assessment?", MsgBoxStyle.YesNo)

        If strAns = MsgBoxResult.Yes Then
            connectAssess("DELETE FROM assessment_table WHERE StudentID='" & Me.txtStudentID.Text & "'")
            connectAssess("SELECT * FROM assessment_table")
            dsAss.Tables("assessment_table").Clear()
            daAss.Fill(dsAss, rsAss, "assessment_table")
            dgvAssessment.DataSource = dsAss.Tables("assessment_table").DefaultView

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
        txtStudentID.Focus()
    End Sub

    Private Sub btnSelectMisc_Click(sender As Object, e As EventArgs) Handles btnSelectMisc.Click
        Dim tick As Boolean = (Me.btnSelectMisc.Text = "Select All")

        Me.chkAthletic.Checked = tick
        Me.chkAudio.Checked = tick
        Me.chkGuidance.Checked = tick
        Me.chkID.Checked = tick
        Me.chkInsurance.Checked = tick
        Me.chkLibrary.Checked = tick
        Me.chkMedical.Checked = tick
        Me.chkPublication.Checked = tick
        Me.chkRegistration.Checked = tick

        If tick = True Then
            Me.btnSelectMisc.Text = "Unselect All"
        Else
            Me.btnSelectMisc.Text = "Select All"
        End If
    End Sub

    Private Sub btnSelectOther_Click(sender As Object, e As EventArgs) Handles btnSelectOther.Click
        Dim tick As Boolean = (Me.btnSelectOther.Text = "Select All")

        Me.chkAcademic.Checked = tick
        Me.chkAnswer.Checked = tick
        Me.chkComputer.Checked = tick
        Me.chkCSC.Checked = tick
        Me.chkDepartmental.Checked = tick
        Me.chkInternet.Checked = tick
        Me.chkPRISAA.Checked = tick
        Me.chkStudent.Checked = tick
        Me.chkTest.Checked = tick

        If tick = True Then
            Me.btnSelectOther.Text = "Unselect All"
        Else
            Me.btnSelectOther.Text = "Select All"
        End If
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        connectAssess("SELECT * FROM assessment_table")
        dsAss.Tables("assessment_table").Clear()
        daAss.Fill(dsAss, rsAss, "assessment_table")
        dgvAssessment.DataSource = dsAss.Tables("assessment_table").DefaultView
        Me.txtSearch.Text = ""
    End Sub

    Private Sub dgvAssessment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAssessment.CellContentClick

    End Sub

    Private Sub dgvAssessment_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAssessment.RowHeaderMouseClick
        Dim strer As String
        Dim keepSearch As String = Me.txtSearch.Text

        strer = dgvAssessment.Rows(e.RowIndex).Cells("StudentID").Value
        connectAssess("SELECT * FROM assessment_table WHERE StudentID ='" & strer & "'")

        If rsAss.EOF = False Then
            Dim t As Decimal
            Dim m As Decimal
            Dim o As Decimal
            Dim paid As Decimal = 0
            Decimal.TryParse(rsAss("Tuition").Value & "", t)
            Decimal.TryParse(rsAss("Miscellaneous").Value & "", m)
            Decimal.TryParse(rsAss("Otherfee").Value & "", o)

            Call burahin()
            Me.txtSearch.Text = keepSearch
            Me.txtStudentID.Text = strer
            Me.cmbTuition.Text = t.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)

            ' balance = total fees minus the payments recorded for this student
            connectAssess("SELECT IFNULL(SUM(CAST(Amount AS DECIMAL(10,2))), 0) AS TotalPaid " & _
                        "FROM payment_table WHERE StudentID='" & strer & "'")
            If rsAss.EOF = False Then
                paid = CDec(rsAss("TotalPaid").Value)
            End If

            Me.txtTotal.Text = (t + m + o).ToString("N2")
            Me.txtBalance.Text = (t + m + o - paid).ToString("N2")

            Call dipwede()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub cmbTuition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTuition.SelectedIndexChanged

    End Sub
End Class