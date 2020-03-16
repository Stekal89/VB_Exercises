Public Enum Country
    Germany
    Austria
    USA
    GreatBritian
    Australia
End Enum

Public Class MusicLabel
    '   c. MusikLabel : Name, Gruendungsdatum, Land, UmsatzProJahr, Abgabenprozentsatz, LabelGruender

#Region "Properties"

    ' Name 
    Private nameValue As String
    Public Property Name() As String
        Get
            Return nameValue
        End Get
        Set(ByVal value As String)
            nameValue = value
        End Set
    End Property

    ' Gruendungsdatum
    Private creationDateValue As DateTime
    Public Property CreationDate() As DateTime
        Get
            Return creationDateValue
        End Get
        Set(ByVal value As DateTime)
            creationDateValue = value
        End Set
    End Property

    ' Land 
    Private countryValue As Country
    Public Property Country() As Country
        Get
            Return countryValue
        End Get
        Set(ByVal value As Country)
            countryValue = value
        End Set
    End Property

    ' UmsatzProJahr
    Private annualSalesValue As Decimal
    Public Property AnnualSales() As Decimal
        Get
            Return annualSalesValue
        End Get
        Set(ByVal value As Decimal)
            annualSalesValue = value
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

    ' LabelGruender
    Private musicLabelCreatorValue As MusicLabelCreator
    Public Property MusicLabelCreator() As MusicLabelCreator
        Get
            Return musicLabelCreatorValue
        End Get
        Set(ByVal value As MusicLabelCreator)
            musicLabelCreatorValue = value
        End Set
    End Property

#End Region

#Region "Constructor"

    ' Name, Gruendungsdatum, Land, UmsatzProJahr, Abgabenprozentsatz, LabelGruender
    Sub New()

    End Sub

    Sub New(name As String, creationDate As DateTime, annualSales As Decimal, taxPercentage As Double, musicLabelCreator As MusicLabelCreator)
        Me.Name = name
        Me.CreationDate = creationDate
        Me.AnnualSales = annualSales
        Me.TaxPercentage = taxPercentage
        Me.MusicLabelCreator = musicLabelCreator
    End Sub

#End Region

End Class
