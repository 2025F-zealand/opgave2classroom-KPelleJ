using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public DateTime StartOfSemester { get; set; }

        public ClassRoom() 
        { 
            Students = new List<Student>();
        }
    }
}
