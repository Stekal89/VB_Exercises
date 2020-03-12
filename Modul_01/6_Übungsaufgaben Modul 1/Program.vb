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
    ''' Writes successfully output in console foreground color Dark-Green
    ''' </summary>
    ''' <param name="text"></param>
    Sub WriteSuccess(text As String)
        Console.ForegroundColor = ConsoleColor.DarkGreen
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

    ReadOnly nl As String = vbCrLf

    Sub Main()

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

            If ValidateStringInput(exercise.ToLower()) Then

                Select Case exercise
                    Case "1"
#Region "1)"

                        '1. Erstellen Sie die Methode UpDownString mit der Signatur:
                        ' [] static string UpDownString(string text)
                        'Die Methode soll im string text abwechselnd ein Wort groß und das nächste Wort klein schreiben. Danach soll sie den text zurückgeben.

                        Console.Clear()

                        Dim textToConvert As String
                        Dim success As Boolean
                        Do
                            Console.WriteLine($"{nl}{nl}{vbTab}###### Exercise 1 ######{nl}")
                            Console.Write("Please enter a text to convert: ")
                            textToConvert = Console.ReadLine()
                            Console.WriteLine()

                            If ValidateStringInput(textToConvert) Then
                                Dim consoleOutput As String = UpDownString(textToConvert)
                                Console.WriteLine("Converted text:")
                                WriteSuccess(consoleOutput)
                                success = True
                            End If
                            ContinueWithAnyKey()

                        Loop While textToConvert.ToLower() <> "exit" And Not success

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

                        Dim finished As Boolean
                        Dim inputAsString
                        Dim users As List(Of String) = New List(Of String) From {"Max Mustermann", "Jonny Johnson", "Ida Fröhlich", "Julie Williams"}

                        Do
                            Console.WriteLine($"{nl}{nl}{vbTab}###### Exercise 2 ######{nl}")
                            Console.WriteLine($"# # # U S E R - M A N A G E M E N T # # #{nl}")
                            Console.WriteLine("1) List all Users")
                            Console.WriteLine("2) Create new User")
                            Console.WriteLine("3) Delete User")
                            Console.WriteLine("4) Modify User")
                            Console.WriteLine("Manage your users, to exit the exercise, type exit into the console window.")
                            Console.Write("Please choose: ")
                            inputAsString = Console.ReadLine()

                            Select Case inputAsString.ToLower()
                                Case "1"
                                    ' List all users
                                    Console.Clear()
                                    ListAllUsers(users)
                                Case "2"
                                    ' Create new user
                                    users = CreateOrUpdateUser(users, Nothing)
                                    ListAllUsers(users)
                                Case "3"
                                    ' Delete existing user
                                    DeleteUser(users)
                                    ListAllUsers(users)
                                Case "4"
                                    ' Modify user
                                    ModifyExistingUser(users)
                                    ListAllUsers(users)
                                Case "exit"
                                    finished = True
                                Case Else
                                    Console.WriteLine("Unknown input!")
                            End Select
                            ContinueWithAnyKey()

                        Loop While Not finished




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
                    Case "exit"
                        Console.WriteLine($"{nl}Apllication will be shutted down...")
                    Case Else
                        WriteError($"{nl}Unknown input!")
                        WriteError($"Input: ""{exercise}""")
                        WriteWarning("Correct input would be: ""1"", ""2"", ""3"", or ""exit""")
                        ContinueWithAnyKey()
                End Select

            Else
                ContinueWithAnyKey()
            End If
        Loop While exercise.ToLower() <> "exit"

    End Sub

#Region "Functions"
#Region "Base Functions"

    ''' <summary>
    ''' Function to validate user-input (String) is not null, empty, or whitespace!
    ''' </summary>
    ''' <param name="input"></param>
    ''' <returns>Success/Fail</returns>
    Function ValidateStringInput(input As String) As Boolean

        If Not String.IsNullOrEmpty(input) And Not String.IsNullOrWhiteSpace(input) Then
            Return True
        Else
            WriteError($"{nl}String-Input Is NULL, EMPTY, Or WHITESPACE!")
            Return False
        End If

    End Function

#End Region

