using Loja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    public class PessoaFisica : Usuario
    {
        public virtual string CPF { get; set; }
    }
}
