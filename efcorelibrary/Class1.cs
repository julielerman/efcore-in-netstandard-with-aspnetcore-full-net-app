using Microsoft.EntityFrameworkCore;
using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int Id { get; set; }
        public string MyProperty { get; set; }
    }
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
      :base(options)
    {

        }
        public DbSet<Class1> Class1ses { get; set; }
     
    }
}
