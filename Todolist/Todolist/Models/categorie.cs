using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Todolist.Models
{
	public class categorie
	{

		public int ID { get; set; }
		[Required]
		[StringLength(20)]
		public string Nom { get; set; }
	}
}