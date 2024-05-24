// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");


Console.WriteLine("Ingrese su nombre");

string Nombre =  Console.ReadLine();

Console.WriteLine("Ingrese su Edad");

int Edad = int.Parse(Console.ReadLine());

if (Edad >= 18)
{
    Console.WriteLine("Eres Mayor de Edad");
}
else
{
    Console.WriteLine("Eres Menor de Edad");
}


Console.WriteLine("Imprimir Numero del 1 al 10 ");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
