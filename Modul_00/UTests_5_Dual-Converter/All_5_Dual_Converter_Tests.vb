Imports System.IO
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports dualConverter = _5_Dual_Converter

Namespace UTests_5_Dual_Converter
    <TestClass>
    Public Class All_5_Dual_Converter_Tests

        Dim nl As String = vbCrLf

#Region "ConvertStringIntoInteger"

        <TestMethod>
        Sub T001_ConvertStringIntoInteger_NullOrEmpty_CO()
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
        Sub T002_ConvertStringIntoInteger_NullOrEmpty_RV()
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

#Region ""


#End Region

    End Class
End Namespace
