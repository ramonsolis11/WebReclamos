using System;
using System.ComponentModel.DataAnnotations;

namespace WebReclamos.Models
{
    public class Reclamo
    {
        [Required]
        public string Categoria { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreOrganizacion { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreContacto { get; set; }

        [Required]
        [Phone]
        public string TelefonoContacto { get; set; }

        [Required]
        [EmailAddress]
        public string CorreoElectronico { get; set; }

        // Considerar si el número de documento es numérico o alfanumérico y si necesita validación
        public string NumeroDocumento { get; set; }

        public string TipoDocumento { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public string Prioridad { get; set; }

        // Considerar usar un enum para estado si hay un número fijo de estados posibles
        public string Estado { get; set; }

        public string AsignadoA { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaCreacion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaUltimaActualizacion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaCierre { get; set; }

        public string Comentarios { get; set; }

        // Agregar todos los campos necesarios...
    }
}