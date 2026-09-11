using Microsoft.EntityFrameworkCore;
using Atividade_API.Data;
using Atividade_API.Models;

namespace Atividade_API.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
