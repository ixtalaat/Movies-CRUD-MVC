﻿using CRUD.Movies.Models;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Movies.ViewModels
{
	public class MovieFormViewModel
	{
		public int Id { get; set; }

		[Required, StringLength(250)]
		public string Title { get; set; } = string.Empty;

		public int Year { get; set; }

		[Range(1, 10)]
		public double Rate { get; set; }

		[Required, StringLength(2500)]
		public string StoryLine { get; set; } = string.Empty;

		[Display(Name = "Select poster...")]
		public byte[]? Poster { get; set; }

		[Display(Name = "Genre")]
		public byte GenreId { get; set; }

		public IEnumerable<Genre>? Genres{get; set;}
	}
}
