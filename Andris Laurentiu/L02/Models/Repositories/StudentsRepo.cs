using System.Collections.Generic;
using Models; 

namespace Repositories
{

    public static class StudentsRepo
    {

        public static List<Student> Students = new List<Student>() {
            new Student() { Id = 1, Faculty = "AC", Name = "Lau", Year = 4 }, 
            new Student() { Id = 2, Faculty = "ETC", Name = "Daniel", Year = 2 }
        };
    }
}