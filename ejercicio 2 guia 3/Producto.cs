using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_guia_3
{
     abstract class Producto
    {
        private string Descripcion;
        protected double PrecioBase;
        protected int TipoMaterial;

         public Producto(string descripcion, double preciobase, int tipomaterial)
        { Descripcion = descripcion;
            PrecioBase = preciobase;
            TipoMaterial = tipomaterial; 
        }

        abstract public double Calcularprecio();
        abstract public string Verdetalle();



    }
}
