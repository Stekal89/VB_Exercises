Imports System

Module Program
    Sub Main(args As String())

        Dim nl As String = vbCrLf

        '                           Aufgabenblatt -Variablen
        '1. Erstellen Sie ein Programm, dass jeweils eine Variable vom Typ double, Int32 und string und
        'Boolean anlegt.Weisen Sie den Variablen folgende Werte zu:    123.123, "Hallo Welt", 456, false

        Dim dNumb As Double = 123.123
        Dim dInt As Integer = 456
        Dim text As String = "Hallo Welt"
        Dim tf As Boolean = False

        Console.WriteLine($"{nl}############# Exercise 1: #############")
        Console.WriteLine($"Double:  ""{dNumb}""")
        Console.WriteLine($"Int32:   ""{dInt}""")
        Console.WriteLine($"String:  ""{text}""")
        Console.WriteLine($"Boolean: ""{tf}""{nl}{nl}")

        '2. Erstellen Sie ein Programm, das zwei Variablen vom Typ int anlegt und diese auf der Konsole
        'ausgibt.

        Dim i1 As Integer = 21
        Dim i2 As Integer = 45

        Console.WriteLine($"{nl}############# Exercise 2: #############")
        Console.WriteLine($"I1: ""{i1}""")
        Console.WriteLine($"I2: ""{i2}""{nl}{nl}")

        '3. Erstellen Sie ein Programm, das drei Variablen vom Typ int mit den Werten x:15, y:76 und z:24
        'anlegt.Geben Sie die Variablennamen und die Werte nebeneinander auf der Konsole aus.

        Dim x As Integer = 15
        Dim y As Integer = 76
        Dim z As Integer = 24

        Console.WriteLine($"{nl}############# Exercise 3: #############")
        Console.WriteLine($"Values: x = ""{x}"", y = ""{y}"", z ""{z}"",{nl}{nl}")

        '4. Berechnen Sie x * y + z Weisen Sie das Ergebnis an eine Variable namens ergebnis zu. Geben Sie
        'diese Variable und die Rechnungen auf der Konsole aus.


        '5. Berechnen Sie (x*x*z)/y + x und z+z-x+y. Verwenden Sie die gleiche Variable wie vorher um das
        'Ergebnis zu speichern und geben sie nach jedem Schritt die Rechnung und das ergebnis aus.


        '6. Erstellen Sie drei Variablen x, y und z vom typ int. Weisen Sie den Variablen beliebige Zahlen zu.
        'Erstellen Sie eine weitere Variable b. Berechnen Sie folgende Vergleiche: x +y < z, x > y - z, x <> y,
        'x = z und speichern Sie das Ergebnis in die Variable b. Geben Sie nach jedem Vergleich die
        'Variable b auf der Konsole aus.


        '7. Erstellen Sie zwei String Variablen. Geben Sie die Variablen auf der Konsole untereinander aus.
        'Geben Sie die Variablen danach auf einer Zeile aus. Benutzen Sie dazu einerseits den '&'
        'Operator zusammen mit Console.WriteLine und andererseits Console.Write zum Ausgeben.


        '8. Führen Sie Aufgabe 5 und 6 mit Variablen, die Sie vom Benutzer einlesen aus.


        '9. Erstellen Sie ein Programm, das einen Namen, ein Alter und ein Geburtsdatum von der Konsole
        'einliest.und Geben Sie folgenden Satz auf der Konsole aus: Hallo 'Name' du bist 'Alter' alt und
        'am 'Geburtsdaum' geboren


        Console.ReadKey()
    End Sub
End Module
