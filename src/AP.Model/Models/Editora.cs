using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AP.Model.Models
{
    [Table("EDITORA")]
    public class Editora
    {
        [Key]
        public int EditoraId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Nome: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("CEP: "), DataType(DataType.PostalCode, ErrorMessage = "Digite um CEP válido")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Estado: ")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("País: ")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Endereco: ")]
        public string Endereco { get; set; }
    }
}
