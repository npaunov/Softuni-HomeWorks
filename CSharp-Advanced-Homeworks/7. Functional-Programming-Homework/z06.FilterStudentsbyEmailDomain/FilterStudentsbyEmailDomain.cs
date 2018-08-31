using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Print all students that have email @abv.bg. Use LINQ.*/

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

            var studentsByEmails =
                from st in student
                where st.Email.Contains("@abv.bg")
                select st;

            foreach (var st in studentsByEmails)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + "-->" + st.Email);
            }
        }


    }
}