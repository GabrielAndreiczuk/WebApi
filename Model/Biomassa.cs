using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Model
{
    [Table("Biomassa")]
    public class Biomassa
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Biomassa { get; private set; }
        public float Biomassa_Valor { get; private set; }
        public float Biomassa_Esperada { get; private set; }

        public Biomassa(float Biomassa_Valor, float Biomassa_Esperada)
        {
            this.Biomassa_Valor = Biomassa_Valor;
            this.Biomassa_Esperada = Biomassa_Esperada;
        }
    }
}
