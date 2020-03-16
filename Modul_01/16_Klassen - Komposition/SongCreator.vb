Public Enum Genre
    Classical
    Punk
    Rock
    Electro
    Techno
    House
    Country
End Enum
Public Class SongCreator

    '   a. Musikstueck : Name, Dauer, Genre, Komponist, MusikLabel, AnzahlDownloads, Preis

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

    ' Dauer
    Private durationValue As TimeSpan
    Public Property Duration() As TimeSpan
        Get
            Return durationValue
        End Get
        Set(ByVal value As TimeSpan)
            durationValue = value
        End Set
    End Property

    ' Genre
    Private genreValue As Genre
    Public Property Genre() As Genre
        Get
            Return genreValue
        End Get
        Set(ByVal value As Genre)
            genreValue = value
        End Set
    End Property

    ' Komponist
    Private composerValue As Composer
    Public Property Composer() As Composer
        Get
            Return composerValue
        End Get
        Set(ByVal value As Composer)
            composerValue = value
        End Set
    End Property

    ' MusikLabel
    Private musicLabelValue As MusicLabel
    Public Property MusicLabel() As MusicLabel
        Get
            Return musicLabelValue
        End Get
        Set(ByVal value As MusicLabel)
            musicLabelValue = value
        End Set
    End Property

    ' AnzahlDownloads
    Private downloadCountValue As Integer
    Public Property DownloadCount() As Integer
        Get
            Return downloadCountValue
        End Get
        Set(ByVal value As Integer)
            downloadCountValue = value
        End Set
    End Property

    ' Preis
    Private priceValue As Decimal
    Public Property Price() As Decimal
        Get
            Return priceValue
        End Get
        Set(ByVal value As Decimal)
            priceValue = value
        End Set
    End Property

#End Region


#Region "Constructor"

    ' Name, Dauer, Genre, Komponist, MusikLabel, AnzahlDownloads, Preis
    Sub New()

    End Sub

    Sub New(name As String, duration As TimeSpan, genre As Genre, composer As Composer, musicLabel As MusicLabel, downloadCount As Integer, price As Decimal)
        Me.Name = name
        Me.Duration = duration
        Me.Genre = genre
        Me.Composer = composer
        Me.MusicLabel = musicLabel
        Me.DownloadCount = downloadCount
        Me.Price = price
    End Sub

#End Region

End Class
