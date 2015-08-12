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

			var item = new Item {
				Name = formCollection["Name"],
				Description = formCollection["Description"],
				//CreatedOn = DateTime.ParseExact(formCollection["CreatedOn"], "MM/dd/yyyy", CultureInfo.CurrentCulture),
				//CompletedOn = DateTime.ParseExact(formCollection["CompletedOn"], "MM/dd/yyyy", CultureInfo.CurrentCulture),

			};
			return item;
		}

	}
}

