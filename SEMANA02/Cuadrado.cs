public class Cuadrado : Figura
{
   //Atributos del encansulado
   public double Lado {get; set;}

   //constructor
   public Cuadrado(double Lado)
    {
        this.Lado = Lado;
    }

    //metodos
    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}