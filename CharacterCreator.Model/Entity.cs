using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Model
{
    public class Entity
    {
        [Key]
        public int ID { get; set; }
    }
}