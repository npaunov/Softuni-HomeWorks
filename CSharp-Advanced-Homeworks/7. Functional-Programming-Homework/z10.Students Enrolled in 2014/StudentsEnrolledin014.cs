using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Extract and print the Marks of the students that enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).*/

namespace z02.Students_by_Group
{
    class StudentsEnrolledin014
    {
        static void Main()
        {
            var student = new List<Student>
        {
            new Student("Ivan", "Ivanov",18,"100014","021234","",new List<int> {5, 3, 5, 6},1),
            new Student("Pesho", "Peshev",18,"200015","+3592321638","peshev@abv.bg",new List<int> {5, 2, 5, 6},1),
            new Student("Petko", "Petkov",19,"300014","07113","petkov@abv.bg",new List<int> {5, 2, 5, 6},2),
            new Student("Goshko", "Goskov",19,"400014","083545","goshov@gmail.com",new List<int> {5, 2, 2, 5},2),
            new Student("Mariika", "Marieva",20,"500014","+359 2 554135435","niama@ght.gh",new List<int> {6, 2, 6, 4},1),
            new Student("Rositza", "Roseva",21,"600013","112345","pakmail@abv.bg",new List<int> {4, 2, 2, 3},2),
            new Student("Ivan", "Petkov",36,"700013","524354","zashto@hotmail.com",new List<int> {6, 2, 6, 6},3),
        };


            var enroledIn2014 =
                from st in student
                where (st.FacultyNumber.EndsWith("14"))
                select st;

            foreach (var st in enroledIn2014)
            {
                Console.WriteLine("{0} {1} {2}", st.FirstName, st.LastName, string.Join(" ", st.Marks));
            }


        }


    }
}