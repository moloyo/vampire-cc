namespace CharacterCreator.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clan", "Descripcion", c => c.String());
            AddColumn("dbo.Disciplina", "Descripcion", c => c.String());
            AddColumn("dbo.Habilidad", "Descripcion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Habilidad", "Descripcion");
            DropColumn("dbo.Disciplina", "Descripcion");
            DropColumn("dbo.Clan", "Descripcion");
        }
    }
}
