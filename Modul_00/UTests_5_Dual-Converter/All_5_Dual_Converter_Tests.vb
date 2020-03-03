Imports System.IO
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports dualConverter = _5_Dual_Converter

Namespace UTests_5_Dual_Converter
    <TestClass>
    Public Class All_5_Dual_Converter_Tests

        ReadOnly nl As String = vbCrLf
        Const toCalculate As Integer = 123456

#Region "ConvertStringIntoInteger"

        <TestMethod>
        Sub T001_ConvertStringIntoInteger_Null_CO()
            Dim input As String = Nothing
            Const expected As String = "Input is null, empty, or whitespace!"

            Using sw As New StringWriter()

                Console.SetOut(sw)
                dualConverter.ConvertStringIntoInteger(Nothing)
                Dim output As String = sw.ToString().Trim()

                Trace.WriteLine("Verify Console-Output:")
                Trace.WriteLine($"Input: ""{input}"" (NULL/Nothing)")
                Trace.WriteLine($"Expected: ""{expected}""")
                Trace.WriteLine($"Console-Output: ""{output}""")

                Assert.AreEqual(expected, output, "Wrong console output!")
            End Using
        End Sub

        <TestMethod>
        Sub T002_ConvertStringIntoInteger_Null_RV()
            Dim input As String = Nothing
            Dim returnedNumb = dualConverter.ConvertStringIntoInteger(Nothing)

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{input}"" (Nothing/NULL)")
            Trace.WriteLine($"Expected: """" (Nothing/NULL)")
            Trace.WriteLine($"Return-Value: ""{returnedNumb}""")

            Assert.IsNull(returnedNumb, "Expected value is not Nothing/NULL!")
        End Sub

        <TestMethod>
        Sub T003_ConvertStringIntoInteger_Empty_CO()
            Const input As String = ""
            Const expected As String = "Input is null, empty, or whitespace!"

            Using sw As New StringWriter()

                Console.SetOut(sw)
                dualConverter.ConvertStringIntoInteger(input)
                Dim output As String = sw.ToString().Trim()

                Trace.WriteLine("Verify Console-Output:")
                Trace.WriteLine($"Input: ""{input}"" (Empty-String)")
                Trace.WriteLine($"Expected: ""{expected}""")
                Trace.WriteLine($"Console-Output: ""{output}""")

                Assert.AreEqual(expected, output, "Wrong console output!")

            End Using
        End Sub

        <TestMethod>
        Sub T004_ConvertStringIntoInteger_Empty_RV()
            Const input As String = ""
            Dim returnedNumb = dualConverter.ConvertStringIntoInteger(input)

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{input}"" (Empty-String)")
            Trace.WriteLine($"Expected: """" (NULL/Nothing)")
            Trace.WriteLine($"Return-Value: ""{returnedNumb}""")

            Assert.IsNull(returnedNumb, "Expected value is not Nothing/NULL!")
        End Sub

        <TestMethod>
        Sub T005_ConvertStringIntoInteger_Whitespace_CO()
            Const input As String = " "
            Const expected As String = "Input is null, empty, or whitespace!"

            Using sw As New StringWriter()

                Console.SetOut(sw)
                dualConverter.ConvertStringIntoInteger(input)
                Dim output = sw.ToString().Trim()

                Trace.WriteLine("Verify Console-Output:")
                Trace.WriteLine($"Input: ""{input}"" (Whitespace)")
                Trace.WriteLine($"Expected: ""{expected}""")
                Trace.WriteLine($"Console-Output: ""{output}""")

                Assert.AreEqual(expected, output, "Wrong console output!")

            End Using
        End Sub

        <TestMethod>
        Sub T006_ConvertStringIntoInteger_Whitespace_RV()
            Const input As String = " "
            Dim returnedNumb = dualConverter.ConvertStringIntoInteger(input)

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{input}"" (Whitespace)")
            Trace.WriteLine("Expected: """" (NULL/Nothing)")
            Trace.WriteLine($"Return-Value: ""{returnedNumb}""")

            Assert.IsNull(returnedNumb, "Expected value is not Nothing/NULL!")
        End Sub

        <TestMethod>
        Sub T007_ConvertStringIntoInteger_NotANumber_CO()
            Const input As String = "Bla Blubb"
            Dim expected As String = $"Input is not an Integer!{nl}"
            expected += $"Input: ""{input}"""

            Using sw As New StringWriter()

                Console.SetOut(sw)
                dualConverter.ConvertStringIntoInteger(input)
                Dim output = sw.ToString().Trim()

                Trace.WriteLine("Verify Console-Output:")
                Trace.WriteLine($"Input: ""{input}""")
                Trace.WriteLine($"Expected: ""{expected}""")
                Trace.WriteLine($"Console-Output: ""{output}""")

                Assert.AreEqual(expected, output, "Wrong console output!")

            End Using
        End Sub

        <TestMethod>
        Sub T008_ConvertStringIntoInteger_NotANumber_RV()
            Const input As String = "Bla Blubb"

            Dim returnedNumb = dualConverter.ConvertStringIntoInteger(input)

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{input}""")
            Trace.WriteLine($"Expected: """" (NULL/Nothing)")
            Trace.WriteLine($"Return-Value: ""{returnedNumb}""")

            Assert.IsNull(returnedNumb, "Expected value is not Nothing/NULL!")
        End Sub

        <TestMethod>
        Sub T009_ConvertStringIntoInteger_ValidInput_CO()
            Const input As Integer = 321

            Using sw As New StringWriter()

                Console.SetOut(sw)
                dualConverter.ConvertStringIntoInteger(input)

                Dim output = sw.ToString().Trim()

                Trace.WriteLine("Verify Console-Output:")
                Trace.WriteLine($"Input: ""{input}""")
                Trace.WriteLine("Expected: """" (NULL, or EMPTY)")
                Trace.WriteLine($"Console-Output: ""{output}""")

                Assert.IsTrue(String.IsNullOrEmpty(output), "Console output should be ""NULL/Nothing""")
            End Using
        End Sub

        <TestMethod>
        Sub T009_ConvertStringToInteger_ValidInput_RV()
            Const expected As Integer = 132
            Dim returnedNumb = dualConverter.ConvertStringIntoInteger("132")

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine("Input: ""132""")
            Trace.WriteLine($"Expected: ""{expected}""")
            Trace.WriteLine($"Return-Value: ""{returnedNumb}""")

            Assert.AreEqual(expected, returnedNumb, "Wrong value returned!")
        End Sub

