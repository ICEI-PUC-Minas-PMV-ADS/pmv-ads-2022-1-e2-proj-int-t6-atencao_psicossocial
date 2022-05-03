using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconnect_01.Models
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CPF!")]
        public int Cpf { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Telefone!")]
        [DataType(DataType.PhoneNumber)]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o E-mail!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Cidade!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CEP!")]
        [DataType(DataType.PostalCode)]
        public int Cep { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Endereço!")]
        public string Endereço { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Bairro!")]
        public string Bairro { get; set; }

        public ICollection<Atendimento> Atendimentos { get; set; }
    }
}
