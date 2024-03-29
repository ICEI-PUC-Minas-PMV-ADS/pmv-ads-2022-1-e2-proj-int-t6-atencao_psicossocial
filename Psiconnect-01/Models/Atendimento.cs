﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconnect_01.Models
{
    [Table("Atendimentos")]
    public class Atendimento
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Paciente:")]
        [Required(ErrorMessage = "Obrigatório informar o Paciente!")]
        public string PacienteId { get; set; }

        [ForeignKey("PacienteId")]
        public Paciente Paciente { get; set; }

        [Display(Name = "Tipo:")]
        [Required(ErrorMessage = "Obrigatório informar o Tipo!")]
        public TipoEspecialidade Tipo { get; set; }

        [Display(Name = "N° CID:")]
        [Required(ErrorMessage = "Obrigatório Informar o Cid!")]
        public string CodProfissional { get; set; }

        [Display(Name = "Nome Profissional:")]
        
        public string NomeProfissional { get; set; }

        [Display(Name = "Data:")]
        [Required(ErrorMessage = "Obrigatório informar a Data!")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }


        [Display(Name = "Descrição:")]
        [Required(ErrorMessage = "Obrigatório informar a Descrição!")]

        public string Descricao { get; set; }

        [Display(Name = "Prescrição:")]
        [Required(ErrorMessage = "Obrigatório informar a Prescrição!")]
        public string Prescricao { get; set; }

        [Display(Name = "Sintomas:")]
        [Required(ErrorMessage = "Obrigatório informar a Sintomas!")]
        public string Sintomas { get; set; }

    }
    public enum TipoEspecialidade
    {
        Psiquiatra,
        Neurologista,
        Pediatra,
        Enfermeiro,
        Psicólogo,
        AssistenteSocial,
        TerapeutaOcupacional
    }
}
