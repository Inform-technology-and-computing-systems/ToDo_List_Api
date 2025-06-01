using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
            // Database.EnsureCreated(); // Раскомментируйте, если хотите, чтобы БД создавалась автоматически при первом обращении
            // Для учебных целей это нормально. В продакшене лучше использовать миграции.
            // Мы добавим EnsureCreated после настройки подключения в Program.cs
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}