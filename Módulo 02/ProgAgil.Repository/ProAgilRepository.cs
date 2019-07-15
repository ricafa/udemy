using System;
using ProgAgil.Repository;

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

        public Task<Evento[]> GetAllEventosAsyncByTema(string tema, bool includePalestrantes)
        {
            throw new System.NotImplementedException();
        }
        public Task<Evento[]> GetAllEventosAsync(bool  includePalestrantes)
        {
            throw new System.NotImplementedException();
        }
         public Task<Evento> GetAllEventosAsyncById(int EventoId, bool includePalestrantes)
         {
            throw new System.NotImplementedException();
         }
        public Task<Evento[]> GetAllPalestrantesAsyncByName(string nome, bool includePalestrantes)
        {
            throw new System.NotImplementedException();
        }
        public Task<Evento> GetAllPalestranteAsync(int PalestranteId, bool  includePalestrantes)
        {
            throw new System.NotImplementedException();
        }
    }
    
}