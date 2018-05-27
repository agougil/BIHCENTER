namespace BIHCENTER
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BIHCENTERDBModel : DbContext
    {
        public BIHCENTERDBModel()
            : base("name=BIHCENTERModel")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Projet> Projets { get; set; }
        public virtual DbSet<Tache> Taches { get; set; }
        public virtual DbSet<Membre> Membres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.mdp)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .HasMany(e => e.Projets)
                .WithOptional(e => e.Admin)
                .HasForeignKey(e => e.idAdmin);

            modelBuilder.Entity<Projet>()
                .Property(e => e.NomProjet)
                .IsUnicode(false);

            modelBuilder.Entity<Projet>()
                .Property(e => e.nomChefProjet)
                .IsUnicode(false);

            modelBuilder.Entity<Tache>()
                .Property(e => e.nomTache)
                .IsUnicode(false);

            modelBuilder.Entity<Tache>()
                .Property(e => e.avancement)
                .IsUnicode(false);

            modelBuilder.Entity<Tache>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Membre>()
                .Property(e => e.nomMembre)
                .IsUnicode(false);
        }
    }
}
