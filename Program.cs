using System;
using TareaSemana8;
using TareaSemana8.Models;
using TareaSemana8.DAO;
while (true)
{
    Console.WriteLine("Por Favor Seleccione una Opción del Menú");
    Console.WriteLine("1 - Guardar");
    Console.WriteLine("2 - Salir");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Producto producto = new Producto();
            crudProductos crudProductos = new crudProductos();
            Console.WriteLine("Ingrese el Nombre de un Producto de su elección ");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la Descripción de un Producto de su elección ");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese el Precio de un Producto de su elección");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Stock de un Producto de su elección");
            producto.Stock = int.Parse(Console.ReadLine());
            break;
        case 2:
            break;
    }
    Console.WriteLine("¿Desea Volver a la Ejecución del Programa? SI= I / No= O");
    String seguir = Console.ReadLine();
    if (!(seguir.Equals('I')))
    {
        break;
    }

}
