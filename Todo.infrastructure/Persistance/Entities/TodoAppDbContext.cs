using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Todo.infrastructure.Persistance.Entities
{
    public class TodoAppDbContext : DbContext
    {

        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<TodoItemTag> TodoItemTags { get; set; }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }

   

    }
}
