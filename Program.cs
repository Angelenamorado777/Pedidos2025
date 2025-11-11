// Creamos el objeto

List<Producto> catalogoList = new List<Producto>();

Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "Iphone 17 Pro Max";
electronico.Precio = 52000;
electronico.Stock = 10;
electronico.GarantiaMeses = 12;
electronico.Voltaje = "110V";
electronico.MostrarInformation();
catologoList.Add(electronico);



Pedido pedido = new Pedido(1);
pedido.AgregarItem(electronico, 1);
pedido.AgregarItem(electronico, 5);

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

Pedido pedido1 = new Pedido(1);
pedido1.AgregarItem(libro, 1);
pedido1.AgregarItem(libro, 5);

libro.MostrarInformation();