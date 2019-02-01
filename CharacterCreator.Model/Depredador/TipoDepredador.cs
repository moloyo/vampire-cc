using System.ComponentModel.DataAnnotations;

namespace CharacterCreator.Model.Depredador
{
    public class TipoDepredadores
    {
        public static string Bolsero = "Bolsero";
        public static string Cleaver = "Cleaver";
        public static string Consensualista = "Consensualista";
        public static string GatoCallejero = "Gato Callejero";
        public static string Granjero = "Granjero";
        public static string Osiris = "Osiris";
        public static string ReinaDelAmbiente = "Reina del Ambiente";
        public static string Sandman = "Sandman";
        public static string SanguijuelaDeLaSangre = "Sanguijuela de la Sangre";
        public static string Sirena = "Sirena";
    }

    public class TipoDepredador : Entity
    {
        [StringLength(30)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
