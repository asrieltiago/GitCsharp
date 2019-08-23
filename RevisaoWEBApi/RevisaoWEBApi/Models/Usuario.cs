using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class Usuario : UserControls
    {
        [Key]
        public int Id { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaNome)]
        public string Nome { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaEmail)]        
        public string Email { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaLogin)]
        [MaxLength(16, ErrorMessage = "O campo excedeu o limite de 16 caracteres.")]
        [MinLength(8, ErrorMessage = "O campo não atende a quantidade minima de 8 caracteres.")]
        public string Login { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaSenha)]
        [MaxLength(16, ErrorMessage = "O campo excedeu o limite de 16 caracteres.")]
        [MinLength(8, ErrorMessage = "O campo não atende a quantidade minima de 8 caracteres.")]
        public string Senha { get; set; }

    }
}