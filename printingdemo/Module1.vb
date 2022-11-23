Module Module1

    Sub Main()

        'program to find largest among 4 numners using extra variable l using simple if

        'Dim a, b, c, d, l As Integer

        'Console.WriteLine("enter values in a,b,c,d")
        'a = Convert.ToInt32(Console.ReadLine())
        'b = Convert.ToInt32(Console.ReadLine())
        'c = Convert.ToInt32(Console.ReadLine())
        'd = Convert.ToInt32(Console.ReadLine())

        'l = a
        'If b > l Then l = b
        'If c > l Then l = c
        'If d > l Then l = d

        'Console.WriteLine("The laregst among {0},{1},{2},{3} is {4}", a, b, c, d, l)


        'using else if ladder no extra variable l is used 
        'Dim a, b, c, d As Integer
        'Console.WriteLine("enter values in a,b,c,d")
        'a = Convert.ToInt32(Console.ReadLine())
        'b = Convert.ToInt32(Console.ReadLine())
        'c = Convert.ToInt32(Console.ReadLine())
        'd = Convert.ToInt32(Console.ReadLine())
        'If a > b AndAlso a > c AndAlso a > d Then
        '    Console.WriteLine("{0} is larger", a)
        'ElseIf b > c AndAlso b > d Then
        '    Console.WriteLine("{0} is larger", b)
        'ElseIf c > d Then
        '    Console.WriteLine("{0} is larger", c)
        'Else
        '    Console.WriteLine("{0} is larger", d)
        'End If

        'nested if code 

        Dim x As Integer = 1
        Dim y As Integer = 1
        Dim z As Integer = 1
        If x = 1 Then
            If y = 1 Then
                If z = 1 Then
                    Console.WriteLine("all are one")
                Else
                    Console.WriteLine("only x and y are one")
                End If
            Else
                Console.WriteLine("only x is one")
            End If
        Else
            Console.WriteLine("no one  is one")
        End If

        Console.ReadLine()







    End Sub

End Module
