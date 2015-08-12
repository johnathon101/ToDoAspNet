using System;
using ToDoAppMVC;
using ToDoAppMVC.Models;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Globalization;

namespace ToDoAppMVC.ViewModels
{
	public class ToDoViewModel
	{
		public IEnumerable<Item> Items {get; set;}
		
		public ToDoViewModel()
		{

			using (var context = new db_Entities())
			{
				Items = context.Items.ToList();

			}
		}

		public static Item ToItem(FormCollection formCollection)
		{
			DateTime completedOn;
			var haveDate = DateTime.TryParse(formCollection["CompletedOn"], out completedOn);
			int itemId = 0;
			int.TryParse(formCollection["ItemId"], out itemId);
			var item = new Item {
				ItemId = itemId,
				Name = formCollection["Name"],
				Description = formCollection["Description"],
				CompletedOn = haveDate ? completedOn : default(DateTime),

			};
			return item;
		}

	}
}

