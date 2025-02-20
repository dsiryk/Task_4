
/* static int Num(string mess
{
    Console.WriteLine(mess;
    return Convert.ToInt32(Console.ReadLine(;
}
int a = Num("Ведіть 1 сторону"; */

/*   static int number_1 (string num
{
 Console.WriteLine (num;
    return Convert.ToInt32 (num;
}
int a = number_1("Введіть перше число";
*/

/* static int AddNumbers(int num1, int num2
{
    int sum = num1 + num2;
    return sum;
}
Console.WriteLine(AddNumbers; */
/* using System.Text;

static void showResult(string name
{
    Console.WriteLine("Ваш трикутник " + name;
}

static int getNumber(string message
{
    Console.WriteLine(message;
    return Convert.ToInt16(Console.ReadLine(;
}

    Console.OutputEncoding = Encoding.Unicode;
    Console.InputEncoding = Encoding.Unicode;

    int a = getNumber("Введіть першу сторону трикутника ";
    int b = getNumber("Введіть другу сторону трикутника ";
    int c = getNumber("Введіть третю сторону трикутника ";
*/


// Виводить (Ваш трикутник різносторонній)
/* static void end1 (string rez)
{
Console.WriteLine ("Результат " + num_1 + symvol + num_2 + " є " + rez);
}
end1(); */

/* Console.WriteLine("Введіть 1 число");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введіть символ");
string sym = Console.ReadLine();
Console.WriteLine("Введіть 2 число");
double num2 = Convert.ToDouble(Console.ReadLine()); */

using System;
using System.ComponentModel.Design;
using System.Text;
class Sad
{


    static double Sum(double num1, double num2)
    {
        double res = num1 + num2;
        return res;
    }
    static double Minus(double num1, double num2)
    {
        double res = num1 - num2;
        return res;
    }
    static double Mnog(double num1, double num2)
    {
        double res = num1 * num2;
        return res;
    }
    static double Dil(double num1, double num2) 
    {
        if (num2 == 0) 
        {
            Console.WriteLine("Error");
            return 0;
        }
        else 
        {
             double res = num1 / num2;
             return res; 
        }
    }
static void Main(string[] args)
    {
        double num1, num2, summa;
        string symv;
        Console.WriteLine("Введiть 1 число ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введiть символ (+, -, *, /): ");
        symv = Console.ReadLine();
        Console.WriteLine("Введiть 2 число ");
        num2 = Convert.ToDouble(Console.ReadLine());
        double result;
        switch (symv)
        {
            case "+":
                result = Sum(num1, num2);
                break;
            case "-":
                result = Minus(num1, num2);
                break;
            case "*":
                result = Mnog(num1, num2);
                break;
            case "/":
                result = Dil(num1, num2);
                break;
            default:
                Console.WriteLine("Невiрна операцiя!");
                return;
        }
        Console.WriteLine("Результат: " + num1 + " " + symv + " " + num2 + " is " + result + '.');

    }
}