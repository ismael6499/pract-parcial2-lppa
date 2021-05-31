using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using practica2parcialllpa1.Data;
using practica2parcialllpa1.Data.Entities;

namespace practica2parcialllpa1.Business
{
    public class PochocloBiz
    {
        BaseDataService<Pochoclo> db;

        public PochocloBiz()
        {
            db = new BaseDataService<Pochoclo>();
        }

        public Pochoclo Agregar(Pochoclo model)
        {
            return db.Create(model);
        }

        public List<Pochoclo> Listar()
        {

            var lista = db.Get();
            return lista;
        }

        public Pochoclo Get(int id)
        {
            return db.GetById(id);
        }

        public void Eliminar(Pochoclo model)
        {
            db.Delete(model);
        }

        public void Update(Pochoclo model)
        {
            db.Update(model);
        }
    }
}