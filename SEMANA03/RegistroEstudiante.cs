class RegistroEstudiante
{
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;

    // Array para los teléfonos
    public string[] Telefonos = new string[3];

    public void MostrarDatos()
    {
        Console.WriteLine("\n--- REGISTRO DEL ESTUDIANTE ---");
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombres: " + Nombres);
        Console.WriteLine("Apellidos: " + Apellidos);
        Console.WriteLine("Dirección: " + Direccion);

        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}
