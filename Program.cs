// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using EspacioCalculadora;
 Calculadora calculo = new Calculadora();
// calculo.Sumar(5);
// Console.WriteLine(calculo.Resultado);
// calculo.Multiplicar(2);
// Console.WriteLine(calculo.Resultado);
// calculo.Restar(3);
// Console.WriteLine(calculo.Resultado);
// calculo.Dividir(5);
// Console.WriteLine(calculo.Resultado);

// calculo.Limpiar();
// Console.WriteLine(calculo.Resultado);
// calculo.Sumar(5);
// Console.WriteLine(calculo.Resultado);
int opcion= 999;
do
{
Console.WriteLine("Escriba qué operacion desea realizar con " + calculo.Resultado + ":");
Console.WriteLine("1. Sumarle un numero");
Console.WriteLine("2. Restarle un numero");
Console.WriteLine("3. Multiplicarlo por un numero");
Console.WriteLine("4. Dividirlo en un numero");
Console.WriteLine("5. Limpiar");
Console.WriteLine("0. Salir");

int.TryParse(Console.ReadLine(), out opcion);
Console.WriteLine("Ingrese un numero: ");
double.TryParse(Console.ReadLine(), out double num2);
switch (opcion)
{
    case 1:
        calculo.Sumar(num2);
        break;
    case 2:
        calculo.Restar(num2);
        break;
    case 3:
        calculo.Multiplicar(num2);
        break;
    case 4:
       if (num2 != 0)
       {
          calculo.Dividir(num2);
       }else
       {
        Console.WriteLine("No es posible dividir por 0");
       }
       
        break;
    case 5:
        calculo.Limpiar();
        break;
    
}
Console.WriteLine("Resultado: " + calculo.Resultado + " -----------------------");
} while (opcion != 0);



