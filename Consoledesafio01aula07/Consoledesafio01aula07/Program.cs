using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoledesafio01aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            context con = new context();

            con.Database.Initialize(true);
            con.Database.CreateIfNotExists();

            Usuario user = new Usuario();
            user.NOME = "João";
            user.APELIDO = "Joãozinho";
            user.DATANASCIMENTO = "20/09/1996";
            con.Usuários.Add(user);
            con.SaveChanges();
            con.Dispose();
        

        }
    }
}


