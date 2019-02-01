namespace CharacterCreator.DataAccess.Migrations
{
    using CharacterCreator.Model;
    using CharacterCreator.Model.Clanes;
    using CharacterCreator.Model.Depredador;
    using CharacterCreator.Model.Disciplinas;
    using CharacterCreator.Model.Habilidades;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CharacterCreator.DataAccess.CharacterCreatorDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CharacterCreator.DataAccess.CharacterCreatorDbContext context)
        {
            SeedHabilidades(context);
            SeedDisciplinas(context);
            context.SaveChanges();

            SeedClanes(context);
            SeedTipoDepredador(context);
            context.SaveChanges();

            SeedPersonajes(context);
        }

        private static void SeedTipoDepredador(CharacterCreatorDbContext context)
        {
            context.TipoDepredador.AddOrUpdate(t => t.Nombre,
                new TipoDepredador()
                {
                    Nombre = TipoDepredadores.Bolsero,
                    Descripcion = "Adquieres sangre conservada o muerta, en vez de Cazar a los vivos."
                },
                new TipoDepredador()
                {
                    Nombre = TipoDepredadores.Cleaver,
                    Descripcion = "Tomas sangre de forma encubierta de tu familia mortal o amigos."
                },
                new TipoDepredador()
                {
                    Nombre = TipoDepredadores.Consensualista,
                    Descripcion = "Tomas sangre con consentimiento."
                },
                new TipoDepredador()
                {
                    Nombre = TipoDepredadores.GatoCallejero,
                    Descripcion = "Tomas sangre por la fuerza o con amenazas."
                },
                new TipoDepredador()
                {
                    Nombre = TipoDepredadores.Granjero,
                    Descripcion = "Te alimentas de animales."
                },
                new TipoDepredador()
                {
                    Nombre = TipoDepredadores.Osiris,
                    Descripcion = "Como objeto de devoción, te alimentas de tu culto, iglesia o fans."
                },
                new TipoDepredador()
                {
                    Nombre = TipoDepredadores.ReinaDelAmbiente,
                    Descripcion = "Te alimentas de una subcultura o grupo exclusivo entre el que disfrutas de un alto estatus."
                },
                new TipoDepredador()
                {
                    Nombre = TipoDepredadores.Sandman,
                    Descripcion = "Te alimentas de víctimas dormidas, a menudo entrando a la fuerza en sus casas."
                },
                new TipoDepredador()
                {
                    Nombre = TipoDepredadores.SanguijuelaDeLaSangre,
                    Descripcion = "Te alimentas de otros vampiros."
                },
                new TipoDepredador()
                {
                    Nombre = TipoDepredadores.Sirena,
                    Descripcion = "Te alimentas mediante la seducción, bajo la apariencia de sexo."
                });
            
        }

        private static void SeedPersonajes(CharacterCreatorDbContext context)
        {
            context.Personajes.AddOrUpdate(p => p.Nombre,
                new Personaje() {
                    Nombre = "Drácula",
                    Ambicion = "Dominar el mundo",
                    Fuerza = 5,
                    Destreza = 4,
                    Resistencia = 5,
                    Carisma = 4,
                    Manipulacion = 5,
                    Compostura = 3,
                    Inteligencia = 5,
                    Astucia = 5,
                    Resolucion = 5,
                    Depredador = context.TipoDepredador.First(d => d.Nombre == TipoDepredadores.Sandman),
                    Clan = context.Clan.First(c => c.Nombre == Clanes.Ventrue),
                    Generacion = 4
                },
                new Personaje() { Nombre = "Jorge" },
                new Personaje() { Nombre = "Colmillón" },
                new Personaje() { Nombre = "Doña" }
                );
        }

        private static void SeedHabilidades(CharacterCreatorDbContext context)
        {
            context.Habilidad.AddOrUpdate(p => p.Nombre,
                new Habilidad()
                {
                    Nombre = Habilidades.Academicismo,
                    TipoHabilidad = "Mental",
                    Descripcion = "Humanidades y artes liberales, educación formal"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.ArmasDeFuego,
                    TipoHabilidad = "Física",
                    Descripcion = "Usar armas a distancia, como pistolas y arcos"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Artesania,
                    TipoHabilidad = "Física",
                    Descripcion = "Confeccionar, construir, moldear"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Atletismo,
                    TipoHabilidad = "Física",
                    Descripcion = "Correr, saltar, escalar"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Callejeo,
                    TipoHabilidad = "Social",
                    Descripcion = "Comprender las idas y venidas de la sociedad criminal y urbana"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Ciencias,
                    TipoHabilidad = "Mental",
                    Descripcion = "Conocimientos y teorías sobre el mundo físico"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Conducir,
                    TipoHabilidad = "Física",
                    Descripcion = "Manejar vehículos"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Consciencia,
                    TipoHabilidad = "Mental",
                    Descripcion = "Sentidos, ser consciente de tu entorno, advertir peligros"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Etiqueta,
                    TipoHabilidad = "Social",
                    Descripcion = "Educación en entornos sociales"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Finanzas,
                    TipoHabilidad = "Mental",
                    Descripcion = "Gestionar, transferir y generar dinero"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Interpretación,
                    TipoHabilidad = "Social",
                    Descripcion = "Realizar una expresión artística personalmente frente a una audiencia"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Intimidacion,
                    TipoHabilidad = "Social",
                    Descripcion = "Hacer que otra persona se eche atrás"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Investigacion,
                    TipoHabilidad = "Mental",
                    Descripcion = "Seguir pistas, resolver misterios"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Latrocinio,
                    TipoHabilidad = "Física",
                    Descripcion = "Forzar y allanar viviendas, protegerse contra ello"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Liderazgo,
                    TipoHabilidad = "Social",
                    Descripcion = "Dirigir e inspirar a los demás"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Medicina,
                    TipoHabilidad = "Mental",
                    Descripcion = "Curar heridas, diagnosticar enfermedades"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Ocultismo,
                    TipoHabilidad = "Mental",
                    Descripcion = "Conocimientos secretos, tanto reales como fantásticos"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Pelea,
                    TipoHabilidad = "Física",
                    Descripcion = "Cualquier tipo de combate sin armas"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.PeleaConArmas,
                    TipoHabilidad = "Física",
                    Descripcion = "Combate cuerpo a cuerpo con armas"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Perspicacia,
                    TipoHabilidad = "Social",
                    Descripcion = "Determinar estados mentales y motivaciones"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Persuasion,
                    TipoHabilidad = "Social",
                    Descripcion = "Convencer a los demás"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Politica,
                    TipoHabilidad = "Mental",
                    Descripcion = "Gestionar, transferir y crear gobiernos"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Sigilo,
                    TipoHabilidad = "Física",
                    Descripcion = "No ser visto, oído ni reconocido"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Subterfugio,
                    TipoHabilidad = "Social",
                    Descripcion = "Engañar a otros para que hagan tu voluntad"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Supervivencia,
                    TipoHabilidad = "Física",
                    Descripcion = "Permanecer vivo en un entorno hostil"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.Tecnologia,
                    TipoHabilidad = "Mental",
                    Descripcion = "Comprender y usar la tecnología moderna, las computadoras y la actividad en línea"
                },
                new Habilidad()
                {
                    Nombre = Habilidades.TratoConAnimales,
                    TipoHabilidad = "Social",
                    Descripcion = "Manejo de animales y comunicación con ellos"
                });
        }

        private static void SeedDisciplinas(CharacterCreatorDbContext context)
        {
            context.Disciplina.AddOrUpdate(p => p.Nombre,
                new Disciplina()
                {
                    Nombre = "Animalismo",
                    Descripcion = "Afinidad sobrenatural con los animales y control de los mismos."
                },
                new Disciplina()
                {
                    Nombre = "Auspex",
                    Descripcion = "Percepción extrasensorial, consciencia y premoniciones."
                },
                new Disciplina()
                {
                    Nombre = "Celeridad",
                    Descripcion = "Velocidad y reflejos sobrenaturales."
                },
                new Disciplina()
                {
                    Nombre = "Dominación",
                    Descripcion = "Control mental llevado a cabo mediante una mirada penetrante."
                },
                new Disciplina()
                {
                    Nombre = "Fortaleza",
                    Descripcion = "Robustez sobrenatural, hasta el punto de resistir el fuego y la luz del sol."
                },
                new Disciplina()
                {
                    Nombre = "Hechicería de Sangre",
                    Descripcion = "El uso de la Sangre para realizar magia."
                },
                new Disciplina()
                {
                    Nombre = "Ofuscación",
                    Descripcion = "La habilidad de permanecer oculto y sin ser visto, incluso entre multitudes."
                },
                new Disciplina()
                {
                    Nombre = "Potencia",
                    Descripcion = "La Disciplina del vigor y la fuerza física."
                },
                new Disciplina()
                {
                    Nombre = "Presencia",
                    Descripcion = "La habilidad de atraer, influir y controlar emociones."
                },
                new Disciplina()
                {
                    Nombre = "Protean",
                    Descripcion = "Cambios de forma, desde desarrollar garras a fundirse con la tierra."
                });
        }

        private static void SeedClanes(CharacterCreatorDbContext context)
        {
            context.Clan.AddOrUpdate(p => p.Nombre,
                new Clan()
                {
                    Nombre = Clanes.Brujah,
                    Descripcion = "La Chusma se rebela contra el poder y carga contra la tiranía",
                    Disciplina1 = context.Disciplina.First(d => d.Nombre == "Celeridad"),
                    Disciplina2 = context.Disciplina.First(d => d.Nombre == "Potencia"),
                    Disciplina3 = context.Disciplina.First(d => d.Nombre == "Presencia")
                },
                new Clan()
                {
                    Nombre = Clanes.Grangrel,
                    Descripcion = "Los salvajes Forasteros funden vampiro y bestia",
                    Disciplina1 = context.Disciplina.First(d => d.Nombre == "Animalismo"),
                    Disciplina2 = context.Disciplina.First(d => d.Nombre == "Fortaleza"),
                    Disciplina3 = context.Disciplina.First(d => d.Nombre == "Protean")
                },
                new Clan()
                {
                    Nombre = Clanes.Malkavian,
                    Descripcion = "La locura de los Lunáticos esconde y revela verdades",
                    Disciplina1 = context.Disciplina.First(d => d.Nombre == "Auspex"),
                    Disciplina2 = context.Disciplina.First(d => d.Nombre == "Dominación"),
                    Disciplina3 = context.Disciplina.First(d => d.Nombre == "Ofuscación")
                },
                new Clan()
                {
                    Nombre = Clanes.Nosferatu,
                    Descripcion = "Las desagradables Ratas de Alcantarilla esconden sus formas desfiguradas en la oscuridad, desde la que acumulan secretos",
                    Disciplina1 = context.Disciplina.First(d => d.Nombre == "Animalismo"),
                    Disciplina2 = context.Disciplina.First(d => d.Nombre == "Ofuscación"),
                    Disciplina3 = context.Disciplina.First(d => d.Nombre == "Potencia")
                },
                new Clan()
                {
                    Nombre = Clanes.Toreador,
                    Descripcion = "Los Degenerados buscan la emoción del arte, el romance y la crueldad en medio de una no-muerte agostada",
                    Disciplina1 = context.Disciplina.First(d => d.Nombre == "Auspex"),
                    Disciplina2 = context.Disciplina.First(d => d.Nombre == "Celeridad"),
                    Disciplina3 = context.Disciplina.First(d => d.Nombre == "Presencia")
                },
                new Clan()
                {
                    Nombre = Clanes.Tremere,
                    Descripcion = "Quebrados por una nueva Inquisición, los antaño poderosos Hechiceros intentan restaurar su monopolio sobre los poderes de la magia",
                    Disciplina1 = context.Disciplina.First(d => d.Nombre == "Auspex"),
                    Disciplina2 = context.Disciplina.First(d => d.Nombre == "Dominación"),
                    Disciplina3 = context.Disciplina.First(d => d.Nombre == "Hechicería de Sangre")
                },
                new Clan()
                {
                    Nombre = Clanes.Ventrue,
                    Descripcion = "Los aristócratas Sangre Azul hacen cumplir las Tradiciones y la Mascarada a las razas inferiores",
                    Disciplina1 = context.Disciplina.First(d => d.Nombre == "Dominación"),
                    Disciplina2 = context.Disciplina.First(d => d.Nombre == "Fortaleza"),
                    Disciplina3 = context.Disciplina.First(d => d.Nombre == "Presencia")
                },
                new Clan()
                {
                    Nombre = Clanes.Caitiff,
                    Descripcion = "Los sin Clan no presentan ningún rasgo común, salvo verse excluidos por los vampiros que pertenecen a un linaje establecido",
                });
        }
    }
}
