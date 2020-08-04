using Microsoft.EntityFrameworkCore;
using OnionSample.Core.Entities;

namespace OnionSample.Infrastructure
{
    class ToDoContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().HasKey(p => p.Id);
        }
    }
}
