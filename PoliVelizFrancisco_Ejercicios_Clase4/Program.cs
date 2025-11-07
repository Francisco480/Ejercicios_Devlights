// See https://aka.ms/new-console-template for more information

//Ejercicio1();

//////1. Dado que se tiene almacenado en una lista, los resultados de los últimos 10 exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10 notas de los exámenes y el promedio resultante.

//static void Ejercicio1()
//{
//    List<double> notas = new List<double> { 5.5, 8, 6, 9.5, 10, 4, 7, 8.5, 9, 7.5 };

//    double promedio = CalcularPromedio(notas);

//    Console.WriteLine("Notas de los últimos 10 exámenes:");
//    foreach (double nota in notas)
//    {
//        Console.WriteLine($"- {nota}");
//    }

//    Console.WriteLine($"\nPromedio del alumno: {promedio:F2}");
//}

//static double CalcularPromedio(List<double> listaNotas)
//{
//    double suma = 0;
//    foreach (double nota in listaNotas)
//    {
//        suma += nota;
//    }

//    return suma / listaNotas.Count;
//}


////2.Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla
////cuántos son mayores de edad y cuántos no.
///

//Ejercicio2();
//static void Ejercicio2()
//{
//    List<int> edades = new List<int> { 13, 19, 24, 32, 16, 20, 15, 40, 22, 10, 19, 17, 14, 30, 27, 8, 13, 35, 21, 11 };

//    int mayores = 0;
//    int menores = 0;

//    foreach (int edad in edades)
//    {
//        if (edad >= 18)
//            mayores++;
//        else
//            menores++;
//    }

//    Console.WriteLine("Listado de edades:");
//    foreach (int edad in edades)
//    {
//        Console.WriteLine($"- {edad} años");
//    }

//    Console.WriteLine($"\nCantidad de mayores de edad: {mayores}");
//    Console.WriteLine($"Cantidad de menores de edad: {menores}");
//}


////3.Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que
////tenga menos letras de todos.

//Ejercicio3();
//static void Ejercicio3()
//{
//    List<string> nombres = new List<string>
//    {
//        "Rocío", "Gabriel", "Francisco", "José", "Walter",
//        "Yanet", "Agustina", "Nahuel", "Camila", "Cristian"
//    };

//    string nombreMasLargo = nombres[0];
//    string nombreMasCorto = nombres[0];

//    foreach (string nombre in nombres)
//    {
//        if (nombre.Length > nombreMasLargo.Length)
//            nombreMasLargo = nombre;

//        if (nombre.Length < nombreMasCorto.Length)
//            nombreMasCorto = nombre;
//    }

//    Console.WriteLine("Lista de estudiantes:");
//    foreach (string nombre in nombres)
//    {
//        Console.WriteLine($"- {nombre}");
//    }

//    Console.WriteLine($"\nNombre con más letras: {nombreMasLargo} ({nombreMasLargo.Length} letras)");
//    Console.WriteLine($"Nombre con menos letras: {nombreMasCorto} ({nombreMasCorto.Length} letras)");
//}


////4.Crear una variable para guardar los nombres de elementos para una “lista de
////supermercado”. Solicitar al usuario que ingrese el nombre de un elemento que va a
////comprar en el super y verificar que el elemento esté en la lista. Si no está, agregarlo
////e indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba. Al
////finalizar mostrar por pantalla los elementos que no compró y los que compró, pero
////no estaban en la lista. Si se quiere, mostrar también todos los elementos que el
////usuario compró. Para salir el usuario debe ingresar “fin”.


//Ejercicio4();

//static void Ejercicio4()
//{

//    List<string> listaSuper = new List<string>
//    {
//        "leche", "pan", "huevos", "arroz", "azúcar",
//        "yerba", "fideos", "aceite", "queso", "manteca"
//    };

//    List<string> compradosFueraDeLista = new List<string>();
//    List<string> noComprados = new List<string>(listaSuper);

//    Console.WriteLine("=== Lista de supermercado ===");
//    Console.WriteLine(string.Join(", ", listaSuper));
//    Console.WriteLine("\nIngrese los productos que va a comprar. Escriba 'fin' para terminar.\n");

