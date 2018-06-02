namespace MVC_Sample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNameFieldMembershipType : DbMigration
    {
        public override void Up()
        {

            Sql("UPDATE MembershipTypes set Name='Pay as your go' where Id=1");
            Sql("UPDATE MembershipTypes set Name='Monthly' where Id=2");
            Sql("UPDATE MembershipTypes set Name='Quaterly' where Id=3");
            Sql("UPDATE MembershipTypes set Name='Yearly' where Id=4");


        }

        public override void Down()
        {
        }
    }
}
