Public Class Payment_Form
    Dim rcptBalance As Double
    Dim rcptFees As Double

    Private Sub pwede()
        Me.txtPaymentID.Enabled = True
        Me.txtStudentID.Enabled = True
        Me.txtAmount.Enabled = True
        Me.cmbReceive.Enabled = True
        Me.dtpPayment.Enabled = True
        Me.txtSearch.Enabled = True
    End Sub

    Private Sub dipwede()
        Me.txtPaymentID.Enabled = False
        Me.txtStudentID.Enabled = False
        Me.txtAmount.Enabled = False
        Me.cmbReceive.Enabled = False
        Me.dtpPayment.Enabled = False
    End Sub

    Private Sub burahin()
        Me.txtPaymentID.Text = ""
        Me.txtStudentID.Text = ""
        Me.lblStudentName.Text = ""
        Me.lblTotal.Text = ""
        Me.lblPaid.Text = ""
        Me.lblBalance.Text = ""
        Me.txtAmount.Text = ""
        Me.cmbReceive.Text = ""
        Me.dtpPayment.Value = Date.Today
        Me.txtSearch.Text = ""
    End Sub

    Private Sub Payment_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()

        If UserRole = "Registrar" Then
            btnAdd.Visible = False
            btnSave.Visible = False
            btnUpdate.Visible = False
            btnDelete.Visible = False
            Receipt.Visible = False
        Else
            btnAdd.Visible = True
            btnSave.Visible = True
            btnUpdate.Visible = True
            btnDelete.Visible = True
            Receipt.Visible = True
        End If

        Me.cmbReceive.Items.Clear()
        connectPayment("SELECT CashierFname, CashierLname FROM cashier_record ORDER BY CashierLname")
        Do While rsPay.EOF = False
            Me.cmbReceive.Items.Add(rsPay("CashierFname").Value & " " & rsPay("CashierLname").Value)
            rsPay.MoveNext()
        Loop

        connectPayment("SELECT * FROM payment_table")
        If dsPay.Tables.Contains("payment_table") Then
            dsPay.Tables("payment_table").Clear()
        End If
        daPay.Fill(dsPay, rsPay, "payment_table")
        dgvPayment.DataSource = dsPay.Tables("payment_table").DefaultView

        Me.dtpPayment.MaxDate = Date.Today

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
        txtPaymentID.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim pid As Integer
        Dim sid As Integer
        Dim amt As Decimal
        Dim saved As Boolean = False

        If Len(Me.txtPaymentID.Text) = 0 Then
            MsgBox("Please Enter Payment ID!")
            Me.txtPaymentID.Focus()
        ElseIf Not Integer.TryParse(Me.txtPaymentID.Text.Trim(), pid) Then
            MsgBox("Payment ID Must Be a Number!")
            Me.txtPaymentID.Focus()
        ElseIf Len(Me.txtStudentID.Text) = 0 Then
            MsgBox("Please Enter Student ID!")
            Me.txtStudentID.Focus()
        ElseIf Not Integer.TryParse(Me.txtStudentID.Text.Trim(), sid) Then
            MsgBox("Student ID Must Be a Number!")
            Me.txtStudentID.Focus()
        ElseIf Not Decimal.TryParse(Me.txtAmount.Text.Trim(), amt) OrElse amt <= 0 Then
            MsgBox("Please Enter a Valid Amount!")
            Me.txtAmount.Focus()
        ElseIf Len(Me.cmbReceive.Text.Trim()) = 0 Then
            MsgBox("Please Enter Who Received the Payment!")
            Me.cmbReceive.Focus()
        Else
            amt = Math.Round(amt, 2)
            Dim amtText As String = amt.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)

            connectPayment("SELECT * FROM student_record WHERE StudentID='" & sid & "'")

            If rsPay.EOF = True Then
                MsgBox("Student ID Not Found!")
                Me.txtStudentID.Focus()
            Else
                connectPayment("SELECT * FROM assessment_table WHERE StudentID='" & sid & "'")

                If rsPay.EOF = True Then
                    MsgBox("This student has no assessment yet! The registrar must assess the student first.")
                    Me.txtStudentID.Focus()
                Else
                    If saveRecord = True Then
                        connectPayment("SELECT * FROM payment_table WHERE PaymentID='" & pid & "'")

                        If rsPay.EOF = False Then
                            MsgBox("Record Already Exists!")
                        Else
                            rsPay.AddNew()
                            rsPay("PaymentID").Value = pid
                            rsPay("StudentID").Value = sid
                            rsPay("Amount").Value = amtText
                            rsPay("ReceivedBy").Value = Me.cmbReceive.Text.Trim()
                            rsPay("PaymentDate").Value = Me.dtpPayment.Value.ToString("yyyy-MM-dd")
                            rsPay.Update()

                            MsgBox("Record Successfully Saved!")
                            saved = True
                        End If
                    Else
                        connectPayment("SELECT * FROM payment_table WHERE PaymentID='" & pid & "'")

                        rsPay("StudentID").Value = sid
                        rsPay("Amount").Value = amtText
                        rsPay("ReceivedBy").Value = Me.cmbReceive.Text.Trim()
                        rsPay("PaymentDate").Value = Me.dtpPayment.Value.ToString("yyyy-MM-dd")
                        rsPay.Update()

                        MsgBox("Record Successfully Edited!")
                        saved = True
                    End If
                End If
            End If
        End If

        If saved = True Then
            connectPayment("SELECT * FROM payment_table")
            dsPay.Tables("payment_table").Clear()
            daPay.Fill(dsPay, rsPay, "payment_table")
            dgvPayment.DataSource = dsPay.Tables("payment_table").DefaultView

            Call dipwede()

            ' refresh the balance label
            Dim fees As Decimal = 0
            Dim paid As Decimal = 0
            Me.lblTotal.Text = ""
            Me.lblPaid.Text = ""
            Me.lblBalance.Text = ""

            connectPayment("SELECT IFNULL(CAST(Tuition AS DECIMAL(10,2)) + CAST(Miscellaneous AS DECIMAL(10,2)) + " & _
                        "CAST(Otherfee AS DECIMAL(10,2)), 0) AS TotalFees " & _
                        "FROM assessment_table WHERE StudentID='" & sid & "'")
            If rsPay.EOF = True Then
                Me.lblTotal.Text = "No assessment found for this student"
            Else
                fees = CDec(rsPay("TotalFees").Value)

                connectPayment("SELECT IFNULL(SUM(CAST(Amount AS DECIMAL(10,2))), 0) AS TotalPaid " & _
                            "FROM payment_table WHERE StudentID='" & sid & "'")
                If rsPay.EOF = False Then
                    paid = CDec(rsPay("TotalPaid").Value)
                End If

                Me.lblTotal.Text = fees.ToString("N2")
                Me.lblPaid.Text = paid.ToString("N2")
                Me.lblBalance.Text = (fees - paid).ToString("N2")
            End If

            btnAdd.Enabled = True
            btnSave.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call pwede()
        Me.txtPaymentID.Enabled = False
        btnSave.Enabled = True
        btnAdd.Enabled = True
        btnDelete.Enabled = False
        saveRecord = False
        Me.txtStudentID.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim strAns As MsgBoxResult
        strAns = MsgBox("Do you really want to delete this payment?", MsgBoxStyle.YesNo)

        If strAns = MsgBoxResult.Yes Then
            connectPayment("DELETE FROM payment_table WHERE PaymentID='" & Me.txtPaymentID.Text & "'")
            connectPayment("SELECT * FROM payment_table")
            dsPay.Tables("payment_table").Clear()
            daPay.Fill(dsPay, rsPay, "payment_table")
            dgvPayment.DataSource = dsPay.Tables("payment_table").DefaultView

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
        txtPaymentID.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim s As String = Me.txtSearch.Text.Replace("'", "''")
        connectPayment("SELECT * FROM payment_table WHERE StudentID LIKE '" & s & "%' OR PaymentID LIKE '" & s & "%'")
        dsPay.Tables("payment_table").Clear()
        daPay.Fill(dsPay, rsPay, "payment_table")
        dgvPayment.DataSource = dsPay.Tables("payment_table").DefaultView
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        connectPayment("SELECT * FROM payment_table")
        dsPay.Tables("payment_table").Clear()
        daPay.Fill(dsPay, rsPay, "payment_table")
        dgvPayment.DataSource = dsPay.Tables("payment_table").DefaultView
        Me.txtSearch.Text = ""
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        Dim sid As Integer
        Dim fees As Decimal = 0
        Dim paid As Decimal = 0

        Me.lblStudentName.Text = ""
        Me.lblTotal.Text = ""
        Me.lblPaid.Text = ""
        Me.lblBalance.Text = ""

        If Integer.TryParse(Me.txtStudentID.Text.Trim(), sid) Then
            connectPayment("SELECT StudFirstName, StudLastName FROM student_record WHERE StudentID='" & sid & "'")
            If rsPay.EOF = True Then
                Me.lblStudentName.Text = "Student not found"
                Return
            End If
            Me.lblStudentName.Text = rsPay("StudFirstName").Value & " " & rsPay("StudLastName").Value

            connectPayment("SELECT IFNULL(CAST(Tuition AS DECIMAL(10,2)) + CAST(Miscellaneous AS DECIMAL(10,2)) + " & _
                        "CAST(Otherfee AS DECIMAL(10,2)), 0) AS TotalFees " & _
                        "FROM assessment_table WHERE StudentID='" & sid & "'")
            If rsPay.EOF = True Then
                Me.lblTotal.Text = "No assessment found for this student"
                Return
            End If
            fees = CDec(rsPay("TotalFees").Value)

            connectPayment("SELECT IFNULL(SUM(CAST(Amount AS DECIMAL(10,2))), 0) AS TotalPaid " & _
                        "FROM payment_table WHERE StudentID='" & sid & "'")
            If rsPay.EOF = False Then
                paid = CDec(rsPay("TotalPaid").Value)
            End If

            Me.lblTotal.Text = fees.ToString("N2")
            Me.lblPaid.Text = paid.ToString("N2")
            Me.lblBalance.Text = (fees - paid).ToString("N2")
        End If
    End Sub

    Private Sub dgvPayment_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPayment.RowHeaderMouseClick
        Dim strer As String
        Dim d As Date

        strer = dgvPayment.Rows(e.RowIndex).Cells("PaymentID").Value
        connectPayment("SELECT * FROM payment_table WHERE PaymentID ='" & strer & "'")

        If rsPay.EOF = False Then
            Me.txtPaymentID.Text = rsPay("PaymentID").Value & ""
            Me.txtAmount.Text = rsPay("Amount").Value & ""
            Me.cmbReceive.Text = rsPay("ReceivedBy").Value & ""


            If Date.TryParse(rsPay("PaymentDate").Value & "", d) AndAlso d <= Date.Today Then
                Me.dtpPayment.Value = d
            Else
                Me.dtpPayment.Value = Date.Today
            End If

            Me.txtStudentID.Text = rsPay("StudentID").Value & ""

            Call dipwede()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub lblBalance_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub dgvPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayment.CellContentClick

    End Sub

    Private Sub Receipt_Click(sender As Object, e As EventArgs) Handles Receipt.Click
        Dim pid As Integer
        Dim sid As Integer
        Dim Paidsss As Decimal = 0
        Dim Balancesss As Decimal = 0

        ' the payment must be saved first
        If Not Integer.TryParse(Me.txtPaymentID.Text.Trim(), pid) Then
            MsgBox("Select or save a payment first!")
            Return
        End If
        connectPayment("SELECT * FROM payment_table WHERE PaymentID='" & pid & "'")
        If rsPay.EOF = True Then
            MsgBox("Please save the payment first!")
            Return
        End If

        If Not Integer.TryParse(Me.txtStudentID.Text.Trim(), sid) Then
            MsgBox("Please enter a valid Student ID!")
            Return
        End If

        Decimal.TryParse(lblPaid.Text, Paidsss)
        Decimal.TryParse(lblBalance.Text, Balancesss)

        connectPayment("SELECT StudFirstName, StudMiddleName, StudLastName FROM student_record WHERE StudentID='" & sid & "'")
        If rsPay.EOF = True Then
            Me.lblStudentName.Text = "Student not found"
            Return
        End If

        Dim fullName As String = rsPay("StudLastName").Value & ", " & rsPay("StudFirstName").Value & " " & rsPay("StudMiddleName").Value

        MsgBox("Mary The Queen Colleges" & vbCrLf _
               & "OFFICIAL RECEIPT" & vbCrLf _
               & "===================" & vbCrLf _
               & "Receipt No: " & txtPaymentID.Text & vbCrLf _
               & "Payment date: " & dtpPayment.Value.ToShortDateString() & vbCrLf _
               & "Student ID: " & txtStudentID.Text & vbCrLf _
               & "Student Name: " & fullName.Trim() & vbCrLf _
               & "===================" & vbCrLf _
               & "Amount Paid: " & txtAmount.Text & vbCrLf _
               & "Total Paid: " & Paidsss.ToString("N2") & vbCrLf _
               & "Balance: " & Balancesss.ToString("N2") & vbCrLf _
               & "Received By: " & cmbReceive.Text & vbCrLf _
               & "Issued on: " & Date.Now.ToString("yyyy-MM-dd HH:mm"), _
               MsgBoxStyle.Information, "Receipt")
    End Sub

End Class