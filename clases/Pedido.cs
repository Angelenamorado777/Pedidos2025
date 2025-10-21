
using System.Collections.ObjectModel;

public class Pedido
{
    public int Id { get; set; }
    public DateTime Fecha => DateTime.Now;
    public List<ItemPedido> Items { get; set; }
    public decimal Total => Items.Sum(item => item.Subtotal);

    public Pedido(int IdPedido)
    {
        Id = IdPedido;
        Items = new List<ItemPedido>();
        //Fecha = DateTime.Now;
    }

    public void AgregarItem(Producto Producto, int Cantidad)
    {
        if (Producto.Stock >= Cantidad)
        {
            // Agregar elementos a la lista
            Items.Add(new ItemPedido(Producto, Cantidad));
            Producto.DisminuirStock(Cantidad);
            Console.WriteLine($"El Producto {Producto.Nombre} con cantidad {Cantidad}, se ha agregado al Pedido");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"No hay suficiente stock de {Producto.Nombre}");
        }
    }
    
    public void MostrarDetalles()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Detalles del Pedido #{Id}");
        Console.WriteLine($"Fecha: {Fecha:dd/MM/yyyy hh:mm:ss tt}");

        foreach (var item in Items)
        {
            Console.WriteLine($"Producto: {item.Producto.Nombre}, Cantidad: {item.Cantidad}, Subtotal: {item.Subtotal:C}");
        }
        Console.WriteLine($"Total: {Total:C}");
        Console.WriteLine("------------------------------");
        Console.WriteLine();
    }
}