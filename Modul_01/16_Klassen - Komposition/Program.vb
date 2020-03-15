Imports System

Module Program
    Sub Main(args As String())
        'Klassenkomposition – Aufgaben

        ' 1. Erstellen Sie folgende Klassen. Wählen Sie geeignete Datentypen für die Felder. Erstellen Sie
        ' einen geeigneten Konstruktor. Erstellen Sie ausserdem Properties(get/set) fuer die Felder
        '   a. Musikstueck : Name, Dauer, Genre, Komponist, MusikLabel, AnzahlDownloads, Preis
        '   b. Komponist : Kuenstlername, Vorname, Nachname, Alter, Nationalitaet, Abgabenprozentsatz, Geschlecht
        '   c. MusikLabel : Name, Gruendungsdatum, Land, UmsatzProJahr, Abgabenprozentsatz, LabelGruender
        '   d. LabelGruender : Vorname, Nachname, Nationalitaet, Geschlecht, Alter, 
        ' Erstellen Sie in der Main Methode 5 Musikstuecke mit verschiedenen Komponisten, Labels und Labelgruendern.

        ' 2. Fügen Sie den Klassen aus Übung 1 folgende Funktionen hinzu.
        '   a. Musikstueck
        '       i. DatenAusgeben() : Soll saemtliche Daten eines Musikstuecks auf der Konsole ausgeben.
        '       ii. double UmsatzBerechnen() : Berechnet den Umsatz eines Online Stores fuer ein Musikstueck nach der Formel:  
        '           (Preis - Preis * AbgabgenprozentsatzKomponist – Preis * AbgabenprozentsatzLabel) * AnzahlDownloads
        '           Der errechnete Preis soll von der Funktion zurueckgegeben werden.
        '   b.Komponist
        '       i. DatenAusgeben() : Soll saemtliche Daten eines Komponisten auf der Konsole ausgeben.
        '       ii. Musikstueck MusikstueckErstellen(Musiklabel label, String name, Double dauer, String genre, Double preis): 
        '           Erstellt ein Musikstueck mit den angegebenen Daten und gibt es zurueck. Der Komponist wird noch nicht gesetzt.
        '       iii. double UmsatzBerechnen(Musikstueck m): Berechnet den Umsatz fuer ein gegebenes Musikstueck und gibt den Wert zurueck. 
        '            Der Umsatz berechnet sich mittels der Formel: 
        '            Preis * AbgabenprozentsatzKuenstler * AnzahlDownloads.
        '   c.MusikLabel: 
        '       i. DatenAusgeben() : Soll saemtliche Daten eines MusikLabels auf der Konsole ausgeben.
        '       ii. double UmsatzbisJahrBerechnen(Int jahr): Berechnet den Umsatz eines Musiklabels seit dessen Gruendung. Die Formel 
        '           zur Berechnung des Umsatzes lautet:   (jahr – Gruendungsjahr) * UmsatzProJahr.
        '           Wenn der Parameter jahr vor den Gruendungsjahr liegt soll 0 zurueckgegeben werden.
        '       iii. bool WurdeGegründetVon(LabelGruender g): Ueberprueft ob der gegebene LabelGruender das MusikLabel gegeründet hat. 
        '            Gibt True zurueck wenn ja. Ansonsten False.
        '   d.LabelGruender
        '       i. DatenAusgeben() : 
        '          Soll saemtliche Daten eines Labelgruenders auf der Konsole ausgeben. Fuehren Sie jede Funktion aus um zu Testen ob alles Funktioniert.
    End Sub
End Module
