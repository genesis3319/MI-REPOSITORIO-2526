
class Program
{
    static Contacto[] agenda = new Contacto[5];   // ES EL  VECTOR
    static int[,] llamadas = new int[5, 3];       // MATRIZ
    static int contador = 0;

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\nAGENDA TELEFÓNICA");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Listar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarContacto();
                    break;
                case 2:
                    ListarContactos();
                    break;
                case 3:
                    BuscarContacto();
                    break;
            }

        } while (opcion != 4);
    }

    static void AgregarContacto()
    {
        if (contador < agenda.Length)
        {
            Console.Write("Ingrese Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese Teléfono: ");
            string telefono = Console.ReadLine();

           //AQUI GUARDAMOS VECTOR
            agenda[contador] = new Contacto(nombre, telefono);

            // Simulación de llamadas (matriz)
            llamadas[contador, 0] = 1;
            llamadas[contador, 1] = 2;
            llamadas[contador, 2] = 3;

            contador++;
            Console.WriteLine("Contacto agregado.");
        }
        else
        {
            Console.WriteLine("Agenda llena.");
        }
    }

    static void ListarContactos()
    {
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"Nombre: {agenda[i].Nombre} | Teléfono: {agenda[i].Telefono}");
        }
    }

    static void BuscarContacto()
    {
        Console.Write("Ingrese el nombre a buscar: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < contador; i++)
        {
            if (agenda[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Contacto encontrado: {agenda[i].Nombre} - {agenda[i].Telefono}");
                return;
            }
        }
        Console.WriteLine("Contacto no encontrado.");
    }
}

