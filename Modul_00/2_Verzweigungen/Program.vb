Imports System

Module Program
    Sub Main(args As String())

        Dim nl As String = vbCrLf

        'Aufgabenblatt – Verzweigungen:


#Region "1)"
        '1. Erstellen Sie eine Programm, das eine Integer Variable anlegt. Weisen Sie dieser Integer Variable
        'den Wert 42 zu. Erstellen Sie eine Verzweigung, die prüft, ob diese Integer Variable einen Wert
        'hat, der kleiner oder gleich 42 ist. Geben Sie "Kleinergleich 42" auf der Konsole aus, wenn die
        'Verzweigung betreten wird.

        Dim first As Integer = 42

        Console.WriteLine($"{nl}############# Exercise 1: #############")

        If first <= 42 Then
            Console.WriteLine($"Value of variable ""first"" smaller than, or equals to 42!")
        Else
            Console.WriteLine($"Value of variable ""first"" bigger than 42!")
        End If

        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()
#End Region

#Region "2)"

        '2. Erstellen Sie ein Programm, das eine Zeichenkette von der Konsole einliest. Erstellen Sie eine
        'Verzweigung die prüft, ob der eingegebene Name ihrem Namen entspricht. Geben Sie "Hallo,
        ''Name'" aus, wenn ja. Ansonsten geben Sie "Geh weg, ich kenne dich nicht" aus.

        Console.WriteLine($"{nl}############# Exercise 2: #############")
        Console.Write("Enter your name please: ")
        Dim name As String = Console.ReadLine()

        If Not String.IsNullOrEmpty(name) Then
            If name = "Tom" Then
                Console.WriteLine($"Hy ""{name}""")
            Else
                Console.WriteLine($"Go away!{nl}I don't know you ""{name}""")
            End If
        Else
            Console.WriteLine("Input is NULL or EMPTY!")
        End If
        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

#End Region

#Region "3)"

        '3. Erstellen Sie ein Programm, das eine Ganzzahl einliest. Prüfen Sie, ob die Eingabe kleiner 0 ist.
        'Geben Sie "Du hast eine negative Zahl eingegeben aus, wenn das zutrifft. Prüfen Sie ob die Zahl
        'genau null ist. Geben Sie in diesem Fall "Du hast 0 eingegeben" aus. Prüfen Sie weiters, ob die
        'Zahl größer 0 ist. Geben Sie in diesem Fall: "Du hast eine positive Zahl eingegeben" aus.

        Console.WriteLine($"{nl}############# Exercise 3: #############")
        Console.Write("Please insert a valid integer: ")
        Dim intNumberAsString As String = Console.ReadLine()

        If Not String.IsNullOrEmpty(intNumberAsString) And Not String.IsNullOrWhiteSpace(intNumberAsString) Then
            Dim intNumber As Integer
            Integer.TryParse(intNumberAsString, intNumber)

            If intNumber < 0 Then
                Console.WriteLine($"Your input ""{intNumber}"" is a negative number.")
            ElseIf intNumber = 0 Then
                Console.WriteLine("Your input was 0.")
            ElseIf intNumber > 0 Then
                Console.WriteLine($"Your input ""{intNumber}"" is a positive number.")
            End If
        Else
            Console.WriteLine("Input was NULL, EMPTY, or a whitespace!")
        End If

        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

#End Region

#Region "4)"

        '4. Erstellen Sie ein Programm, das eine Zahl, das Alter, von der Konsole einliest. Wenn die Zahl
        'kleiner 3 ist geben Sie Kleinkind aus. Wenn die Zahl kleiner 10 ist geben Sie Kind aus. Wenn die
        'Zahl kleiner 18 ist geben Sie Jugendlicher aus. Wenn die Zahl kleiner 70 ist geben Sie
        'Erwachsener aus. Wenn die Zahl größer oder gleich 70 ist geben Sie Pensionist aus.

        Console.WriteLine($"{nl}############# Exercise 4: #############")
        Console.Write("Please enter your age: ")
        Dim ageAsString As String = Console.ReadLine()

        If Not String.IsNullOrEmpty(ageAsString) And Not String.IsNullOrWhiteSpace(ageAsString) Then
            Dim age As Integer
            Integer.TryParse(ageAsString, age)

            If age < 3 Then
                Console.WriteLine("Small child. :D")
            ElseIf age < 13 Then
                Console.WriteLine("Child. :)")
            ElseIf age < 20 Then
                Console.WriteLine("Teenager.")
            ElseIf age < 70 Then
                Console.WriteLine("Adult person. :(")
            Else
                Console.WriteLine("Pensioner. :/")
            End If
        Else
            Console.WriteLine("Input was NULL, EMPTY, or a whitespace!")
        End If

        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

