using Imobiliaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Imobiliaria.Controllers
{
    public class ClienteController
    {
        protected BancoImobiliariaContainer1 contexto = new BancoImobiliariaContainer1();

        public void Adicionar(Cliente Cliente)
        {
            if (Cliente != null)
            {
                contexto.Clientes.Add(Cliente);
                contexto.SaveChanges();
            }
        }

        public List<Cliente> Listar()
        {
            return contexto.Clientes.Where(c => c.Ativo == true).ToList();
        }

        public List<Cliente> ListarInativos()
        {
            return contexto.Clientes.Where(c => c.Ativo == false).ToList();
        }


        public Cliente BuscarClientePorID(int id)
        {
            return contexto.Clientes.Find(id); // Find pode encontrar a chave
        }

        public Cliente BuscarClientePorNome(Cliente Cliente)
        {
            Cliente =  contexto.Clientes.FirstOrDefault(c => c.Nome.Equals(Cliente.Nome));
            return Cliente;
        }

        //Exclusap Fisica(Apaga o registro do banco)
        //public void Excluir(Cliente Cliente)
        //{  (Instrução delete)
        //    contexto.Entry(Cliente).State = System.Data.Entity.EntityState.Deleted;
        //    contexto.SaveChanges();
        //}

        //Exclusao logica (campo Ativo/Inativo)
        public void Excluir(Cliente Cliente)
        {
            Cliente.Ativo = false;
            //(Intrução Update)
            contexto.Entry(Cliente).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Alterar(Cliente Cliente)
        {
            contexto.Entry(Cliente).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}
