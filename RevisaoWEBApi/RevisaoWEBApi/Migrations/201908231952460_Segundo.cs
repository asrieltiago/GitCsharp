namespace RevisaoWEBApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segundo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Login", c => c.String(maxLength: 16));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Login", c => c.String());
        }
    }
}
