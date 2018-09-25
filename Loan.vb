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
    Private _InterestRepayment As Double
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
    'property method for interest rate
    Public Property InterestRepayment As Double
        Get
            Return _InterestRepayment
        End Get
        Set(value As Double)
            _InterestRepayment = value
        End Set
    End Property
End Class
