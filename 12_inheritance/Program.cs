namespace _12_inheritance;
using System.Linq;

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

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string firstName, string lastName, int idNumber, int[] scores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = idNumber;
        this.testScores = scores;
    }

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public string Calculate()
    {
        int avr = Convert.ToInt32(testScores.Average());
        if (avr<=100 && avr>=90)
        {
            return "O";
        }else if (avr<90 && avr>=80)
        {
            return "E";
        }else if (avr<90 && avr>=80)
        {
            return "E";
        }else if (avr<80 && avr>=70)
        {
            return "A";
        }else if (avr<70 && avr>=55)
        {
            return "P";
        }else if (avr<55 && avr>=40)
        {
            return "D";
        }else{
            return "T";
        }
    }
}

class Solution
{
    static void Main()
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
