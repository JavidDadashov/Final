﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Locationn { get; set; }
        public ICollection<Apply> Applies { get; set; }
    }
}
