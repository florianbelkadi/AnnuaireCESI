using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnnuaireModel.Dao; 
public class Site
{
    [Required]
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Column("Ville")]
    public string Ville { get; set; }
}
