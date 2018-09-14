using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Todolist.Models;

namespace Todolist.Data
{
	public class TodoDbContext : DbContext
	{
		public TodoDbContext() : base("TodoListConnectionString")
		{

		}

		public DbSet<Categorie> Categories { get; set; }


	}
}