namespace ERP_EntityFramework.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_2 : DbMigration
    {
        public override void Up()
        {
        }

        public override void Down()
        {
            CreateTable(
                "dbo.PasswordResetTokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TokenHash = c.String(nullable: false, maxLength: 128),
                        ExpiresAt = c.DateTime(nullable: false),
                        UsedAt = c.DateTime(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 150));
            CreateIndex("dbo.PasswordResetTokens", "UserId");
            AddForeignKey("dbo.PasswordResetTokens", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
