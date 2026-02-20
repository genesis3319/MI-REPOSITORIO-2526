using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Aqui se crea el sistema con los datos ficticios
        var sistema = new SistemaVacunacion();

        // OPERACIONES DE TEORÍA DE CONJUNTOS 

        // Unión: P ∪ A → Ciudadanos vacunados con al menos una dosis
        var vacunados = new HashSet<string>(sistema.Pfizer);
        vacunados.UnionWith(sistema.AstraZeneca);

        // Intersección: P ∩ A → Ciudadanos con ambas dosis
        var ambasDosis = new HashSet<string>(sistema.Pfizer);
        ambasDosis.IntersectWith(sistema.AstraZeneca);

        // Diferencia: P – A → Solo vacunados con Pfizer
        var soloPfizer = new HashSet<string>(sistema.Pfizer);
        soloPfizer.ExceptWith(sistema.AstraZeneca);

        // Diferencia: A – P → Solo vacunados con AstraZeneca
        var soloAstra = new HashSet<string>(sistema.AstraZeneca);
        soloAstra.ExceptWith(sistema.Pfizer);

        // Diferencia: U – (P ∪ A) → Ciudadanos no vacunados
        var noVacunados = new HashSet<string>(sistema.Ciudadanos);
        noVacunados.ExceptWith(vacunados);

        // ------------------ RESULTADOS ------------------

        Console.WriteLine("===== RESULTADOS DE LA CAMPAÑA DE VACUNACIÓN =====\n");

        Console.WriteLine($"Ciudadanos no vacunados: {noVacunados.Count}");
        Console.WriteLine($"Ciudadanos con ambas dosis: {ambasDosis.Count}");
        Console.WriteLine($"Ciudadanos solo con Pfizer: {soloPfizer.Count}");
        Console.WriteLine($"Ciudadanos solo con AstraZeneca: {soloAstra.Count}");

        
    }
}