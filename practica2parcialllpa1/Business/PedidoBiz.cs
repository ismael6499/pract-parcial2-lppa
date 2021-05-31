using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using practica2parcialllpa1.Data;
using practica2parcialllpa1.Data.Entities;

namespace practica2parcialllpa1.Business
{
    public class PedidoBiz
    {
        BaseDataService<Pedido> db;

        public PedidoBiz()
        {
            db = new BaseDataService<Pedido>();
        }

        public Pedido Agregar(Pedido model)
        {
            return db.Create(model);
        }

        public List<Pedido> Listar()
        {

            var lista = db.Get();
            return lista;
        }

        public Pedido Get(int id)
        {
            return db.GetById(id);
        }

        public void Eliminar(Pedido model)
        {
            db.Delete(model);
        }

        public void Update(Pedido model)
        {
            db.Update(model);
        }
    }
}