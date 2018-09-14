using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Todolist.Data;
using Todolist.Models;


namespace Todolist.Controllers
{
	public class CategoriesController : ApiController
	{
		private TodoDbContext db = new TodoDbContext();

		public IQueryable<Categorie> GetCategories()
		{
			return db.Categories;

		}

		public IHttpActionResult GetCategorie(int id)
		{
			var categorie = db.Categories.Find(id);
			if (categorie == null)
				return NotFound();
			return Ok(categorie);
		}

		public IHttpActionResult PostCategories(Categorie categorie)
		{
			if (ModelState.IsValid)
			{
				db.Categories.Add(categorie);
				db.SaveChanges();
				return Ok(categorie);

			}
			else
				return BadRequest(ModelState);
		}
		public IHttpActionResult PutCategories(int id, Categorie categorie)
		{
			if (id != categorie.ID)
				return BadRequest();

			if (!ModelState.IsValid)
				return BadRequest();

			if(db.Categories.Count(x=> x.ID == id)!=1)
				return BadRequest();

			db.Entry(categorie).State = System.Data.Entity.EntityState.Modified;
			db.SaveChanges();

			return StatusCode(HttpStatusCode.NoContent);

			


		}


		/*public IHttpActionResult DeleteCategoriesOLD(int id, Categorie categorie)
		{
			if (id != categorie.ID)
				return BadRequest();

			if (!ModelState.IsValid)
				return BadRequest();

			if (db.Categories.Count(x => x.ID == id) != 1)
				return BadRequest();

			db.Entry(categorie).State = System.Data.Entity.EntityState.Deleted;
			db.SaveChanges();

			return StatusCode(HttpStatusCode.NoContent);




		}*/

		public IHttpActionResult DeleteCategories(int id)
		{
			var categorie = db.Categories.Find(id);

			if (categorie==null)
				return NotFound();

			

			if (db.Categories.Count(x => x.ID == id) != 1)
				return BadRequest();

			db.Entry(categorie).State = System.Data.Entity.EntityState.Deleted;
			db.SaveChanges();

			return Ok(categorie);




		}
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			db.Dispose();
		}



	}
}
