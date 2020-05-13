using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.CadastroPessoas.Dominio;

namespace TreinaWeb.CadastroPessoas.Persistencia.EF
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CadastroPessoasDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
