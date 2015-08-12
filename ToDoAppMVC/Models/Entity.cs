using System;
using System.Data.Entity;

namespace ToDoAppMVC.Models
{
	public partial class db_Entities : DbContext
	{
		public db_Entities() : base(nameOrConnectionString: "ToDoApp") { }

		public DbSet<Item> Items { get; set; }
	}
//
//	protected override void OnModelCreating(DbModelBuilder modelBuilder)
//	{
//		modelBuilder.Entity().ToTable("Items", "public");
//	}
}

