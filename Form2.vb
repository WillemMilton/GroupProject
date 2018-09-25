' ********************************************************************************* 
'  TEAM NUMBER: 13
'  Member 1: MONCHO, R.M (216028656)
'  Member 2: SEKGOTO, N.L (218031731)
'  Member 3: NTOAMPE, L.H (201314444)
'  Member 4: MJEKULA, C (218076052)
'  Class name: frmFreeStateGranniesSocialSavings
' *********************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class frmFreeStateGranniesSocialSavings
    Private Members() As Member
    Private NumOfMember, NumOfWeeks As Integer
    Private Sub frmFreeStateGranniesSocialSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Please Set The interest rate before Entering any Information")
    End Sub
    ' Subroutine for displaying the information on the grid
    Private Sub DisplayInfo(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdSocialSavings.Row = r
        grdSocialSavings.Col = c
        grdSocialSavings.Text = t
    End Sub

    Private Sub btnMembersRecords_Click(sender As Object, e As EventArgs) Handles btnMembersRecords.Click
        ' get the number of members 
        NumOfMember = CInt(InputBox("How many member's you want to add?"))
        NumOfWeeks = CInt(InputBox("For how many weeks do you want to record information of each member?"))
        ReDim Members(NumOfMember)
        grdSocialSavings.Rows = NumOfMember + 1
        grdSocialSavings.Cols = NumOfWeeks + 3
        ' Instantiate any objects of member class 
        For x As Integer = 1 To NumOfMember
            Members(x) = New Member(NumOfMember)
            Members(x).Addresses(x) = New Address
            Members(x).Votes(x) = New Vote
            Members(x).Loans(x) = New Loan 
        Next x

        ' Loop for storing the info of all member's 
        For x As Integer = 1 To NumOfMember
            Members(x).Surname = InputBox("What's the Surname of Member " & CStr(x) & "?")
            Members(x).Name = InputBox("What's the Name of Member " & CStr(x) & "?")
            Members(x).Age = CInt(InputBox("How Old is " & Members(x).Name & " " & Members(x).Surname & "?"))
            Members(x).BirthDay = InputBox("Please Enter " & Members(x).Name & " " & Members(x).Surname & "Birthday in the Format YYYY/MM/DD ")
            Members(x).IDnumber = CDec(InputBox("Please Enter " & Members(x).Name & "'s  ID Number"))


        Next x

        For n As Integer = 1 To NumOfMember
            DisplayInfo(n, 0, "[ " & Members(n).IDnumber & " ]" & Members(n).Name & " " & Members(n).Surname)
        Next n
        For y As Integer = 1 To NumOfWeeks
            DisplayInfo(0, y, "Week " & CStr(y))
        Next y
        grdSocialSavings.set_ColWidth(0, 150)
        grdSocialSavings.set_ColWidth(NumOfWeeks + 1, 150)
        DisplayInfo(0, NumOfWeeks + 1, "Owes Money(Yes/No)")
        DisplayInfo(0, 0, "[ID Number] Name & Surname")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        Me.Close()
    End Sub

    Private Sub btnChangeInterest_Click(sender As Object, e As EventArgs) Handles btnChangeInterest.Click

    End Sub

    Private Sub btnBorrowedMoney_Click(sender As Object, e As EventArgs) Handles btnBorrowedMoney.Click

    End Sub

    Private Sub btnRemoveMember_Click(sender As Object, e As EventArgs) Handles btnRemoveMember.Click


    End Sub

    Private Sub btnInterestRepayments_Click(sender As Object, e As EventArgs) Handles btnInterestRepayments.Click

    End Sub

    Private Sub btnBorrowMoney_Click(sender As Object, e As EventArgs) Handles btnBorrowMoney.Click

    End Sub

    Private Sub btnPayMoney_Click(sender As Object, e As EventArgs) Handles btnPayMoney.Click

    End Sub

    Private Sub btnProfitSpending_Click(sender As Object, e As EventArgs) Handles btnProfitSpending.Click

    End Sub

    Private Sub btnWeeklyAmount_Click(sender As Object, e As EventArgs) Handles btnWeeklyAmount.Click
        For x As Integer = 1 To NumOfMember
            Dim Amount As Double = CDbl(InputBox("Choose 1 Or 2 for " & Members(x).Name & " " & Members(x).Surname & vbCrLf &
                                                   "1-Paying " & vbCrLf &
                                                   "2-Not Paying"))
            Select Case Amount
                Case 1
                    Members(x).WeeklyAmount = 2
                Case 2
                    Members(x).WeeklyAmount = 0
            End Select
        Next x
    End Sub

    Private Sub btnSetInterestRate_Click(sender As Object, e As EventArgs) Handles btnSetInterestRate.Click
        Dim Interest As Double
        Interest = CDbl(InputBox("Set the Interest in percentage"))
        For x As Integer = 1 To NumOfMember
            Members(x).InterestRate = CDbl(Interest)
        Next x
    End Sub
End Class