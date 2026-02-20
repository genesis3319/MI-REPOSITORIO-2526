using System;
using System.Collections.Generic;

public class SistemaVacunacion
{
    // Conjunto universo → U
    public HashSet<string> Ciudadanos { get; } = new HashSet<string>();

    // Conjunto P → Vacunados con Pfizer
    public HashSet<string> Pfizer { get; } = new HashSet<string>();

     // Conjunto A → Vacunados con AstraZeneca
    public HashSet<string> AstraZeneca { get; } = new HashSet<string>();

    private Random random = new Random();

    public SistemaVacunacion()
    {
        GenerarCiudadanos(); //Aqui Genera los 500 ciudadanos ficticio
        AsignarVacunas(Pfizer, 75); //Aqui Selecciona 75 ciudadanos aleatorios para Pfizer
        AsignarVacunas(AstraZeneca, 75); // Aqui Selecciona 75 ciudadanos aleatorios para AstraZeneca
    }

      // Método para generar los ciudadanos ficticios
    private void GenerarCiudadanos()
    {
        for (int i = 1; i <= 500; i++)
        {
            Ciudadanos.Add($"Ciudadano {i}");
        }
    }

       // Método para asignar vacunas sin repetir ciudadanos
    private void AsignarVacunas(HashSet<string> conjunto, int cantidad)
    {
        List<string> lista = new List<string>(Ciudadanos);

        while (conjunto.Count < cantidad)
        {
            int indice = random.Next(lista.Count);
            conjunto.Add(lista[indice]);
        }
    }
}