using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. Create a List<Student> with sample students. These students will be used for the next few tasks.*/

class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public int FacultyNumber { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public IList<int> Marks { get; set; }

    public int GroupNumber { get; set; }

    public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.FacultyNumber = facultyNumber;
        this.Phone = phone;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNumber;

    }
    public static void Main()
    {
        var students = new List<Student>
		{
			new Student("Ivan", "Ivanov",18,1,"021234","",new List<int> {5, 3, 5, 6},1),
			new Student("Pesho", "Peshev",18,2,"3592321638","peshev@abv.bg",new List<int> {5, 2, 5, 6},1),
			new Student("Petko", "Petkov",19,3,"07113","petkov@abv.bg",new List<int> {5, 2, 5, 6},2),
			new Student("Goshko", "Goskov",19,4,"083545","goshov@gmail.com",new List<int> {5, 2, 5, 5},2),
			new Student("Mariika", "Marieva",20,5,"+359 2","niama@ght.gh",new List<int> {6, 2, 6, 4},1),
			new Student("Rositza", "Roseva",21,6,"112345","pakmail@abv.bg",new List<int> {4, 2, 6, 3},2),
			new Student("Ivan", "Petkov",36,7,"524354","zashto@hotmail.com",new List<int> {6, 2, 6, 6},3),
		};

    }
      

}

    




