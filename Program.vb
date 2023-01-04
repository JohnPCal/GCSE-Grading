Imports System
Module GCSE_Grade
    Sub Main()
        Dim gcsemark As Char
        Dim message As String
        Console.WriteLine("Please enter your GCSE mark")
        Console.Write("GCSE Mark: ")
        gcsemark = Console.ReadLine()

        Select Case gcsemark
            Case "a", "A", "b", "B", "c", "C"
                message = "This grade is good enough for computing!"
            Case "d", "D", "e", "E", "f", "F"
                message = "This grade is'nt good enough for computing!"
            Case Else
                message = "Invalid entry"
        End Select
        Console.WriteLine(message)
    End Sub
End Module
