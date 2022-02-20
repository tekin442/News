namespace News_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class news2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        SettingId = c.Int(nullable: false, identity: true),
                        AppGuid = c.String(),
                        UserId = c.Int(nullable: false),
                        AppName = c.String(),
                        LogoUrl = c.String(),
                        AcilisFileUrl = c.String(),
                        WebServiceUrl = c.String(),
                        AdmobBannerCode = c.String(),
                        AdmobSplashCode = c.String(),
                        TemplateId = c.Int(nullable: false),
                        TemplateArea1 = c.String(),
                        TemplateArea2 = c.String(),
                        TemplateArea3 = c.String(),
                        TemplateArea4 = c.String(),
                        TemplateArea5 = c.String(),
                        TemplateArea6 = c.String(),
                        TemplateArea7 = c.String(),
                        TemplateArea8 = c.String(),
                        TemplateArea9 = c.String(),
                        TemplateArea10 = c.String(),
                        TemplateArea11 = c.String(),
                        TemplateArea12 = c.String(),
                        TemplateArea13 = c.String(),
                        TemplateArea14 = c.String(),
                        TemplateArea15 = c.String(),
                    })
                .PrimaryKey(t => t.SettingId);
            
            CreateTable(
                "dbo.Templates",
                c => new
                    {
                        TemplateId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ColorCode = c.String(),
                    })
                .PrimaryKey(t => t.TemplateId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Templates");
            DropTable("dbo.Settings");
        }
    }
}
