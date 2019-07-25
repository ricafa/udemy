using ProgAgil.Domain;
using System.Threading.Tasks;

namespace ProgAgil.Repository
{
    public interface IProAgilRepository
    {
        //GERAL
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveChangesAsync();

         //EVENTOS
         Task<Evento[]> GetAllEventosAsyncByTema(string tema, bool includePalestrantes);
         Task<Evento[]> GetAllEventosAsync(bool  includePalestrantes);
         Task<Evento> GetAllEventosAsyncById(int EventoId, bool includePalestrantes);

         //PALESTRANTES
         Task<Palestrante[]> GetAllPalestrantesAsyncByName(string nome, bool includeEventos);
         Task<Palestrante> GetAllPalestranteAsync(int PalestranteId, bool  includeEventos);
    }
}