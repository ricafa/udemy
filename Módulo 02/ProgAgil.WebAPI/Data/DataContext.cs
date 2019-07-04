using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ProgAgil.WebAPI.Data
{

  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options)
      : base(options)
    {

    }

  }
}