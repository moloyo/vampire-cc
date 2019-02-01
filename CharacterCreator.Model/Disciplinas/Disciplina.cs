using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Model.Disciplinas
{
    public class Disciplina : Entity
    {
        [StringLength(30)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Required]
        public int Nivel { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
