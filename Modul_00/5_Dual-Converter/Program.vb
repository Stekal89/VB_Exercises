Imports System

Public Module Program

#Region "Help-Functions"
    Function ColorRed()
        Console.ForegroundColor = ConsoleColor.Red
        Return Nothing
    End Function

    Function ColorGray()
        Console.ForegroundColor = ConsoleColor.Gray
        Return Nothing
    End Function

    Function ColorDarkGreen()
        Console.ForegroundColor = ConsoleColor.DarkGreen
        Return Nothing
    End Function
#End Region

    Public nl As String = vbCrLf

    Sub Main(args As String())

        'Dualzahlen:

        '1) Entwickeln Sie ein Programm, das für eine eingegebene Dezimalzahl (nur ganze Zahlen) die
        'entsprechende Dualzahl berechnet. Lesen Sie eine Zahl von der Eingabeaufforderung ein. Dividieren
        'Sie die Zahl sukzessive durch 2, solange, bis kein Rest mehr bleibt. Die Reste ergeben die
        'Entsprechende Dualzahl.
        'zb.
        '100 / 2 = 50 R: 0
        '50 / 2 = 25 R: 0
        '25 / 2 = 12 R: 1
        '12 / 2 = 6 R: 0
        '6 / 2 = 3 R: 0
        '3 / 2 = 1 R: 1
        '1 / 2 = 0 R: 1
        'Binärzahl : 1100100
        'Probe:
        '1 * 2^6 + 1 * 2^5 + 0 * 2^4 + 0*2^3 + 1* 2^2 + 0 * 2^1 + 0* 2^0 = 100
        '64 + 32 + 4 = 100

        Dim inputAsString As String
        Dim binaryOutput As String
        Dim octaOutput As String
        Dim hexOutput As String

        Do
            Console.WriteLine($"{nl}{nl}{vbTab}# # # # D U A L - C O N V E R T E R # # # #{nl}")

            Console.WriteLine("To exit the application, please write exit into the command line!")
            Console.Write("Please insert your number, which you want to convert: ")
            inputAsString = Console.ReadLine()
            Console.WriteLine()

            Dim input As Integer? = ConvertStringIntoInteger(inputAsString)

            If input = 0 Then
                input = Nothing
            End If

            '2) Gliedern Sie die Berechnungsmethode in eine Funktion aus, die eine int zahl übernimmt und eine
            'Binärzahl (in Form eines Strings) zurückgibt.
            binaryOutput = GetBinarayResult(input)

            If input IsNot Nothing Then
                Console.WriteLine($"{nl}Decimal: ""{input}""")
            End If

            If Not String.IsNullOrEmpty(binaryOutput) Then
                Console.WriteLine($"Binary:  ""{binaryOutput}""")

            Else
                ColorRed()
                Console.WriteLine("Output variable for Binary (Type String) is NULL!")
                ColorGray()
            End If

            'Bonusaufgaben:
            '3) Schreiben Sie eine weitere Funktion zur Umrechnung von Dezimalzahlen in Oktalzahlen.
            'Gehen Sie dazu gleich vor wie bei der Konvertierung in Dualzahlen. Ersetzen Sie nur den
            'Schritt "Divison durch 2" durch den Schritt "Divison durch 8".
            '100 / 8 = 12 R: 4
            '12 / 8 = 1 R: 4
            '1 / 8 = 0 R: 1
            '1 * 8^2 + 4 * 8^1 + 4 * 8^0 = 100
            '64 + 32 + 4 = 100

            octaOutput = GetOctaResult(input)

            If Not String.IsNullOrEmpty(octaOutput) Then
                Console.WriteLine($"Octa:    ""{octaOutput}""")

            Else
                ColorRed()
                Console.WriteLine("Output variable for Okta (Type String) ins NULL!")
                ColorGray()
            End If

            '3) Generalisieren Sie ihre Funktion und ermöglichen Sie außerdem die Berechnung von
            'Hexadezimalzahlen
            'Achtung ! in Visual Basic wird eine ganzzahlige Division mit dem „\“ (Backslash) – Operator
            'durchgeführt.

            hexOutput = GetHEXResult(input)

            If Not String.IsNullOrEmpty(hexOutput) Then
                Console.WriteLine($"HEX:     ""{hexOutput}""")

            Else
                ColorRed()
                Console.WriteLine("Output variable for HEX (Type String) ins NULL!")
                ColorGray()
            End If

            Console.WriteLine($"{nl}{nl}Continue With any key...")
            Console.ReadKey()
            Console.Clear()

        Loop While inputAsString <> "Exit"

    End Sub

    ''' <summary>
    ''' Gets a value as string and validates it:
    ''' - if string is not null, empty, or whitespace
    ''' - if input is integer -> TryParse
    ''' </summary>
    ''' <param name="input">value as string</param>
    ''' <returns>success -> string converted as integer
    '''          failure -> "-1"</returns>
    Public Function ConvertStringIntoInteger(input As String) As Integer?

        If Not String.IsNullOrEmpty(input) And Not String.IsNullOrWhiteSpace(input) Then

            Dim output As Integer
            If Integer.TryParse(input, output) Then
                Return output
            Else
                ColorRed()
                Console.WriteLine("Input is not an Integer!")
                Console.WriteLine($"Input: ""{input}""")
                ColorGray()
            End If

        Else
            ColorRed()
            Console.WriteLine("Input is null, empty, or whitespace!")
            ColorGray()
        End If

        Return Nothing

    End Function

    ''' <summary>
    ''' Converts Integer into binary in groups of four.
    ''' </summary>
    ''' <param name="input">input as Integer</param>
    ''' <returns>connverted, sorted binary</returns>
    Public Function GetBinarayResult(input As Integer?) As String

        If input IsNot Nothing Then

            Dim binList As Stack(Of Integer) = GetRestOfIntegerInStack(input, 2)

            If binList IsNot Nothing Then

                Return OrderAndGroupRestResult(binList, 4)

            End If

        Else
            ColorRed()
            Console.WriteLine("Cannot convert INPUT into INTEGER!")
            ColorGray()

        End If

        Return Nothing

    End Function

    ''' <summary>
    ''' Converts Integer into octa in groups of three
    ''' </summary>
    ''' <param name="input">input as Integer</param>
    ''' <returns>converted, sorted octa</returns>
    Public Function GetOctaResult(input As Integer?) As String

        If input IsNot Nothing Then
            Dim octaList As Stack(Of Integer) = GetRestOfIntegerInStack(input, 8)

            If octaList IsNot Nothing Then

                Dim endResult As String = OrderAndGroupRestResult(octaList, 3)
                Return endResult.TrimStart("0").TrimStart(" ")

            End If
        Else
            ColorRed()
            Console.WriteLine("Cannot convert INPUT into INTEGER!")
            ColorGray()
        End If

        Return Nothing

    End Function

    ''' <summary>
    ''' Converrts Integer into HEX in groups of four
    ''' </summary>
    ''' <param name="input">input as Integer</param>
    ''' <returns>converted, sorted HEX</returns>
    Public Function GetHEXResult(input As Integer?) As String
        If input IsNot Nothing Then
            Dim hexList As Stack(Of Integer) = GetRestOfIntegerInStack(input, 16)

            If hexList IsNot Nothing Then

                Dim endResult As String = OrderAndGroupRestResult(hexList, 4)
                Return endResult.TrimStart("0").TrimStart(" ")

            End If
        Else
            ColorRed()
            Console.WriteLine("Cannot convert INPUT into INTEGER!")
            ColorGray()
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Calculates the Rest of the given parameter, depends on the dividor, to get a wrong sorted stack of Integer -> Binaries, Octa, HEX
    ''' </summary>
    ''' <param name="input">input as integer</param>
    ''' <param name="dividor">dividor, which will be used to get the rest</param>
    ''' <returns>wrong sorted stack of Integer</returns>
    Public Function GetRestOfIntegerInStack(input As Integer, dividor As Integer) As Stack(Of Integer)

        ' Convert to Binary, Octa, or HEX
        Dim converted As Boolean = False
        Dim rest As Integer
        Dim result As Double
        Dim restList As New Stack(Of Integer)

        Do
            ' Get rest result (one index)
            rest = input Mod dividor

            ' Get result of the calculation, rounded down, because we only need the first
            result = input / dividor
            result = Math.Floor(result)

            'Console.WriteLine($"{input} / 2 = {res} ""{rest} Rest""")

            ' Add result to stack of Binaries, Octa, or HEX
            restList.Push(rest)

            ' overwrite the input with the result to calculate the next rest result
            input = CInt(result)
        Loop While input > 0

        Return restList

    End Function

    ''' <summary>
    ''' Groups Rest-Result (Stack) into group of "groupLength" e.g. 4: 
    ''' -> 1234 1234
    ''' Gets the needed result in correct order into a string variable and returns it afterwards.
    ''' </summary>
    ''' <param name="restList">Stack of calculated Rest of the divisions</param>
    ''' <param name="groupLength">lenght of one displayed group: e.g. 1111 4444</param>
    ''' <returns>grouped and sorted result in string</returns>
    Public Function OrderAndGroupRestResult(restList As Stack(Of Integer), groupLength As Integer) As String

        ' To group the result in groups of four we need to add "0" into the stacks
        Dim zeroNeeded As Integer = restList.Count Mod groupLength
        If zeroNeeded <> groupLength Then

            For i = 1 To groupLength - zeroNeeded
                restList.Push(0)
            Next

        End If

        Dim sortedResult As String = Nothing
        Dim actualRest As Integer
        For i = 0 To restList.Count() - 1

            ' Group the result in groups of four
            If Not String.IsNullOrEmpty(sortedResult) Then

                Dim withoutWhiteSpaces As New String(sortedResult.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())

                If withoutWhiteSpaces.Count Mod groupLength = 0 Then
                    sortedResult += " "
                End If
            End If

            actualRest = restList.Pop()
            If actualRest < 10 Then
                ' Add result to the variable, which will be needed to display the endresult on the console.
                sortedResult += actualRest.ToString()
            Else
                Select Case actualRest
                    Case 10
                        sortedResult += "A"
                    Case 11
                        sortedResult += "B"
                    Case 12
                        sortedResult += "C"
                    Case 13
                        sortedResult += "D"
                    Case 14
                        sortedResult += "E"
                    Case 15
                        sortedResult += "F"
                End Select
            End If
        Next

        Return sortedResult

    End Function

End Module
