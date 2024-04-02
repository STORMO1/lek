using Laba_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть ім'я собаки:");
        string dogName = Console.ReadLine();

        Console.Write("Введіть вік собаки:");
        int dogAge = int.Parse(Console.ReadLine());

        Console.Write("Введіть тип тварини (Домашній улюбленець чи дика тварина?):");
        string dogType = Console.ReadLine();

        Console.Write("Введіть дату народження:");
        string dogBirth = Console.ReadLine();

        Console.Write("Чи має собака дефекти? (Оберіть лиш одну відповідь з цих двох : так/ні):");
        bool dogDefects = Console.ReadLine().Equals("так", StringComparison.OrdinalIgnoreCase);

        Console.Write("Чи навчена собака? (так/ні):");
        bool dogIsTrained = Console.ReadLine().Equals("так", StringComparison.OrdinalIgnoreCase);

        Console.Write("Введіть породу собаки:");
        string dogBreed = Console.ReadLine();

        Dog dog = new Dog(dogName, dogAge, dogType, dogBirth, dogDefects, dogIsTrained, dogBreed);


        Console.WriteLine("Що робить собака?");
        Console.WriteLine("1. Гавкає?");
        Console.WriteLine("2. Виляє хвостом?");
        Console.WriteLine("3. Лікується?");
        int dogActionChoice = int.Parse(Console.ReadLine());

        switch (dogActionChoice)
        {
            case 1:
                dog.Bark();
                break;
            case 2:
                dog.Activity();
                break;
            case 3:
                dog.Heal();
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
        Console.Write("Введіть ім'я людини:");
        string personName = Console.ReadLine();

        Console.Write("Введіть вік людини:");
        int personAge = int.Parse(Console.ReadLine());

        Console.Write("Введіть стать людини:");
        string personGender = Console.ReadLine();

        Console.Write("Введіть дату народження:");
        string personBirthDate = Console.ReadLine();

        Console.Write("Чи є людина студентом? (Оберіть лиш одну відповідь з цих двох : так/ні)::");
        bool isStudent = (Console.ReadLine()).Equals("так", StringComparison.OrdinalIgnoreCase); ;

        Console.Write("Чи працює людина? (true/false):");
        bool isWorking = Console.ReadLine().Equals("так", StringComparison.OrdinalIgnoreCase); ;


        Person person = new Person(personName, personAge, personGender, personBirthDate, isStudent, isWorking);

        Console.WriteLine("Що робить людина?");
        Console.WriteLine("1. Працює?");
        Console.WriteLine("2. Відпочиває?");
        Console.WriteLine("3. Лікується?");
        int personActionChoice = int.Parse(Console.ReadLine());

        switch (personActionChoice)
        {
            case 1:
                person.Work();
                break;
            case 2:
                person.Relax();
                break;
            case 3:
                person.Healing();
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
                Console.ReadLine();
    }
}