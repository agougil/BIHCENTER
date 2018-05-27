namespace BIHCENTER
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Membre")]
    public partial class Membre
    {
        [Key]
        public int idMembre { get; set; }

        [StringLength(100)]
        public string nomMembre { get; set; }
    }
}
