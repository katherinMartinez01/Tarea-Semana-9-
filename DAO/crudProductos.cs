﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaSemana8.Models;

namespace TareaSemana8.DAO
{
    public class crudProductos
    {
        public void guardar(Producto paramProducto)
        {
            using (AlmacenContext bd = new AlmacenContext())
            {
                Producto producto = new Producto();
                producto.Nombre = paramProducto.Nombre;
                producto.Descripcion = paramProducto.Descripcion;
                producto.Precio = paramProducto.Precio;
                producto.Stock = paramProducto.Stock;

                bd.Add(producto);
                bd.SaveChanges();
                Console.WriteLine("¡¡Su Producto Fue Ingresado Exitosamente!!");
            }
        }
    }
}
    

