using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> traductor = new Dictionary<string, string>()
        {
            {"tiempo","time"},
            {"persona","person"},
            {"año","year"},
            {"día","day"},
            {"mundo","world"},
            {"vida","life"},
            {"mano","hand"},
            {"ojo","eye"},
            {"mujer","woman"},
            {"trabajo","work"},
            {"azul","blue"}
            
    
        };

        int opcion;

        do
        {
            Console.WriteLine("\n================ MENÚ =================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Traducir(traductor);
                    break;

                case 2:
                    Agregar(traductor);
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }

        } while (opcion != 0);
    }

    static void Traducir(Dictionary<string, string> dic)
    {
        Console.Write("\nIngrese una frase: ");
        string frase = Console.ReadLine().ToLower();

        string[] palabras = frase.Split(' ');
        string resultado = "";

        foreach (string palabra in palabras)
        {
            if (dic.ContainsKey(palabra))
                resultado += dic[palabra] + " ";
            else
                resultado += palabra + " ";
        }

        Console.WriteLine("\nTraducción parcial:");
        Console.WriteLine(resultado);
    }

    static void Agregar(Dictionary<string, string> dic)
    {
        Console.Write("\nPalabra en español: ");
        string ingles = Console.ReadLine().ToLower();

        Console.Write("Traducción en ingles: ");
        string espanol = Console.ReadLine().ToLower();

        if (!dic.ContainsKey(ingles))
        {
            dic.Add(ingles, espanol);
            Console.WriteLine(" Palabra agregada.");
        }
        else
        {
            Console.WriteLine(" Esa palabra ya existe.");
        }
    }
}
