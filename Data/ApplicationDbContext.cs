using CRUDusingEFJisaHW.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CRUDusingEFJisaHW.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {

        }
        public DbSet<Student> Students { get; set; }

        


    }
}
