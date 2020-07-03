using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Task1.Models;

namespace Task1.DAL
{
    public class TaskContext : DbContext
    {
        public TaskContext() : base("TaskContext")
        {
        }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<File> Files { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Write tables in database in singular form, e.g. Task instead of Tasks
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Configure a One-to-Many Relationship using Fluent API
            modelBuilder.Entity<Task>()
                .HasMany<File>(t => t.Files)
                .WithOptional(f => f.Task);

            // Delete All tasks whenever a story is deleted
            modelBuilder.Entity<Story>()
                 .HasMany<Task>(s => s.Tasks)
                 .WithOptional(t => t.story)
                 .WillCascadeOnDelete();

            // Delete All files whenever a task is deleted
            modelBuilder.Entity<Task>()
                 .HasMany<File>(t => t.Files)
                 .WithOptional(f => f.Task)
                 .WillCascadeOnDelete();
        }
    }
}