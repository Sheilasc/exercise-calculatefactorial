//Crear un programa que calcule el factorial de un número `N' entero y positivo.
internal class Program
{
    private static void Main(string[] args)
    {
        //Leer un numero
    Console.WriteLine ("Ingrese un numero");
    string numeroComoString = Console.ReadLine();
    int valor = Int32.Parse(numeroComoString);
    //valor inicial del factorial
    int factorial = 1;
    for (int i=1; i<=valor; i++)
    {
      factorial=factorial*i;
    }
    Console.WriteLine ("El factorial de " +valor+ " es: " +factorial);
    }
}