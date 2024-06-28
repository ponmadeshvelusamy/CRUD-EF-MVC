using EFAppLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace EFAppLibrary
{
    public class ConstituteEFW:DbContext
    {
        public ConstituteEFW(DbContextOptions option):base(option)
        {

        }
        public DbSet<Constitutemodel> Constitutemodel { get; set; }


    }
}
