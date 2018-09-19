' *********************************************************************************
' TEAM NUMBER: 13
' Member 1: MONCHO, R.M (216028656)
' Member 2: SEKGOTO, N.L (218031731)
' Member 3: NTOAMPE, L.H (201314444)
' Member 4: MJEKULA, C (218076052)
' Class name: 
' *********************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class Member
    Private _Surname As String
    Private _Name As String
    Private _Age As Integer
    Private _Birthday As String
    Private _Address As String
    ' Property method for a Surname 
    Public Property Surname As String 
        Get 
            Return _Surname
        End Get
        Set(Value As String)
            _Surname = Value
        End Set
    End Property 
    ' Property method for a name 
    Public Property Name As String 
        Get 
            Return _Name 
        End Get 
        Set(Value As String)
            _Name = Value 
        End Set
    End Property 
    ' property method for age 
    Public Property Age As Integer 
        Get 
            Return _Age 
        End Get
        Set(Value As Integer)
            _Age = value
        End Set
    End Property
    ' Property Method for Birthday
    Public Property Birthday As String 
        Get
            Return _Birthday
        End Get 
        Set(Value As String)
            _Birthday = Value 
        End Set
    End Property
    'Property Method for Address
    Public Property Address AS String 
        Get
            Return _Address
        End Get
        Set(Value As String)
            _Address = value 
        End Set 
    End Property 

End Class
