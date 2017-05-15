using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula1505.Model
{
    public class Projeto
    {
        public int ProjetoID { set; get; }

        [Required, StringLength(20)]
        public string Nome { set; get; }

        [Display(Name = "Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { set; get; }

        public bool Ativo { set; get; }
    }
}