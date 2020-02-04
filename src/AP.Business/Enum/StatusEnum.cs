using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AP.Business.Enum
{
    public enum StatusEnum
    {
        [Display(Name = "@Disponível")]
        Disponivel = 1,
        [Display(Name = "@Emprestado")]
        Emprestado = 2
    }
}
