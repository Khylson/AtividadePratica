using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AP.Model.Models
{
    [Table("ALUNO")]
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Nome: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Sobrenome: ")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Sexo: ")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("RA: ")]
        public string RA { get; set; }

        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Digite um CPF válido")]
        [Required]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("E-mail: "), DataType(DataType.EmailAddress, ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Telefone: "), DataType(DataType.PhoneNumber, ErrorMessage = "Digite um e-mail válido")]
        public string Telefone { get; set; }
    }
}
