using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace _11_5_Lab_dB_2_C_2HTML
{
    class SakilaContext :   DbContext
    {
        public DbSet<SakilaFilmTable> SakilaFilmTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(LAPTOP-S7PH0AS7\Wms Web App)\\MSSQLlocaldb; Database = sakila; Trusted_Connection = True;");
            //LAPTOP-S7PHOAS7           //LAPTOP-S7PH0AS7\Wms Web App  //=C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQLLocalDb
        }


    }
}
