using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Model.Habilidades
{
    public class Habilidades
    {
        public static string Academicismo = "Academicismo";
        public static string ArmasDeFuego = "Armas de fuego";
        public static string Artesania = "Artesanía";
        public static string Atletismo = "Atletismo";
        public static string Callejeo = "Callejeo";
        public static string Ciencias = "Ciencias";
        public static string Conducir = "Conducir";
        public static string Consciencia = "Consciencia";
        public static string Etiqueta = "Etiqueta";
        public static string Finanzas = "Finanzas";
        public static string Interpretación = "Interpretación";
        public static string Intimidacion = "Intimidación";
        public static string Investigacion = "Investigación";
        public static string Latrocinio = "Latrocinio";
        public static string Liderazgo = "Liderazgo";
        public static string Medicina = "Medicina";
        public static string Ocultismo = "Ocultismo";
        public static string Pelea = "Pelea";
        public static string PeleaConArmas = "Pelea con Armas";
        public static string Perspicacia = "Perspicacia";
        public static string Persuasion = "Persuasión";
        public static string Politica = "Política";
        public static string Sigilo = "Sigilo";
        public static string Subterfugio = "Subterfugio";
        public static string Supervivencia = "Supervivencia";
        public static string Tecnologia = "Tecnología";
        public static string TratoConAnimales = "Trato con animales";
    }

    public class Habilidad : Entity
    {
        [StringLength(30)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [StringLength(30)]
        public string TipoHabilidad { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
