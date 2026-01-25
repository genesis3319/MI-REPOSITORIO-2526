

class Program
{
    static Stack<int> origen = new Stack<int>();
    static Stack<int> auxiliar = new Stack<int>();
    static Stack<int> destino = new Stack<int>();

    static void Main()
    {
        int discos = 3;

        for (int i = discos; i >= 1; i--)
        {
            origen.Push(i);
        }

        ResolverHanoi(discos, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }

    static void ResolverHanoi(
        int n,
        Stack<int> origen,
        Stack<int> destino,
        Stack<int> auxiliar,
        string nombreOrigen,
        string nombreDestino,
        string nombreAuxiliar)
    {
        if (n == 0) return;

        ResolverHanoi(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);

        int disco = origen.Pop();
        destino.Push(disco);
        Console.WriteLine($"Movimiento de disco {disco} de {nombreOrigen} a {nombreDestino}");

        ResolverHanoi(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
    }
}


