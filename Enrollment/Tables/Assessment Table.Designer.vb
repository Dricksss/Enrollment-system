<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assessment_Table
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assessment_Table))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbTuition = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpMisc = New System.Windows.Forms.GroupBox()
        Me.btnSelectMisc = New System.Windows.Forms.Button()
        Me.chkRegistration = New System.Windows.Forms.CheckBox()
        Me.chkPublication = New System.Windows.Forms.CheckBox()
        Me.chkMedical = New System.Windows.Forms.CheckBox()
        Me.chkLibrary = New System.Windows.Forms.CheckBox()
        Me.chkInsurance = New System.Windows.Forms.CheckBox()
        Me.chkID = New System.Windows.Forms.CheckBox()
        Me.chkGuidance = New System.Windows.Forms.CheckBox()
        Me.chkAudio = New System.Windows.Forms.CheckBox()
        Me.chkAthletic = New System.Windows.Forms.CheckBox()
        Me.grpOther = New System.Windows.Forms.GroupBox()
        Me.btnSelectOther = New System.Windows.Forms.Button()
        Me.chkTest = New System.Windows.Forms.CheckBox()
        Me.chkAcademic = New System.Windows.Forms.CheckBox()
        Me.chkStudent = New System.Windows.Forms.CheckBox()
        Me.chkAnswer = New System.Windows.Forms.CheckBox()
        Me.chkPrisaa = New System.Windows.Forms.CheckBox()
        Me.chkComputer = New System.Windows.Forms.CheckBox()
        Me.chkInternet = New System.Windows.Forms.CheckBox()
        Me.chkCSC = New System.Windows.Forms.CheckBox()
        Me.chkDepartmental = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvAssessment = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.grpMisc.SuspendLayout()
        Me.grpOther.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvAssessment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbTuition)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtBalance)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtStudentID)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(531, 169)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Information"
        '
        'cmbTuition
        '
        Me.cmbTuition.FormattingEnabled = True
        Me.cmbTuition.Items.AddRange(New Object() {"₱26,573.42 (Fixed)"})
        Me.cmbTuition.Location = New System.Drawing.Point(108, 101)
        Me.cmbTuition.Name = "cmbTuition"
        Me.cmbTuition.Size = New System.Drawing.Size(142, 24)
        Me.cmbTuition.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(281, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Balance: "
        '
        'txtBalance
        '
        Me.txtBalance.Enabled = False
        Me.txtBalance.Location = New System.Drawing.Point(363, 101)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(142, 22)
        Me.txtBalance.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Total: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Student ID: "
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(361, 36)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(142, 22)
        Me.txtTotal.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Tuition Fee: "
        '
        'txtStudentID
        '
        Me.txtStudentID.Enabled = False
        Me.txtStudentID.Location = New System.Drawing.Point(108, 36)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(142, 22)
        Me.txtStudentID.TabIndex = 34
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(551, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(169, 28)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(551, 150)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(169, 28)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(551, 116)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(169, 28)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(551, 82)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(169, 28)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(551, 48)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(169, 28)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grpMisc
        '
        Me.grpMisc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMisc.Controls.Add(Me.btnSelectMisc)
        Me.grpMisc.Controls.Add(Me.chkRegistration)
        Me.grpMisc.Controls.Add(Me.chkPublication)
        Me.grpMisc.Controls.Add(Me.chkMedical)
        Me.grpMisc.Controls.Add(Me.chkLibrary)
        Me.grpMisc.Controls.Add(Me.chkInsurance)
        Me.grpMisc.Controls.Add(Me.chkID)
        Me.grpMisc.Controls.Add(Me.chkGuidance)
        Me.grpMisc.Controls.Add(Me.chkAudio)
        Me.grpMisc.Controls.Add(Me.chkAthletic)
        Me.grpMisc.Location = New System.Drawing.Point(14, 187)
        Me.grpMisc.MaximumSize = New System.Drawing.Size(343, 203)
        Me.grpMisc.Name = "grpMisc"
        Me.grpMisc.Size = New System.Drawing.Size(343, 203)
        Me.grpMisc.TabIndex = 2
        Me.grpMisc.TabStop = False
        Me.grpMisc.Text = "Miscellaneous Fees"
        '
        'btnSelectMisc
        '
        Me.btnSelectMisc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectMisc.Location = New System.Drawing.Point(7, 174)
        Me.btnSelectMisc.Name = "btnSelectMisc"
        Me.btnSelectMisc.Size = New System.Drawing.Size(330, 23)
        Me.btnSelectMisc.TabIndex = 29
        Me.btnSelectMisc.Text = "Select All"
        Me.btnSelectMisc.UseVisualStyleBackColor = True
        '
        'chkRegistration
        '
        Me.chkRegistration.AutoSize = True
        Me.chkRegistration.Location = New System.Drawing.Point(189, 112)
        Me.chkRegistration.Name = "chkRegistration"
        Me.chkRegistration.Size = New System.Drawing.Size(150, 21)
        Me.chkRegistration.TabIndex = 8
        Me.chkRegistration.Text = "Registration Fee"
        Me.chkRegistration.UseVisualStyleBackColor = True
        '
        'chkPublication
        '
        Me.chkPublication.AutoSize = True
        Me.chkPublication.Location = New System.Drawing.Point(189, 85)
        Me.chkPublication.Name = "chkPublication"
        Me.chkPublication.Size = New System.Drawing.Size(142, 21)
        Me.chkPublication.TabIndex = 7
        Me.chkPublication.Text = "Publication Fee"
        Me.chkPublication.UseVisualStyleBackColor = True
        '
        'chkMedical
        '
        Me.chkMedical.AutoSize = True
        Me.chkMedical.Location = New System.Drawing.Point(189, 58)
        Me.chkMedical.Name = "chkMedical"
        Me.chkMedical.Size = New System.Drawing.Size(117, 21)
        Me.chkMedical.TabIndex = 6
        Me.chkMedical.Text = "Medical Fee"
        Me.chkMedical.UseVisualStyleBackColor = True
        '
        'chkLibrary
        '
        Me.chkLibrary.AutoSize = True
        Me.chkLibrary.Location = New System.Drawing.Point(189, 31)
        Me.chkLibrary.Name = "chkLibrary"
        Me.chkLibrary.Size = New System.Drawing.Size(113, 21)
        Me.chkLibrary.TabIndex = 5
        Me.chkLibrary.Text = "Library Fee"
        Me.chkLibrary.UseVisualStyleBackColor = True
        '
        'chkInsurance
        '
        Me.chkInsurance.AutoSize = True
        Me.chkInsurance.Location = New System.Drawing.Point(12, 139)
        Me.chkInsurance.Name = "chkInsurance"
        Me.chkInsurance.Size = New System.Drawing.Size(133, 21)
        Me.chkInsurance.TabIndex = 4
        Me.chkInsurance.Text = "Insurance Fee"
        Me.chkInsurance.UseVisualStyleBackColor = True
        '
        'chkID
        '
        Me.chkID.AutoSize = True
        Me.chkID.Location = New System.Drawing.Point(12, 112)
        Me.chkID.Name = "chkID"
        Me.chkID.Size = New System.Drawing.Size(77, 21)
        Me.chkID.TabIndex = 3
        Me.chkID.Text = "ID Fee"
        Me.chkID.UseVisualStyleBackColor = True
        '
        'chkGuidance
        '
        Me.chkGuidance.AutoSize = True
        Me.chkGuidance.Location = New System.Drawing.Point(12, 85)
        Me.chkGuidance.Name = "chkGuidance"
        Me.chkGuidance.Size = New System.Drawing.Size(131, 21)
        Me.chkGuidance.TabIndex = 2
        Me.chkGuidance.Text = "Guidance Fee"
        Me.chkGuidance.UseVisualStyleBackColor = True
        '
        'chkAudio
        '
        Me.chkAudio.AutoSize = True
        Me.chkAudio.Location = New System.Drawing.Point(12, 58)
        Me.chkAudio.Name = "chkAudio"
        Me.chkAudio.Size = New System.Drawing.Size(152, 21)
        Me.chkAudio.TabIndex = 1
        Me.chkAudio.Text = "Audio Visual Fee"
        Me.chkAudio.UseVisualStyleBackColor = True
        '
        'chkAthletic
        '
        Me.chkAthletic.AutoSize = True
        Me.chkAthletic.Location = New System.Drawing.Point(12, 31)
        Me.chkAthletic.Name = "chkAthletic"
        Me.chkAthletic.Size = New System.Drawing.Size(116, 21)
        Me.chkAthletic.TabIndex = 0
        Me.chkAthletic.Text = "Athletic Fee"
        Me.chkAthletic.UseVisualStyleBackColor = True
        '
        'grpOther
        '
        Me.grpOther.Controls.Add(Me.btnSelectOther)
        Me.grpOther.Controls.Add(Me.chkTest)
        Me.grpOther.Controls.Add(Me.chkAcademic)
        Me.grpOther.Controls.Add(Me.chkStudent)
        Me.grpOther.Controls.Add(Me.chkAnswer)
        Me.grpOther.Controls.Add(Me.chkPrisaa)
        Me.grpOther.Controls.Add(Me.chkComputer)
        Me.grpOther.Controls.Add(Me.chkInternet)
        Me.grpOther.Controls.Add(Me.chkCSC)
        Me.grpOther.Controls.Add(Me.chkDepartmental)
        Me.grpOther.Location = New System.Drawing.Point(377, 187)
        Me.grpOther.Name = "grpOther"
        Me.grpOther.Size = New System.Drawing.Size(343, 203)
        Me.grpOther.TabIndex = 3
        Me.grpOther.TabStop = False
        Me.grpOther.Text = "Other Fees"
        '
        'btnSelectOther
        '
        Me.btnSelectOther.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectOther.Location = New System.Drawing.Point(7, 174)
        Me.btnSelectOther.Name = "btnSelectOther"
        Me.btnSelectOther.Size = New System.Drawing.Size(330, 23)
        Me.btnSelectOther.TabIndex = 30
        Me.btnSelectOther.Text = "Select All"
        Me.btnSelectOther.UseVisualStyleBackColor = True
        '
        'chkTest
        '
        Me.chkTest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTest.AutoSize = True
        Me.chkTest.Location = New System.Drawing.Point(196, 112)
        Me.chkTest.Name = "chkTest"
        Me.chkTest.Size = New System.Drawing.Size(118, 21)
        Me.chkTest.TabIndex = 17
        Me.chkTest.Text = "Test Papers"
        Me.chkTest.UseVisualStyleBackColor = True
        '
        'chkAcademic
        '
        Me.chkAcademic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAcademic.AutoSize = True
        Me.chkAcademic.Location = New System.Drawing.Point(19, 31)
        Me.chkAcademic.Name = "chkAcademic"
        Me.chkAcademic.Size = New System.Drawing.Size(131, 21)
        Me.chkAcademic.TabIndex = 9
        Me.chkAcademic.Text = "Academic Fee"
        Me.chkAcademic.UseVisualStyleBackColor = True
        '
        'chkStudent
        '
        Me.chkStudent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStudent.AutoSize = True
        Me.chkStudent.Location = New System.Drawing.Point(19, 139)
        Me.chkStudent.Name = "chkStudent"
        Me.chkStudent.Size = New System.Drawing.Size(217, 21)
        Me.chkStudent.TabIndex = 16
        Me.chkStudent.Text = "Student Development Fee"
        Me.chkStudent.UseVisualStyleBackColor = True
        '
        'chkAnswer
        '
        Me.chkAnswer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAnswer.AutoSize = True
        Me.chkAnswer.Location = New System.Drawing.Point(19, 58)
        Me.chkAnswer.Name = "chkAnswer"
        Me.chkAnswer.Size = New System.Drawing.Size(137, 21)
        Me.chkAnswer.TabIndex = 10
        Me.chkAnswer.Text = "Answer Sheets"
        Me.chkAnswer.UseVisualStyleBackColor = True
        '
        'chkPrisaa
        '
        Me.chkPrisaa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPrisaa.AutoSize = True
        Me.chkPrisaa.Location = New System.Drawing.Point(196, 58)
        Me.chkPrisaa.Name = "chkPrisaa"
        Me.chkPrisaa.Size = New System.Drawing.Size(117, 21)
        Me.chkPrisaa.TabIndex = 15
        Me.chkPrisaa.Text = "PRISAA Fee"
        Me.chkPrisaa.UseVisualStyleBackColor = True
        '
        'chkComputer
        '
        Me.chkComputer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkComputer.AutoSize = True
        Me.chkComputer.Location = New System.Drawing.Point(19, 85)
        Me.chkComputer.Name = "chkComputer"
        Me.chkComputer.Size = New System.Drawing.Size(131, 21)
        Me.chkComputer.TabIndex = 11
        Me.chkComputer.Text = "Computer Lab"
        Me.chkComputer.UseVisualStyleBackColor = True
        '
        'chkInternet
        '
        Me.chkInternet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkInternet.AutoSize = True
        Me.chkInternet.Location = New System.Drawing.Point(196, 31)
        Me.chkInternet.Name = "chkInternet"
        Me.chkInternet.Size = New System.Drawing.Size(118, 21)
        Me.chkInternet.TabIndex = 14
        Me.chkInternet.Text = "Internet Fee"
        Me.chkInternet.UseVisualStyleBackColor = True
        '
        'chkCSC
        '
        Me.chkCSC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCSC.AutoSize = True
        Me.chkCSC.Location = New System.Drawing.Point(196, 85)
        Me.chkCSC.Name = "chkCSC"
        Me.chkCSC.Size = New System.Drawing.Size(92, 21)
        Me.chkCSC.TabIndex = 12
        Me.chkCSC.Text = "CSC Fee"
        Me.chkCSC.UseVisualStyleBackColor = True
        '
        'chkDepartmental
        '
        Me.chkDepartmental.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDepartmental.AutoSize = True
        Me.chkDepartmental.Location = New System.Drawing.Point(19, 112)
        Me.chkDepartmental.Name = "chkDepartmental"
        Me.chkDepartmental.Size = New System.Drawing.Size(159, 21)
        Me.chkDepartmental.TabIndex = 13
        Me.chkDepartmental.Text = "Departmental Fee"
        Me.chkDepartmental.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.btnShowAll)
        Me.GroupBox4.Controls.Add(Me.txtSearch)
        Me.GroupBox4.Controls.Add(Me.btnSearch)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.dgvAssessment)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 396)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(706, 191)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data"
        '
        'btnShowAll
        '
        Me.btnShowAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnShowAll.Location = New System.Drawing.Point(556, 160)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(142, 23)
        Me.btnShowAll.TabIndex = 26
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(92, 160)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(239, 22)
        Me.txtSearch.TabIndex = 28
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(380, 160)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(142, 23)
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Search: "
        '
        'dgvAssessment
        '
        Me.dgvAssessment.AllowUserToAddRows = False
        Me.dgvAssessment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAssessment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAssessment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvAssessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssessment.Location = New System.Drawing.Point(7, 24)
        Me.dgvAssessment.Name = "dgvAssessment"
        Me.dgvAssessment.ReadOnly = True
        Me.dgvAssessment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvAssessment.RowTemplate.Height = 24
        Me.dgvAssessment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAssessment.Size = New System.Drawing.Size(693, 130)
        Me.dgvAssessment.TabIndex = 0
        '
        'Assessment_Table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 599)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpOther)
        Me.Controls.Add(Me.grpMisc)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Assessment_Table"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assessment"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpMisc.ResumeLayout(False)
        Me.grpMisc.PerformLayout()
        Me.grpOther.ResumeLayout(False)
        Me.grpOther.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvAssessment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpMisc As System.Windows.Forms.GroupBox
    Friend WithEvents grpOther As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTuition As System.Windows.Forms.ComboBox
    Friend WithEvents chkRegistration As System.Windows.Forms.CheckBox
    Friend WithEvents chkPublication As System.Windows.Forms.CheckBox
    Friend WithEvents chkMedical As System.Windows.Forms.CheckBox
    Friend WithEvents chkLibrary As System.Windows.Forms.CheckBox
    Friend WithEvents chkInsurance As System.Windows.Forms.CheckBox
    Friend WithEvents chkID As System.Windows.Forms.CheckBox
    Friend WithEvents chkGuidance As System.Windows.Forms.CheckBox
    Friend WithEvents chkAudio As System.Windows.Forms.CheckBox
    Friend WithEvents chkAthletic As System.Windows.Forms.CheckBox
    Friend WithEvents chkTest As System.Windows.Forms.CheckBox
    Friend WithEvents chkStudent As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnswer As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrisaa As System.Windows.Forms.CheckBox
    Friend WithEvents chkComputer As System.Windows.Forms.CheckBox
    Friend WithEvents chkInternet As System.Windows.Forms.CheckBox
    Friend WithEvents chkCSC As System.Windows.Forms.CheckBox
    Friend WithEvents chkDepartmental As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvAssessment As System.Windows.Forms.DataGridView
    Friend WithEvents btnSelectMisc As System.Windows.Forms.Button
    Friend WithEvents btnSelectOther As System.Windows.Forms.Button
    Friend WithEvents chkAcademic As System.Windows.Forms.CheckBox
End Class
