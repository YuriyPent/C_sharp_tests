using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Sharp7
    {
    public class NewFeatures
        {

        public List<Students> student = null;

        public NewFeatures ()
            {
            var s = new List<Students>
                {
                new Students()
                    {
                    Name = "Karthik",
                    Age = 20,
                    Gender = "M",
                    Grade = "First"
                    },
                new Students()
                    {
                    Name = "Prashanth",
                    Age = 25,
                    Gender = "M",
                    Grade = "First"
                    },
                new Students()
                    {
                    Name = "Shrea",
                    Age = 30,
                    Gender = "F",
                    Grade = "Second"
                    }
                };
            student=s;
            }
        public void GetStudentsInfoWithGrade ( Students student )
            {
            switch (student)
                {
                case Students s when (s.Grade=="First"&&s.Name.Contains ("Kart")):
                    Console.WriteLine ($"Student with name {s.Name} is with Age {s.Age}");
                    break;
                case Students s when (s.Grade=="Second"):
                    Console.WriteLine ($"Student with name {s.Name} is with Age {s.Age}");
                    break;

                default:
                    break;
                }
            }
        }

    public class Students
        {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public string Gender { get; set; }
        }
    }
