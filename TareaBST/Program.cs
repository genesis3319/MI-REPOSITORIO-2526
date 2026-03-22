class Program
{
    static void Main()
    {
        ArbolBST miArbol = new ArbolBST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n    MENU ARBOL BST ");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Recorridos");
            Console.WriteLine("4. Minimo y Maximo");
            Console.WriteLine("5. Altura");
            Console.WriteLine("6. Eliminar");
            Console.WriteLine("7. Limpiar");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione la opcion que necesite: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    valor = int.Parse(Console.ReadLine());
                    miArbol.Raiz = miArbol.Insertar(miArbol.Raiz, valor);
                    break;

                case 2:
                    Console.Write("Valor a buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(miArbol.Buscar(miArbol.Raiz, valor)
                        ? "Encontrado"
                        : "No encontrado");
                    break;

                case 3:
                    Console.WriteLine("InOrden:");
                    miArbol.InOrden(miArbol.Raiz);
                    Console.WriteLine("\nPreOrden:");
                    miArbol.PreOrden(miArbol.Raiz);
                    Console.WriteLine("\nPostOrden:");
                    miArbol.PostOrden(miArbol.Raiz);
                    break;

                case 4:
                    Console.WriteLine("Minimo: " + miArbol.Minimo(miArbol.Raiz));
                    Console.WriteLine("Maximo: " + miArbol.Maximo(miArbol.Raiz));
                    break;

                case 5:
                    Console.WriteLine("Altura: " + miArbol.Altura(miArbol.Raiz));
                    break;

                case 6:
                    Console.Write("Valor a eliminar: ");
                    valor = int.Parse(Console.ReadLine());
                    miArbol.Raiz = miArbol.Eliminar(miArbol.Raiz, valor);
                    Console.WriteLine("Nodo eliminado");
                    break;

                case 7:
                    miArbol.Limpiar();
                    Console.WriteLine("Arbol limpiado");
                    break;
            }

        } while (opcion != 8);
    }
}