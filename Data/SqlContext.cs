using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uppgift1Datalagring.Models;

namespace uppgift1Datalagring.Data
{
    internal class SqlContext: DbContext
    {
        public SqlContext()
        {
                
        }

        public SqlContext(DbContextOptions<SqlContext>options) : base(options)
        {

        }
        public virtual DbSet<AdressEntity> Adresses { get; set; } = null!;
        public virtual DbSet<ArendeEntity> Arendes { get; set; } = null!;
        public virtual DbSet<CustomerEntity> Customers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\WIN21\Datalagring\Datalagring-test1\Uppgift1Datalagring\uppgift1Datalagring\uppgift1Datalagring\Data\EFC-Codfirst.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
