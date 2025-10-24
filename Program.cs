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

Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "Iphone 17 Pro Max";
electronico.Precio = 52000;
electronico.Stock = 10;
electronico.GarantiaMeses = 12;
electronico.Voltaje = "110V";
electronico.MostrarInformation();

Libro libro = new Libro();
libro.Id = 4;
libro.Nombre = "El Principito";
libro.Precio = 250;
libro.Stock = 1500;
libro.ISBN = "85364581814522";
libro.Autor = "Antoine de Saint-Exupéry";
libro.NumeroPaginas = 170;
libro.MostrarInformation();

