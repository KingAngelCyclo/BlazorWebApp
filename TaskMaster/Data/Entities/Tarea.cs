using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskMaster.Data.Entities
{
    [Table("Tareas")]
    public class Tarea
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Titulo { get; set; } = null!;
        [StringLength(500)]
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }
        public string? Prioridad { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaLimite { get; set; }
        public DateTime? FechaCompletada { get; set; }


        public static Tarea Create(
            string titulo,
            string? descripcion = null,
            string? estado = null,
            string? prioridad = null,
            DateTime? fechacreacion = null,
            DateTime? fechalimite = null,
            DateTime? fechacompletada = null
            )
            => new()
            {
                Titulo = titulo,
                Descripcion = descripcion,
                Estado = estado,
                Prioridad = prioridad,
                FechaCreacion = fechacreacion,
                FechaLimite = fechalimite,
                FechaCompletada = fechacompletada

            };
        public bool Update(
            string titulo,
            string? descripcion = null,
            string? estado = null,
            string? prioridad = null,
            DateTime? fechacreacion = null,
            DateTime? fechalimite = null,
            DateTime? fechacompletada = null
            )
        {
            var save = false;
            if (Titulo != titulo)
            {
                Titulo = titulo; save = true;
            }
            if (Descripcion != descripcion)
            {
                Descripcion = descripcion; save = true;
            }
            if (Estado != estado)
            {
                Estado = estado; save = true;
            }
            if (Prioridad != prioridad)
            {
                Prioridad = prioridad; save = true;
            }
            if (FechaCreacion != fechacreacion)
            {
                FechaCreacion = fechacreacion; save = true;
            }
            if (FechaLimite != fechalimite)
            {
                FechaLimite = fechalimite; save = true;
            }
            if (FechaCompletada != fechacompletada)
            {
                FechaCompletada = fechacompletada; save = true;
            }
            return save;
        }


    }
}
