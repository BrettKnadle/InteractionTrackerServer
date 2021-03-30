﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteractionTrackerServer.Models
{
    public class Duration
    {
        [Required]
        public string Value { get; set; }

        [Required]
        public string Unit { get; set; }
    }
}
