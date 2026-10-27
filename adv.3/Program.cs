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

    //class Program
    //{
    //    static void Main()
    //    {
    //        Stack<string> history = new Stack<string>();

    //        history.Push("google.com");
    //        history.Push("github.com");
    //        history.Push("stackoverflow.com");
    //        history.Push("youtube.com");
    //        history.Push("claude.ai");

    //        Console.WriteLine("Current Page: " + history.Peek());

    //        Console.WriteLine("\nGoing Back:");

    //        for (int i = 0; i < 3; i++)
    //        {
    //            Console.WriteLine("Leaving: " + history.Pop());
    //        }

    //        Console.WriteLine("\nCurrent Page: " + history.Peek());

    //        history.Pop();
    //        history.Pop();

    //        if (history.TryPop(out string page))
    //        {
    //            Console.WriteLine(page);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Stack is empty");
    //        }
    //    }
    //}


    #endregion


    #region q3

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    class Program
    {
        #region Question 3.2: Transform Products

        static List<string> TransformProducts(
            List<Product> products,
            Func<Product, string> transform)
        {
            List<string> result = new List<string>();

            foreach (Product product in products)
            {
                result.Add(transform(product));
            }

            return result;
        }

        #endregion

        static void Main()
        {
            List<Product> products = new List<Product>
        {
            new Product("Laptop", 1200),
            new Product("Phone", 800),
            new Product("T-Shirt", 30),
            new Product("Jeans", 60),
            new Product("Chocolate", 5),
            new Product("Coffee Beans", 15),
            new Product("C# Book", 45)
        };

            #region Scenario 3: Summary List

            Console.WriteLine("--- Summary List ---");

            List<string> summary = TransformProducts(
                products,
                p => $"{p.Name} (${p.Price})"
            );

            foreach (string item in summary)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Scenario 4: Price Labels

            Console.WriteLine("\n--- Price Labels ---");

            List<string> labels = TransformProducts(
                products,
                p => $"{p.Name}: {(p.Price > 100 ? "Expensive!" : "Affordable")}"
            );

            foreach (string item in labels)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }

    #endregion 



}
