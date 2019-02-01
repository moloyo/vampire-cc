namespace CharacterCreator.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoDepredador",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 30),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Personaje", "Clan_ID", c => c.Int());
            AddColumn("dbo.Personaje", "Depredador_ID", c => c.Int());
            CreateIndex("dbo.Personaje", "Clan_ID");
            CreateIndex("dbo.Personaje", "Depredador_ID");
            AddForeignKey("dbo.Personaje", "Clan_ID", "dbo.Clan", "ID");
            AddForeignKey("dbo.Personaje", "Depredador_ID", "dbo.TipoDepredador", "ID");
            DropColumn("dbo.Personaje", "Depredador");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personaje", "Depredador", c => c.String(maxLength: 30));
            DropForeignKey("dbo.Personaje", "Depredador_ID", "dbo.TipoDepredador");
            DropForeignKey("dbo.Personaje", "Clan_ID", "dbo.Clan");
            DropIndex("dbo.Personaje", new[] { "Depredador_ID" });
            DropIndex("dbo.Personaje", new[] { "Clan_ID" });
            DropColumn("dbo.Personaje", "Depredador_ID");
            DropColumn("dbo.Personaje", "Clan_ID");
            DropTable("dbo.TipoDepredador");
        }
    }
}
