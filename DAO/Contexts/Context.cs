using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO.Contexts {
    public class Context : DbContext {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-C14ILB8\SQLEXPRESS01;Initial Catalog=Jeymer;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<RequestModel1> RequestModel { get; set; }       
    }
}
