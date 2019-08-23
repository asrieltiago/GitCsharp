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
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaLogin:
                        {
                            Usuario user = dB.usuarios.FirstOrDefault(x => x.Login == value.ToString());

                            if (user == null)
                            {
                                return ValidarLogin(value, validationContext.DisplayName);

                            }
                            else
                            {
                                return new ValidationResult("O login informado já existe.");
                            }
                        }

                    case ValidFields.ValidaEmail:
                        return ValidarEmail(value, validationContext.DisplayName);

                    case ValidFields.ValidaSenha:
                        return ValidarSenha(value, validationContext.DisplayName);

                    case ValidFields.ValidaNome:
                        return ValidarNome(value, validationContext.DisplayName);

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

        private ValidationResult ValidarNome(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-zÀ-ú]+ [A-Za-zÀ-ú]+$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");
        }

        private ValidationResult ValidarLogin(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^(?![_ -])(?:(?![_ -]{2})[\w -]){8,16}(?<![_ -])$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido. ");
        }

        private ValidationResult ValidarSenha(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^(?:(?=.*?\p{N})(?=.*?[\p{S}\p{P} ])(?=.*?\p{Lu})(?=.*?\p{Ll}))[^\p{C}]{8,16}$");   

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido." +
                $"O mesmo precisa conter ao menos: \n " +
                $"1 Caractere Especial, 1 Letra Maiúscula, " +
                $"1 Número e entre 8 à 16 caracteres.");
        }
    }
}