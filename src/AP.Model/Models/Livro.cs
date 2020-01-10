using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AP.Model.Models
{
    [Table("LIVRO")]
    public class Livro
    {
        [Key]
        public int LivroId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Titulo: ")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("ISBN: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Quantidade: ")]
        public int  Quantidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Status: ")]
        public string Status { get; set; }

        
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Autor: ")]
        public int AutorId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Editora: ")]
        public int EditoraId { get; set; }



    }
}
