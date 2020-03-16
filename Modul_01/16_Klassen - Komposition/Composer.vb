Public Class Composer
    '   b. Komponist : Kuenstlername, Vorname, Nachname, Alter, Nationalitaet, Abgabenprozentsatz, Geschlecht

#Region "Peoperties"

    ' Kuenstlername
    Private artistNameValue As String
    Public Property ArtistName() As String
        Get
            Return artistNameValue
        End Get
        Set(ByVal value As String)
            artistNameValue = value
        End Set
    End Property

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

    'Nachname 
    Private lastNameValue As String
    Public Property LastName() As String
        Get
            Return lastNameValue
        End Get
        Set(ByVal value As String)
            lastNameValue = value
        End Set
    End Property

    'Alter 
    Private ageValue As Integer
    Public Property Age() As Integer
        Get
            Return ageValue
        End Get
        Set(ByVal value As Integer)
            ageValue = value
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

    ' Abgabenprozentsatz
    Private taxPercentageValue As Double
    Public Property TaxPercentage() As Double
        Get
            Return taxPercentageValue
        End Get
        Set(ByVal value As Double)
            taxPercentageValue = value
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

#End Region


#Region "Constructors"

    '  Komponist : Kuenstlername, Vorname, Nachname, Alter, Nationalitaet, Abgabenprozentsatz, Geschlecht
    Sub New()

    End Sub

    Sub New(artistName As String, firstName As String, lastName As String, age As Integer, nationality As Nationality, taxPercentage As Double, sex As Sex)
        Me.ArtistName = artistName
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.Age = age
        Me.Nationality = nationality
        Me.TaxPercentage = taxPercentage
        Me.Sex = sex
    End Sub
#End Region



End Class
