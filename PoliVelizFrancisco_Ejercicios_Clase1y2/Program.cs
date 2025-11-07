// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//1. Número positivo o negativo: Pedir un número y mostrar si es positivo, negativo o
//cero.

//Console.Write("Ingrese un número: ");
//double number = double.Parse(Console.ReadLine());
//if (number > 0)
//{
//    Console.WriteLine("El número es positivo.");
//}
//else if (number < 0)
//{
//    Console.WriteLine("El número es negativo.");
//}
//else
//{
//    Console.WriteLine("El número es cero.");
//} Console.ReadLine();



//2. Comparación de tres números: Pedir tres números distintos y mostrar cuál es el
//mayor y cuál el menor.

//Console.Write("Ingrese el primer número: ");
//double num1 = double.Parse(Console.ReadLine());
//Console.Write("Ingrese el segundo número: ");
//double num2 = double.Parse(Console.ReadLine());
//Console.Write("Ingrese el tercer número: ");
//double num3 = double.Parse(Console.ReadLine());

//double mayor = num1;
//if (num2 > mayor) mayor = num2;
//if (num3 > mayor) mayor = num3;

//double menor = num1;
//if (num2 < menor) menor = num2;
//if (num3 < menor) menor = num3;

//Console.WriteLine($"El número mayor es: {mayor}");
//Console.WriteLine($"El número menor es: {menor}"); Console.ReadLine();

//3. Múltiplos de un número: Pedir dos números e indicar si el primero es múltiplo del
//segundo.

//Console.Write("Ingrese el primer número: ");
//double num1 = double.Parse(Console.ReadLine());
//Console.Write("Ingrese el segundo número: ");
//double num2 = double.Parse(Console.ReadLine());
//if (num1 % num2 == 0)
//{
//    Console.WriteLine($"{num1} es múltiplo de {num2}");
//}
//else
//{
//    Console.WriteLine($"{num1} no es múltiplo de {num2}");
//} Console.ReadLine();

//4. Descuento en tienda: Pedir el precio de un producto y aplicar un descuento del 10%
//si el precio es mayor a $1000.

//Console.Write("Ingrese el precio del producto: ");
//double precio = double.Parse(Console.ReadLine());
//if (precio > 1000)
//{
//    double descuento = precio * 0.1;
//    double precioFinal = precio - descuento;
//    Console.WriteLine($"El precio final con descuento es: {precioFinal}");
//}
//else
//{
//    Console.WriteLine("No se aplica descuento.");
//} Console.ReadLine();


//5. Conversión de tipo: Pedir un número decimal y convertirlo a entero (usando
//conversión explícita). Mostrar ambos valores y comentar la diferencia.

//Console.Write("Ingrese un número decimal: ");
//double numeroDecimal = double.Parse(Console.ReadLine());
//int numeroEntero = (int)numeroDecimal;
//Console.WriteLine($"Número decimal: {numeroDecimal}");
//Console.WriteLine($"Número entero (convertido): {numeroEntero}");
//Console.WriteLine("La diferencia es que el número entero no tiene parte decimal.");
//double diferencia = numeroDecimal - numeroEntero;
//Console.WriteLine($"Diferencia numérica: {diferencia}");
//Console.ReadLine();


//6. Clasificación por edad: Pedir la edad y mostrar si la persona es niño, adolescente,
//adulto o adulto mayor (usa if-else if-else).

//Console.Write("Ingrese su edad: ");
//int edad = int.Parse(Console.ReadLine());
//if (edad < 13)
//{
//    Console.WriteLine("Es un niño.");
//}
//else if (edad < 20)
//{
//    Console.WriteLine("Es un adolescente.");
//}
//else if (edad < 65)
//{
//    Console.WriteLine("Es un adulto.");
//}
//else
//{
//    Console.WriteLine("Es un adulto mayor.");
//} Console.ReadLine();


//7. Número dentro de rango: Pedir un número y verificar si está dentro del rango 1–100
//(inclusive).


//Console.Write("Ingrese un número: ");
//int numero = int.Parse(Console.ReadLine());
//if (numero >= 1 && numero <= 100)
//{
//    Console.WriteLine("El número está dentro del rango.");
//}
//else
//{
//    Console.WriteLine("El número está fuera del rango.");
//} Console.ReadLine();


//8. Operador ternario: Pedir un número y mostrar "Par" o "Impar" usando el operador
//ternario.


//Console.Write("Ingrese un número: ");
//int numero = int.Parse(Console.ReadLine());
//string resultado = (numero % 2 == 0) ? "Par" : "Impar";
//Console.WriteLine($"El número es: {resultado}");
//Console.ReadLine();


//9. Cálculo de impuestos: Pedir un ingreso anual y calcular el impuesto:
//< 10,000: 0 %
//10,000–50,000: 10 %
//50,000: 20 %
//Mostrar el monto de impuesto a pagar.


