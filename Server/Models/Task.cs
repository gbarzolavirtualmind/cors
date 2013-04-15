using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Model
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }

    public class ServerContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}