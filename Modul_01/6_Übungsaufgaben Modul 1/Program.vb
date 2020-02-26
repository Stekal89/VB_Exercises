Imports System

Module Program

#Region "Help-Functions"

    ''' <summary>
    ''' Writes Errors in console foreground color Red
    ''' </summary>
    ''' <param name="text"></param>
    Sub WriteError(text As String)
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(text)
        Console.ForegroundColor = ConsoleColor.Gray
    End Sub

    ''' <summary>
    ''' Writes Errors in console foreground color Dark-Yellow
    ''' </summary>
    ''' <param name="text"></param>
    Sub WriteWarning(text As String)
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.WriteLine(text)
        Console.ForegroundColor = ConsoleColor.Gray
    End Sub

    ''' <summary>
    ''' Default method to continue with any key
    ''' </summary>
    Sub ContinueWithAnyKey()

        Console.WriteLine($"{nl}Continue with any key...")
        Console.ReadKey()
        Console.Clear()

    End Sub

#End Region

    Private nl As String = vbCrLf

    Sub Main(args As String())

        'Modul1 Übungen

        Dim exercise As String

        Do
            Console.WriteLine($"{nl}{nl}{vbTab}# # # # E X E R C I S E S   M O D U L   0 1 # # # #{nl}")

            Console.WriteLine("Choose the exercise, which you want by typing the number of the exercise into the command line.")
            Console.WriteLine($"To close the application, please type exit into the command line.{nl}")
            Console.WriteLine("1) Exercise 1")
            Console.WriteLine("2) Exercise 2")
            Console.WriteLine("3) Exercise 3")
            Console.Write("Choose your Exercise: ")
            exercise = Console.ReadLine()

            If ValidateStringInput(exercise) Then

                Select Case exercise
                    Case "1"
#Region "1)"

                        '1. Erstellen Sie die Methode UpDownString mit der Signatur:
                        ' [] static string UpDownString(string text)
                        'Die Methode soll im string text abwechselnd ein Wort groß und das nächste Wort klein schrei
                        'ben. Danach soll sie den text zurückgeben.

                        Console.Clear()
                        Console.WriteLine($"{nl}{nl}{vbTab}###### Exercise 1 ######{nl}")
#End Region
                    Case "2"
#Region "2)"

                        '2. Erstellen Sie folgendes Benutzermenü.
                        '   1. Benutzer anlegen.
                        '   2. Benutzer löschen.
                        '   3. Benutzer ändern.
                        '   4. Programmende.
                        'Legen Sie eine Liste von strings an.
                        '   1. Wenn der Punkt Benutzer anlegen aufgerufen wird, tragen Sie einen neuen String
                        '      am Ende in ihre Liste ein.
                        '   2. Wenn der Punkt Benutzer löschen aufgerufen wird, kann ein Benutzer
                        '      ausgewählt werden, der danach gelöscht wird.
                        '   3. Benutzer ändern erlaubt erneut die Auswahl eines Benutzers, der danach
                        '      geändert werden kann. (neuer name)
                        '   4. Programmende beendet das Programm.

                        Console.Clear()
                        Console.WriteLine($"{nl}{nl}{vbTab}###### Exercise 2 ######{nl}")

#End Region
                    Case "3"
#Region "3)"

                        '3. Erstellen Sie die Methoden mit den folgenden Signaturen:
                        '[] static int CountWords(string sentence)
                        '[] static int CountSimilarWords(string sentence, string sentenceToCompare)
                        '[] static int CountSimilarSentences(string text, string text2)
                        'CountWords ist eine einfache Hilfsmethode, die sie später benötigen. Sie zählt lediglich die Wörter eines Satzes und gibt deren Anzahl zurück.
                        'CountSimilarWords nimmt zwei Sätze entgegen und zählt wieviele Wörter des ersten Satzes im zweiten Satz vorkommen. Verwenden Sie hierzu Schleifen und die Contains Methode.
                        'CountSimilarSentences zählt wieviele Sätze in zwei Texten gleich waren.
                        'Hinweis: Zwei Sätze sind gleich, wenn all ihre Wörter gleich sind. Verwenden Sie dazu Count
                        'SimilarWords und CountWords.

                        Console.Clear()
                        Console.WriteLine($"{nl}{nl}{vbTab}###### Exercise 3 ######{nl}")

#End Region
                    Case Else
                        WriteError($"{nl}Unknown input!")
                        WriteError($"Input: ""{exercise}""")
                        WriteWarning("Correct input would be: ""1"", ""2"", ""3"", or ""exit""")

                End Select

            End If

            ContinueWithAnyKey()

        Loop While exercise.ToLower() <> "exit"

    End Sub

    Function ValidateStringInput(input As String) As Boolean

        If Not String.IsNullOrEmpty(input) And Not String.IsNullOrWhiteSpace(input) Then
            Return True
        Else
            WriteError($"{nl}String-Input Is NULL, EMPTY, Or WHITESPACE!")
            Return False
        End If

    End Function

End Module
