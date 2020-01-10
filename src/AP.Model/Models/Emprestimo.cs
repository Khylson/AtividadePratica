using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AP.Model.Models
{
    [Table("EMPRESTIMO")]
    public class Emprestimo
    {
        [Key]
        public int EmpId { get; set; }


        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Data Emprestimo: "), DataType(DataType.Date)]
        public DateTime DataEmprestimo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Data Devolução: "), DataType(DataType.Date)]
        public DateTime DataDevolucao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Valor da Multa: ")]
        public decimal ValorMulta { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Livro: ")]
        public int LivroId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Aluno: ")]
        public int AlunoId { get; set; }
    }
}
