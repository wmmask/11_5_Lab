using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace _11_5_Lab_dB_2_C_2HTML
{
    class SakilaContext :   DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            public DbSet<Actor> Actor { get; set; }
            optionsBuilder.UseSqlServer(@"server=D:\localhost\LAPTOP-S7PHOAS7; Database = sakila; Trusted_Connection = True;");
        }


    }
}
