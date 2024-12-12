using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Infraestrutura
{
    public class BiomassaRepository : IBiomassaRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Biomassa valores)
        {
            _context.Biomassa.Add(valores);
            _context.SaveChanges();
        }

        public List<Biomassa> Get()
        {
            return _context.Biomassa.ToList();
        }
    }

    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Usuario valores)
        {
            _context.Usuario.Add(valores);
            _context.SaveChanges();
        }
        public List<Usuario> Get() 
        { 
            return _context.Usuario.ToList(); 
        }

        public async Task<Usuario?> GetUsuario(string email, string senha)
        {
            return await _context.Usuario
                .FirstOrDefaultAsync(u => u.Email == email &&  u.Senha == senha);
        }
    }
}
