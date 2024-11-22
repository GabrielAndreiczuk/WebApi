using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Model
{
    [Table("employee")]
    public class Employee
    {
        public int id { get; private set; }
        public string nome { get; private set; }
        public int idade { get; private set; }

        public Employee(string nome, int idade)
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.idade = idade;
        }
    }
}
