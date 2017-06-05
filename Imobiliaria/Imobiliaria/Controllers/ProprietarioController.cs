using Imobiliaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Imobiliaria.Controllers
{
    public class ProprietarioController
    {
        protected BancoImobiliariaContainer1 contexto = new BancoImobiliariaContainer1();

        public void Adicionar(Proprietario Proprietario)
        {
            if (Proprietario != null)
            {
                contexto.Proprietarios.Add(Proprietario);
                contexto.SaveChanges();
            }
        }

        public List<Proprietario> Listar()
        {
            return contexto.Proprietarios.Where(c => c.Ativo == true).ToList();
        }

        public List<Proprietario> ListarInativos()
        {
            return contexto.Proprietarios.Where(c => c.Ativo == false).ToList();
        }


        public Proprietario BuscarProprietarioPorID(int id)
        {
            return contexto.Proprietarios.Find(id); // Find pode encontrar a chave
        }

        public Proprietario BuscarProprietarioPorNome(string proprietario)
        {
            return contexto.Proprietarios.Find(proprietario); // Find pode encontrar a chave
        }

        //Exclusap Fisica(Apaga o registro do banco)
        //public void Excluir(Proprietario Proprietario)
        //{  (Instrução delete)
        //    contexto.Entry(Proprietario).State = System.Data.Entity.EntityState.Deleted;
        //    contexto.SaveChanges();
        //}

        //Exclusao logica (campo Ativo/Inativo)
        public void Excluir(Proprietario Proprietario)
        {
            Proprietario.Ativo = false;
            //(Intrução Update)
            contexto.Entry(Proprietario).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Alterar(Proprietario Proprietario)
        {
            contexto.Entry(Proprietario).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}
