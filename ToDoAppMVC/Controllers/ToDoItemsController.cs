using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoAppMVC.ViewModels;
using ToDoAppMVC.Models;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core;

namespace ToDoAppMVC.Controllers
{
	public class ToDoItemsController :Controller 
    {
        public ActionResult Index()
        {
			return View (new ToDoViewModel());
        }

        public ActionResult _Details(int id)
        {
			Item displayItem;
			using (var db = new db_Entities ()) {
				displayItem = db.Items.FirstOrDefault (i => i.ItemId == id);
			}
			return PartialView (displayItem);
        }

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try {
				using(var db = new db_Entities())
				{
					var myItem = ToDoViewModel.ToItem(collection);
					myItem.CreatedOn = DateTime.Now;
					db.Items.Add(myItem);
					db.SaveChanges();
	                return RedirectToAction ("Index", "Home");
				}
			} catch (Exception ex){
				throw ex;
				return View ();
            }
        }

        public ActionResult Edit(int id)
        {
			using (var db = new db_Entities ()) {
				
				Item item = db.Items.FirstOrDefault (i => i.ItemId == id);
				return View (item);
			}
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
				using (var db = new db_Entities ()) {
					Item updatedItem = ToDoViewModel.ToItem(collection);
					Item myItem = db.Items.FirstOrDefault(i=> i.ItemId == updatedItem.ItemId);
					if(myItem != null){
						myItem.Description = updatedItem.Description;
						myItem.Name = updatedItem.Name;
						myItem.CompletedOn = updatedItem.CompletedOn;
						db.SaveChanges();
					}
					return RedirectToAction ("Index", "Home");
				}
			} catch (Exception ex)
			{
				return RedirectToAction ("Index", "Home");
            }
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}