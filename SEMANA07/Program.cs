using System;

class Program
{
    static void Main(string[] args)
    {
        //creamos una lista enlazada
        ListadoSimple lista = new ListadoSimple();

        //insertamos elementos
        lista.InsertarFinal(10);
        lista.InsertarFinal(20);
        lista.InsertarFinal(30);
        lista.InsertarFinal(40);

        //lista original
        Console.WriteLine("Lista original:");
        lista.MostrarLista();

        Console.WriteLine("\nNúmero de elementos: " + lista.ContarElementos());

        //invertir lista
        lista.InvertirLista();

        //mostramos lista invertida
        Console.WriteLine("\nLista invertida:");
        lista.MostrarLista();
    }
}
