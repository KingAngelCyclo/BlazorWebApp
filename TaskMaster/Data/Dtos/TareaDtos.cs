using System.ComponentModel.DataAnnotations;

namespace TaskMaster.Data.Dtos;
public record TareaDto(
    int Id,
    string Titulo = null!,
    string? Descripcion = null,
    string? Estado = null!,
    string? Prioridad = null!,
    DateTime? FechaCreacion = null!,
    DateTime? FechaLimite = null!,
    DateTime? FechaCompletada = null
    ) 
    {
    public TareaRequest ToRequest()
=> new()
{
    Id = this.Id,
    Titulo = this.Titulo,
    Descripcion = this.Descripcion,
    Prioridad = this.Prioridad,
    Estado = this.Estado,
    FechaCompletada = this.FechaCompletada,
    FechaCreacion= this.FechaCreacion,
    FechaLimite= this.FechaLimite,

};
};
public class TareaRequest
{
    public int Id { get; set; } = 0;
    [Required(ErrorMessage = "El título es obligatorio")]
    public string Titulo { get; set; } = "";
    public string? Descripcion { get; set; } = null;
    [Required(ErrorMessage = "La prioridad es obligatoria")]
    public string? Estado { get; set; }
    [Required(ErrorMessage = "El estado es obligatorio")]
    public string? Prioridad { get; set; }
    public DateTime? FechaCreacion { get; set; }
    [Required(ErrorMessage = "La fecha límite es obligatoria")]

    public DateTime? FechaLimite { get; set; }
    public DateTime? FechaCompletada { get; set; }

}

