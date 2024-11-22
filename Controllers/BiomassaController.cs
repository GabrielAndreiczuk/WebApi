using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using WebApi.ViewModel;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v2/biomassa")]
    public class BiomassaController : ControllerBase
    {
        private readonly IBiomassaRepository _biomassaRepository;

        public BiomassaController(IBiomassaRepository biomassaRepository)
        {
            _biomassaRepository = biomassaRepository ?? throw new ArgumentNullException(nameof(biomassaRepository));
        }

        [HttpPost]        
        public IActionResult Add(BiomassaViewModel biomassaView)
        {
            var valores = new Biomassa(biomassaView.Biomassa_Valor, biomassaView.Biomassa_Esperada);

            _biomassaRepository.Add(valores);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var valores = _biomassaRepository.Get();
            return Ok(valores);
        }
    }
}
