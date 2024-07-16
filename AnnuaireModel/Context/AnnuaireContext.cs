using AnnuaireModel.Dao;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AnnuaireModel.Context;
public class AnnuaireContext(DbContextOptions<AnnuaireContext> options) 
    : IdentityDbContext<User>(options)
{
    public DbSet<Salarie> Salaries { get; set; }
    public DbSet<Site> Sites { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Utilisateur> Utilisateurs { get; set; }
}


public class AnnuaireContextFactory : IDesignTimeDbContextFactory<AnnuaireContext>
{
    public AnnuaireContext CreateDbContext(string[] args)
    {
        var connexionString = "server=localhost;port=3306;userid=root;password=;database=AnnuaireCESI;";
        var optionsBuilder = new DbContextOptionsBuilder<AnnuaireContext>();
        optionsBuilder.UseMySql(connexionString, ServerVersion.AutoDetect(connexionString));

        return new AnnuaireContext(optionsBuilder.Options);
    }
}