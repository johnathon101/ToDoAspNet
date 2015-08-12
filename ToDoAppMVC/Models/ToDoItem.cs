using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ToDoAppMVC.Models
{

	[Table("Items", Schema = "public")]
	public class Item
	{
		[Key]
		[Column("ItemId")]
		public int ItemId { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public DateTime? CreatedOn { get; set; }

		public DateTime? CompletedOn { get; set; }
	}
		
}

