Imports System.Data
Imports System.Data.OleDb
Imports ADODB

Module Module1

    Public dbConn As ADODB.Connection
    Public rsStud As ADODB.Recordset
    Public daStud As New OleDbDataAdapter
    Public dsStud As New DataSet("student_record")
    Public saveRecord As Boolean
    Public strUser As String

    Public rsReg As ADODB.Recordset
    Public daReg As New OleDbDataAdapter
    Public dsReg As New DataSet("registrar_record")

    Public rsCash As ADODB.Recordset
    Public daCash As New OleDbDataAdapter
    Public dsCash As New DataSet("cashier_record")

    Public rsAdm As ADODB.Recordset
    Public daAdm As New OleDbDataAdapter
    Public dsAdm As New DataSet("admin_record")

    Public rsAss As ADODB.Recordset
    Public daAss As New OleDbDataAdapter
    Public dsAss As New DataSet("assessment_table")

    Public rsPay As ADODB.Recordset
    Public daPay As New OleDbDataAdapter
    Public dsPay As New DataSet("payment_table")


    Public Sub connectDB()
        dbConn = New ADODB.Connection
        dbConn.ConnectionString = "DRIVER={MySQL ODBC 3.51 Driver};" _
            & "SERVER=localhost;" _
            & "DATABASE=enrollment;" _
            & "UID=root;" _
            & "PASSWORD=123456;"
        dbConn.Open()
    End Sub

    Public Sub connectUser(ByVal table As String)
        rsStud = New ADODB.Recordset
        rsStud.CursorLocation = CursorLocationEnum.adUseClient
        rsStud.Open(table, dbConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, 1)
    End Sub

    Public Sub connectReg(ByVal table As String)
        rsReg = New ADODB.Recordset
        rsReg.CursorLocation = CursorLocationEnum.adUseClient
        rsReg.Open(table, dbConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, 1)
    End Sub

    Public Sub connectCash(ByVal table As String)
        rsCash = New ADODB.Recordset
        rsCash.CursorLocation = CursorLocationEnum.adUseClient
        rsCash.Open(table, dbConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, 1)
    End Sub

    Public Sub connectAdmin(ByVal table As String)
        rsAdm = New ADODB.Recordset
        rsAdm.CursorLocation = CursorLocationEnum.adUseClient
        rsAdm.Open(table, dbConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, 1)
    End Sub

    Public Sub connectAssess(ByVal table As String)
        rsAss = New ADODB.Recordset
        rsAss.CursorLocation = CursorLocationEnum.adUseClient
        rsAss.Open(table, dbConn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, 1)
    End Sub

    Public Sub connectPayment(ByVal table As String)
        rsPay = New ADODB.Recordset
        rsPay.CursorLocation = CursorLocationEnum.adUseClient
        rsPay.Open(table, dbConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, 1)
    End Sub
End Module
