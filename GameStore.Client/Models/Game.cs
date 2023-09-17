using System.ComponentModel.DataAnnotations;

namespace GameStore.Client.Models;

public class Game
{
    public int Id { get; set; }
    [Required]
    [StringLength(64)]
    public required string Name { get; set; } = string.Empty;
    [Required]
    [StringLength(32)]
    public required string Genre { get; set; }
    [Required]
    [Range(1, 200)]
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
}