using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppVentaCursosContext : DbContext
    {
        private const string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CursosOnline;Integrated Security=True";
        // Initial Catalog --> Nombre de la BD

        // Crear Instancia hacia el Servidor

        protected override void OnConfiguring(DBContextOptionsBuilder optionsBuilder) {
            
        }
    }
}