namespace EDAPacman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class public_layout_and_player : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mazes", "Layout", c => c.String());
            AddColumn("dbo.Mazes", "Player_Row", c => c.Int(nullable: false));
            AddColumn("dbo.Mazes", "Player_Col", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mazes", "Player_Col");
            DropColumn("dbo.Mazes", "Player_Row");
            DropColumn("dbo.Mazes", "Layout");
        }
    }
}
