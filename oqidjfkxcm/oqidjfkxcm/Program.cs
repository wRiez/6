using oqidjfkxcm;
using System.Security.Cryptography;

WorkingOnString work = new WorkingOnString();
string choose = "e";

string choose_void = "0";

switch (choose)
{
    case "s":

        switch (choose_void)
        {
            case "One":
                work.five();
                break;
            case "Two":
                work.twantytwo();
                break;
            case "Three":
                work.thirtyone();
                break;
            case "Four":
                work.fiftysix();
                break;
            default:
                Console.WriteLine("\nНеверное значение");
                break;
        }
        goto case "e";
    case "e":

        Console.WriteLine("\nВведите какое задание хотите выбрать:   One   Two   Three   Four");
        choose_void = Console.ReadLine();
        goto case "s";
}