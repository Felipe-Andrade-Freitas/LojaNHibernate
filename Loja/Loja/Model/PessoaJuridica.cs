using Loja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    public class PessoaJuridica : Usuario
    {
        public virtual string CNPJ { get; set; }
    }
}
