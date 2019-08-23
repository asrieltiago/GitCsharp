using RevisaoWEBApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB dB = new ContextDB();

        private ValidFields typeField;

        public CustomValidFields(ValidFields type)
        {
            typeField = type;
        }

        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //Se o valor não for nulo
            if(value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaLogin:
                        
                        break;
                    case ValidFields.ValidaEmail:
                        return ValidarEmail(value, validationContext.DisplayName);   

                    case ValidFields.ValidaSenha:
                        break;
                    case ValidFields.ValidaNome:
                        break;
                    default:
                        break;
                }
            }

            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");
        }

        /// <summary>
        /// Método utilizado para validar um email, utilizando-se de um pattern.
        /// </summary>
        /// <param name="value">Campo que verifica se o Email informado é válido</param>
        /// <param name="displayField">Field que está sendo preenchido</param>
        /// <returns></returns>
        private ValidationResult ValidarEmail(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");
        }
    }
}