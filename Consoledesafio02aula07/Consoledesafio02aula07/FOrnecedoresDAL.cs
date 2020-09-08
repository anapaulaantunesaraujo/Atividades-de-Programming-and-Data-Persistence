using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoledesafio02aula07
{
   public class FOrnecedoresDAL
    {
        context context = new context();

        FOrnecedoresDAL()
        {
            context.Dispose();

        }
        public List<FOrnecedoresDAL> Listar()
        {
            return context.Fornecedores.ToList();
        }


        public FOrnecedoresDAL AdicionarFornecedor(FOrnecedoresDAL novoFornecedor)
        {
            try
            {

                FOrnecedoresDAL novofornecedor = context.Fornecedores.Add(novoFornecedor);
                context.SaveChanges();
                return novofornecedor;
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro ao adicionar o fornecedor na base de dados. Erro: {0}", e);
            }

        }

            }
}

            
       
    

