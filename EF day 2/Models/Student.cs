﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_day_2.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public int Age { get; set; }
        public int trackId { get; set; }
        public virtual Track track { get; set; }
    }
}
