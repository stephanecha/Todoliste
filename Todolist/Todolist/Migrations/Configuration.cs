using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using Todolist.Data;

namespace Todolist.Migrations
{
	public class Configuration :DbMigrationsConfiguration<TodoDbContext>
	{
		public Configuration ()
		{

		

		AutomaticMigrationsEnabled = false;
		}
	}
}