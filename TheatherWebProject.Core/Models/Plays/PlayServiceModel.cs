using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatherWebProject.Core.Models.Plays
{
	public class PlayServiceModel
	{
		public int Id { get; set; }

		public string Title { get; set; } = string.Empty;

		public string Description { get; set; } = string.Empty;

		public string Genre { get; set; } = string.Empty;

		public string ImagesURL { get; set; } = string.Empty;
	}

}
