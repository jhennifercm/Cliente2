using System.Data.Entity;

namespace MVCcliente.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCcliente.Models.Client> Clients { get; set; }
    }
}