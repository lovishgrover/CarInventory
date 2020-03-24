'Author : Lovish Grover
'Date : January 26 2020
'Description :
' This program accepts series of units shipped per day and 
' take input for a week and then after click enter.
' It will show the average units shipped per day. 

Option Strict On

Public Class Car
#Region "Variable Declarations"
    Private Shared carCount As Integer = 0
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carYear As Integer = 0
    Private carModel As String = String.Empty
    Private carPrice As Decimal = 0.0D
    Private carNewStatus As Boolean = True


#End Region

#Region "Procedures"

    ''' <summary>
    ''' Returns car count
    ''' </summary>
    ''' <returns></returns>
    Private Shared ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' Returns car identification Number
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Id() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>

    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property


    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    Public Property NewStatus() As Boolean
        Get
            Return carNewStatus
        End Get
        Set(value As Boolean)
            carNewStatus = value
        End Set
    End Property
#End Region



#Region "Constructors"
    ''' <summary>
    ''' Default Constructor = increments the car count
    ''' </summary>
    Public Sub New()
        carCount += 1
        carIdentificationNumber = carCount
    End Sub

    ''' <summary>
    ''' Parameterized Constructor = it sets all the private variable according to the passed value
    ''' </summary>
    ''' <param name="makeValue">for car's manufacturer company</param>
    ''' <param name="modelValue">for car's model </param>
    ''' <param name="yearValue"> for car's year of manufacture</param>
    ''' <param name="priceValue">for car's price</param>
    ''' <param name="carNewValue"> for car's status that it is new or used</param>
    Public Sub New(makeValue As String, modelValue As String, yearValue As Integer,
                   priceValue As Decimal, carNewValue As Boolean)

        Me.New()

        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carNewStatus = carNewValue

    End Sub

#End Region



#Region "Methods"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCarData() As String
        If carNewStatus Then
            Return "New ! " & carYear & "  " & carMake & "  " & carModel & " for " & carPrice.ToString("c")
        Else
            Return "Used ! " & carYear & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")
        End If
    End Function


#End Region


End Class
