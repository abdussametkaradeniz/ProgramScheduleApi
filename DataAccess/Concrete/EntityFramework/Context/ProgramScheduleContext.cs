using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class ProgramScheduleContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LDKVN8F\SQLEXPRESS;Initial Catalog=ProgramSchedule;Integrated Security=True");
            //trusted connection yap hata alırsan

        }
        public DbSet<CustomerDto> CustomerDtos { get; set; }
    }
}
