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
}