//    while (true)
//    {
//        Console.Write("Ingrese un producto o escriba 'fin' para terminar.: ");
//        string producto = Console.ReadLine().ToLower();

//        if (producto == "fin")
//            break;

//        if (listaSuper.Contains(producto))
//        {
//            Console.WriteLine($"El producto '{producto}' estaba en la lista, lo marcamos como comprado.");
//            listaSuper.Remove(producto);
//            noComprados.Remove(producto);
//        }
//        else
//        {
//            Console.WriteLine($"El producto '{producto}' no estaba en la lista, se agrega como extra.");
//            compradosFueraDeLista.Add(producto);
//        }
//    }

//    Console.WriteLine("\n=== Resultado final ===");

//    Console.WriteLine("\nProductos que NO compró:");
//    if (noComprados.Count > 0)
//        Console.WriteLine(string.Join(", ", noComprados));
//    else
//        Console.WriteLine("Compró todo lo que estaba en la lista.");

//    Console.WriteLine("\nProductos que compró pero NO estaban en la lista:");
//    if (compradosFueraDeLista.Count > 0)
//        Console.WriteLine(string.Join(", ", compradosFueraDeLista));
//    else
//        Console.WriteLine("No compró productos fuera de la lista.");

//    Console.WriteLine("\n¡Compra finalizada!");
//}




////5.Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares
////pares. Imprimir la matriz por pantalla

//Ejercicio5();

//static void Ejercicio5()
//{
//    char[,] matriz = new char[5, 5];

//    for (int fila = 0; fila < 5; fila++)
//    {
//        for (int col = 0; col < 5; col++)
//        {
//            int posicion = fila * 5 + col + 1; // número de posición de 1 a 25

//            if (posicion % 2 == 0)
//                matriz[fila, col] = 'P';
//            else
//                matriz[fila, col] = 'I';
//        }
//    }

//    Console.WriteLine("Matriz 5x5 con 'I' en posiciones impares y 'P' en pares:\n");

//    for (int fila = 0; fila < 5; fila++)
//    {
//        for (int col = 0; col < 5; col++)
//        {
//            Console.Write(matriz[fila, col] + " ");
//        }
//        Console.WriteLine();
//    }
//}



////6.Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de
////la semana. La estructura es para registrar la temperatura diaria de una cabina de
////pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la matriz de forma
////aleatoria para el mes de mayo donde el primer día inicia en lunes y el último (31) se
////ubica en el miércoles (la matriz puede ser inicializada con valores aleatorios desde el
////principio del programa, no es necesario pedir los valores al usuario para cada
////posición). Se nos pide hacer lo siguiente:
////a.Obtener la temperatura más alta y baja de la semana y que día se produjo
////(lunes, martes, etc.)
////b. Promedio de temperatura de la semana.
////c. Temperatura más alta del mes y su día.

//Ejercicio6();



//static void Ejercicio6()
//{
//    int filas = 5;        // Estas son las semanas
//    int columnas = 7;     // Estos los días, Lunes a Domingo
//    int[,] temperaturas = new int[filas, columnas];
//    Random random = new Random();

//    // Cargo mayo
//    int diaMes = 1;

//    for (int semana = 0; semana < filas; semana++)
//    {
//        for (int dia = 0; dia < columnas; dia++)
//        {
//            if (diaMes <= 31)
//            {
//                temperaturas[semana, dia] = random.Next(7, 39); 
//                diaMes++;
//            }
//            else
//            {
//                temperaturas[semana, dia] = 0; 
//            }
//        }
//    }

//    string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

//    //Muestro la matriz
//    Console.WriteLine("=== Temperaturas del mes de Mayo ===\n");

//    int contadorDia = 1;
//    for (int semana = 0; semana < filas; semana++)
//    {
//        for (int dia = 0; dia < columnas; dia++)
//        {
//            if (temperaturas[semana, dia] != 0)
//            {
//                Console.Write($"{contadorDia:00}({temperaturas[semana, dia]}°) ");
//                contadorDia++;
//            }
//            else
//            {
//                Console.Write("   --      ");
//            }
//        }
//        Console.WriteLine();
//    }

