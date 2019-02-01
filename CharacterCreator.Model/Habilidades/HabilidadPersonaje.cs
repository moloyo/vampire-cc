using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Model.Habilidades
{
    public class HabilidadPersonaje : Entity
    {
        [Required]
        public Habilidad Habilidad { get; set; }

        [Required]
        public Personaje Personaje { get; set; }

        [Required]
        public int Nivel { get; set; }

        [StringLength(30)]
        public string Especialidad { get; set; }
    }
}
