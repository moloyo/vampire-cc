using CharacterCreator.Model;
using CharacterCreator.Model.Clanes;
using CharacterCreator.Model.Depredador;
using CharacterCreator.Model.Disciplinas;
using CharacterCreator.Model.Habilidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CharacterCreator.DataAccess
{
    public class CharacterCreatorDbContext : DbContext
    {
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<HabilidadPersonaje> HabilidadPersonaje { get; set; }
        public DbSet<DisciplinaPersonaje> DisciplinaPersonaje { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Habilidad> Habilidad { get; set; }

        public DbSet<TipoDepredador> TipoDepredador { get; set; }

        public DbSet<Clan> Clan { get; set; }

        public CharacterCreatorDbContext() : base("CharacterCreatorDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