//    //a) y b) Informacion por semana
//    Console.WriteLine("\n=== Información por semana ===");

//    for (int semana = 0; semana < filas; semana++)
//    {
//        int max = int.MinValue;
//        int min = int.MaxValue;
//        int colMax = -1;
//        int colMin = -1;
//        int suma = 0;
//        int cantDias = 0;

//        for (int dia = 0; dia < columnas; dia++)
//        {
//            int temp = temperaturas[semana, dia];
//            if (temp == 0) continue; 

//            suma += temp;
//            cantDias++;

//            if (temp > max)
//            {
//                max = temp;
//                colMax = dia;
//            }

//            if (temp < min)
//            {
//                min = temp;
//                colMin = dia;
//            }
//        }

//        if (cantDias > 0)
//        {
//            double promedio = (double)suma / cantDias;

//            Console.WriteLine($"\nSemana {semana + 1}:");
//            Console.WriteLine($"  - Temp más alta: {max}° el {diasSemana[colMax]}");
//            Console.WriteLine($"  - Temp más baja: {min}° el {diasSemana[colMin]}");
//            Console.WriteLine($"  - Promedio de la semana: {promedio:F2}°");
//        }
//    }

//    //c) Temperatura más alta 
//    int tempMaxMes = int.MinValue;
//    int diaMaxMes = 0;
//    string diaSemanaMaxMes = "";

//    contadorDia = 1; 

//    for (int semana = 0; semana < filas; semana++)
//    {
//        for (int dia = 0; dia < columnas; dia++)
//        {
//            int temp = temperaturas[semana, dia];
//            if (temp == 0) continue; 

//            if (temp > tempMaxMes)
//            {
//                tempMaxMes = temp;
//                diaMaxMes = contadorDia;
//                diaSemanaMaxMes = diasSemana[dia];
//            }

//            contadorDia++;
//        }
//    }

//    Console.WriteLine("\n=== Temperatura máxima del mes ===");
//    Console.WriteLine($"La temperatura más alta fue {tempMaxMes}° el {diaMaxMes} de mayo ({diaSemanaMaxMes}).");
//}




////7.Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera
////fila y la primera columna se debe guardar los números (de 0 a 9), estando el cero en
////la primera posición (fila 0, columna 0). El resto de los lugares debe ser calculado
////usando los números que se dispone, por ejemplo, en la fila 1, calcular 1*1, 1*2, 1*3,
////etc. usando las posiciones del array o arreglo. Al finalizar el cálculo, mostrar la matriz
////por pantalla

//Ejercicio7();

//static void Ejercicio7()
//{
//    int filas = 10;     
//    int columnas = 10;  
//    int[,] tabla = new int[filas, columnas];


//    for (int i = 0; i < filas; i++)
//    {
//        tabla[i, 0] = i; 
//        tabla[0, i] = i; 
//    }


//    for (int i = 1; i < filas; i++)
//    {
//        for (int j = 1; j < columnas; j++)
//        {
//            tabla[i, j] = tabla[i, 0] * tabla[0, j];
//        }
//    }


//    Console.WriteLine("=== Tablas de multiplicar del 1 al 9 ===\n");

//    for (int i = 0; i < filas; i++)
//    {
//        for (int j = 0; j < columnas; j++)
//        {
//            Console.Write($"{tabla[i, j],4}");
//        }
//        Console.WriteLine();
//    }
//}




////8.Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la
////cantidad que el programador decida, pero no más de la mitad de los lugares
////disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que hay una
////X, ingresando la fila y la columna por separado. Informar si acertó o no por cada
////ingreso. Se debe pedir al usuario ingresar valores por tantas X que se haya
////guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya sea porque se

////terminaron los 3 intentos, o el jugador acertó todas las X) imprimir por pantalla la
////matriz con sus correspondientes X, mostrando un * donde no haya nada.


