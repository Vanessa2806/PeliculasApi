﻿using System.ComponentModel.DataAnnotations;

namespace PeliculasApi.DTOs
{
    public class ActorPatchDTO
    {
        [Required]
        [StringLength(120)]
        public string Nombre { get; set; }
        public string FechaNacimiento { get; set; }
    }
}
