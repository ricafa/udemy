using System.Linq;
using System;
using ProgAgil.Repository;
using System.Linq;
using System.Include;

namespace ProgAgil.Repository
{
    public class ProAgilRepository : IProAgilRepository
    {
        public ProAgilContext _context ;

        //GERAIS
        public ProAgilRepository(ProAgilContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T: class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T: class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            return (await _context.Remove(entity)) > 0;
        }
        public async Task<bool> SaveChangesAsync()
        {
            _context.SaveChangesAsync();
        }
        //EVENTOS
        public async <Evento[]> GetAllEventosAsync(bool  includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
                .Include(c => c.Lotes)
                .Include(c => c.RedesSociais);

            if(includePalestrantes)
            {
                query = query.Include(p => p.PalestranteEventos)
                .ThenInclude(p => p.Palestrante);
            }

            query = query.OrderByDescending(c => c.DataEvento);
            return await query.ToArrayAsync();
        }
        public Task<Evento[]> GetAllEventosAsyncByTema(string tema, bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
                .Include(c => c.Lotes)
                .Include(c => c.RedesSociais);

            if(includePalestrantes)
            {
                query = query.Include(p => p.PalestranteEventos)
                .ThenInclude(p => p.Palestrante);
            }
  
            query = query.OrderByDescending(c => c.DataEvento)
                    .Where(c => c.Tema.Contains(tema));
            return await query.ToArrayAsync();
        }
         public async Task<Evento> GetAllEventosAsyncById(int EventoId, bool includePalestrantes = false)
         {
            IQueryable<Evento> query = _context.Eventos
                .Include(c => c.Lotes)
                .Include(c => c.RedesSociais);

            if(includePalestrantes)
            {
                query = query.Include(p => p.PalestranteEventos)
                .ThenInclude(p => p.Palestrante);
            }
  
            query = query.OrderByDescending(c => c.DataEvento)
                    .Where(c => c.Id == EventoId );
            return await query.FirstOrDefaultAsync();
         }
         //PALESTRANTES
        public Task<Evento[]> GetAllPalestrantesAsyncByName(string nome, bool includePalestrantes = false)
        {
            throw new System.NotImplementedException();
        }
        public Task<Evento> GetAllPalestranteAsync(int PalestranteId, bool  includePalestrantes = false)
        {
            throw new System.NotImplementedException();
        }
    }
}