public abstract class Producto : IInformacionDetallada
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    /// <summary>
    /// Muestra la information del producto
    /// </summary>
    public abstract void MostrarInformation();

    /// <summary>
    /// Disminuye el inventario
    /// </summary>
    /// <param name="Cantidad">Cantidad a disminuir en el inventario</param>
    public void DisminuirStock(int Cantidad)
    {
        if (Stock >= Cantidad)
        {
            Stock -= Cantidad;
        }
        else
        {
            Console.WriteLine($"No hay suficiente stock de {Nombre}");
            Console.WriteLine();
        }
    }

    public string ObtenerInformacionDetallada()
    {
        return $"ID: {Id}\n" +
       $"Nombre: {Nombre}\n" +
       $"Precio: {Precio:C}\n" +
       $"Cantidad disponible: {Stock}";
    }
}