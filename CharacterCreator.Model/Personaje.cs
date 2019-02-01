using CharacterCreator.Model.Clanes;
using CharacterCreator.Model.Depredador;
using CharacterCreator.Model.Disciplinas;
using CharacterCreator.Model.Habilidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterCreator.Model
{
    public class Personaje : Entity
    {
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        [MaxLength(30)]
        public string Concepto { get; set; }

        public TipoDepredador Depredador { get; set; }

        [StringLength(30)]
        public string Cronica { get; set; }

        [StringLength(30)]
        public string Ambicion { get; set; }

        public Clan Clan { get; set; }

        [StringLength(30)]
        public string Sire { get; set; }

        [StringLength(30)]
        public string Deseo { get; set; }

        public int Generacion { get; set; }

        #region Atributos

        public int Fuerza { get; set; }

        public int Destreza { get; set; }

        public int Resistencia { get; set; }

        public int Carisma { get; set; }

        public int Manipulacion { get; set; }

        public int Compostura { get; set; }

        public int Inteligencia { get; set; }

        public int Astucia { get; set; }

        public int Resolucion { get; set; }

        #endregion Atributos

        public int Salud { get; set; }

        public int SaludMaxima => this.Resistencia + 3;

        public int FuerzaVoluntad { get; set; }

        public int FuerzaVoluntadMaxima => this.Resolucion + this.Compostura;

        #region Habilidades

        public IEnumerable<HabilidadPersonaje> HabilidadesPersonaje { get; set; }

        #endregion Habilidades

        #region Disciplinas

        public IEnumerable<DisciplinaPersonaje> DisciplinasPersonaje { get; set; }

        #endregion Disciplinas

        [StringLength(30)]
        public string Resonancia { get; set; }

        public int Ansia { get; set; }

        public int Humanidad { get; set; }

        public int PotenciaSangre { get; set; }

        public Personaje()
        {
            this.DisciplinasPersonaje = new List<DisciplinaPersonaje>();
            this.HabilidadesPersonaje = new List<HabilidadPersonaje>();
            this.Ansia = 0;
            this.Humanidad = 7;
            this.Generacion = 13;
            this.PotenciaSangre = 0;
        }
    }
}