#Region "Exercise 1"

    '1. Erstellen Sie die Methode UpDownString mit der Signatur:
    ' [] static string UpDownString(string text)
    'Die Methode soll im string text abwechselnd ein Wort groß und das nächste Wort klein schreiben. Danach soll sie den text zurückgeben.


    Function UpDownString(text As String) As String
        Dim output As String = ""
        Dim lowercase As Boolean

        If ValidateStringInput(text) Then
            For Each item As Char In text
                If Char.IsLetter(item) Then
                    If lowercase Then
                        output += item.ToString().ToLower()
                        lowercase = False
                    Else
                        output += item.ToString().ToUpper()
                        lowercase = True
                    End If
                Else
                    output += item.ToString()
                End If
            Next

            Return output
        End If

        Return Nothing
    End Function

#End Region

#Region "Exercise 2"

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

    ''' <summary>
    ''' Function to list all existing users. (Displayed on the console window)
    ''' </summary>
    ''' <param name="listOfUsers">list of Strings, where the users are inside.</param>
    Sub ListAllUsers(listOfUsers As List(Of String))
        Console.WriteLine($"{nl}--- Users ---")

        For i = 0 To listOfUsers.Count() - 1
            Console.WriteLine($"{i + 1}) {listOfUsers(i)}")
        Next

    End Sub

    ''' <summary>
    ''' Creates a new user, or updates an existing one.
    ''' </summary>
    ''' <param name="users">Neccessary Parameter -> List where all existing users are inside.</param>
    ''' <param name="position">Nullable integer if NULL/Nothing -> new user will be created. else a existing user will be modified.</param>
    ''' <returns>actual user list</returns>
    Function CreateOrUpdateUser(users As List(Of String), position As Integer?) As List(Of String)
        Console.Clear()

        Dim finished As Boolean
        Dim firstname As String
        Dim lastname As String = ""

        Do
            Console.WriteLine($"{nl}--- Create, or modify a User ---")
            Console.WriteLine("Create a new user, or modify a existing user, by adding the firstname and the lastname.")
            Console.WriteLine("To exit the ""Create, or modify User"" menu, type ""exit"" into the console window.")
            Console.Write("Please enter the firstname of the user: ")
            firstname = Console.ReadLine()

            If ValidateStringInput(firstname) Then
                If firstname.ToLower() <> "exit" Then
                    Console.Write("Please enter the lastname of the user: ")
                    lastname = Console.ReadLine()

                    If ValidateStringInput(lastname) Then
                        If lastname.ToLower() <> "exit" Then
                            If IsNothing(position) Then
                                users.Add($"{firstname} {lastname}")

                                If users.Last() = $"{firstname} {lastname}" Then
                                    WriteSuccess($"{nl}New user was successfully created:")
                                    WriteSuccess($"User: ""{users.Last()}""")

                                Else
                                    WriteError($"{nl}User was not successfully created:")
                                    WriteError($"Firstname: ""{firstname}""")
                                    WriteError($"Lastname: ""{lastname}""")
                                    WriteError($"Last-User: ""{users.Last()}""")
                                End If

                            Else
                                Dim before As String = users(position - 1)
                                users(position - 1) = $"{firstname} {lastname}"
                                Dim after As New String(users.Where(Function(x As String) x = before).FirstOrDefault())

                                If Not IsNothing(after) Then
                                    WriteSuccess($"{nl}User was successfully modified:")
                                    WriteSuccess($"Old: ""{before}""")
                                    WriteSuccess($"New: ""{users(position - 1)}""")

                                Else
                                    WriteError($"{nl}User was not successfully modified:")
                                    WriteError($"Before: ""{before}""")
                                    WriteError($"Firstname: ""{firstname}""")
                                    WriteError($"Lastname: ""{lastname}""")
                                    WriteError($"After: ""{after}""")
                                    WriteError($"Actual: ""{users(position - 1)}""")
                                End If

                            End If

                            finished = True
                        End If
                    End If
                End If
            End If

            If Not finished Then
                ContinueWithAnyKey()
            End If

        Loop While firstname.ToLower() <> "exit" And lastname.ToLower() <> "exit" And Not finished

        Return users
    End Function

    ''' <summary>
    ''' Deletes/Removes an existing user from the userlist, using the users list of strings.
    ''' </summary>
    ''' <param name="users">userlist -> list of strings</param>
    ''' <returns>actual user list</returns>
    Function DeleteUser(users As List(Of String)) As List(Of String)
        Console.Clear()

        Dim finished As Boolean
        Dim userNumbAsString As String
        Do
            ListAllUsers(users)
            Console.WriteLine($"{nl}--- Delete User ---")
            Console.WriteLine("Delete user by adding the Number of the user.")
            Console.WriteLine("To exit the ""Delete User"" menu, type exit into the console window.")
            Console.Write("Please enter the number of the user, which you want to delete: ")
            userNumbAsString = Console.ReadLine()

            If ValidateStringInput(userNumbAsString) Then
                If userNumbAsString <> "exit" Then

                    Dim userNumb As Integer
                    If Integer.TryParse(userNumbAsString, userNumb) Then
                        If userNumb >= 1 And userNumb <= users.Count() Then
                            Dim keyInfo As ConsoleKeyInfo

                            Do
                                Console.WriteLine($"{nl}Are you sure that you want to delete the user:")
                                Console.WriteLine($"ID: ""{userNumb}""")
                                Console.WriteLine($"Name: ""{users(userNumb - 1)}""")
                                Console.WriteLine($"{nl}Hit the ""y"" key for yes or the ""n"" key for no!")
                                keyInfo = Console.ReadKey()

                                Select Case keyInfo.Key
                                    Case ConsoleKey.Y
                                        ' delete the user
                                        Console.WriteLine($"{nl}Delete the user...")

                                        Dim before As String = users(userNumb - 1)
                                        users.RemoveAt(userNumb - 1)
                                        Dim after As New String(users.Where(Function(x As String) x = before).FirstOrDefault())

                                        If Not String.IsNullOrEmpty(after) Then
                                            WriteError($"{nl}User was not removed successfully!")
                                            WriteError($"before: ""{before}""")
                                            WriteError($"after: ""{after}""")
                                        Else
                                            WriteSuccess($"User ""{before}"" was successfully removed.")

                                        End If

                                        finished = True

                                    Case ConsoleKey.N
                                        ' Do not remove the user
                                        WriteWarning($"{nl}No user will be deleted!")

                                        finished = True

                                    Case Else

                                End Select

                            Loop While Not finished
                        Else
                            WriteError($"User with ID ""{userNumb}"" does not exist!")
                        End If
                    Else
                        WriteError("Input is not an integer!")
                        WriteError($"Input: ""{userNumbAsString}""")
                    End If
                End If
            End If

            ContinueWithAnyKey()

        Loop While userNumbAsString.ToLower() <> "exit" And Not finished



        Return users
    End Function

    ''' <summary>
    ''' Modifies an existing user, using te "users(POSITION)" parameter.
    ''' </summary>
    ''' <param name="users">userlist -> list of strings</param>
    ''' <returns>actual list of users</returns>
    Function ModifyExistingUser(users As List(Of String)) As List(Of String)
        Console.Clear()

        Dim finished As Boolean
        Dim userNumbAsString As String
        Do
            ListAllUsers(users)
            Console.WriteLine($"{nl}--- Modify User ---")
            Console.WriteLine("Modify user by adding the Number of the user.")
            Console.WriteLine("To exit the ""Delete User"" menu, type ""exit"" into the console window.")
            Console.Write("Please enter the number of the user, which you want to modify: ")
            userNumbAsString = Console.ReadLine()

            If ValidateStringInput(userNumbAsString) Then
                If userNumbAsString <> "exit" Then

                    Dim userNumb As Integer
                    If Integer.TryParse(userNumbAsString, userNumb) Then
                        If userNumb >= 1 And userNumb <= users.Count() Then
                            users = CreateOrUpdateUser(users, userNumb)
                            finished = True
                        Else
                            WriteError($"User with ID ""{userNumb}"" does not exist!")
                        End If
                    Else
                        WriteError("Input is not an integer!")
                        WriteError($"Input: ""{userNumbAsString}""")
                    End If
                End If
            End If

            ContinueWithAnyKey()

        Loop While Not finished And userNumbAsString.ToLower() <> "exit"

        Return users
    End Function

#End Region

#Region "Exercise 3"

#End Region


#End Region


End Module
