using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Print all students whose first name is before their last name alphabetically. Use a LINQ query.*/

namespace z02.Students_by_Group
{
    class StudentsFirstAndLastName
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

            var studentsFirstAndLastName =
                from st in student
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;

            foreach (var st in studentsFirstAndLastName)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group Number = {7}", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(" ", st.Marks), st.GroupNumber);
            }
        }


    }
}