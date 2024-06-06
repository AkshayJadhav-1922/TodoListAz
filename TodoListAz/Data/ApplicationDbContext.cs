using Microsoft.EntityFrameworkCore;
using TodoListAz.Models;

namespace TodoListAz.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<ToDo> Todos { get; set; }
    }
}
