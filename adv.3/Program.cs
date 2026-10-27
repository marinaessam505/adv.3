namespace adv._3
{


    #region q1

    //class Program
    //{
    //    static void Main()
    //    {

    //        List<int> grades = new List<int>
    //    {
    //        85, 92, 78, 95, 88, 70, 100, 65
    //    };


    //        Console.WriteLine("Grades:");
    //        Console.WriteLine(string.Join(", ", grades));
    //        Console.WriteLine("Count: " + grades.Count);
    //        Console.WriteLine("First Grade: " + grades.First());
    //        Console.WriteLine("Last Grade: " + grades.Last());


    //        grades.Sort();
    //        Console.WriteLine("\nSorted Grades:");
    //        Console.WriteLine(string.Join(", ", grades));


    //        int firstAbove90 = grades.First(g => g > 90);
    //        Console.WriteLine("\nFirst Grade Above 90: " + firstAbove90);


    //        List<int> failingGrades = grades.Where(g => g < 75).ToList();
    //        Console.WriteLine("\nFailing Grades:");
    //        Console.WriteLine(string.Join(", ", failingGrades));


    //        grades.RemoveAll(g => g < 75);
    //        Console.WriteLine("\nGrades After Removing Failing Grades:");
    //        Console.WriteLine(string.Join(", ", grades));


    //        bool has100 = grades.Any(g => g == 100);
    //        Console.WriteLine("\nHas Grade 100: " + has100);


    //        List<string> gradeLabels = grades
    //            .Select(g => $"Grade: {g}")
    //            .ToList();

    //        Console.WriteLine("\nGrade Labels:");
    //        foreach (string label in gradeLabels)
    //        {
    //            Console.WriteLine(label);
    //        }
    //    }
    //}


    #endregion


    #region q2

    class Program
    {
        static void Main()
        {
            Stack<string> history = new Stack<string>();

            history.Push("google.com");
            history.Push("github.com");
            history.Push("stackoverflow.com");
            history.Push("youtube.com");
            history.Push("claude.ai");

            Console.WriteLine("Current Page: " + history.Peek());

            Console.WriteLine("\nGoing Back:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Leaving: " + history.Pop());
            }

            Console.WriteLine("\nCurrent Page: " + history.Peek());

            history.Pop();
            history.Pop();

            if (history.TryPop(out string page))
            {
                Console.WriteLine(page);
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }
    }


    #endregion


}
