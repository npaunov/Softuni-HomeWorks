using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ query syntax.*/

namespace z02.Students_by_Group
{
    class SortStudents
    {
        static void Main()
        {
            var student = new List<Student>
        {
            new Student("Ivan", "Ivanov",18,1,"021234","",new List<int> {5, 3, 5, 6},1),
            new Student("Pesho", "Peshev",18,2,"3592321638","peshev@abv.bg",new List<int> {5, 2, 5, 6},1),
            new Student("Petko", "Petkov",19,3,"07113","petkov@abv.bg",new List<int> {5, 2, 5, 6},2),
            new Student("Goshko", "Goskov",19,4,"083545","goshov@gmail.com",new List<int> {5, 2, 5, 5},2),
            new Student("Mariika", "Marieva",20,5,"+359 2","niama@ght.gh",new List<int> {6, 2, 6, 4},1),
            new Student("Rositza", "Roseva",21,6,"112345","pakmail@abv.bg",new List<int> {4, 2, 6, 3},2),
            new Student("Ivan", "Petkov",36,7,"524354","zashto@hotmail.com",new List<int> {6, 2, 6, 6},3),
        };

            Console.WriteLine("Using Lambda:");
            Console.WriteLine();

            //this is DESCENDING order by and DESCENDING thenby
            var sortStudentsLambda = student.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName).Select(st => (string.Format("{0} {1}", st.FirstName, st.LastName)));
            foreach (var st in sortStudentsLambda)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
            Console.WriteLine("LINQ query:");
            Console.WriteLine();

            var sortStudentsLINQ =
                from st in student
                orderby st.FirstName descending, st.LastName descending
                select st;

            foreach (var st in sortStudentsLINQ)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }
        }


    }
}