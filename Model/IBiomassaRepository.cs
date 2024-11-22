namespace WebApi.Model
{
    public interface IBiomassaRepository
    {
        void Add(Biomassa valores);

        List<Biomassa> Get();
    }
}
