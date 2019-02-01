namespace CharacterCreator.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clan",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Disciplina1_ID = c.Int(),
                        Disciplina2_ID = c.Int(),
                        Disciplina3_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Disciplina", t => t.Disciplina1_ID)
                .ForeignKey("dbo.Disciplina", t => t.Disciplina2_ID)
                .ForeignKey("dbo.Disciplina", t => t.Disciplina3_ID)
                .Index(t => t.Disciplina1_ID)
                .Index(t => t.Disciplina2_ID)
                .Index(t => t.Disciplina3_ID);
            
            CreateTable(
                "dbo.Disciplina",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 30),
                        Nivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DisciplinaPersonaje",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nivel = c.Int(nullable: false),
                        Poder1 = c.String(maxLength: 30),
                        Poder2 = c.String(maxLength: 30),
                        Poder3 = c.String(maxLength: 30),
                        Poder4 = c.String(maxLength: 30),
                        Poder5 = c.String(maxLength: 30),
                        Disciplina_ID = c.Int(nullable: false),
                        Personaje_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Disciplina", t => t.Disciplina_ID, cascadeDelete: true)
                .ForeignKey("dbo.Personaje", t => t.Personaje_ID, cascadeDelete: true)
                .Index(t => t.Disciplina_ID)
                .Index(t => t.Personaje_ID);
            
            CreateTable(
                "dbo.Personaje",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        Concepto = c.String(maxLength: 30),
                        Depredador = c.String(maxLength: 30),
                        Cronica = c.String(maxLength: 30),
                        Ambicion = c.String(maxLength: 30),
                        Sire = c.String(maxLength: 30),
                        Deseo = c.String(maxLength: 30),
                        Generacion = c.Int(nullable: false),
                        Fuerza = c.Int(nullable: false),
                        Destreza = c.Int(nullable: false),
                        Resistencia = c.Int(nullable: false),
                        Carisma = c.Int(nullable: false),
                        Manipulacion = c.Int(nullable: false),
                        Compostura = c.Int(nullable: false),
                        Inteligencia = c.Int(nullable: false),
                        Astucia = c.Int(nullable: false),
                        Resolucion = c.Int(nullable: false),
                        Salud = c.Int(nullable: false),
                        FuerzaVoluntad = c.Int(nullable: false),
                        Resonancia = c.String(maxLength: 30),
                        Ansia = c.Int(nullable: false),
                        Humanidad = c.Int(nullable: false),
                        PotenciaSangre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Habilidad",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 30),
                        TipoHabilidad = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HabilidadPersonaje",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nivel = c.Int(nullable: false),
                        Especialidad = c.String(maxLength: 30),
                        Habilidad_ID = c.Int(nullable: false),
                        Personaje_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Habilidad", t => t.Habilidad_ID, cascadeDelete: true)
                .ForeignKey("dbo.Personaje", t => t.Personaje_ID, cascadeDelete: true)
                .Index(t => t.Habilidad_ID)
                .Index(t => t.Personaje_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HabilidadPersonaje", "Personaje_ID", "dbo.Personaje");
            DropForeignKey("dbo.HabilidadPersonaje", "Habilidad_ID", "dbo.Habilidad");
            DropForeignKey("dbo.DisciplinaPersonaje", "Personaje_ID", "dbo.Personaje");
            DropForeignKey("dbo.DisciplinaPersonaje", "Disciplina_ID", "dbo.Disciplina");
            DropForeignKey("dbo.Clan", "Disciplina3_ID", "dbo.Disciplina");
            DropForeignKey("dbo.Clan", "Disciplina2_ID", "dbo.Disciplina");
            DropForeignKey("dbo.Clan", "Disciplina1_ID", "dbo.Disciplina");
            DropIndex("dbo.HabilidadPersonaje", new[] { "Personaje_ID" });
            DropIndex("dbo.HabilidadPersonaje", new[] { "Habilidad_ID" });
            DropIndex("dbo.DisciplinaPersonaje", new[] { "Personaje_ID" });
            DropIndex("dbo.DisciplinaPersonaje", new[] { "Disciplina_ID" });
            DropIndex("dbo.Clan", new[] { "Disciplina3_ID" });
            DropIndex("dbo.Clan", new[] { "Disciplina2_ID" });
            DropIndex("dbo.Clan", new[] { "Disciplina1_ID" });
            DropTable("dbo.HabilidadPersonaje");
            DropTable("dbo.Habilidad");
            DropTable("dbo.Personaje");
            DropTable("dbo.DisciplinaPersonaje");
            DropTable("dbo.Disciplina");
            DropTable("dbo.Clan");
        }
    }
}