#End Region

#Region "GetRestOfIntegerInStack"

        <TestMethod>
        Sub T010_GetRestOfIntegerInStack_ValidInput_Binary_RV()
            Dim expected As Stack(Of Integer) = New Stack(Of Integer)({0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1})
            Dim stackOfBinaries As Stack(Of Integer) = dualConverter.GetRestOfIntegerInStack(toCalculate, 2)

            Dim expectedAsString As String = ""
            For i = 1 To expected.Count()
                expectedAsString += expected.Pop().ToString()
            Next

            Dim stackOfBinariesAsString As String = ""
            For i = 1 To stackOfBinaries.Count()
                stackOfBinariesAsString += stackOfBinaries.Pop().ToString()
            Next

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{toCalculate}""")
            Trace.WriteLine($"Expected: ""{expectedAsString}""")
            Trace.WriteLine($"Return-Value: ""{stackOfBinariesAsString}""")

            Assert.AreEqual(expectedAsString, stackOfBinariesAsString, "Wrong result returned fron the Function: ""GetRestOfIntegerInStack""")
        End Sub

        <TestMethod>
        Sub T011_GetRestOfIntegerInStack_ValidInput_Octa_RV()
            Dim expected As Stack(Of Integer) = New Stack(Of Integer)({0, 0, 1, 1, 6, 3})
            Dim stackOfOctas As Stack(Of Integer) = dualConverter.GetRestOfIntegerInStack(toCalculate, 8)

            Dim expectedAsString As String = ""
            For i = 1 To expected.Count()
                expectedAsString += expected.Pop().ToString()
            Next

            Dim stackOfOctasAsString As String = ""
            For i = 1 To stackOfOctas.Count()
                stackOfOctasAsString += stackOfOctas.Pop().ToString()
            Next

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{toCalculate}""")
            Trace.WriteLine($"Expected: ""{expectedAsString}""")
            Trace.WriteLine($"Return-Value: ""{stackOfOctasAsString}""")

            Assert.AreEqual(expectedAsString, stackOfOctasAsString, "Wrong result returned fron the Function: ""GetRestOfIntegerInStack""")
        End Sub

        <TestMethod>
        Sub T012_GetRestOfIntegerInStack_ValidInput_HEX_RV()
            Dim expected As Stack(Of Integer) = New Stack(Of Integer)({0, 4, 2, 14, 1})
            Dim stackOfHEX As Stack(Of Integer) = dualConverter.GetRestOfIntegerInStack(toCalculate, 16)

            Dim expectedAsString As String = ""
            For i = 1 To expected.Count()
                expectedAsString += expected.Pop().ToString()
            Next

            Dim stackOfHEXAsString As String = ""
            For i = 1 To stackOfHEX.Count()
                stackOfHEXAsString += stackOfHEX.Pop().ToString()
            Next

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{toCalculate}""")
            Trace.WriteLine($"Expected: ""{expectedAsString}""")
            Trace.WriteLine($"Return-Value: ""{stackOfHEXAsString}""")

            Assert.AreEqual(expectedAsString, stackOfHEXAsString, "Wrong result returned fron the Function: ""GetRestOfIntegerInStack""")
        End Sub


