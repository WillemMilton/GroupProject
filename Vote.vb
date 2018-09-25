' ********************************************************************************* 
'  TEAM NUMBER: 13
'  Member 1: MONCHO, R.M (216028656)
'  Member 2: SEKGOTO, N.L (218031731)
'  Member 3: NTOAMPE, L.H (201314444)
'  Member 4: MJEKULA, C (218076052)
'  Class name: Vote
' *********************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class Vote
    Public _numNominations As Integer
    Public _NumVoters As Integer
    ' Property method for the number of nominations
    Public Property NumNominations As Integer
        Get
            Return _numNominations

        End Get
        Set(value As Integer)
            _numNominations = value

        End Set
    End Property
    ' Property method for the number of voters
    Public Property NumVoters As Integer
        Get
            Return _NumVoters

        End Get
        Set(value As Integer)
            _NumVoters = value

        End Set
    End Property
End Class