//Console.Write("Ingrese su ingreso anual: ");
//double ingreso = double.Parse(Console.ReadLine());
//double impuesto = 0;

//if (ingreso < 10000)
//{
//    impuesto = 0;
//}
//else if (ingreso < 50000)
//{
//    impuesto = ingreso * 0.1;
//}
//else
//{
//    impuesto = ingreso * 0.2;
//}

//Console.WriteLine($"El monto de impuesto a pagar es: {impuesto}");
//Console.ReadLine();


//10. Día de la semana con switch: Pedir un número del 1 al 7 y mostrar el día de la
//semana correspondiente.


//Console.Write("Ingrese un número del 1 al 7: ");
//int dia = int.Parse(Console.ReadLine());
//switch (dia)
//{
//    case 1:
//        Console.WriteLine("Lunes");
//        break;
//    case 2:
//        Console.WriteLine("Martes");
//        break;
//    case 3:
//        Console.WriteLine("Miércoles");
//        break;
//    case 4:
//        Console.WriteLine("Jueves");
//        break;
//    case 5:
//        Console.WriteLine("Viernes");
//        break;
//    case 6:
//        Console.WriteLine("Sábado");
//        break;
//    case 7:
//        Console.WriteLine("Domingo");
//        break;
//    default:
//        Console.WriteLine("El número ingresado no corresponde a un día de la semana.");
//        break;
//}
//Console.ReadLine();


//11. Menú con switch: Crear un menú con opciones (1. Sumar, 2. Restar, 3. Multiplicar, 4.
//Dividir). Pedir dos números y ejecutar la operación elegida.


//Console.WriteLine("Menú de operaciones:");
//Console.WriteLine("1. Sumar");
//Console.WriteLine("2. Restar");
//Console.WriteLine("3. Multiplicar");
//Console.WriteLine("4. Dividir");
//Console.Write("Ingrese el número de la opción deseada: ");
//int opcion = int.Parse(Console.ReadLine());

//Console.Write("Ingrese el primer número: ");
//double num1 = double.Parse(Console.ReadLine());
//Console.Write("Ingrese el segundo número: ");
//double num2 = double.Parse(Console.ReadLine());

//switch (opcion)
//{
//    case 1:
//        Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
//        break;
//    case 2:
//        Console.WriteLine($" El resultado de la resta es: {num1 - num2}");
//        break;
//    case 3:
//        Console.WriteLine($"El resultado de la multiplicación es: {num1 * num2}");
//        break;
//    case 4:
//        if (num2 != 0)
//        {
//            Console.WriteLine($"El resultado de la división es: {num1 / num2}");
//        }
//        else
//        {
//            Console.WriteLine("Error: Está intentando dividir por cero y eso no es posible.");
//        }
//        break;
//    default:
//        Console.WriteLine("Opción inválida.");
//        break;
//}
//Console.ReadLine();


//12. Contador de pares: Pedir un número N y mostrar cuántos números pares hay entre 1
//y N.


//Console.Write("Ingrese un número: ");
//int N = int.Parse(Console.ReadLine());
//int contadorPares = 0;

//for (int i = 1; i <= N; i++)
//{
//    if (i % 2 == 0)
//    {
//        contadorPares++;
//    }
//}

//Console.WriteLine($"La cantidad de números pares entre 1 y {N} es: {contadorPares} números pares");
//Console.ReadLine();


//13. Suma de números impares: Calcular la suma de los números impares del 1 al 100.


//int sumaImpares = 0;
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2 != 0)
//    {
//        sumaImpares += i;
//    }
//}
//Console.WriteLine($"La suma de los números impares del 1 al 100 es: {sumaImpares}");
//Console.ReadLine();


//14. Contador de letras: Pedir una palabra y mostrar cuántas letras tiene.

//Opcion 1
//Console.Write("Ingrese una palabra: ");
//string palabra = Console.ReadLine();
//int contadorLetras = 0;

//for (int i = 0; i < palabra.Length; i++)
//{
//    if (char.IsLetter(palabra[i]))
//    {
//        contadorLetras++;
//    }
//}
//Console.WriteLine($"La cantidad de letras en la palabra es: {contadorLetras}");
//Console.ReadLine();

//Opcion 2
//Console.Write("Ingrese una palabra: ");
//string palabra = Console.ReadLine();
//int contadorLetras = 0;

//for (int i = 0; i < palabra.Length; i++)
//{
//    char c = palabra[i];
//    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
//    {
//        contadorLetras++;
//    }
//}

//Console.WriteLine($"La cantidad de letras en la palabra es: {contadorLetras}");
//Console.ReadLine();


//15. Tabla de multiplicar: Pedir un número y mostrar su tabla de multiplicar del 1 al 10.


//Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
//int numero = int.Parse(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{numero} x {i} = {numero * i}");
//}
//Console.ReadLine();

//16.Promedio de notas: Pedir 5 notas, calcular el promedio y mostrar si el estudiante
//aprueba (>=6) o no.


