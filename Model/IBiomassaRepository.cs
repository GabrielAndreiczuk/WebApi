namespace WebApi.Model
{
    public interface IBiomassaRepository
    {
        void Add(Biomassa valores);

        List<Biomassa> Get();
    }

    public interface IUsuarioRepository
    {
        void Add(Usuario valores);

        List<Usuario> Get();

        Task<Usuario?> GetUsuario(string email, string senha);
    }
}
