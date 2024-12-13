using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using WebApi.Infraestrutura;
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

    [ApiController]
    [Route("api/v2/Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(_usuarioRepository));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var valores = _usuarioRepository.Get();
            return Ok(valores);
        }

        [HttpPost("Cadastro")]
        public IActionResult Add(UsuarioViewModel usuarioView)
        {
            var valores = new Usuario(usuarioView.Nome, usuarioView.Email, usuarioView.Senha);

            _usuarioRepository.Add(valores);

            return Ok();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var usuario = await _usuarioRepository.GetUsuario(request.Email, request.Password);

            if (usuario == null)
            {
                return Unauthorized("Email ou senha inválidos!");
            }

            return Ok("Login realizado com sucesso!");
        }
    }
}
