Imports System
Module Program
    Public nota(6), notas, posicion, i, prom As Integer
    Public nota1, nota2, nota3, nota4, nota5, nota6 As Integer   
    Sub Main()
        Console.WriteLine("Coloque la 1era nota del alumno: ")
        nota1 = Console.ReadLine()
        Console.WriteLine("Coloque la 2da nota del alumno: ")
        nota2 = Console.ReadLine()
        Console.WriteLine("Coloque la 3ra nota del alumno: ")
        nota3 = Console.ReadLine()
        Console.WriteLine("Coloque la 4ta nota del alumno: ")
        nota4 = Console.ReadLine()
        Console.WriteLine("Coloque la 5ta nota del alumno: ")
        nota5 = Console.ReadLine()
        Console.WriteLine("Coloque la 6ta nota del alumno: ")
        nota6 = Console.ReadLine()
        fill_vector()
        mayor()
        menor()
        promedio()
    End Sub
    Sub fill_vector()
        nota(1) = nota1
        nota(2) = nota2
        nota(3) = nota3
        nota(4) = nota4
        nota(5) = nota5
        nota(6) = nota6
    End Sub
    Sub mayor()
        notas = 0
        For i = 1 To 6
            If nota(i) > notas Then
                notas = nota(i)
            End If
        Next
        Console.WriteLine("La nota mas alta es " & notas)
    End Sub
    Sub menor()
        notas = 99999
        For i = 1 To 6
            If nota(i) < notas Then
                notas = nota(i)
                posicion = i
            End If
        Next
        Console.WriteLine("La nota mas baja es " & notas)
    End Sub
    Sub promedio()
        For i = 1 To 6
            prom = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6) / 6
        Next
        Console.WriteLine("El promedio entre todas las notas es " & prom)
    End Sub
End Module