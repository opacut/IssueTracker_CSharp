// <auto-generated />
namespace DAL.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class rename_customer_to_owner_in_project : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(rename_customer_to_owner_in_project));
        
        string IMigrationMetadata.Id
        {
            get { return "201605161243415_rename_customer_to_owner_in_project"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}