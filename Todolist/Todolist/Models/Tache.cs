﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Todolist.Models
{
	public class Tache
	{
		public int ID { get; set; }
		[Required]
		[StringLength(30)]
		public string Nom { get; set; }

		[StringLength(250)]
		public string Description { get; set; }
		public DateTime? Datefin { get; set; }

		[Required]
		public bool Statut { get; set; }

		public int? Priorite { get; set; }

		public int CategoryID { get; set; }

		[ForeignKey("CategoryID")]
		public Categorie Categorie { get; set; }



	}
}