namespace Day_12_Inheritance;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    public Student(string firstName, string lastName, int id, int[] scores)
        : base(firstName, lastName, id)
    {
        testScores = scores;
    }

    public char Calculate()
    {
        return testScores.Average() switch
        {
            (>= 90 and <= 100) => 'O',
            (>= 80 and < 90) => 'E',
            (>= 70 and < 80) => 'A',
            (>= 55 and < 70) => 'P',
            (>= 40 and < 55) => 'D',
            (< 40) => 'T',
        };
    }
}

internal class Solution
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}
