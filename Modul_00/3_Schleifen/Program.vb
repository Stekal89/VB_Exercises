Imports System

Module Program
    Sub Main(args As String())

        Dim nl As String = vbCrLf

        '        Aufgabenblatt -Schleifen


#Region "1)"

        ' 1. Erstellen Sie eine While Schleife, die die Zahlen von 0 bis 10 ausgibt.

        Dim whileCount As Integer = 0
        Dim whileMax As Integer = 10

        Console.WriteLine($"{nl}{nl}############# Exercise 1: #############")

        While whileCount <= whileMax
            Console.WriteLine($"Count: ""{whileCount}""")
            whileCount += 1
        End While

        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

#End Region

#Region "2)"

        ' 2. Erstellen Sie eine For Schleife, die die Zahlen von 0 bis 100 ausgibt.

        Console.WriteLine($"{nl}{nl}############# Exercise 2: #############")

        For i = 0 To 100
            Console.WriteLine($"I: ""{i}""")
        Next

        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

#End Region

#Region "3)"

        ' 3. Erstellen Sie eine While Schleife, die r�ckw�rts von 100 bis - 10 z�hlt und die Zahlen ausgibt.

        'Console.WriteLine($"{nl}{nl}############# Exercise 3: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

#Region "4)"

        ' 4. Erstellen Sie eine While Schleife, die in zweier- Schritten von 0 bis 30 z�hlt und die Zahlen
        ' ausgibt.

        'Console.WriteLine($"{nl}{nl}############# Exercise 4: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

#Region "5)"

        ' 5. Erstellen Sie ein Programm, das zwei Zahlen von 0 bis 10 von der Konsole einliest. Die Schleife
        ' soll von der ersten eingegebenen Zahl bis zur zweiten eingegebenen Zahl z�hlen.

        'Console.WriteLine($"{nl}{nl}############# Exercise 5: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

#Region "6)"

        ' 6. Erstellen Sie ein Programm, das je nach Eingabe eine bestimmte Anzahl von * ausgibt.

        'Console.WriteLine($"{nl}{nl}############# Exercise 6: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

#Region "7)"

        ' 7. Erstellen Sie ein Programm, das von 0 bis 100 z�hlt. Das Programm soll bei jeder Zahl �berpr�fen,
        ' ob Sie ohne Rest durch 2 Teilbar ist. (Hinweis: Modulo.zahl Mod 2 = 0). Wenn ja, soll das
        ' Programm 'Zahl' ist durch 2 Teilbar ausgeben. ansonsten 'Zahl' ist nicht durch 2 Teilbar.

        'Console.WriteLine($"{nl}{nl}############# Exercise 7: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

#Region "8)"

        ' 8. Verbessern Sie das Programm aus �bung 7. Der Benutzer kann jetzt einen Zahlenbereich w�hlen
        ' und eine Zahl. Danach soll �berpr�ft werden welche Zahlen in dem Zahlenbereich durch die Zahl
        ' teilbar sind.

        'Console.WriteLine($"{nl}{nl}############# Exercise 8: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

#Region "9)"

        ' 9. Entwickeln Sie ein Programm, dass einem Einbrecher hilft ein 4 Stelliges Zahlenschloss zu
        ' knacken.Das Zahlenschloss akzeptiert an jeder Stelle Zahlen von 0-36. Es besitzt 4 Stellen.
        ' Eine m�gliche Kombination w�re zb.
        ' 36-22-11-14
        ' Schreiben Sie eine Funktion, die ihnen alle m�glichen Kombinationen des Zahlenschlosses (auf
        ' der Konsole) ausgibt.

        'Console.WriteLine($"{nl}{nl}############# Exercise 9: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

#Region "10)"

        ' 10. Erstellen Sie ein Programm, das das kleine Einmaleins ausgibt.11. Geben Sie einen Christbaum aus. Der Benutzer kann die H�he w�hlen:
        ' zb.: H�he 10
        ' Die Formel f�r den Baum ist
        ' Leerzeichenanzahl Links / Rechts = H�he � 1 � i
        ' Sterne = i * 2 + 1
        ' i = Nummer des Durchlaufs.

        'Console.WriteLine($"{nl}{nl}############# Exercise 10: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

    End Sub
End Module
