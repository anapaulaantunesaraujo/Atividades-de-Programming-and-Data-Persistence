namespace Consoledesafio01aula07
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usuario")]
    public class Usuario
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }
        public string APELIDO { get; set; }
        public string DATANASCIMENTO { get; set; }
    }
}
