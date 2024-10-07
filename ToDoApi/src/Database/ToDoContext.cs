using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using todoApi.src.Database.Domain;

namespace todoApi.src.Database
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions options) : base(options)
        {            
        }

        public DbSet<Todo> Tasks { get; set; }     
    }

}