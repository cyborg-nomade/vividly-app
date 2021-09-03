namespace vividly_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UpdateMembershipTableWithNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE Id=0");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id=1");
            Sql("UPDATE MembershipTypes SET Name = 'Quaterly' WHERE Id=2");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE Id=3");
        }

        public override void Down()
        {
        }
    }
}
