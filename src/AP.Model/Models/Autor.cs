using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AP.Model.Models
   {
    
    [Table("AUTOR")]
    public class Autor
    {
        [Key]
        public int AutorId { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        [DisplayName("Nome: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Sobrenome: ")]
        public string Sobrenome { get; set; }

        [DisplayName("Idade: ")]
        public int Idade { get; set; }
    }
}