#End Region

#Region "5)"

        '5. Lesen Sie eine Zeichenkette von der Konsole ein. Prüfen Sie, ob diese Zeichenkette aus 'r'
        'besteht. Geben Sie in diesem Fall: 'Von der Festplatte lesen' aus. Wenn die eingelesene
        'Zeichenkette aus 'w' besteht geben Sie "Schreiben" aus. Wenn die Zeichenkette aus 'rw'
        'besteht, geben Sie "Lesen und Schreiben" aus. Ansonsten geben Sie "Unbekannter Befehl" aus.

        Console.WriteLine($"{nl}############# Exercise 5: #############")
        Console.WriteLine("You can choose one of following options:")
        Console.WriteLine("To read from the Hard Disc type ""r"" into the console.")
        Console.WriteLine("To write on the Hard Disc type ""w"" into the console.")
        Console.WriteLine("To read and write type ""rw"" into the console.")
        Console.Write($"{nl}Choose your option (r, w, rw): ")
        Dim input = Console.ReadLine()

        If Not String.IsNullOrEmpty(input) And Not String.IsNullOrWhiteSpace(input) Then
            If input.ToLower() = "r" Then
                Console.WriteLine($"{nl}Read from the Hard Disk...")
            ElseIf input.ToLower() = "w" Then
                Console.WriteLine($"{nl}Write to the Hard Disk...")
            ElseIf input.ToLower() = "rw" Then
                Console.WriteLine($"{nl}Read and write from and to the Hard Disk...")
            Else
                Console.WriteLine($"{nl}Unknown command...")
            End If
        Else
            Console.WriteLine("Input was NULL, EMPTY, or a whitespace!")
        End If

        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

#End Region

#Region "6)"

        '6. Erstellen Sie ein Programm (oder eine Methode), das prüft wer im Blackjack gewonnen hat.:
        'Lesen Sie dazu Werte in zwei Integer Variablen ein, die die Punktestände der Spieler darstellen.
        'Benutzen Sie folgende Regeln um Herauszufinden wer gewonnen hat und geben Sie das Ergebnis
        'auf der Konsole aus.:
        '    a. Ein Spieler dessen Zahl größer als 21 ist hat verloren.
        '    b. Der Spieler der die größere Zahl hat, hat gewonnen.
        '    c. Haben beide die gleiche Zahl ist das Spiel unentschieden.

        Console.WriteLine($"{nl}############# Exercise 6 (BlackJack): #############")
        Console.Write("Enter value of Player 1: ")
        Dim playerOneAsString As String = Console.ReadLine()
        Console.Write("Enter value of Player 2: ")
        Dim playerTwoAsString As String = Console.ReadLine()

        If Not String.IsNullOrEmpty(playerOneAsString) And
            Not String.IsNullOrWhiteSpace(playerOneAsString) And
            Not String.IsNullOrEmpty(playerTwoAsString) And
            Not String.IsNullOrWhiteSpace(playerTwoAsString) Then

            Dim playerOne As Integer
            Dim playerTwo As Integer
            Integer.TryParse(playerOneAsString, playerOne)
            Integer.TryParse(playerTwoAsString, playerTwo)


            If playerOne > playerTwo And playerOne <= 21 Then
                Console.WriteLine($"{nl}Player 1: ""{playerOne}"" -> WINNER")
                Console.WriteLine($"Player 2: ""{playerTwo}"" -> LOOSER")

            ElseIf playerOne < playerTwo And playerTwo <= 21 Then
                Console.WriteLine($"{nl}Player 1: ""{playerOne}"" -> LOOSER")
                Console.WriteLine($"Player 2: ""{playerTwo}"" -> WINNER")

            ElseIf playerOne > 21 And playerTwo <= 21 Then
                Console.WriteLine($"{nl}Player 1: ""{playerOne}"" -> LOOSER")
                Console.WriteLine($"Player 2: ""{playerTwo}"" -> WINNER")

            ElseIf playerOne <= 21 And playerTwo > 21 Then
                Console.WriteLine($"{nl}Player 1: ""{playerOne}"" -> WINNER")
                Console.WriteLine($"Player 2: ""{playerTwo}"" -> LOOSER")

            Else
                Console.WriteLine($"{nl}Player 1: ""{playerOne}""")
                Console.WriteLine($"Player 2: ""{playerTwo}""")
                Console.WriteLine("----- DRAW -----")

            End If

        Else
            Console.WriteLine("One Player-input was NULL, EMPTY, or a whitespace!")
        End If

        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

