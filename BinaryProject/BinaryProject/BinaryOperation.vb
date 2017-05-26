Imports System.Text.RegularExpressions
Public Class BinaryOperation
    'Realiza la suma de binarios e imprime en consola
    Public Sub sum(numOne As String, numTwo As String)
        'Convierte los dos números a decimales
        Dim decOne As Integer = Convert.ToInt32(numOne, 2)
        Dim decTwo As Integer = Convert.ToInt32(numTwo, 2)
        'suma los números
        Dim decResult As Integer = decOne + decTwo
        'Convierte los números a binarios
        Dim binaryResult As String = Convert.ToString(decResult, 2)

        ' imprime el resultado
        Console.WriteLine("")
        Console.WriteLine("*******************************")
        Console.WriteLine("El resultado de la suma es: {0}", binaryResult)
        Console.WriteLine("")
    End Sub

    'Realiza la resta de binarios e imprime en consola
    Public Sub subtract(numOne As String, numTwo As String)
        'Convierte los dos números a decimales
        Dim decOne As Integer = Convert.ToInt32(numOne, 2)
        Dim decTwo As Integer = Convert.ToInt32(numTwo, 2)
        'suma los números
        Dim decResult As Integer = decOne - decTwo
        'Convierte los números a binarios
        Dim binaryResult As String = Convert.ToString(decResult, 2)

        ' imprime el resultado
        Console.WriteLine("")
        Console.WriteLine("*******************************")
        Console.WriteLine("El resultado de la resta es: {0}", binaryResult)
        Console.WriteLine("")
    End Sub




    'Retorna los dos números binarios para realizar la operación
    Public Function ReturnBinaryNumsOperation() As String()
        Dim binaryNumOne As String = ""
        Dim binaryNumTwo As String = ""

        binaryNumOne = AddBinaryNum("primer")

        'Si el primero número es binario pregunta por el segundo
        If (binaryNumOne <> "") Then
            binaryNumTwo = AddBinaryNum("segundo")
        End If

        'Si el segundo número es binario, realize la acción de resta
        If (binaryNumTwo <> "") Then
            'Crea una lista de string para retornar los dos valores
            Dim listOfBinaryNums(0 To 1) As String
            listOfBinaryNums(0) = binaryNumOne
            listOfBinaryNums(1) = binaryNumTwo
            Return listOfBinaryNums
        Else
            Return Nothing
        End If
    End Function

    'Function que retorna el numero binario ingresado por el usuario
    Function AddBinaryNum(secuenseNumber As String) As String
        Console.WriteLine("")
        Console.WriteLine("Ingrése {0} número binario", secuenseNumber)

        'Se crea el string de la respuesta del readline
        Dim binaryNum As String
        'Lee la tecla tocada por el usuario  y se lo asigna a binaryNumOne
        binaryNum = Console.ReadLine()
        'Válida por medio de la expresión regular si es un número binario o no
        If (Regex.IsMatch(binaryNum, "^[01]+$") = False) Then
            Console.WriteLine("Lo sentimos, este número no es binario.")
            'Retorna un valor vacío
            Return ""
        Else
            'Retorna un número binario
            Return binaryNum
        End If
    End Function
End Class
