﻿using Microsoft.EntityFrameworkCore;
using Registration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Data
{
    internal class AppEFContext:DbContext
    {
        public AppEFContext()
        {
            this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // string strCon = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=pv113;Trusted_Connection=True;TrustServerCertificate=true";
            // string strCon = "Server=turtles.mssql.somee.com;Database=turtles;User Id=kotel-2222_SQLLogin_1;Password=gvnuokhqa2;TrustServerCertificate=true;";
            string strCon = "Data Source=mydata.sqlite";
            optionsBuilder.UseSqlite(strCon);

            //optionsBuilder.UseSqlServer(strCon);
        }
        public DbSet<UserEntity> Users { get; set; }
    }
}