//double sumaNotas = 0;
//for (int i = 1; i <= 5; i++)
//{
//    Console.Write($"Ingrese la nota {i}: ");
//    double nota = double.Parse(Console.ReadLine());
//    sumaNotas += nota;
//}
//double promedio = sumaNotas / 5;
//if (promedio >= 6)
//{
//    Console.WriteLine($"El estudiante aprueba con un promedio de: {promedio}");
//}
//else
//{
//    Console.WriteLine($"El estudiante no aprueba, su promedio es: {promedio}");
//}
//Console.ReadLine();


//17. Contador hasta que sea cero: Pedir números enteros hasta que el usuario ingrese 0.
//Mostrar la cantidad de números introducidos.

//int contadorNumeros = 0;
//while (true)
//{
//    Console.Write("Ingrese un número entero (0 para terminar): ");
//    int numero = int.Parse(Console.ReadLine());
//    if (numero == 0)
//    {
//        break;
//    }
//    contadorNumeros++;
//}
//Console.WriteLine($"Se ingresaron {contadorNumeros} números.");
//Console.ReadLine();


//18. Suma acumulada con condición: Pedir números y sumar hasta que la suma supere
//100.Mostrar cuántos números se ingresaron.


//int sumaAcumulada = 0;
//int contadorNumeros = 0;

//while (sumaAcumulada <= 100)
//{
//    Console.Write("Ingrese un número: ");
//    int numero = int.Parse(Console.ReadLine());

//    sumaAcumulada += numero;
//    contadorNumeros++;


//    if (sumaAcumulada <= 100)
//    {
//        Console.WriteLine("La suma de sus números ingresados aún no ha superado al 100");
//    }
//}

//Console.WriteLine($"Se ingresaron {contadorNumeros} números.");
//Console.ReadLine();


//19. Contador de dígitos: Pedir un número entero y decir cuántos dígitos tiene.

//Console.Write("Ingrese un número entero: ");
//int numero = int.Parse(Console.ReadLine());
//int contadorDigitos = 0;

//while (numero != 0)
//{
//    numero /= 10;
//    contadorDigitos++;
//}

//Console.WriteLine($"La cantidad de dígitos es: {contadorDigitos}");
//Console.ReadLine();


//20. Contar vocales: Pedir una palabra y contar cuántas vocales tiene.


//Console.Write("Ingrese una palabra: ");
//string palabra = Console.ReadLine();
//int contadorVocales = 0;

//for (int i = 0; i < palabra.Length; i++)
//{
//    char letra = palabra[i];

//    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' ||
//        letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
//    {
//        contadorVocales++;
//    }
//}

//Console.WriteLine("La cantidad de vocales en la palabra es: " + contadorVocales);
//Console.ReadLine();


//21. Mini cajero automático
//Simular un cajero con un saldo inicial. Mostrar un menú con opciones:
//● 1) Consultar saldo
//● 2) Depositar
//● 3) Retirar
//● 4) Salir
//Validar que no se retire más de lo que hay y que los montos sean positivos.

//double saldo = 1000.0; // Acá yo defino un saldo inicial

//while (true)
//{
//    Console.WriteLine("Bienvenido a Cajeros Poli Veliz");
//    Console.WriteLine("Seleccione una opción:");
//    Console.WriteLine("1) Consultar saldo");
//    Console.WriteLine("2) Depositar");
//    Console.WriteLine("3) Retirar");
//    Console.WriteLine("4) Salir");
//    int opcion = int.Parse(Console.ReadLine());

//    switch (opcion)
//    {
//        case 1:
//            Console.WriteLine($"Su saldo es: {saldo}");
//            break;
//        case 2:
//            Console.Write("Ingrese el monto a depositar: ");
//            double montoDeposito = double.Parse(Console.ReadLine());
//            if (montoDeposito > 0)
//            {
//                saldo += montoDeposito;
//                Console.WriteLine($"Ha depositado {montoDeposito}. Su nuevo saldo es: {saldo}");
//            }
//            else
//            {
//                Console.WriteLine("El monto a depositar debe ser positivo.");
//            }
//            break;
//        case 3:
//            Console.Write("Ingrese el monto a retirar: ");
//            double montoRetiro = double.Parse(Console.ReadLine());
//            if (montoRetiro > 0 && montoRetiro <= saldo)
//            {
//                saldo -= montoRetiro;
//                Console.WriteLine($"Ha retirado {montoRetiro}. Su nuevo saldo es: {saldo}");
//            }
//            else
//            {
//                Console.WriteLine("El monto a retirar debe ser positivo y no puede superar el saldo.");
//            }
//            break;
//        case 4:
//            Console.WriteLine("Gracias por usar el cajero automático.");
//            return;
//        default:
//            Console.WriteLine("Opción no válida.");
//            break;
//    }
//}
//Console.ReadLine();