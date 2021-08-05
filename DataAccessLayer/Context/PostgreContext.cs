using Core.Enums;
using Core.Models.EfModels;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace DataAccessLayer.Context
{
    public class PostgreContext : DbContext
    {
        public PostgreContext(DbContextOptions<PostgreContext> dbContextOptions) : base(dbContextOptions)
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<TodoType>();
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasPostgresEnum<TodoType>();
        }
    }
}
