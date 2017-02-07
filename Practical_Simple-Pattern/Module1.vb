Module Module1
    Sub Main()
        Console.Write("Enter the number of rows/columns: ")
        Dim n As Integer = Console.ReadLine()
        Dim counter As Integer

        Console.WriteLine()
        Console.WriteLine("Pattern 1")
        For r = 1 To n
            For c = 1 To n
                Console.Write("*")
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()
        Console.WriteLine("Pattern 2")
        For r = 1 To n
            For c = 1 To n
                If r <> c Then
                    Console.Write("*")
                Else
                    Console.Write("-")
                End If
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()
        Console.WriteLine("Pattern 3")
        For r = n To 1 Step -1
            For c = 1 To n
                If c <> r Then
                    Console.Write("*")
                Else
                    Console.Write("-")
                End If
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()
        Console.WriteLine("Pattern 4")
        For r = 1 To n
            For c = 1 To n
                If c Mod 2 = 1 Then
                    Console.Write("*")
                Else
                    Console.Write("-")
                End If
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()
        Console.WriteLine("Pattern 5")
        For r = 1 To n
            For c = 1 To n
                If r Mod 2 = 1 Then
                    Console.Write("*")
                Else
                    Console.Write("-")
                End If
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()
        Console.WriteLine("Pattern 6")
        For r = 1 To n
            For c = 1 To n
                If r Mod 2 = 1 Then
                    If c Mod 2 = 1 Then
                        Console.Write("*")
                    Else
                        Console.Write("-")
                    End If
                Else
                    If c Mod 2 = 0 Then
                        Console.Write("*")
                    Else
                        Console.Write("-")
                    End If
                End If
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()
        Console.WriteLine("Pattern 7")
        For r = 1 To n
            For c = 1 To n
                If r = 1 Or r = n Or c = 1 Or c = n Then
                    Console.Write("*")
                Else
                    Console.Write("-")
                End If
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()
        Console.WriteLine("Pattern 8")
        For r = 1 To n
            For c = 1 To n
                If c <= r Then
                    Console.Write(r)
                Else
                    Console.Write("*")
                End If
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()
        Console.WriteLine("Pattern 9")
        counter = n
        For r = n To 1 Step -1
            For c = 1 To n
                If c <= counter Then
                    Console.Write(counter)
                Else
                    Console.Write("*")
                End If
            Next
            Console.WriteLine()
            counter -= 1
        Next

        Console.WriteLine()
        Console.WriteLine("Pattern 10")
        counter = n
        For r = 1 To n
            For c = 1 To n
                If c = r Or c = counter Then
                    Console.Write("*")
                Else
                    Console.Write("-")
                End If
            Next
            Console.WriteLine()
            counter -= 1
        Next

        Console.ReadLine()
    End Sub
End Module
