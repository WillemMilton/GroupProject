' *********************************************************************************
' TEAM NUMBER: 13
' Member 1: MONCHO, R.M (216028656)
' Member 2: SEKGOTO, N.L (218031731)
' Member 3: NTOAMPE, L.H (201314444)
' Member 4: MJEKULA, C (218076052)
' Class name: frmFreeStateGranniesSocialSaving
' *********************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class frmFreeStateGranniesSocialSaving

    ' Communicating betwwen two forms 
    Inherits System.Windows.Forms.Form
    Public myLogin As frmLogin

    Dim myForm As frmFreeStateGranniesSocialSaving
    ' When the form load passes a form reference with a property
    Private Sub frmFreeStateGranniesSocialSaving_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If myForm Is Nothing Then
            myForm = New frmFreeStateGranniesSocialSaving
            myForm.myLogin = Me
        End If
        myForm.Show()
    End Sub
End Class