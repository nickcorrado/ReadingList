namespace ReadingList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUserIdType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserBook", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.UserBook", new[] { "User_Id" });
            DropColumn("dbo.UserBook", "UserId");
            RenameColumn(table: "dbo.UserBook", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.UserBook", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.UserBook", "UserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.UserBook", "UserId");
            AddForeignKey("dbo.UserBook", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBook", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.UserBook", new[] { "UserId" });
            AlterColumn("dbo.UserBook", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.UserBook", "UserId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.UserBook", name: "UserId", newName: "User_Id");
            AddColumn("dbo.UserBook", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserBook", "User_Id");
            AddForeignKey("dbo.UserBook", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
