namespace CustMovMVCAppWithAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes(SignupFree,DurationInMonths,DiscountRate) values(0,0,0)");
            Sql("Insert Into MembershipTypes(SignupFree,DurationInMonths,DiscountRate) values(30,1,10)");
            Sql("Insert Into MembershipTypes(SignupFree,DurationInMonths,DiscountRate) values(90,3,15)");
            Sql("Insert Into MembershipTypes(SignupFree,DurationInMonths,DiscountRate) values(300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
