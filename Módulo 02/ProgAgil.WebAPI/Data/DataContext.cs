using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgAgil.WebAPI.Model;

namespace ProgAgil.WebAPI.Data
{

  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options): base(options) { }
    public DbSet<Evento> Eventos { get; set; }

  }
}