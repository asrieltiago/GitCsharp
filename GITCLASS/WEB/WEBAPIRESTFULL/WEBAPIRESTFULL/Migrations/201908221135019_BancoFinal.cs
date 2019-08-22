namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BancoFinal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Livros", "Observacoes", c => c.String(maxLength: 1000, unicode: false));
            AlterColumn("dbo.Locacao", "Ativo", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Locacao", "DatInc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Locacao", "DatAlt", c => c.DateTime(nullable: false));
            DropColumn("dbo.Livros", "Observacao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Livros", "Observacao", c => c.String(maxLength: 1000, unicode: false));
            AlterColumn("dbo.Locacao", "DatAlt", c => c.DateTime());
            AlterColumn("dbo.Locacao", "DatInc", c => c.DateTime());
            AlterColumn("dbo.Locacao", "Ativo", c => c.Boolean());
            DropColumn("dbo.Livros", "Observacoes");
        }
    }
}
