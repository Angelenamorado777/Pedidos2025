
public class Electronico : Producto
{
    public int GarantiaMeses { get; set; }

    public string? Voltaje { get; set; }



    public override void MostrarInformation()
    {
        base.MostrarInformation();
        Console.WriteLine($"Garantía: {GarantiaMeses} meses");
        Console.WriteLine($"Voltaje: {Voltaje}");
        Console.WriteLine($"");

    }

}