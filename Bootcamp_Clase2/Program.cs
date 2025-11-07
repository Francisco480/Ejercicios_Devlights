// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte numero = 4;
short numero2 = 30000;
int edad1 = 25;


float numeroDecimal = 2.5f;
double numeroDecimal2 = 3.1416;
decimal numeroDecimal3 = 2.5m;

char letra = 'a';
bool flag = false;

string nombre = "Francisco";
var variable = "Hola Mundo";

var otraVariable = 3.5;

int numeroEntero = 10;
long numeroLong = numeroEntero; // conversion implicita
numeroEntero = (int)numeroLong; // conversion explicita

string numeroString = numeroEntero.ToString();
int otroEntero = int.Parse(numeroString);

Console.WriteLine("Ingrese su edad");
string valor = Console.ReadLine();
int edad = int.Parse(valor);

int edad3;
bool resultado = int.TryParse(Console.ReadLine(), out edad3);