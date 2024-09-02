using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.Infrastructure.Database.Relations;
using FaculdadeApp_Backend.src.pieces.cadeiras.models;
using FaculdadeApp_Backend.src.pieces.semestres.models;
using Microsoft.EntityFrameworkCore;

namespace FaculdadeApp_Backend.src.Infrastructure.Database;
public class ApplicationContext : DbContext
{
    public DbSet<Semestre> Semestres { get; set; }
    public DbSet<Cadeira> Cadeiras { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.SetUpRelations();
    }

}