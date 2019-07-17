using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProgAgil.WebAPI.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase {
        private readonly IProAgilRepository _repo;
        public EventoController (IProAgilRepository repo) {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _repo.GetAllEventoAsync(true);
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
        }

        [HttpGet("{EventoId}")]
        public async Task<IActionResult> Get(int EventoId)
        {
            try
            {
                var results = await _repo.GetAllEventoAsyncById(EventoId, true);
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
        }

        [HttpGet("{getByTema/{tema}}")]
        public async Task<IActionResult> Get(string tema)
        {
            try
            {
                var results = await _repo.GetAllEventoAsyncByTema(tema, true);
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
        }

         [HttpPost]
        public async Task<IActionResult> Post(Evento model)
        {
            try
            {
                _repo.Add(model);
                if(await _repo.SaveChangesAsyn())
                {
                    return Created($"/api/evento/{model.id}", model);
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
            return BadRequest;
        }
        
        [HttpPut]
        public async Task<IActionResult> Post(int EventoId, Evento model)
        {
            try
            {
                var evento = await _repo.GetEventoAsynvById(EventoId, false);
                if(evento==null) return NotFound();

                _repo.Update(model);
                
                if(await _repo.SaveChangesAsyn())
                {
                    return Created($"/api/evento/{model.id}", model);
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
            return BadRequest;
        }
        
        [HttpDelete]
        public async Task<IActionResult> Post(int EventoId)
        {
            try
            {
                var evento = await _repo.GetEventoAsynvById(EventoId, false);
                if(evento==null) return NotFound();

                _repo.Delete(model);
                
                if(await _repo.SaveChangesAsyn())
                {
                    return Ok;
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
            return BadRequest;
        }

    }
}