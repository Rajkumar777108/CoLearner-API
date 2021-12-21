using CoLearner.API.Model;
using Microsoft.EntityFrameworkCore;

namespace CoLearner.API.Data
{
    public class DBEntity : DbContext
    {
        public DBEntity (DbContextOptions<DBEntity> options): base(options){}
        public DbSet<Menu> Menus { get; set; }
        public DbSet<User> Users {get;set;}
        public DbSet<TechFramework> Teches { get; set; }
        
    }
}