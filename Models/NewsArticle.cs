using System;
using System.ComponentModel;

namespace JokesWebApp.Models
{
	public class NewsArticle
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }

		[DisplayName("Date")]
		public DateTime DatePublished { get; set; }

		public NewsArticle()
		{
		}
	}
}
