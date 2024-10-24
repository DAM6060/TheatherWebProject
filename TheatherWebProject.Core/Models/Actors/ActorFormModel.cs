﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatherWebProject.Core.Models.Actors
{
    public class ActorFormModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ActorImageUrl { get; set; } = string.Empty;
    }
}
