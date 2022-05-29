using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconnect_01.Models
{
    [Table("Usuarios")]
    public class Usuario
    {     
        
        [Display(Name = "Nome Completo:")]
        [Required(ErrorMessage = "Obrigatório Informar o nome!")]
        public string Nome { get; set; }

        [Key]
        [Display(Name = "CPF:")]
        [Required(ErrorMessage = "Obrigatório Informar o CPF!")]
        public string Cpf { get; set; }

        [Display(Name = "E-mail::")]
        [Required(ErrorMessage = "Obrigatório Informar o E-mail!")]
        public string Email { get; set; }

        [Display(Name = "Senha:")]
        [Required(ErrorMessage = "Obrigatório Informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Departamento:")]
        [Required(ErrorMessage = "Obrigatório Informar o perfil!")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        [Display(Name = "Profissional de saúde")]
        ProfissionalDeSaude,
        [Display(Name = "Secretaria")]
        Secretaria
    }
}
