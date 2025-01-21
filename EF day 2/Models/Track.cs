using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_day_2.Models
{
    public class Track
    {

        public Track()
        {
            Students = new List<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Student> Students { get; set; }
    }
}
