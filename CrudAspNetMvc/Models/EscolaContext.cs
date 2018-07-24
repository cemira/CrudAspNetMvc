using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;  // para utilizar o "DbContext" é preciso incliur essa diretiva using "System.Data.Entity".

namespace CrudAspNetMvc.Models
{
    public class EscolaContext : DbContext
    {
        public EscolaContext() : base("Escola")     // Essa é a string de conexão "Escola" para conexão com o banco de dados.
        {
            Database.CreateIfNotExists();           // Cria o banco de dados caso ele não exista.
        }

        public DbSet<Aluno> Alunos { get; set; }    // Essa é a coleção de dados que será persistida no BD.
    }
}