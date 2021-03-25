using System;
using System.ComponentModel;

namespace WadoRyu.Models
{
	public class Video
	{
		public int ID { get; set; }

		[DisplayName("YouTube Embed URL")]
		public string Url { get; set; }
		public string Name  { get; set; }
		public string Category { get; set; }

		[DisplayName("Date added")]
		public DateTime DateAdded { get; set; }
	}
}
