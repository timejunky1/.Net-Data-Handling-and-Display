using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_practice
{
    internal class Student
    {
        int studentNumber;
        string name, surname, gender, phone, address;
        Image image;
        DateTime dob;
        List<string> modules;

        public Student(int studentNumber, string name, string surname, Image image, DateTime dob, string gender, string phone, string address, List<string> modules)
        {
            this.studentNumber = studentNumber;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.phone = phone;
            this.address = address;
            this.image = image;
            this.dob = dob;
            this.modules = modules;
        }

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public Image Image { get => image; set => image = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public List<string> Modules { get => modules; set => modules = value; }

        public override string ToString()
        {
            return $"{studentNumber},{name},{surname}";
        }
    }
}
