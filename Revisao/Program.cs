using System;

namespace Revisao
{
   class Program
   {
      static void Main(string[] args)
      {

         Student[] students = new Student[5];
         var studentIndex = 0;
         string userInput = getUserInput();

         while (userInput.ToUpper() != "X")
         {
            switch (userInput)
            {
               case "1":
                  Console.WriteLine("Enter student name:");
                  Student student = new Student();
                  student.Name = Console.ReadLine();

                  Console.WriteLine("Enter student grade:");

                  if (decimal.TryParse(Console.ReadLine(), out decimal grade))
                  {
                     student.Grade = grade;
                  }
                  else
                  {
                     throw new ArgumentException("Grade must be decimal");
                  }

                  students[studentIndex] = student;
                  studentIndex++;

                  break;
               case "2":
                  foreach (var s in students)
                  {
                     if (!string.IsNullOrEmpty(s.Name))
                     {
                        Console.WriteLine($"STUDENT: {s.Name} / GRADE: {s.Grade}");
                     }
                  }
                  break;
               case "3":
                  decimal totalGrades = 0;
                  var studentsQNT = 0;

                  for (int i = 0; i < students.Length; i++)
                  {
                     if (!string.IsNullOrEmpty(students[i].Name))
                     {
                        totalGrades += students[i].Grade;
                        studentsQNT++;
                     }
                  }

                  decimal gradesAverage = 0;
                  if (studentsQNT != 0)
                  {
                     gradesAverage = totalGrades / studentsQNT;
                  }

                  Concept concept;

                  if (gradesAverage < 2) concept = Concept.E;
                  else if (gradesAverage < 4) concept = Concept.D;
                  else if (gradesAverage < 6) concept = Concept.C;
                  else if (gradesAverage < 8) concept = Concept.B;
                  else concept = Concept.A;

                  Console.WriteLine($"GRADES AVERAGE : {gradesAverage} - CONCEPT: {concept}");

                  break;
               default:
                  throw new ArgumentOutOfRangeException();
            }

            userInput = getUserInput();
         }
      }

      private static string getUserInput()
      {
         Console.WriteLine();
         Console.WriteLine("Select desired option:");
         Console.WriteLine("1 - Insert new student ");
         Console.WriteLine("2 - List students");
         Console.WriteLine("3 - Calculate average of grades");
         Console.WriteLine("X - Exit");
         Console.WriteLine();

         string userInput = Console.ReadLine();
         Console.WriteLine();
         return userInput;
      }

   }
}
