namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKategoriİsimColumnKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "Kategoriİsim", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategoris", "Kategoriİsim");
        }
    }
}
