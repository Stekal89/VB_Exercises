Imports System

Module Program
    Dim rnd As Random = New Random

    Sub Main(args As String())

        Dim nl As String = vbCrLf

        'Zahlenraten:
        'Programmieren Sie ein Spiel, bei dem der Benutzer eine Zufallszahl zwischen 1 und 6 erraten muss.

        Dim success As Boolean = False

        Do
            Dim guesTry As Integer = 1

            Console.WriteLine($"{nl}{nl}{vbTab}# # # # N U M B E R   G U E S S # # # #")
            '1. Lesen Sie dazu einen Wert von der Eingabeaufforderung ein.
            Console.Write("Please insert your number (1 - 6): ")
            Dim userNumbAsString As String = Console.ReadLine()
            Console.WriteLine()

            If Not String.IsNullOrEmpty(userNumbAsString) And Not String.IsNullOrWhiteSpace(userNumbAsString) Then

                '3. Wandeln Sie die eingegebene Zeichenkette in eine Zahl um ! (int.Parse(..))
                Dim userNumb As Integer
                If Integer.TryParse(userNumbAsString, userNumb) Then

                    If userNumb >= 1 And userNumb <= 6 Then

                        '2. Ermitteln Sie danach einen Wert zwischen 1 und 6 mittels der Funktion Random.Next(1,6)
                        Dim randomNumb As Integer = rnd.Next(1, 6)

                        '4. Vergleichen Sie den eingegebenen Wert mit der eingelesenen Zahl. Sind sie gleich, hat der
                        'Benutzer gewonnen andernfalls verloren. Geben Sie eine enstprechende Nachricht auf der
                        'Kommandozeile aus.

                        Console.WriteLine($"Your Number:   ""{userNumb}""")
                        Console.WriteLine($"Random Number: ""{randomNumb}""")

                        If userNumb = randomNumb Then
                            Console.ForegroundColor = ConsoleColor.DarkGreen
                            Console.WriteLine("You win. Numbers are matching!")
                            Console.ForegroundColor = ConsoleColor.Gray
                        Else
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("You loose. Numbers are not matching!")
                            Console.ForegroundColor = ConsoleColor.Gray
                        End If

                        '5. Erweitern Sie ihr Programm, sodass es solange weitermacht, bis der Benutzer ein mal
                        'gewonnen hat.

                        '6. Erweitern Sie ihr Programm, sodass der Benutzer 6 mal gewinnen muss bevor das Spiel
                        'gewonnen ist.

                        '7. Benutzen Sie Console.Clear() an einer geeigneten Stelle um die alten eingaben zu löschen.

                    Else
                        Console.WriteLine("Input is not between 1 and 6!")
                        Console.WriteLine($"Input: ""{userNumb}""")
                    End If

                Else
                    Console.WriteLine("Input is not an Integer!")
                    Console.WriteLine($"Input: ""{userNumb}""")
                End If

            Else
                Console.WriteLine("Input is null, empty, or whitespace!")

            End If

            Console.WriteLine($"{nl}{nl}Continue with any key...")
            Console.ReadKey()
            Console.Clear()

        Loop While Not success

    End Sub
End Module
