Imports Microsoft.VisualBasic
Public Enum Nationality
    Austria
    Germany
    USA
    GreatBritai0n
End Enum

Public Enum Sex
    Male
    Female
    Others
End Enum

Public Class MusicLabelCreator

    '   d. LabelGruender : Vorname, Nachname, Nationalitaet, Geschlecht, Alter

#Region "Properties"

    ' Vorname
    Private firstNameValue As String
    Public Property FirstName() As String
        Get
            Return firstNameValue
        End Get
        Set(ByVal value As String)
            firstNameValue = value
        End Set
    End Property

    ' Nachname
    Private lastNameValue As String
    Public Property LastName() As String
        Get
            Return lastNameValue
        End Get
        Set(ByVal value As String)
            lastNameValue = value
        End Set
    End Property

    ' Nationalitaet
    Private nationalityValue As Nationality
    Public Property Nationality() As Nationality
        Get
            Return nationalityValue
        End Get
        Set(ByVal value As Nationality)
            nationalityValue = value
        End Set
    End Property

    ' Geschlecht 
    Private sexValue As Sex
    Public Property Sex() As Sex
        Get
            Return sexValue
        End Get
        Set(ByVal value As Sex)
            sexValue = value
        End Set
    End Property

    ' Alter
    Private ageValue As Integer
    Public Property Age() As Integer
        Get
            Return ageValue
        End Get
        Set(ByVal value As Integer)
            ageValue = value
        End Set
    End Property

#End Region

#Region "Constructor"

    ' Vorname, Nachname, Nationalitaet, Geschlecht, Alter
    Sub New()

    End Sub

    Sub New(firstName As String, lastName As String, sex As Sex, age As Integer)
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.Sex = sex
        Me.Age = age
    End Sub

#End Region

End Class