//Ejercicio8();


//static void Ejercicio8()
//{
//    int filas = 10;
//    int columnas = 10;
//    bool[,] hayX = new bool[filas, columnas];
//    bool[,] descubierta = new bool[filas, columnas];
//    Random random = new Random();


//    int cantidadX = 20;


//    int colocadas = 0;
//    while (colocadas < cantidadX)
//    {
//        int f = random.Next(0, filas);
//        int c = random.Next(0, columnas);

//        if (!hayX[f, c])
//        {
//            hayX[f, c] = true;
//            colocadas++;
//        }
//    }

//    int aciertos = 0;
//    int fallos = 0;

//    Console.WriteLine("=== JUEGO: ENCONTRÁ LAS X ===");
//    Console.WriteLine($"Se escondieron {cantidadX} X en una matriz de 10x10.");
//    Console.WriteLine("Ingresá fila y columna (1 a 10). Tenés hasta 3 fallos.\n");


//    while (aciertos < cantidadX && fallos < 3)
//    {
//        Console.Write("Fila (1-10): ");
//        int fila = int.Parse(Console.ReadLine()) - 1;

//        Console.Write("Columna (1-10): ");
//        int columna = int.Parse(Console.ReadLine()) - 1;

//        Console.WriteLine();


//        if (fila < 0 || fila >= filas || columna < 0 || columna >= columnas)
//        {
//            Console.WriteLine("Coordenadas fuera de rango. No cuenta como intento. Probá de nuevo.\n");
//            continue;
//        }


//        if (descubierta[fila, columna])
//        {
//            Console.WriteLine("Ya probaste esa posición. Elegí otra.\n");
//            continue;
//        }


//        descubierta[fila, columna] = true;

//        if (hayX[fila, columna])
//        {
//            aciertos++;
//            Console.WriteLine($"¡Acertaste! Encontraste una X. Aciertos: {aciertos}/{cantidadX}\n");
//        }
//        else
//        {
//            fallos++;
//            Console.WriteLine($"❌ No había X. Fallos: {fallos}/3\n");
//        }
//    }

//    Console.WriteLine("=== FIN DEL JUEGO ===");
//    if (aciertos == cantidadX)
//        Console.WriteLine("¡Felicitaciones! Encontraste todas las X.");
//    else
//        Console.WriteLine("Alcanzaste el límite de fallos.");


//    Console.WriteLine("\n=== MATRIZ FINAL ===");
//    for (int f = 0; f < filas; f++)
//    {
//        for (int c = 0; c < columnas; c++)
//        {
//            if (hayX[f, c])
//                Console.Write(" X ");
//            else
//                Console.Write(" * ");
//        }
//        Console.WriteLine();
//    }
//}



////9.Diccionario de calificaciones: Crear un diccionario donde la clave sea el nombre del
////alumno y el valor sea su nota. El programa debe permitir:
////a.Agregar alumnos y sus notas.
////b. Mostrar el promedio general del curso.
////c. Indicar el alumno con mejor nota y el de peor nota.
////d. Hint: usar Dictionary<string, double> y recorrer con foreach


//Ejercicio9();


//static void Ejercicio9()
//{
//    Dictionary<string, double> calificaciones = new Dictionary<string, double>();
//    string continuar;

//    Console.WriteLine("=== Diccionario de Calificaciones ===");
//    Console.WriteLine("Ingrese el nombre y la nota de cada alumno. Escriba 'fin' para terminar.\n");

//    // a) Agregar alumnos y sus notas
//    while (true)
//    {
//        Console.Write("Nombre del alumno: ");
//        string nombre = Console.ReadLine();

//        if (nombre.ToLower() == "fin")
//            break;

//        Console.Write("Nota del alumno: ");
//        double nota;
//        while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
//        {
//            Console.Write("Nota inválida. Ingrese un número entre 0 y 10: ");
//        }

//        if (!calificaciones.ContainsKey(nombre))
//            calificaciones.Add(nombre, nota);
//        else
//            Console.WriteLine("⚠️ Ese alumno ya fue ingresado. No se agregó de nuevo.");