#End Region

#Region "OrderAndGroupRestResult"

        <TestMethod>
        Sub T013_OrderAndGroupRestResult_ValidInput_Binary_RV()
            Dim stackOfBinaries As Stack(Of Integer) = New Stack(Of Integer)({0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1})
            Dim binList As List(Of Integer) = stackOfBinaries.Reverse().ToList()
            Dim expected As String = "0001 1110 0010 0100 0000"
            Dim result As String = dualConverter.OrderAndGroupRestResult(stackOfBinaries, 4)

            Dim inputAsString As String = ""
            For Each bl In binList
                inputAsString += $"{bl.ToString()}, "
            Next

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{inputAsString.TrimEnd(",", " ")}""")
            Trace.WriteLine($"Expected: ""{expected}""")
            Trace.WriteLine($"Return-Value: ""{result}""")

            Assert.AreEqual(expected, result, "Result of Function ""OrderAndGroupRestResult"" returned the wrong value!")
        End Sub

        <TestMethod>
        Sub T014_OrderAndGroupRestResult_ValidInput_Octa_RV()
            Dim stackOfOctas As Stack(Of Integer) = New Stack(Of Integer)({0, 0, 1, 1, 6, 3})
            Dim octaList As List(Of Integer) = stackOfOctas.Reverse().ToList()
            Dim expected As String = "000 361 100"
            Dim result As String = dualConverter.OrderAndGroupRestResult(stackOfOctas, 3)



            Dim inputAsString As String = ""
            For Each ol In octaList
                inputAsString += $"{ol.ToString()}, "
            Next

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{inputAsString.TrimEnd(",", " ")}""")
            Trace.WriteLine($"Expected: ""{expected}""")
            Trace.WriteLine($"Return-Value: ""{result}""")

            Assert.AreEqual(expected, result, "Result of Function ""OrderAndGroupRestResult"" returned the wrong value!")
        End Sub

        Sub T015_OrderAndGroupRestResult_ValidInput_HEX_RV()
            Dim stackOfBinaries As Stack(Of Integer) = New Stack(Of Integer)({0, 4, 2, 14, 1})
            Dim binList As List(Of Integer) = stackOfBinaries.Reverse().ToList()
            Dim expected As String = "0001 E240"
            Dim result As String = dualConverter.OrderAndGroupRestResult(stackOfBinaries, 4)

            Dim inputAsString As String = ""
            For Each bl In binList
                inputAsString += bl.ToString()
            Next

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{inputAsString}""")
            Trace.WriteLine($"Expected: ""{expected}""")
            Trace.WriteLine($"Return-Value: ""{result}""")

            Assert.AreEqual(expected, result, "Result of Function ""OrderAndGroupRestResult"" returned the wrong value!")
        End Sub

