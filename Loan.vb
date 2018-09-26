' ********************************************************************************* 
'  TEAM NUMBER: 13
'  Member 1: MONCHO, R.M (216028656)
'  Member 2: SEKGOTO, N.L (218031731)
'  Member 3: NTOAMPE, L.H (201314444)
'  Member 4: MJEKULA, C (218076052)
'  Class name: Loan
' *********************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class Loan
    Private _AmountBorrowing As Double
    Private _Payment As Double
    Private _StillOwing As Double
    Private _InterestRate As Double
    Private _InterestAmount As Double
    'Property method for amount of money the member is asking to borrow
    Public Property AmountBorrowing As Double
        Get
            Return _AmountBorrowing
        End Get
        Set(value As Double)
            _AmountBorrowing = value
        End Set
    End Property
    'Property method for payment which is being made
    Public Property Payment As Double
        Get
            Return _Payment
        End Get
        Set(value As Double)
            _Payment = value
        End Set
    End Property
    'property method for amount that the member still owes
    Public Property StillOwing As Double
        Get
            Return _StillOwing
        End Get
        Set(value As Double)
            _StillOwing = value
        End Set
    End Property
    'property method for InterestRate
    Public Property InterestRate As Double
        Get
            Return _InterestRate
        End Get
        Set(Ir As Double)
            _InterestRate = Ir
        End Set

    End Property
    'property method for interest rate
    Public Property InterestAmount As Double
        Get
            Return _InterestAmount
        End Get
        Set(value As Double)
            _InterestAmount = value
        End Set
    End Property



    '*************************
    'method calculates if money  can be borrowed from the chest 
    Public Function Borrowmoney(ByRef total As Double, ByVal bm As Double) As Double
        'bm is the money being borrowed it will be taken in from the Form2 class

        If bm < total And StillOwing = 0 Then

            AmountBorrowing += bm
            ' Return AmountBorrowing
        End If
        'get the interest amount
        calcInterestAmount(AmountBorrowing,InterestRate)
        StillOwing = AmountBorrowing+InterestAmount
        'subtracts the amount going out to the member 
        total=total-StillOwing
        Return StillOwing
    End Function

    'this utility method calculates the Intrest amount
    Private Function calcIntrestAmount(ByVal bm As Double, ByVal IR As Double) As Double
        'bm is again the amount of money being borrowed it will be taken in from the Form2 class
        InterestAmount = IR*bm
    End Function


    Public Function Pay(ByRef total as double,ByVal mp As Double) As Double
        StillOwing -= mp
        total+=mp
    End Function



End Class
