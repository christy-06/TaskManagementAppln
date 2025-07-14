using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskManagementApi.Models;
using TaskManagementAppln;

namespace TaskManagementApi.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
