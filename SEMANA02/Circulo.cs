// Este es la clase Circulo hereda de Figura 
public class Circulo : Figura
{
    //Atributos
    public double Radio {get; set;}

    // Constructor inicializa el radio
    public Circulo(double radio)
    {
        this.Radio = radio;
    }

    // Metodos
    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }  
    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}