//        Console.WriteLine();
//    }

//    if (calificaciones.Count == 0)
//    {
//        Console.WriteLine("\nNo se ingresaron alumnos.");
//        return;
//    }

//    // b) Promedio general del curso
//    double suma = 0;
//    foreach (var par in calificaciones)
//    {
//        suma += par.Value;
//    }
//    double promedio = suma / calificaciones.Count;

//    // c) Alumno con mejor y peor nota
//    string mejorAlumno = "";
//    string peorAlumno = "";
//    double mejorNota = double.MinValue;
//    double peorNota = double.MaxValue;

//    foreach (var par in calificaciones)
//    {
//        if (par.Value > mejorNota)
//        {
//            mejorNota = par.Value;
//            mejorAlumno = par.Key;
//        }

//        if (par.Value < peorNota)
//        {
//            peorNota = par.Value;
//            peorAlumno = par.Key;
//        }
//    }

//    //d) Mostrar resultados
//    Console.WriteLine("\n=== Resultados ===");
//    Console.WriteLine("Listado de alumnos y notas:");
//    foreach (var par in calificaciones)
//    {
//        Console.WriteLine($"- {par.Key}: {par.Value}");
//    }

//    Console.WriteLine($"\nPromedio general del curso: {promedio:F2}");
//    Console.WriteLine($"Mejor alumno: {mejorAlumno} con nota {mejorNota}");
//    Console.WriteLine($"Peor alumno: {peorAlumno} con nota {peorNota}");
//}




////10.Simulador de atención en ventanilla: Usar una cola (Queue) para simular la atención
////de clientes en una ventanilla bancaria.
////a. Encolar nombres de clientes.
////b. Atender (desencolar) uno por uno hasta que no queden.
////c. Mostrar en pantalla quién está siendo atendido y cuántos quedan en la fila.
////d. Hint: usar Enqueue(), Dequeue() y Count.


//Ejercicio10();

//static void Ejercicio10()
//{
//    Queue<string> colaClientes = new Queue<string>();
//    string nombre;

//    Console.WriteLine("=== Simulador de Atención en Ventanilla Bancaria ===");
//    Console.WriteLine("Ingrese los nombres de los clientes (escriba 'fin' para terminar):\n");

//    // a) Encolar nombres de clientes
//    while (true)
//    {
//        Console.Write("Nombre del cliente: ");
//        nombre = Console.ReadLine();

//        if (nombre.ToLower() == "fin")
//            break;

//        colaClientes.Enqueue(nombre);
//    }

//    Console.WriteLine($"\nTotal de clientes en espera: {colaClientes.Count}\n");

//    // b) y c) Atender (desencolar) uno por uno hasta que no queden
//    while (colaClientes.Count > 0)
//    {
//        string clienteAtendido = colaClientes.Dequeue();
//        Console.WriteLine($"Atendiendo a: {clienteAtendido}");
//        Console.WriteLine($"Clientes restantes en la fila: {colaClientes.Count}\n");
//    }

//    Console.WriteLine("No quedan más clientes en la fila. Ventanilla libre.");
//}





///
////11.Inventario con múltiples colecciones: Diseñar un sistema de inventario básico
////usando distintas colecciones:
////a.Un List<string> con los productos disponibles.
////b.Un Dictionary<string, int> para registrar el stock de cada producto.
////c.Un Stack<string> para llevar el historial de acciones realizadas (agregar,
////quitar, vender).
////d.El programa debe permitir:
////i.Agregar un producto y su cantidad.
////ii. Vender un producto (restando stock).
////iii. Mostrar el inventario actual.
////iv. Mostrar las últimas 3 acciones registradas.
////e. Hint: combina listas, diccionarios y pilas para manipular distintos tipos de
////información.


//Ejercicio11();


//static void Ejercicio11()
//{
//    List<string> productos = new List<string>();                 // a) Productos disponibles
//    Dictionary<string, int> stock = new Dictionary<string, int>(); // b) Stock por producto
//    Stack<string> historial = new Stack<string>();               // c) Historial de acciones

