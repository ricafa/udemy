using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgAgil.Domain;

namespace ProgAgil.Repository
{

  public class ProAgilContext : DbContext
  {
    public ProAgilContext(DbContextOptions<ProAgilContext> options): base(options) { }
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Palestrante> Palestrantes { get; set; }
    public DbSet<PalestranteEvento> PalestrantesEventos { get; set; }
    public DbSet<Lote> Lotes { get; set; }
    public DbSet<RedeSocial> RedeSociais { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
      modelBuilder.Entity<PalestranteEvento>()
        .HasKey(PE => new { PE.EventoId, PE.PalestranteId });
    }

  }
}