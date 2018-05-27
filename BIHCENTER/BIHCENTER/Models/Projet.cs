namespace BIHCENTER
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Projet")]
    public partial class Projet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projet()
        {
            Taches = new HashSet<Tache>();
        }

        [Key]
        public int idProjet { get; set; }

        [StringLength(100)]
        public string NomProjet { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateDepart { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateFin { get; set; }

        [StringLength(100)]
        public string nomChefProjet { get; set; }

        public int? idAdmin { get; set; }

        public virtual Admin Admin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tache> Taches { get; set; }
    }
}
