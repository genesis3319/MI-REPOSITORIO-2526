// Clase Nodo: representa cada elemento del árbol
class Nodo
{
    public int Valor;
    public Nodo Izquierdo;  // Apunta al hijo izquierdo
    public Nodo Derecho;    // Apunta al hijo derecho

// Constructor: se ejecuta cuando se crea un nodo
    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}

