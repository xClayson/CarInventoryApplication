' Author: Ryan Clayson
' Date: March 11 2020
' Description
' This class represents care objects with properties for the make, model, year, and price.
' Used as part of a Lab assignment for NETD 2202

Option Strict On
Public Class Car

#Region "Variable Declarations"

    Private Shared carCount As Integer = 0
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0.0D
    Private carIsNew As Boolean = True

#End Region

#Region "Constructors"

    'Default Constructor. Increments the carCount
    Friend Sub New()

        carCount += 1
        carIdentificationNumber = carCount

    End Sub


    ''' <summary>
    ''' ' Parameterized constructor: sets all class values based on arguments passed in
    ''' </summary>
    ''' <param name="makeValue">  a car manufacturer </param>
    ''' <param name="modelValue"> a car model name </param> 
    ''' <param name="yearValue"> year that car was made </param> 
    ''' <param name="priceValue"> car price </param>
    ''' <param name="newValue"> True if the car is new, False is used </param> 
    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer,
                       priceValue As Decimal, newValue As Boolean)
        Me.New()

        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carIsNew = newValue

    End Sub

#End Region
#Region "Property Procedures"
    ''' <summary>
    ''' Returns the number of car objects
    ''' </summary>
    ''' <returns> number of car objects as an Integer</returns>
    Friend Shared ReadOnly Property Count As Integer

        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' Returns the car unique's Identification Number
    ''' </summary>
    ''' <returns> identification number as an integer</returns>
    Friend ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' Returns the car's manufacturer
    ''' </summary>
    ''' <returns> the car's manufacturer as a string</returns>
    Friend Property Make As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the car's model
    ''' </summary>
    ''' <returns> the car's model as a string</returns>
    Friend Property Model As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the car's year
    ''' </summary>
    ''' <returns> the car's year as a integer</returns>
    Friend Property Year As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the car's price
    ''' </summary>
    ''' <returns> the car's price as a decimal</returns>
    Friend Property Price As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the if the car is new
    ''' </summary>
    ''' <returns>True if car is new, false if it is used</returns>
    Friend Property IsNew As Boolean
        Get
            Return carIsNew
        End Get
        Set(value As Boolean)
            carIsNew = value
        End Set
    End Property
#End Region

#Region "Methods"
    ''' <summary>
    ''' Returns a string describing a car
    ''' </summary>
    ''' <returns> string describing a car</returns>
    Friend Function GetCarData() As String

        Return IIf(carIsNew, "New ", "Used ").ToString & carYear.ToString & " " & carMake & " " & carModel &
                " for " & carPrice.ToString("c")

    End Function
#End Region
End Class
