Console.WriteLine("SEMANA02");
Console.WriteLine();

        //  CUADRADO 
        Cuadrado cuadrado = new Cuadrado(8);

        Console.WriteLine("Cuadrado       | Valor");
        Console.WriteLine("----------------|----------");
        Console.WriteLine("Lado           | " + cuadrado.Lado);
        Console.WriteLine("Área           | " + cuadrado.CalcularArea());
        Console.WriteLine("Perímetro      | " + cuadrado.CalcularPerimetro());

        Console.WriteLine();

        // CÍRCULO 
        Circulo circulo = new Circulo(7);

        Console.WriteLine("Círculo        | Valor");
        Console.WriteLine("----------------|-----------");
        Console.WriteLine("Radio           | " + circulo.Radio);
        Console.WriteLine("Área           | " + circulo.CalcularArea());
        Console.WriteLine("Perímetro      | " + circulo.CalcularPerimetro());

        Console.WriteLine();
