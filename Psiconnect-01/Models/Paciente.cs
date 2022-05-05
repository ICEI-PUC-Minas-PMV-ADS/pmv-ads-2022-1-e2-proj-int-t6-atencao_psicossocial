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
        
        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Obrigatório Informar o Nome!")]
        public string Nome { get; set; }

        [Key]
        [Display(Name = "CPF:")]
        [Required(ErrorMessage = "Obrigatório Informar o CPF!")]
        public string Cpf { get; set; }

        [Display(Name = "Telefone:")]
        [Required(ErrorMessage = "Obrigatório Informar o Telefone!")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "Obrigatório Informar o E-mail!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Cidade:")]
        [Required(ErrorMessage = "Obrigatório Informar a Cidade!")]
        public string Cidade { get; set; }

        [Display(Name = "CEP:")]
        [Required(ErrorMessage = "Obrigatório Informar o CEP!")]
        [DataType(DataType.PostalCode)]
        public int Cep { get; set; }

        [Display(Name = "Endereço:")]
        [Required(ErrorMessage = "Obrigatório Informar o Endereço!")]
        public string Endereço { get; set; }

        [Display(Name = "Bairro:")]
        [Required(ErrorMessage = "Obrigatório Informar o Bairro!")]
        public string Bairro { get; set; }

        public ICollection<Atendimento> Atendimentos { get; set; }
    }
}
