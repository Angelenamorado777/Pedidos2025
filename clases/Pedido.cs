
public class Pedido
{
    public int Id { get; set; }
    
    public DateTime Fecha { get; set; }

    public List<ItemPedido> Items { get; set; }
     
    public decimal Total => Items.Sum{item => item.Subtotal};

    public Pedido (int IdPedido)
{
    IdPedido = IdPedido;
}
}