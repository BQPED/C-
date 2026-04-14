using System;

class Human
{
    private string name;
    private string second_name;
    private string last_name;
    private int age;
    static private int count_human;


    static public int Counthuman
    {
        set { count_human = value; }
    }
    public string Second_name
    {
        set { second_name = value; }
        get { return second_name; }
    }

    public string Name
    {
        set { name = value; }
        get { return name; }
    }

    public string Last_Name
    {
        set { last_name = value; }
        get { return last_name; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Full_name
    {
        get
        {
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            if (password == "123")
            {
                return $"{last_name} | {name} | {second_name}";
            }
            else
            {
                throw new Exception("incorrect password!");
            }
        }
    }

    public void printInfo()
    {
        Console.WriteLine($"Name: {name} \n SecondName: {second_name} \n LastName: {last_name} \n Age: {age} {Option()}");
    }

    public string Option()
    {
        int lastDigit = age % 10;
        int lastTwoDigits = age % 100;

        if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
            return "лет";

        switch (lastDigit)
        {
            case 1:
                return "год";
            case 2:
            case 3:
            case 4:
                return "года";
            default:
                return "лет";
        }
    }
    public Human(string last_name, string name, string second_name, int age)
    {
        this.last_name = last_name;
        this.name = name;
        this.second_name = second_name;
        this.age = age;
        count_human++;
    }
    public Human()
    {
        count_human++;
    }
    static Human()
    {
        Console.WriteLine("Вы используете класс Human");
    }

    static public void getCountHuman()
    {
        Console.WriteLine($"Количество: {count_human}");
    }
}