using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_guia_3
{
    internal class Mesa1 : Producto
    {
        private double Largo;
        public Mesa1(string descripcion, double preciobase, int tipomaterial, double largo) : base(descripcion, preciobase, tipomaterial)
        {
            Largo = largo;
        }

        public override double Calcularprecio()
        {
            double precioF = (PrecioBase * Largo) * (1 + TipoMaterial * 0.33);
            return precioF;  
        
        }

        string material;
        public override string Verdetalle()
        {
            if (TipoMaterial == 0)
            {
                 material = "pino";
            }
            else if(TipoMaterial == 1) 
            {
                material = "algarrobo";
            }
            else 
            {
                material = "caoba";
                    
            }

            return $""
                
        }




    }
}
