using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practica2parcialllpa1.Data.Entities
{
    public class Pochoclo : IdentityBase
    {

        private String nombre;
        private Double precio;

        public virtual Pedido pedido { get; set; }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public double Precio
        {
            get => precio;
            set => precio = value;
        }
    }
}