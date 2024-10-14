class YourName
{
    static void Main()
    {
       
        int percetage;

        Console.Write("Enter Your student name: ");
        var name = Console.ReadLine();

        Console.Write("Enter The Student percentage: ");
        percetage = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"the grade of the student: {name}");
        String statement = percetage >= 60 && percetage < 70 ? "Accepted" :
            percetage >= 70 && percetage < 80 ? "Good" :
            percetage >= 80 && percetage < 85 ? "very good" :
            percetage >= 85 && percetage < 95 ? "EXCELLENT" :
            percetage >= 95 && percetage <= 100 ? "High Excellent" :
            "Failed";
        Console.WriteLine($"the grade is {statement}");
        Console.ReadKey();
    }
}
