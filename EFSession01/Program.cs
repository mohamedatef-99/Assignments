using EFSession01.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EFSession01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Comparison ADO,EF Core and Dapper
            // ADO Writes more code and EF Core write less code
            // EF Core built on top of ADO
            // which means ADO is faster than EF Core
            // Dapper is simple close more to ADO than EF Core 
            #endregion

            AppDbContext context = new AppDbContext();
            //context.Database.Migrate();
        }
    }
}
