using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb_2025CS231.Models
{
    public class GroupStudent
    {
        public int GroupId { get; set; }
        public int StudentId { get; set; }
        public int Status { get; set; } 
        public DateTime AssignmentDate { get; set; }
    }
}
