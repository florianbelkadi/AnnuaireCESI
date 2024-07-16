using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnnuaireModel.Dao;
public class Salarie
{
    [Required]
    [Key]
    public int Id { get; set; }

    [Column("Nom")]
    public string Nom { get; set; }

    [Column("Prenom")]
    public string Prenom { get; set; }

    [Column("TelFixe")]
    public string TelFixe { get; set; }

    [Column("TelPort")]
    public string TelPort { get; set; }

    [Column("Email")]
    public string Email { get; set; }

    [ForeignKey(nameof(Site))]
    [Column("SiteId")]
    public int SiteId { get; set; }
    public virtual Site? Site { get; set; } = null!;

    [ForeignKey(nameof(Service))]
    [Column("ServiceId")]
    public int ServiceId { get; set; }
    public virtual Service? Service { get; set; } = null!;

}
