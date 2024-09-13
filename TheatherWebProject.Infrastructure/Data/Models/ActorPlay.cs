using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatherWebProject.Infrastructure.Data.Models
{
	public class ActorPlay
	{
		public required int ActorId { get; set; }
		[ForeignKey(nameof(ActorId))]
		public  Actor Actor { get; set; } = null!;

		public required int PlayId { get; set; }
		[ForeignKey(nameof(PlayId))]
		public  Play Play { get; set; } = null!;
	}
}
