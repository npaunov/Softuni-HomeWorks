using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsFrom1To11
{
    class ProblemsFrom1To11
    {
        static void Main()
        {
            /* Problem 1: Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. Create a List<Student> with sample students. These students will be used for the next few tasks.*/
            Console.WriteLine("Problem 1: There is a class Student with properties and class StudentList with all students");

            StudentList instanceOfClass = new StudentList();
            var students = instanceOfClass.Students();
            Console.WriteLine("-------------\n");

            /*Problem 2: Print all students from group number 2. Use a LINQ query. Order the students by FirstName.*/
            Console.WriteLine("Problem 2: Students by Group\n");

             var groupTwoStudents =
             from st in students
             where st.GroupNumber == 2
             orderby st.FirstName
             select st;

            foreach (var st in groupTwoStudents)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group Number = {7}", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(" ", st.Marks), st.GroupNumber);
            }
            Console.WriteLine("-------------\n");

            /*Problem 3: Print all students whose first name is before their last name alphabetically. Use a LINQ query.*/
            Console.WriteLine("Problem 3: Students First And LastName\n");

            var studentsFirstAndLastName =
                from st in students
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;

            foreach (var st in studentsFirstAndLastName)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group Number = {7}", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(" ", st.Marks), st.GroupNumber);
            }
            Console.WriteLine("-------------\n");

            /*Promblem 4: Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. The query should return only the first name, last name and age.*/
            Console.WriteLine("Problem 4: Students by Age\n");

            var studentsByAge =
                from st in students
                where (st.Age >= 18 && st.Age <= 24)
                select new { st.FirstName, st.LastName, st.Age };

            foreach (var st in studentsByAge)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " " + st.Age);
            }
            Console.WriteLine("-------------\n");
            /*Problem 5: Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ query syntax.*/
            Console.WriteLine("Problem 5: Sort Students\n");

            Console.WriteLine("Using Lambda:");
            Console.WriteLine();

            //this is DESCENDING order by and DESCENDING thenby
            var sortStudentsLambda = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName).Select(st => (string.Format("{0} {1}", st.FirstName, st.LastName)));
            foreach (var st in sortStudentsLambda)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
            Console.WriteLine("LINQ query:");
            Console.WriteLine();

            var sortStudentsLINQ =
                from st in students
                orderby st.FirstName descending, st.LastName descending
                select st;

            foreach (var st in sortStudentsLINQ)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }
            Console.WriteLine("-------------\n");

            /*Problem 6: Print all students that have email @abv.bg. Use LINQ.*/
            Console.WriteLine("Problem 6: Filter Students by Email Domain\n");

            var studentsByEmails =
                from st in students
                where st.Email.Contains("@abv.bg")
                select st;

            foreach (var st in studentsByEmails)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " --> " + st.Email);
            }
            Console.WriteLine("-------------\n");

            /*Problem 7: Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ*/
            Console.WriteLine("Problem 7: Filter Students by Phone\n");

            var studentsPhoneSofia =
                from st in students
                where (st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592") || st.Phone.StartsWith("+359 2"))
                select st;

            foreach (var st in studentsPhoneSofia)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " --> " + st.Phone);
            }
            Console.WriteLine("-------------\n");
            /*Problem 8: Print all students that have at least one mark Excellent (6). Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.*/
            Console.WriteLine("Problem 8: Excellent Students\n");

            var excellentStudents =
                from st in students
                where (st.Marks.Max() == 6)
                select new { Fullname = string.Join(" ", st.FirstName, st.LastName), Marks = string.Join(" ", st.Marks) };

            foreach (var st in excellentStudents)
            {
                Console.WriteLine(st.Fullname + " " + st.Marks);
            }
            Console.WriteLine("-------------\n");

            /*Problem 9: Write a similar program to the previous one to extract the students with exactly two marks "2". Use extension methods.*/
            Console.WriteLine("Problem 9: Weak Students \n");

            var countThem = students.ExtentionCount();

            foreach (var st in countThem)
            {
                Console.WriteLine("{0} {1} {2}", st.FirstName, st.LastName, string.Join(" ", st.Marks));
            }
            Console.WriteLine("-------------\n");

            /*Problem 10: Extract and print the Marks of the students that enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).*/
            Console.WriteLine("Problem 10: Students Enrolled in 2014\n");

            var enroledIn2014 =
                from st in students
                where (st.FacultyNumber.EndsWith("14"))
                select st;

            foreach (var st in enroledIn2014)
            {
                Console.WriteLine("{0} {1} {2}", st.FirstName, st.LastName, string.Join(" ", st.Marks));
            }
            Console.WriteLine("-------------\n");

            /*Problem 11: Add a GroupName property to Student. Write a program that extracts all students grouped by GroupName and then prints them on the console. Print all group names along with the students in each group. Use the "group by into" LINQ operator.*/
            Console.WriteLine("Problem 11: Students by Groups\n");

            var tudentsByGroups =
               from st in students
               group st by st.GroupName;


            foreach (var studentGroupName in tudentsByGroups)
            {
                Console.WriteLine("Group Name: {0}, Number of Students: {1}", studentGroupName.Key, studentGroupName.Count());
                foreach (var st in studentGroupName)
                {
                    Console.WriteLine("{0} {1}", st.FirstName, st.LastName);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------\n");

        }
    }
}
