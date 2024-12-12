using System.ComponentModel.DataAnnotations;

namespace WebApi.ViewModel
{
    public class BiomassaViewModel
    {
        public float Biomassa_Valor { get;  set; }
        public float Biomassa_Esperada { get;  set; }
    }

    public class UsuarioViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
