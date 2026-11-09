Public Class frmStudent

    Private isChanged As Boolean = False

    Private Function CalculateAge(ByVal birthDate As Date) As Integer
        Dim age As Integer = Date.Today.Year - birthDate.Year

        If birthDate.Date > Date.Today.AddYears(-age) Then
            age -= 1
        End If

        Return age
    End Function

    Private Sub MayBinago() Handles txtStudentID.TextChanged, txtFirstName.TextChanged, txtMiddleName.TextChanged, _
        txtLastName.TextChanged, dtpBirthDate.ValueChanged, cboGender.TextChanged, txtPlaceOfBirth.TextChanged, _
        txtAddress.TextChanged, txtMotherName.TextChanged, txtFatherName.TextChanged, txtContactNo.TextChanged

        isChanged = True
    End Sub

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()

        If UserRole = "Cashier" Then
            btnAdd.Visible = False
            btnSave.Visible = False
            btnUpdate.Visible = False
            btnDelete.Visible = False
        Else
            btnAdd.Visible = True
            btnSave.Visible = True
            btnUpdate.Visible = True
            btnDelete.Visible = True
        End If

        connectStud("SELECT * FROM student_record")
        daStud.Fill(dsStud, rsStud, "student_record")
        dgvStudents.DataSource = dsStud.Tables("student_record").DefaultView

        Call burahin()
        Call dipwede()
        btnSave.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        connectStud("SELECT * FROM Student_record WHERE StudLastName  LIKE '" & Me.txtSearch.Text.Replace("'", "''") & "%'")
        dsStud.Tables("Student_record").Clear()
        daStud.Fill(dsStud, rsStud, "Student_record")
        dgvStudents.DataSource = dsStud.Tables("Student_record").DefaultView
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Len(Me.txtStudentID.Text.Trim()) = 0 AndAlso _
            Len(Me.txtLastName.Text.Trim()) = 0 AndAlso _
            Len(Me.txtFirstName.Text.Trim()) = 0 AndAlso _
            Len(Me.txtMiddleName.Text.Trim()) = 0 AndAlso _
            Len(Me.cboGender.Text.Trim()) = 0 AndAlso _
            Len(Me.txtPlaceOfBirth.Text.Trim()) = 0 AndAlso _
            Len(Me.txtAddress.Text.Trim()) = 0 AndAlso _
            Len(Me.txtMotherName.Text.Trim()) = 0 AndAlso _
            Len(Me.txtFatherName.Text.Trim()) = 0 AndAlso _
            Len(Me.txtContactNo.Text.Trim()) = 0 Then
            MsgBox("The form is empty!")
            Me.txtStudentID.Focus()

        ElseIf saveRecord = True Then
            If Len(Me.txtStudentID.Text) = 0 Then
                MsgBox("Please Enter Student ID!")
                Me.txtStudentID.Focus()
            ElseIf Len(Me.txtLastName.Text) = 0 Then
                MsgBox("Please Enter Last Name!")
                Me.txtLastName.Focus()
            ElseIf Len(Me.txtFirstName.Text) = 0 Then
                MsgBox("Please Enter First Name!")
                Me.txtFirstName.Focus()
            ElseIf Len(Me.txtMiddleName.Text) = 0 Then
                MsgBox("Please Enter Middle Name!")
                Me.txtMiddleName.Focus()
            ElseIf Len(Me.cboGender.Text) = 0 Then
                MsgBox("Please Enter Gender!")
                Me.cboGender.Focus()
            ElseIf Len(Me.txtPlaceOfBirth.Text) = 0 Then
                MsgBox("Please Enter Place of Birth!")
                Me.txtPlaceOfBirth.Focus()
            ElseIf Len(Me.txtAddress.Text) = 0 Then
                MsgBox("Please Enter Address!")
                Me.txtAddress.Focus()
            ElseIf Len(Me.txtMotherName.Text) = 0 Then
                MsgBox("Please Enter Mother's Name!")
                Me.txtMotherName.Focus()
            ElseIf Len(Me.txtFatherName.Text) = 0 Then
                MsgBox("Please Enter Father's Name!")
                Me.txtFatherName.Focus()
            ElseIf Len(Me.txtContactNo.Text) = 0 Then
                MsgBox("Please Enter Contact Number!")
                Me.txtContactNo.Focus()
            Else
                Dim birthDate As Date = Me.dtpBirthDate.Value
                Dim age As Integer = Date.Today.Year - birthDate.Year

                If birthDate.Date > Date.Today.AddYears(-age) Then
                    age -= 1
                End If

                connectStud("SELECT * FROM student_record WHERE StudentID='" & Me.txtStudentID.Text & "'")

                If rsStud.EOF = False Then
                    MsgBox("Record Already Exists!")
                Else
                    rsStud.AddNew()
                    rsStud("StudentID").Value = Me.txtStudentID.Text
                    rsStud("StudFirstName").Value = Me.txtFirstName.Text
                    rsStud("StudMiddleName").Value = Me.txtMiddleName.Text
                    rsStud("StudLastName").Value = Me.txtLastName.Text
                    rsStud("Bday").Value = birthDate.Day
                    rsStud("BMonth").Value = birthDate.Month
                    rsStud("BYear").Value = birthDate.Year
                    rsStud("Age").Value = age
                    rsStud("Gender").Value = Me.cboGender.Text
                    rsStud("PlaceofBirth").Value = Me.txtPlaceOfBirth.Text
                    rsStud("Address").Value = Me.txtAddress.Text
                    rsStud("MotherName").Value = Me.txtMotherName.Text
                    rsStud("FatherName").Value = Me.txtFatherName.Text
                    rsStud("ContactNo.").Value = Me.txtContactNo.Text
                    rsStud.Update()

                    MsgBox("Record Successfully Saved!")

                    connectStud("SELECT * FROM student_record")
                    dsStud.Tables("student_record").Clear()
                    daStud.Fill(dsStud, rsStud, "student_record")
                    dgvStudents.DataSource = dsStud.Tables("student_record").DefaultView

                    Call dipwede()

                    btnSave.Enabled = False
                    btnUpdate.Enabled = False
                    btnDelete.Enabled = False
                End If
            End If
        ElseIf saveRecord = False AndAlso isChanged = True Then

            connectStud("SELECT * FROM student_record WHERE StudentID='" & Me.txtStudentID.Text & "'")
            If rsStud.EOF = True Then
                MsgBox("That student no longer exists.")
                Return
            End If

            Dim birthDate As Date = Me.dtpBirthDate.Value
            Dim age As Integer = Date.Today.Year - birthDate.Year

            If birthDate.Date > Date.Today.AddYears(-age) Then
                age -= 1
            End If

            rsStud("StudentID").Value = Me.txtStudentID.Text
            rsStud("StudFirstName").Value = Me.txtFirstName.Text
            rsStud("StudMiddleName").Value = Me.txtMiddleName.Text
            rsStud("StudLastName").Value = Me.txtLastName.Text
            rsStud("Bday").Value = birthDate.Day
            rsStud("BMonth").Value = birthDate.Month
            rsStud("BYear").Value = birthDate.Year
            rsStud("Age").Value = age
            rsStud("Gender").Value = Me.cboGender.Text
            rsStud("PlaceofBirth").Value = Me.txtPlaceOfBirth.Text
            rsStud("Address").Value = Me.txtAddress.Text
            rsStud("MotherName").Value = Me.txtMotherName.Text
            rsStud("FatherName").Value = Me.txtFatherName.Text
            rsStud("ContactNo.").Value = Me.txtContactNo.Text
            rsStud.Update()

            MsgBox("Record Successfully Edited!")

            connectStud("SELECT * FROM student_record")
            dsStud.Tables("student_record").Clear()
            daStud.Fill(dsStud, rsStud, "student_record")
            dgvStudents.DataSource = dsStud.Tables("student_record").DefaultView

            Call dipwede()

            btnAdd.Enabled = True
            btnSave.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        Else
            MsgBox("No changes were made!")

        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call pwede()
        btnSave.Enabled = True
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        saveRecord = False
        Me.txtStudentID.Enabled = False
        txtStudentID.Focus()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim strAns As String
        strAns = MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo)

        If strAns = vbYes Then
            connectStud("DELETE FROM student_record WHERE StudentID='" & Me.txtStudentID.Text & "'")
            connectStud("SELECT * FROM student_record")
            dsStud.Tables("Student_record").Clear()
            daStud.Fill(dsStud, rsStud, "student_record")
            dgvStudents.DataSource = dsStud.Tables("student_record").DefaultView
            btnAdd.Enabled = True
            Call burahin()
        End If
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        connectStud("SELECT * FROM student_record")
        dsStud.Tables("student_record").Clear()
        daStud.Fill(dsStud, rsStud, "student_record")
        dgvStudents.DataSource = dsStud.Tables("student_record").DefaultView
    End Sub
    Private Sub pwede()
        Me.txtStudentID.Enabled = True
        Me.txtFirstName.Enabled = True
        Me.txtMiddleName.Enabled = True
        Me.txtLastName.Enabled = True
        Me.dtpBirthDate.Enabled = True
        Me.cboGender.Enabled = True
        Me.txtPlaceOfBirth.Enabled = True
        Me.txtAddress.Enabled = True
        Me.txtMotherName.Enabled = True
        Me.txtFatherName.Enabled = True
        Me.txtContactNo.Enabled = True
        Me.txtSearch.Enabled = True


    End Sub

    Private Sub dipwede()
        Me.txtStudentID.Enabled = False
        Me.txtFirstName.Enabled = False
        Me.txtMiddleName.Enabled = False
        Me.txtLastName.Enabled = False
        Me.dtpBirthDate.Enabled = False
        Me.cboGender.Enabled = False
        Me.txtPlaceOfBirth.Enabled = False
        Me.txtAddress.Enabled = False
        Me.txtMotherName.Enabled = False
        Me.txtFatherName.Enabled = False
        Me.txtContactNo.Enabled = False

    End Sub

    Private Sub burahin()
        Me.txtStudentID.Text = ""
        Me.txtFirstName.Text = ""
        Me.txtMiddleName.Text = ""
        Me.txtLastName.Text = ""
        Me.dtpBirthDate.Value = Date.Today
        Me.cboGender.SelectedIndex = -1
        Me.txtPlaceOfBirth.Text = ""
        Me.txtAddress.Text = ""
        Me.txtMotherName.Text = ""
        Me.txtFatherName.Text = ""
        Me.txtContactNo.Text = ""
        Me.txtSearch.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call pwede()
        Call burahin()
        btnSave.Enabled = True
        saveRecord = True
        txtStudentID.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call burahin()
        txtStudentID.Focus()
    End Sub

    Private Sub dgvStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick

    End Sub

    Private Sub dgvStudents_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvStudents.RowHeaderMouseClick
        Dim strer As String

        strer = dgvStudents.SelectedCells.Item(0).Value
        connectStud("SELECT * FROM student_record WHERE StudentID ='" & strer & "'")

        If rsStud.EOF = False Then
            Me.txtStudentID.Text = rsStud("StudentID").Value
            Me.txtFirstName.Text = rsStud("StudFirstName").Value
            Me.txtMiddleName.Text = rsStud("StudMiddleName").Value
            Me.txtLastName.Text = rsStud("StudLastName").Value

            Dim Bday As Integer = CInt(rsStud("Bday").Value)
            Dim BMonth As Integer = CInt(rsStud("BMonth").Value)
            Dim BYear As Integer = CInt(rsStud("BYear").Value)

            Me.dtpBirthDate.Value = New Date(BYear, BMonth, Bday)
            Me.cboGender.Text = rsStud("Gender").Value
            Me.txtPlaceOfBirth.Text = rsStud("PlaceofBirth").Value
            Me.txtAddress.Text = rsStud("Address").Value
            Me.txtMotherName.Text = rsStud("MotherName").Value
            Me.txtFatherName.Text = rsStud("FatherName").Value
            Me.txtContactNo.Text = rsStud("ContactNo.").Value

            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            isChanged = False
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
End Class
