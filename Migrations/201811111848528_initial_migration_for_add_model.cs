namespace ACM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_migration_for_add_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepositMemberLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepositStartDate = c.DateTime(nullable: false),
                        MemberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: false)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MobileNo = c.String(),
                        CreateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Deposits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DepositDateTime = c.DateTime(nullable: false),
                        MemberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: false)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.MemberFeeAmounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeeAmount = c.Double(nullable: false),
                        MemberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: false)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.Withdraws",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WithdrowDateTime = c.DateTime(nullable: false),
                        Purpose = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberFeeAmounts", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Deposits", "MemberId", "dbo.Members");
            DropForeignKey("dbo.DepositMemberLists", "MemberId", "dbo.Members");
            DropIndex("dbo.MemberFeeAmounts", new[] { "MemberId" });
            DropIndex("dbo.Deposits", new[] { "MemberId" });
            DropIndex("dbo.DepositMemberLists", new[] { "MemberId" });
            DropTable("dbo.Withdraws");
            DropTable("dbo.MemberFeeAmounts");
            DropTable("dbo.Deposits");
            DropTable("dbo.Members");
            DropTable("dbo.DepositMemberLists");
        }
    }
}
