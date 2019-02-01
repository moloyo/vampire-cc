using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Model.Disciplinas
{
    public class DisciplinaPersonaje : Entity
    {
        [Required]
        public Disciplina Disciplina { get; set; }

        [Required]
        public Personaje Personaje { get; set; }

        [Required]
        public int Nivel { get; set; }

        [StringLength(30)]
        public string Poder1 { get; set; }

        [StringLength(30)]
        public string Poder2 { get; set; }

        [StringLength(30)]
        public string Poder3 { get; set; }

        [StringLength(30)]
        public string Poder4 { get; set; }

        [StringLength(30)]
        public string Poder5 { get; set; }
    }
}
