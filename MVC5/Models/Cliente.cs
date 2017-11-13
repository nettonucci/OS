using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace MVC5.Model
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int cidadeId { get; set; }
        public virtual Cidade cidade { get; set; }
        public virtual string nomeCidade { get { return cidade.descricao + "-" + cidade.uf; } }
    }
}
