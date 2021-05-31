using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practica2parcialllpa1.Data.Entities
{
    public class Pedido : IdentityBase
    {
        public virtual ICollection<Pochoclo> pochoclos { get; set; } = new List<Pochoclo>();

        
    }
}