using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoledesafio02aula07
{
       public class Fornecedor
    { 
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string Endereço { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime UltimaAlteracao { get; set; }
        public DateTime Exclusão { get; set; }
    }
}
