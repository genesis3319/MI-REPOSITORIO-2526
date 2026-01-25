using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una expresión matemática: ");
        string expresion = Console.ReadLine();

        Stack<char> pila = new Stack<char>();
        bool balanceada = true;

        foreach (char c in expresion)
        {
            // 1) Si es símbolo de apertura → Push
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // 2) Si es símbolo de cierre
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía → error
                if (pila.Count == 0)
                {
                    balanceada = false;
                    break;
                }

                // Sacar el último símbolo abierto
                char ultimo = pila.Pop();

                // Verificar que coincida
                if ((ultimo == '(' && c != ')') ||
                    (ultimo == '{' && c != '}') ||
                    (ultimo == '[' && c != ']'))
                {
                    balanceada = false;
                    break;
                }
            }
        }

        // Si quedó algo en la pila → no está balanceada
        if (pila.Count != 0)
            balanceada = false;

        if (balanceada)
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }
}
