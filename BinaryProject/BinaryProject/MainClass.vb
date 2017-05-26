
Module MainClass

    'Metodo inicial del sistema
    Sub Main()

        TitleBinaryCalculator()
        CalculatorOperationCore()

    End Sub

    'El núcleo de las operaciones del sistema
    Sub CalculatorOperationCore()

        'Realiza la instancia de la clase BinaryOperation que tiene toda la lógica
        ' de operaciones binarias
        Dim binaryOperation As BinaryOperation = New BinaryOperation()

        'Variable boolean para mantenernos en el loop
        Dim stayInWhile As Boolean = True

        'Loop para realizar operaciones o salirse de la aplicación
        Do While stayInWhile
            MenuBinaryCalculator()

            'Se crea el string de la respuesta del readline
            Dim menuAnswer As String
            'Lee la tecla tocada por el usuario  y se lo asigna a menuAnswer
            menuAnswer = Console.ReadLine()
            Console.WriteLine(menuAnswer)

            'Realiza una acción de acuerdo a la opción seleccionada por el usuario
            Select Case menuAnswer
                Case "A", "a"
                    Sum(binaryOperation)
                Case "B", "b"
                    Subtract(binaryOperation)
                Case "C", "c"
                    Console.Clear()
                    TitleBinaryCalculator()
                Case "D", "d"
                    stayInWhile = False
                Case Else
                    Console.WriteLine("")
                    Console.WriteLine("Porfavor, seleccione una tecla válida")
                    Console.WriteLine("")
            End Select
        Loop
    End Sub


    'Método encargado de sumar los números, se pasa por parametro el operador binario
    Sub Sum(binaryOperation As BinaryOperation)
        Console.Clear()
        Console.WriteLine("")
        Console.WriteLine("Vamos a sumar")
        'llama los valores binarios y llena la lista para realizar la acción
        Dim listOfBinaryNums() As String = binaryOperation.ReturnBinaryNumsOperation()

        'Si tiene valores ejecute la accion
        If (listOfBinaryNums IsNot Nothing) Then
            'Llama a la clase binaryOperation y ejecuta el método de suma
            binaryOperation.sum(listOfBinaryNums(0), listOfBinaryNums(1))
        End If

    End Sub

    'Método encargado de restar los números, se pasa por parametro el operador binario
    Sub Subtract(binaryOperation As BinaryOperation)
        Console.Clear()
        Console.WriteLine("")
        Console.WriteLine("Vamos a restar")
        'llama los valores binarios y llena la lista para realizar la acción
        Dim listOfBinaryNums() As String = binaryOperation.ReturnBinaryNumsOperation()

        'Si tiene valores ejecute la accion
        If (listOfBinaryNums IsNot Nothing) Then
            'Llama a la clase binaryOperation y ejecuta el método de resta
            binaryOperation.subtract(listOfBinaryNums(0), listOfBinaryNums(1))
        End If
    End Sub



    'Imprime en pantalla el título de la calculadora
    Sub TitleBinaryCalculator()
        Console.WriteLine("")
        Console.WriteLine("***************************************")
        Console.WriteLine("          Calculadora Binaria          ")
        Console.WriteLine("***************************************")
    End Sub

    'Imprime en pantalla el menú de la calculadora
    Sub MenuBinaryCalculator()
        Console.WriteLine("")
        Console.WriteLine("Elija una opción")
        Console.WriteLine("")
        Console.WriteLine("1. Presione la tecla 'A' para sumar")
        Console.WriteLine("2. Presione la tecla 'B' para restar")
        Console.WriteLine("3. Presione la tecla 'C' para limpiar la consola")
        Console.WriteLine("4. Presione la tecla 'D' Salir")
    End Sub
End Module
