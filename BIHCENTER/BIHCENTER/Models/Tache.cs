namespace BIHCENTER
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tache")]
    public partial class Tache
    {
        [Key]
        public int idTache { get; set; }

        [StringLength(100)]
        [DisplayName("Tache")]
        public string nomTache { get; set; }

        [DisplayName("Priorité")]
        public int? priorite { get; set; }

        [DisplayName("Cout")]
        public int? cout { get; set; }

        [StringLength(100)]
        [DisplayName("Avancement")]
        public string avancement { get; set; }

        [StringLength(300)]
        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("id Projet")]
        public int? idProjet { get; set; }

        public virtual Projet Projet { get; set; }
    }
}
