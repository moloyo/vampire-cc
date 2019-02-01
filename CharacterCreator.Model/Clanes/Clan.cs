using CharacterCreator.Model.Disciplinas;

namespace CharacterCreator.Model.Clanes
{
    public class Clanes
    {
        public static string Brujah = "Brujah";
        public static string Grangrel = "Grangrel";
        public static string Malkavian = "Malkavian";
        public static string Nosferatu = "Nosferatu";
        public static string Toreador = "Toreador";
        public static string Tremere = "Tremere";
        public static string Ventrue = "Ventrue";
        public static string Caitiff = "Caitiff";
    }
    public class Clan : Entity
    {
        public string Nombre { get; set;  }

        public string Descripcion { get; set; }

        public Disciplina Disciplina1 { get; set; }

        public Disciplina Disciplina2 { get; set; }

        public Disciplina Disciplina3 { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
