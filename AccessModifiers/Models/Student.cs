namespace AccessModifiers.Models;

public class Student
{
    string _name;
    public string Name
    {
        get { return _name; }
        set
        {
            value = value.Trim().ToLower();
            if (value.Length > 3 || value.Split().Length == 1)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (i == 0)
                    {
                        _name += char.ToUpper(value[i]);
                        continue;
                    }
                    if (char.IsDigit(value[i]))
                    {
                        _name = null;
                        Console.WriteLine("Duzgun ad daxil edin");
                        break;
                    }
                    _name += value[i];
                }
            }
            else
            {
                Console.WriteLine("duzgun ad daxil edin");
            }


        }
    }
    byte _age = 101;
    public byte Age
    {
        get { return _age; }
        set
        {
            if (value > 0 && value < 100)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Duzgun yas daxil edin");
            }
        }
    }
    byte _grade = 101;
    public byte Grade
    {
        get { return _grade; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                _grade = value;
            }
            else
            {

                Console.WriteLine("Duzgun bal daxil edin");
            }
        }
    }
    public Student(string name, byte age, byte grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}
