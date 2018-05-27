namespace BIHCENTER
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tache")]
    public partial class Tache
    {
        [Key]
        public int idTache { get; set; }

        [StringLength(100)]
        public string nomTache { get; set; }

        public int? priorite { get; set; }

        public int? cout { get; set; }

        [StringLength(100)]
        public string avancement { get; set; }

        [StringLength(300)]
        public string description { get; set; }

        public int? idProjet { get; set; }

        public virtual Projet Projet { get; set; }
    }
}
