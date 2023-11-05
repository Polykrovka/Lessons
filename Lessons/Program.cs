using System;
using System.Globalization; //Для конвертипования разных форматов

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heey");
            int myFirstVariable;
            myFirstVariable = 30;
            byte mySecondVariable = 2;
            Console.WriteLine(mySecondVariable);

            bool a, b;
            a = true;
            b = false; 

            double floatInt = 1.55;

            char oneSymbol =  '#';
            string justSctring = "I am learning C";

            myFirstVariable = 40;


            //string strFromConsole = Console.ReadLine();
            //Console.WriteLine(justSctring + oneSymbol + " а ты написал в консоль (" + strFromConsole + ')');
            Console.WriteLine("Ответ на главный вопрос " + (myFirstVariable + mySecondVariable));

            string strNumber = "404";
            int converted = Convert.ToInt32 (strNumber);
            int convertedSecond = int.Parse (strNumber);
            Console.WriteLine(converted + convertedSecond);

            string floatStringWithWrongFormat = "13.543";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            float confertedFloadWithDot = Convert.ToSingle(floatStringWithWrongFormat, numberFormatInfo);
            float F = float.Parse(floatStringWithWrongFormat, numberFormatInfo);
            Console.WriteLine(confertedFloadWithDot + F + " что бы получить дробное число нужно привести тип хотябы одного из операндов " +  mySecondVariable / (double)myFirstVariable);


            string wrongString = "14.564fdfsd43";
            double parseWrongString;
            bool success = double.TryParse(wrongString, out parseWrongString); //ошиьку не кинет, но значение будет по умолчвнию 0

            if (success )
            {
            Console.WriteLine(parseWrongString + " получилось");
            }
            else
            {
                Console.WriteLine(parseWrongString + " увы не получилось");
            }













        }
    }
}
