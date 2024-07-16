using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnnuaireModel.Dao; 
public class Service
{
    [Required]
    [Key]
    public int Id { get; set; }

    [Column("Nom")]
    public string Nom { get; set; }
}
