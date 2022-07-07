using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    internal class Entity : DbContext
    {
        public Entity() : base()
        { }

        public DbSet<Student> Students { get; set; }
    }
}
