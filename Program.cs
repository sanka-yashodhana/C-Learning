using System;
class Program
{
    static void Main()
    {
        try
        {
            int[] numbers = new int[5];

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine();
                Console.Write($"Enter the marks for student {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());

                Student student = new Student($"Student {i + 1}", 18 + i , numbers[i]);
                student.displayStudentInfo();
                Console.WriteLine();
                GradeSelect.Grade(student.Marks);

                NumberType(student.Marks);

            }

            Console.WriteLine();


            

        } catch(FormatException)
        {
            Console.WriteLine("The entered number is not in correct format");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Number value can not be empty");
        }

        /*
        Student student1 = new Student("Saman", 18, 98);
        Student student2 = new Student("Kamal", 19, 88);
        Student student3 = new Student("Nimal", 20, 78);
        Student student4 = new Student("Sunil", 21, 68);
        Student student5 = new Student("Ruwan", 22, 58);

        student1.displayStudentInfo();
        student2.displayStudentInfo();
        student3.displayStudentInfo();
        student4.displayStudentInfo();
        student5.displayStudentInfo();
        */

    }

    public static void NumberType(int num)
    {
        if(num % 2 == 0)
        {
            Console.WriteLine($"The entered mark is even {num}");
        } else
        {
            Console.WriteLine($"The entered mark is odd {num}");
        }
    }
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
    public Student(string name, int age, int marks)
    {
        Name = name;
        Age = age;
        Marks = marks;
    }
    public void displayStudentInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Marks: {Marks}");
    }
}

class GradeSelect
{
    public static void Grade(int grade)
    {
        if (grade >= 75 && grade <= 100)
        {
            Console.WriteLine("Grade is A");
        }
        else if (grade >= 65 && grade < 75)
        {
            Console.WriteLine("Grade is B");
        }
        else if (grade >= 55 && grade < 65)
        {
            Console.WriteLine("Grade is C");
        }
        else if (grade >= 35 && grade < 55)
        {
            Console.WriteLine("Grade is S");
        }
        else if (grade >= 0 && grade < 35)
        {
            Console.WriteLine("You are failed");
        }
        else
        {
            Console.WriteLine("Enter a valid mark ");
        }
    }
}