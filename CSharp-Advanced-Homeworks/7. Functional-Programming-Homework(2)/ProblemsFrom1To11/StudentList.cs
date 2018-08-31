using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsFrom1To11
{
    class StudentList
    {
        public List<Student> Students()
        {
            var students = new List<Student>
		{
			new Student("Ivan", "Ivanov",18,"100014","021234","",new List<int> {5, 3, 5, 6},1,"Fundamentals"),
            new Student("Pesho", "Peshev",18,"200015","+3592321638","peshev@abv.bg",new List<int> {5, 2, 5, 6},1,"Fundamentals"),
            new Student("Petko", "Petkov",19,"300014","07113","petkov@abv.bg",new List<int> {5, 2, 5, 6},2, "Front-End Development"),
            new Student("Goshko", "Goskov",19,"400014","083545","goshov@gmail.com",new List<int> {5, 2, 2, 5},2,"Front-End Development"),
            new Student("Mariika", "Marieva",20,"500014","+359 2 554135435","niama@ght.gh",new List<int> {6, 2, 6, 4},1,"Fundamentals"),
            new Student("Rositza", "Roseva",21,"600013","112345","pakmail@abv.bg",new List<int> {4, 2, 2, 3},2,"Front-End Development"),
            new Student("Ivan", "Petkov",36,"700013","524354","zashto@hotmail.com",new List<int> {6, 2, 6, 6},3,"Back-End Development")
		};
            return students;
        }
    }
}