//    int opcion;

//    do
//    {
//        Console.WriteLine("\n=== SISTEMA DE INVENTARIO ===");
//        Console.WriteLine("1) Agregar producto y cantidad");
//        Console.WriteLine("2) Vender producto (restar stock)");
//        Console.WriteLine("3) Mostrar inventario actual");
//        Console.WriteLine("4) Mostrar últimas 3 acciones");
//        Console.WriteLine("5) Salir");
//        Console.Write("Seleccione una opción: ");

//        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
//        {
//            Console.Write("Opción inválida. Ingrese un número entre 1 y 5: ");
//        }

//        Console.WriteLine();

//        switch (opcion)
//        {
//            case 1:
//                // i. Agregar producto y su cantidad
//                Console.Write("Nombre del producto: ");
//                string producto = Console.ReadLine();

//                Console.Write("Cantidad: ");
//                int cantidad;
//                while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
//                {
//                    Console.Write("Cantidad inválida. Ingrese un número mayor o igual a 0: ");
//                }

//                if (!stock.ContainsKey(producto))
//                {
//                    productos.Add(producto);
//                    stock[producto] = cantidad;
//                    historial.Push($"Agregado producto '{producto}' con {cantidad} unidades.");
//                }
//                else
//                {
//                    stock[producto] += cantidad;
//                    historial.Push($"Sumadas {cantidad} unidades a '{producto}'. Nuevo stock: {stock[producto]}.");
//                }

//                Console.WriteLine("Operación realizada correctamente.");
//                break;

//            case 2:
//                // ii. Vender producto (restando stock)
//                Console.Write("Producto a vender: ");
//                string prodVender = Console.ReadLine();

//                if (!stock.ContainsKey(prodVender))
//                {
//                    Console.WriteLine("El producto no existe en el inventario.");
//                }
//                else
//                {
//                    Console.Write("Cantidad a vender: ");
//                    int cantVender;
//                    while (!int.TryParse(Console.ReadLine(), out cantVender) || cantVender <= 0)
//                    {
//                        Console.Write("Cantidad inválida. Ingrese un número mayor a 0: ");
//                    }

//                    if (stock[prodVender] < cantVender)
//                    {
//                        Console.WriteLine($"Stock insuficiente. Stock actual: {stock[prodVender]}.");
//                    }
//                    else
//                    {
//                        stock[prodVender] -= cantVender;
//                        historial.Push($"Vendidas {cantVender} unidades de '{prodVender}'. Stock restante: {stock[prodVender]}.");
//                        Console.WriteLine("Venta registrada correctamente.");

//                        if (stock[prodVender] == 0)
//                        {
//                            Console.WriteLine($"El producto '{prodVender}' quedó con stock 0.");
//                        }
//                    }
//                }
//                break;

//            case 3:
//                // iii. Mostrar inventario actual
//                Console.WriteLine("=== INVENTARIO ACTUAL ===");
//                if (productos.Count == 0)
//                {
//                    Console.WriteLine("No hay productos cargados.");
//                }
//                else
//                {
//                    foreach (var p in productos)
//                    {
//                        int cant = stock.ContainsKey(p) ? stock[p] : 0;
//                        Console.WriteLine($"- {p}: {cant} unidades");
//                    }
//                }
//                break;

//            case 4:
//                // iv. Mostrar las últimas 3 acciones
//                Console.WriteLine("=== ÚLTIMAS 3 ACCIONES ===");
//                if (historial.Count == 0)
//                {
//                    Console.WriteLine("No hay acciones registradas aún.");
//                }
//                else
//                {
//                    string[] acciones = historial.ToArray(); // convierte la pila a arreglo
//                    int mostrar = Math.Min(3, acciones.Length);

//                    for (int i = 0; i < mostrar; i++)
//                    {
//                        Console.WriteLine($"- {acciones[i]}");
//                    }
//                }
//                break;

//            case 5:
//                Console.WriteLine("Saliendo del sistema de inventario...");
//                break;
//        }

//    } while (opcion != 5);
//}



