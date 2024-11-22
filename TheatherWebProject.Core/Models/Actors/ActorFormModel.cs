using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatherWebProject.Core.Models.Plays;

namespace TheatherWebProject.Core.Models.Actors
{
    public class ActorFormModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<string> ActorImageUrls { get; set; } = new List<string>();

        public List<PlayServiceModel> AllPlaysDropDown { get; set; } = new List<PlayServiceModel>();

        public List<int> PlaysIds { get; set; } = new List<int>();
    }
}
