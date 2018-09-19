Option Strict On
Option Explicit On
Option Infer Off
' *********************************************************************************
' TEAM NUMBER: 13
' Member 1: MONCHO, R.M (216028656)
' Member 2: SEKGOTO, N.L (218031731)
' Member 3: NTOAMPE, L.H (201314444)
' Member 4: MJEKULA, C (218076052)
' Class name: frmLogin
' *********************************************************************************
Imports T01_P2018B_08

Public Class frmLogin
    Private FSGSaving As frmFreeStateGranniesSocialSaving
    ' String variables 
    Private Password, Username, Usertype As String
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Shared Widening Operator CType(v As frmFreeStateGranniesSocialSaving) As frmLogin
        Throw New NotImplementedException()
    End Operator

    ' New connection to database
    Dim Con As New OleDb.OleDbConnection
    ' to get the provider name
    Dim dbprovider As String
    ' to get the database provider name 
    Dim dbsource As String
    ' dataset to table 
    Dim ds As New DataSet
    ' DatabaseAdapter to dataset and database
    Dim da As OleDb.OleDbDataAdapter
    ' sql command
    Dim sql As String
    Dim maxrows, incdec As Integer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' validation of the username and password 

        If txtUsername.Text = Username And txtPassword.Text = Password Then
            If Usertype = "admin" Then

                ' Username and password correct then go to the next page 
                FSGSaving = New frmFreeStateGranniesSocialSaving
                FSGSaving.Show()
            ElseIf txtUsername.Text = Username And txtPassword.Text = "" Then
                ' Blank password control
                MsgBox("Enter Password")
            ElseIf txtUsername.Text = "" And txtPassword.Text = Password Then
                ' Blank username control
                MsgBox("Enter Username")
            ElseIf txtUsername.Text = Username And txtPassword.Text <> Password Then
                ' Incorrect password 
                MsgBox("Invalid Password")
            ElseIf txtUsername.Text <> Username And txtPassword.Text = Password Then
                ' Incorrect username 
                MsgBox("Invalid Username")
            ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
                'Blank username and password 
                MsgBox("Please Enter your username and password")
            Else
                'Wrong usertype
                MsgBox("Invalid Usertype")
            End If
        Else
            ' Incorrect username and password
            MsgBox("Invalid Username & or Password ")
        End If

    End Sub

    ' the exit button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MessageBox.Show("Are you sure you want to Cancel?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        Me.Close()
    End Sub

    ' Making passwords hidden for every one character
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.TextLength > 0 Then
            For i As Integer = txtPassword.TextLength - 1 To 1 Step -1
                txtPassword.Text = txtPassword.Text.Replace(txtPassword.Text.Substring(i, 1), "*")
            Next i
        End If
    End Sub
End Class
