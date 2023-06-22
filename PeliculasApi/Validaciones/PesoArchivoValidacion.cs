using System.ComponentModel.DataAnnotations;

namespace PeliculasApi.Validaciones
{
    public class PesoArchivoValidacion : ValidationAttribute
    {
        private readonly int pesoMaximoEnMegeBytes;

        public PesoArchivoValidacion(int pesoMaximoEnMegeBytes)
        {
            this.pesoMaximoEnMegeBytes = pesoMaximoEnMegeBytes;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            IFormFile formFile = value as IFormFile;
            
            if (formFile == null)
            {
                return ValidationResult.Success;
            }

            if(formFile.Length > pesoMaximoEnMegeBytes * 1024 * 1024)
            {
                return new ValidationResult($"El peso del archivo no debe ser mayor a {pesoMaximoEnMegeBytes}");
            }

            return ValidationResult.Success;
        }
    }
}
