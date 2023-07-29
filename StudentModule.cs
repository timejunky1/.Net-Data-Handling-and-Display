using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_practice
{
    internal class StudentModule
    {
        string studentID, module;

        public StudentModule(string studentID, string module)
        {
            this.studentID = studentID;
            this.module = module;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string Module { get => module; set => module = value; }
    }
}
