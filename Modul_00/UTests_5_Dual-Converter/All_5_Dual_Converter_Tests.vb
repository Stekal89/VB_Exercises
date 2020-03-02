Imports System.IO
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports dualConverter = _5_Dual_Converter

Namespace UTests_5_Dual_Converter
    <TestClass>
    Public Class All_5_Dual_Converter_Tests

        Dim nl As String = vbCrLf

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

        Const toCalculate As Integer = 123456

        <TestMethod>
        Sub T010_GetRestOfIntegerInStack_ValidInput_Binary_RV()
            Dim expected As Stack(Of Integer) = New Stack(Of Integer)({0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1})
            Dim stackOfBinaries As Stack(Of Integer) = dualConverter.GetRestOfIntegerInStack(toCalculate, 2)

            Dim expectedAsString As String
            For i = 1 To expected.Count()
                expectedAsString += expected.Pop().ToString()
            Next

            Dim stackOfBinariesAsString As String
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

            Dim expectedAsString As String
            For i = 1 To expected.Count()
                expectedAsString += expected.Pop().ToString()
            Next

            Dim stackOfOctasAsString As String
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

            Dim expectedAsString As String
            For i = 1 To expected.Count()
                expectedAsString += expected.Pop().ToString()
            Next

            Dim stackOfHEXAsString As String
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

        '<TestMethod>
        'Sub T013_OrderAndGroupRestResult_ValidInput_RV()

        'End Sub

#End Region

#Region "GetBinarayResult"

        '<TestMethod>
        'Sub T012_GetBinarayResult__NullCO()

        'End Sub

        '<TestMethod>
        'Sub T013_GetBinarayResult_Null_RV()

        'End Sub

        '<TestMethod>
        'Sub T014_GetBinarayResult_ValidInput_CO()

        'End Sub

        '<TestMethod>
        'Sub T015_GetBinarayResult_ValidInput_RV()

        'End Sub

#End Region


#Region "GetOctaResult"

        '<TestMethod>
        'Sub T016_GetOctaResult_NULL_CO()

        'End Sub

        '<TestMethod>
        'Sub T017_GetOctaResult_NULL_RV()

        'End Sub

        '<TestMethod>
        'Sub T018_GetOctaResult_ValidInput_CO()

        'End Sub

        '<TestMethod>
        'Sub T020_GetOctaResult_ValidInput_RV()

        'End Sub

#End Region


#Region "GetHEXResult"

        '<TestMethod>
        'Sub T021_GetHEXResult_NULL_CO()

        'End Sub

        '<TestMethod>
        'Sub T022_GetHEXResult_NULL_RV()

        'End Sub

        '<TestMethod>
        'Sub T023_GetHEXResult_ValidInput_CO()

        'End Sub

        '<TestMethod>
        'Sub T024_GetHEXResult_ValidInput_RV()

        'End Sub

#End Region


    End Class
End Namespace
