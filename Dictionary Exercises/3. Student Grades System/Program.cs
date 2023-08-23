using System.Threading.Channels;

namespace MethodsExercise;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();
        while (true)
        {
            Console.WriteLine("Enter a student name");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter the student's grades");
            List<double> grades = Console.ReadLine().Split().Select(double.Parse).ToList();

            studentsGrades.Add(studentName, grades);
            Console.WriteLine("Do you want to add another student? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "n") break;

            foreach (var student in studentsGrades)
            {
                double averageGradeOfStudent = GetAverageGrade(student.Value);
                Console.WriteLine($"{student.Key} avergae grade is {averageGradeOfStudent}"); ;
            }
        }
    }

    static double GetAverageGrade(List<double> grades)
    {
        double sum = 0;
        foreach (var grade in grades)
        {
            sum += grade;
        }

        return sum / grades.Count;
    }
}