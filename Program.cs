// Creamos el objeto
Producto producto = new Producto();
Producto producto1 = new Producto();

producto.Id = 1;
producto.Nombre = "Laptop";
producto.Precio = 13500;
producto.Stock = 10;
producto.MostrarInformation();
producto.DisminuirStock(15);
producto.MostrarInformation();

producto1.Id = 2;
producto1.Nombre = "Mouse";
producto1.Precio = 250;
producto1.Stock = 100;
producto1.MostrarInformation();
producto1.DisminuirStock(13);
producto1.MostrarInformation();

Pedido pedido = new Pedido(1);
pedido.AgregarItem(producto, 150);
pedido.AgregarItem(producto1, 45);
pedido.MostrarDetalles();

Console.WriteLine("********** Actualización de Productos **********");
producto.MostrarInformation();
producto1.MostrarInformation();