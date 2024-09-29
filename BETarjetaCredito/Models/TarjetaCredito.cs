﻿using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel.DataAnnotations;

namespace BETarjetaCredito.Models
{
    public class TarjetaCredito
    {
        public int Id { get; set; }

        [Required]
        public string  Titular { get; set; }

        [Required]
        public string  NumeroTarjeta { get; set; }

        [Required]
        public string  FechaExpiracion { get; set; }

        [Required]
        public string  cvv { get; set; }
    }
}
