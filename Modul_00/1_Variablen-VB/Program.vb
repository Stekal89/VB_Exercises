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
        Console.WriteLine($"Values: x = ""{x}"", y = ""{y}"", z = ""{z}"",{nl}{nl}")

        '4. Berechnen Sie x * y + z Weisen Sie das Ergebnis an eine Variable namens ergebnis zu. Geben Sie
        'diese Variable und die Rechnungen auf der Konsole aus.

        Dim result As Integer = x * y + z

        Console.WriteLine($"{nl}############# Exercise 4: #############")
        Console.WriteLine("y * y + z = ?")
        Console.WriteLine($"{x} * {y} + {z} = {result} {nl}{nl}")

        '5. Berechnen Sie (x*x*z)/y + x und z+z-x+y. Verwenden Sie die gleiche Variable wie vorher um das
        'Ergebnis zu speichern und geben sie nach jedem Schritt die Rechnung und das ergebnis aus.

        result = (x * x * z) / y + x

        Console.WriteLine($"{nl}############# Exercise 5: #############")
        Console.WriteLine("(x * x * z) / y + x = ?")
        Console.WriteLine($"({x} * {x} * {z}) / {y} = {result}{nl}")

        result = z + z - x + y

        Console.WriteLine("z + z - x + y = ?")
        Console.WriteLine($"{z} + {z} - {x} + {y} = {result}{nl}{nl}")

        '6. Erstellen Sie drei Variablen x, y und z vom typ int. Weisen Sie den Variablen beliebige Zahlen zu.
        'Erstellen Sie eine weitere Variable b. Berechnen Sie folgende Vergleiche: x +y < z, x > y - z, x <> y,
        'x = z und speichern Sie das Ergebnis in die Variable b. Geben Sie nach jedem Vergleich die
        'Variable b auf der Konsole aus.

        Dim b As Boolean
        x = 24
        y = 46
        z = 15
        b = x + y < z

        Console.WriteLine($"{nl}############# Exercise 6: #############")
        Console.WriteLine("x + y < z = ?")
        Console.WriteLine($"({x} + {y} < {z}) = {b}{nl}")

        b = x > y - z

        Console.WriteLine("x > y - z = ?")
        Console.WriteLine($"{x} > {y} - {z} = {b}{nl}")

        b = x <> y

        Console.WriteLine("x <> y = ?")
        Console.WriteLine($"{x} <> {y} = {b}{nl}")

        b = x = z

        Console.WriteLine("x = z = ?")
        Console.WriteLine($"{x} = {z} = {b}{nl}")

        '7. Erstellen Sie zwei String Variablen. Geben Sie die Variablen auf der Konsole untereinander aus.
        'Geben Sie die Variablen danach auf einer Zeile aus. Benutzen Sie dazu einerseits den '&'
        'Operator zusammen mit Console.WriteLine und andererseits Console.Write zum Ausgeben.

        Dim t1 As String = "Das ist der 1. Text!!!"
        Dim t2 As String = "Und das ist der 2. Text!!!"

        Console.WriteLine($"{nl}############# Exercise 7: #############")
        Console.WriteLine(t1)
        Console.WriteLine(t2, nl, nl)

        '8. Führen Sie Aufgabe 5 und 6 mit Variablen, die Sie vom Benutzer einlesen aus.

        Console.WriteLine($"{nl}############# Exercise 8: #############")
        Console.Write("Insert value for value x: ")
        Dim xAsString As String = Console.ReadLine()
        Console.Write("Insert value for value y: ")
        Dim yAsString As String = Console.ReadLine()
        Console.Write("Insert value for value z: ")
        Dim zAsString As String = Console.ReadLine()

        Integer.TryParse(xAsString, x)
        Integer.TryParse(yAsString, y)
        Integer.TryParse(zAsString, z)

        Console.WriteLine($"{nl}### Exercise 8a):")
        result = (x * x * z) / y + x
        Console.WriteLine("(x * x * z) / y + x = ?")
        Console.WriteLine($"({x} * {x} * {z}) / {y} = {result}{nl}")

        result = z + z - x + y
        Console.WriteLine("z + z - x + y = ?")
        Console.WriteLine($"{z} + {z} - {x} + {y} = {result}")

        Console.WriteLine($"{nl}### Exercise 8b):")
        b = x + y < z
        Console.WriteLine("x + y < z = ?")
        Console.WriteLine($"({x} + {y} < {z}) = {b}{nl}")

        b = x > y - z

        Console.WriteLine("x > y - z = ?")
        Console.WriteLine($"{x} > {y} - {z} = {b}{nl}")

        b = x <> y

        Console.WriteLine("x <> y = ?")
        Console.WriteLine($"{x} <> {y} = {b}{nl}")

        b = x = z

        Console.WriteLine("x = z = ?")
        Console.WriteLine($"{x} = {z} = {b}{nl}")
        Console.WriteLine("Continue with any key...")
        'Console.ReadKey()
        Console.Clear()

        '9. Erstellen Sie ein Programm, das einen Namen, ein Alter und ein Geburtsdatum von der Konsole
        'einliest.und Geben Sie folgenden Satz auf der Konsole aus: Hallo 'Name' du bist 'Alter' alt und
        'am 'Geburtsdaum' geboren


        Console.ReadKey()
    End Sub
End Module
