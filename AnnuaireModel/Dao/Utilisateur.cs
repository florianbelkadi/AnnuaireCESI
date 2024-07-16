using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnnuaireModel.Dao;
public class Utilisateur
{
    [Required]
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Column("Identifiant")]
    public string Identifiant { get; set; }

    [Column("Mdp")]
    public string Mdp { get; set; }
}
