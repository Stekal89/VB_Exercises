Imports System

Module Program

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

    Sub Main(args As String())

        Dim nl As String = vbCrLf

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

        Do
            Console.WriteLine($"{nl}{nl}{vbTab}# # # # D U A L - C O N V E R T E R # # # #{nl}")

            Console.WriteLine("To exit the application, please write exit into the command line!")
            Console.Write("Please insert your number, which you want to convert: ")
            inputAsString = Console.ReadLine()
            Console.WriteLine()

            Dim input As Integer? = ConvertStringIntoInteger(inputAsString)

            If input IsNot Nothing Then

                ' Convert to Binary
                Dim converted As Boolean = False
                Dim rest As Integer
                Dim res As Double
                Dim binList As New Stack(Of Integer)

                Do
                    ' Get binary result (one index)
                    rest = input Mod 2

                    ' Get result of the calculation, rounded down, because we only need the first
                    res = input / 2
                    res = Math.Floor(res)

                    'Console.WriteLine($"{input} / 2 = {res} ""{rest} Rest""")

                    ' Add result to stack of binaries
                    binList.Push(rest)

                    ' overwrite the input with the result to calculate the next binary
                    input = CInt(res)
                Loop While input > 0

                ' To group the result in groups of four we need to add "0" into the stacks
                Dim zeroNeeded As Integer = binList.Count Mod 4
                If zeroNeeded <> 4 Then

                    For i = 1 To 4 - zeroNeeded
                        binList.Push(0)
                    Next

                End If

                Dim endResult As String = Nothing
                For i = 0 To binList.Count() - 1

                    ' Group the result in groups of four
                    If Not String.IsNullOrEmpty(endResult) Then

                        Dim withoutWhiteSpaces As New String(endResult.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())

                        If withoutWhiteSpaces.Count Mod 4 = 0 Then
                            endResult += " "
                        End If
                    End If

                    ' Add result to the variable, which will be needed to display the endresult on the console.
                    endResult += binList.Pop().ToString()
                Next

                Console.WriteLine($"{nl}EndResult: ""{endResult}""")

            Else
                ColorRed()
                Console.WriteLine("Cannot convert INPUT into INTEGER!")
                ColorGray()

            End If

            Console.WriteLine($"{nl}{nl}Continue With any key...")
            Console.ReadKey()
            Console.Clear()


        Loop While inputAsString <> "Exit"



        '2) Gliedern Sie die Berechnungsmethode in eine Funktion aus, die eine int zahl übernimmt und eine
        'Binärzahl (in Form eines Strings) zurückgibt.

        'Bonusaufgaben:
        '3) Schreiben Sie eine weitere Funktion zur Umrechnung von Dezimalzahlen in Oktalzahlen.
        'Gehen Sie dazu gleich vor wie bei der Konvertierung in Dualzahlen. Ersetzen Sie nur den
        'Schritt "Divison durch 2" durch den Schritt "Divison durch 8".
        '100 / 8 = 12 R: 4
        '12 / 8 = 1 R: 4
        '1 / 8 = 0 R: 1
        '1 * 8^2 + 4 * 8^1 + 4 * 8^0 = 100
        '64 + 32 + 4 = 100

        '3) Generalisieren Sie ihre Funktion und ermöglichen Sie außerdem die Berechnung von
        'Hexadezimalzahlen
        'Achtung ! in Visual Basic wird eine ganzzahlige Division mit dem „\“ (Backslash) – Operator
        'durchgeführt.



    End Sub

    ''' <summary>
    ''' Gets a value as string and validates it:
    ''' - if string is not null, empty, or whitespace
    ''' - if input is integer -> TryParse
    ''' </summary>
    ''' <param name="input">value as string</param>
    ''' <returns>success -> string converted as integer
    '''          failure -> "-1"</returns>
    Function ConvertStringIntoInteger(input As String) As Integer

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

End Module
