Imports System

Module Program
    Sub Main(args As String())

        Dim nl As String = vbCrLf

        '        Aufgabenblatt -Schleifen
#Region "Commented out"

#Region "1)"

        ' 1. Erstellen Sie eine While Schleife, die die Zahlen von 0 bis 10 ausgibt.

        Dim whileCount As Integer = 0
        Dim whileMax As Integer = 10

        Console.WriteLine($"{nl}{nl}############# Exercise 1: #############{nl}")

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

        Console.WriteLine($"{nl}{nl}############# Exercise 2: #############{nl}")

        For i = 0 To 100
            Console.WriteLine($"I: ""{i}""")
        Next

        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

#End Region

#Region "3)"

        ' 3. Erstellen Sie eine While Schleife, die rückwärts von 100 bis - 10 zählt und die Zahlen ausgibt.

        Console.WriteLine($"{nl}{nl}############# Exercise 3: #############{nl}")

        whileCount = 100
        whileMax = -10

        While whileCount >= whileMax
            Console.WriteLine($"Number: ""{whileCount}""")
            whileCount -= 1
        End While

        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

#End Region

#Region "4)"

        ' 4. Erstellen Sie eine While Schleife, die in zweier- Schritten von 0 bis 30 zählt und die Zahlen
        ' ausgibt.

        Console.WriteLine($"{nl}{nl}############# Exercise 4: #############{nl}")

        whileCount = 0
        whileMax = 30

        While whileCount <= whileMax
            Console.WriteLine($"2 Incremet: ""{whileCount}""")
            whileCount += 2
        End While

        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

#End Region

#End Region

#Region "5)"

        ' 5. Erstellen Sie ein Programm, das zwei Zahlen von 0 bis 10 von der Konsole einliest. Die Schleife
        ' soll von der ersten eingegebenen Zahl bis zur zweiten eingegebenen Zahl zählen.

        Dim fin As Boolean = False

        Do

            Console.WriteLine($"{nl}{nl}############# Exercise 5: #############{nl}")

            Console.Write("Please Enter your Start-Number (0-10): ")
            Dim firstNumbAsString As String = Console.ReadLine()

            ' Verify if input is not null, empty, or whitespace
            If Not String.IsNullOrEmpty(firstNumbAsString) And Not String.IsNullOrWhiteSpace(firstNumbAsString) Then

                ' Verify if input is a number
                Dim firstNumb As Integer
                If Integer.TryParse(firstNumbAsString, firstNumb) Then

                    ' Verify if number is between 0 and 10
                    If firstNumb >= 0 And firstNumb <= 10 Then
                        Console.Write("Please Enter your End-Number (0-10): ")
                        Dim secondNumbAsString As String = Console.ReadLine()

                        ' Verify if input is not null, empty, or whitespace
                        If Not String.IsNullOrEmpty(firstNumbAsString) And Not String.IsNullOrWhiteSpace(firstNumbAsString) Then

                            ' Verify if input is a number
                            Dim secondNumb As Integer
                            If Integer.TryParse(secondNumbAsString, secondNumb) Then

                                If secondNumb >= 0 And secondNumb <= 10 Then
                                    Console.WriteLine()
                                    If firstNumb < secondNumb Then
                                        While firstNumb <= secondNumb
                                            Console.WriteLine($"Numb: {firstNumb}")
                                            firstNumb += 1
                                        End While
                                        fin = True
                                    ElseIf firstNumb > secondNumb Then
                                        While firstNumb >= secondNumb
                                            Console.WriteLine($"Numb: {firstNumb}")
                                            firstNumb -= 1
                                        End While
                                        fin = True
                                    Else
                                        Console.WriteLine($"{nl}Cannot create a loop because both numbers are equal!")
                                    End If

                                Else
                                    Console.WriteLine("Input is not between 0 and 10!")
                                End If
                            Else
                                Console.WriteLine("Input is not a Integer!")
                            End If

                        Else
                            Console.WriteLine("Input is null, empty, or whitespace!")
                        End If
                    Else
                        Console.WriteLine("Input is not between 0 and 10!")
                    End If
                Else
                    Console.WriteLine("Input is not a Integer!")
                End If

            Else
                Console.WriteLine("Input is null, empty, or whitespace!")
            End If

            Console.WriteLine($"{nl}{nl}Continue with any key...")
            Console.ReadKey()
            Console.Clear()

        Loop While fin = False

#End Region

#Region "6)"

        ' 6. Erstellen Sie ein Programm, das je nach Eingabe eine bestimmte Anzahl von * ausgibt.

        'Console.WriteLine($"{nl}{nl}############# Exercise 6: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

#Region "7)"

        ' 7. Erstellen Sie ein Programm, das von 0 bis 100 zählt. Das Programm soll bei jeder Zahl überprüfen,
        ' ob Sie ohne Rest durch 2 Teilbar ist. (Hinweis: Modulo.zahl Mod 2 = 0). Wenn ja, soll das
        ' Programm 'Zahl' ist durch 2 Teilbar ausgeben. ansonsten 'Zahl' ist nicht durch 2 Teilbar.

        'Console.WriteLine($"{nl}{nl}############# Exercise 7: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

#Region "8)"

        ' 8. Verbessern Sie das Programm aus Übung 7. Der Benutzer kann jetzt einen Zahlenbereich wählen
        ' und eine Zahl. Danach soll überprüft werden welche Zahlen in dem Zahlenbereich durch die Zahl
        ' teilbar sind.

        'Console.WriteLine($"{nl}{nl}############# Exercise 8: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

#Region "9)"

        ' 9. Entwickeln Sie ein Programm, dass einem Einbrecher hilft ein 4 Stelliges Zahlenschloss zu
        ' knacken.Das Zahlenschloss akzeptiert an jeder Stelle Zahlen von 0-36. Es besitzt 4 Stellen.
        ' Eine mögliche Kombination wäre zb.
        ' 36-22-11-14
        ' Schreiben Sie eine Funktion, die ihnen alle möglichen Kombinationen des Zahlenschlosses (auf
        ' der Konsole) ausgibt.

        'Console.WriteLine($"{nl}{nl}############# Exercise 9: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

#Region "10)"

        ' 10. Erstellen Sie ein Programm, das das kleine Einmaleins ausgibt.11. Geben Sie einen Christbaum aus. Der Benutzer kann die Höhe wählen:
        ' zb.: Höhe 10
        ' Die Formel für den Baum ist
        ' Leerzeichenanzahl Links / Rechts = Höhe – 1 – i
        ' Sterne = i * 2 + 1
        ' i = Nummer des Durchlaufs.

        'Console.WriteLine($"{nl}{nl}############# Exercise 10: #############")

        'Console.WriteLine($"{nl}{nl}Continue with any key...")
        'Console.ReadKey()
        'Console.Clear()

#End Region

    End Sub
End Module