#End Region

#Region "7)"

        '7. Erstellen Sie einen primitiven Taschenrechner. Der Benutzer soll eine Rechenart auswählen
        'können(+,-,/,*) und danach zwei Zahlen eingeben um das Ergebnis zu berechnen.

        Console.WriteLine($"{nl}############# Exercise 7: #############")
        Console.Write("Please choose your operator (+,-,/,*): ")
        Dim input As String = Console.ReadLine()

        ' Verify input variable -> If it is not null, empty, or Whitespace
        ' Verify if input variable is a valid operator (+,-,/,*)
        If Not String.IsNullOrEmpty(input) And Not String.IsNullOrWhiteSpace(input) Then
            If input = "+" Or input = "-" Or input = "*" Or input = "/" Then
                Console.Write($"{nl}Please insert your first number: ")
                Dim numbOneAsString As String = Console.ReadLine()

                ' Verify if variable "numbOneAsString" is not null, empty, or a Whitespace
                If Not String.IsNullOrEmpty(numbOneAsString) And Not String.IsNullOrWhiteSpace(numbOneAsString) Then

                    ' Verify if value of variable is an integer
                    Dim numbOne As Integer
                    If Integer.TryParse(numbOneAsString, numbOne) Then
                        Console.Write($"{nl}Please insert your second number: ")
                        Dim numbTwoAsString As String = Console.ReadLine()

                        ' Verify if variable "numbTwoAsString" is not null, empty, or a Whitespace
                        If Not String.IsNullOrEmpty(numbTwoAsString) And Not String.IsNullOrWhiteSpace(numbTwoAsString) Then

                            ' Verify if value of variable is an integer
                            Dim numbTwo As Integer
                            If Integer.TryParse(numbTwoAsString, numbTwo) Then

                                ' Create operation
                                Select Case input
                                    Case "+"
                                        Console.WriteLine($"{numbOne} + {numbTwo} = {numbOne + numbTwo}")
                                    Case "-"
                                        Console.WriteLine($"{numbOne} - {numbTwo} = {numbOne - numbTwo}")
                                    Case "*"
                                        Console.WriteLine($"{numbOne} * {numbTwo} = {numbOne * numbTwo}")
                                    Case "/"
                                        Console.WriteLine($"{numbOne} / {numbTwo} = {numbOne / numbTwo}")

                                End Select
                            Else
                                Console.WriteLine("Value of numberTwo is not a number!")
                                Console.WriteLine($"Value of numberTwo: ""{numbTwoAsString}""")
                            End If
                        Else
                            Console.WriteLine("The ""second"" number was NULL, EMPTY, or a whitespace!")
                        End If
                    Else
                        Console.WriteLine("Value of numberOne is not a number!")
                        Console.WriteLine($"Value of numberOne: ""{numbOneAsString}""")
                    End If
                Else
                    Console.WriteLine("The ""first"" number was NULL, EMPTY, or a whitespace!")
                End If
            Else
                Console.WriteLine("Invalid Operator!")

            End If
        Else
            Console.WriteLine("Input was NULL, EMPTY, or a whitespace!")

        End If


        Console.WriteLine($"{nl}{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

#End Region

    End Sub
End Module