#End Region

#Region "GetBinarayResult"

        <TestMethod>
        Sub T016_GetBinarayResult__Null_CO()
            Dim expected As String = "Cannot convert INPUT into INTEGER!"

            Using sw As New StringWriter()

                Console.SetOut(sw)
                dualConverter.GetBinarayResult(Nothing)
                Dim output As String = sw.ToString().Trim()

                Trace.WriteLine("Verify Console-Output:")
                Trace.WriteLine($"Input: """" (NULL/Nothing)")
                Trace.WriteLine($"Expected: ""{expected}""")
                Trace.WriteLine($"Console-Output: ""{output}""")

                Assert.AreEqual(expected, output, "Wrong console output!")
            End Using
        End Sub

        <TestMethod>
        Sub T017_GetBinarayResult_Null_RV()
            Dim result As String = dualConverter.GetBinarayResult(Nothing)

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: """" (Nothing/NULL)")
            Trace.WriteLine($"Expected: """" (NULL, or EMPTY")
            Trace.WriteLine($"Console-Output: ""{result}""")

            Assert.IsTrue(String.IsNullOrEmpty(result), "Return-Value is Not NULL and Not EMPTY!")
        End Sub

        <TestMethod>
        Sub T018_GetBinarayResult_ValidInput_CO()
            Using sw As New StringWriter()

                Console.SetOut(sw)
                dualConverter.GetBinarayResult(toCalculate)
                Dim output As String = sw.ToString().Trim()

                Trace.WriteLine("Verify Console-Output:")
                Trace.WriteLine($"Input: ""{toCalculate}""")
                Trace.WriteLine("Expected: """" (NULL, or EMPTY)")
                Trace.WriteLine($"Console-Output: ""{output}""")

                Assert.IsTrue(String.IsNullOrEmpty(output), "Wrong console output!")
            End Using
        End Sub

        <TestMethod>
        Sub T019_GetBinarayResult_ValidInput_RV()
            Const expected As String = "0001 1110 0010 0100 0000"
            Dim result As String = dualConverter.GetBinarayResult(toCalculate)

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{toCalculate}""")
            Trace.WriteLine($"Expected: ""{expected}""")
            Trace.WriteLine($"Return-Value: ""{result}""")

            Assert.AreEqual(expected, result, "Wrong value returned in function!")
        End Sub

#End Region

