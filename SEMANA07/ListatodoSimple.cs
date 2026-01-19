using System;

public class ListadoSimple
{
    private Nodo? head; //primer nodo

    public ListadoSimple()
    {
        head = null;
    }

    // Insertar nodo al final
    public void InsertarFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (head == null)
        {
            head = nuevo;
        }
        else
        {
            Nodo actual = head;
            while (actual.Next != null)
            {
                actual = actual.Next;
            }
            actual.Next = nuevo;
        }
    }

    //  EJERCICIO 1: Contar elementos de una lista
    public int ContarElementos()
    {
        int contador = 0;
        Nodo? actual = head;

        while (actual != null)
        {
            contador++;
            actual = actual.Next;
        }

        return contador;
    }

    //  EJERCICIO 2: Invertir lista enlazada
    public void InvertirLista()
    {
        Nodo? anterior = null;
        Nodo? actual = head;
        Nodo? siguiente;

        while (actual != null)
        {
            siguiente = actual.Next;
            actual.Next = anterior;
            anterior = actual;
            actual = siguiente;
        }

        head = anterior;
    }

    // Mostrar lista
    public void MostrarLista()
    {
        Nodo? actual = head;
        Console.Write("head --> ");
        while (actual != null)
        {
            Console.Write("[ " + actual.Data + " | * ] --> ");
            actual = actual.Next;
        }
        Console.WriteLine("null");
    }
}
