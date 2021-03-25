using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WadoRyu.Models
{
	public class Video
	{
		public int ID { get; set; }

		[DisplayName("YouTube Embed URL")]
		[Required(ErrorMessage = "Url is required.")]
		public string Url { get; set; }
		public string Name  { get; set; }
		public string Category { get; set; }

		[DisplayName("Date added")]
		public DateTime DateAdded { get; set; }
	}
}
