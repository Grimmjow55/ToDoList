using Microsoft.EntityFrameworkCore;
using TpTodoList.Models;

namespace TpTodoList.Data
{

    public class TpTodoListDbContext : DbContext
    {
        public DbSet<TpTodoList.Models.Task> Tasks { get; set; }
        public TpTodoListDbContext(DbContextOptions<TpTodoListDbContext> options)
            : base(options)
        {
        }

    }
}
