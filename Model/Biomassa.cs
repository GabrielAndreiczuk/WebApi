using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Model
{
    [Table("Biomassa")]
    public class Biomassa
    {
        public int ID_Biomassa { get; private set; }
        public float Biomassa_Valor { get; private set; }
        public float Biomassa_Esperada { get; private set; }

        public Biomassa(float biomassa, float BiomassaEsp)
        {
            this.Biomassa_Valor = biomassa;
            this.Biomassa_Esperada = BiomassaEsp;
        }
    }
}
