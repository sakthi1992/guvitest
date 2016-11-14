Module Module1

    Sub Main()

        Dim stringinput As Integer
        Dim substr As String
        stringinput = Console.ReadLine

        If stringinput < 0 Then
            Console.WriteLine("0")
            End
        End If

        If stringinput.ToString.Length > 4 Then
            substr = stringinput.ToString.Substring(3, 2)
            Console.WriteLine(substr)
        Else
            Console.WriteLine("please enter only 5 digits")

        End If
        Console.ReadLine()


    End Sub

End Module