#Region "GetOctaResult"

        <TestMethod>
        Sub T020_GetOctaResult_NULL_CO()
            Dim expected As String = "Cannot convert INPUT into INTEGER!"

            Using sw As New StringWriter()

                Console.SetOut(sw)
                dualConverter.GetOctaResult(Nothing)
                Dim output As String = sw.ToString().Trim()

                Trace.WriteLine("Verify Console-Output:")
                Trace.WriteLine($"Input: """" (NULL/Nothing)")
                Trace.WriteLine($"Expected: ""{expected}""")
                Trace.WriteLine($"Console-Output: ""{output}""")

                Assert.AreEqual(expected, output, "Wrong console output!")
            End Using
        End Sub

        <TestMethod>
        Sub T021_GetOctaResult_NULL_RV()
            Dim result As String = dualConverter.GetOctaResult(Nothing)

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: """" (Nothing/NULL)")
            Trace.WriteLine($"Expected: """" (NULL, or EMPTY")
            Trace.WriteLine($"Console-Output: ""{result}""")

            Assert.IsTrue(String.IsNullOrEmpty(result), "Return-Value is Not NULL and Not EMPTY!")
        End Sub

        <TestMethod>
        Sub T022_GetOctaResult_ValidInput_CO()
            Using sw As New StringWriter()

                Console.SetOut(sw)
                dualConverter.GetOctaResult(toCalculate)
                Dim output As String = sw.ToString().Trim()

                Trace.WriteLine("Verify Console-Output:")
                Trace.WriteLine($"Input: ""{toCalculate}""")
                Trace.WriteLine("Expected: """" (NULL, or EMPTY)")
                Trace.WriteLine($"Console-Output: ""{output}""")

                Assert.IsTrue(String.IsNullOrEmpty(output), "Wrong console output!")
            End Using
        End Sub

        <TestMethod>
        Sub T023_GetOctaResult_ValidInput_RV()
            Const expected As String = "361 100"
            Dim result As String = dualConverter.GetOctaResult(toCalculate)

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{toCalculate}""")
            Trace.WriteLine($"Expected: ""{expected}""")
            Trace.WriteLine($"Return-Value: ""{result}""")

            Assert.AreEqual(expected, result, "Wrong value returned in function!")
        End Sub

#End Region

#Region "GetHEXResult"

        <TestMethod>
        Sub T024_GetHEXResult_NULL_CO()
            Dim expected As String = "Cannot convert INPUT into INTEGER!"

            Using sw As New StringWriter()

                Console.SetOut(sw)
                dualConverter.GetHEXResult(Nothing)
                Dim output As String = sw.ToString().Trim()

                Trace.WriteLine("Verify Console-Output:")
                Trace.WriteLine($"Input: """" (NULL/Nothing)")
                Trace.WriteLine($"Expected: ""{expected}""")
                Trace.WriteLine($"Console-Output: ""{output}""")

                Assert.AreEqual(expected, output, "Wrong console output!")
            End Using
        End Sub

        <TestMethod>
        Sub T025_GetHEXResult_NULL_RV()
            Dim result As String = dualConverter.GetHEXResult(Nothing)

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: """" (Nothing/NULL)")
            Trace.WriteLine($"Expected: """" (NULL, or EMPTY")
            Trace.WriteLine($"Console-Output: ""{result}""")

            Assert.IsTrue(String.IsNullOrEmpty(result), "Return-Value is Not NULL and Not EMPTY!")
        End Sub

        <TestMethod>
        Sub T026_GetHEXResult_ValidInput_CO()
            Using sw As New StringWriter()

                Console.SetOut(sw)
                dualConverter.GetHEXResult(toCalculate)
                Dim output As String = sw.ToString().Trim()

                Trace.WriteLine("Verify Console-Output:")
                Trace.WriteLine($"Input: ""{toCalculate}""")
                Trace.WriteLine("Expected: """" (NULL, or EMPTY)")
                Trace.WriteLine($"Console-Output: ""{output}""")

                Assert.IsTrue(String.IsNullOrEmpty(output), "Wrong console output!")
            End Using
        End Sub

        <TestMethod>
        Sub T027_GetHEXResult_ValidInput_RV()
            Const expected As String = "1 E240"
            Dim result As String = dualConverter.GetHEXResult(toCalculate)

            Trace.WriteLine("Verify Return-Value:")
            Trace.WriteLine($"Input: ""{toCalculate}""")
            Trace.WriteLine($"Expected: ""{expected}""")
            Trace.WriteLine($"Return-Value: ""{result}""")

            Assert.AreEqual(expected, result, "Wrong value returned in function!")
        End Sub

#End Region

    End Class
End Namespace
