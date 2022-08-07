using System;

namespace Homework.Homework1
{
    public class Task3

    {
        static void Main(string[] args)
        {
            String _stringNumber;

            int _intNumber;
            int _numberFactorial = 1;
            int _sumNumbers = 0;
            int _maxEvenNumber = 0;

            string startProgram = "Здравствуйте вас приветствует математическая программа";
            string entryNumber = "Пожалуйста введите число.";
            string quitProgram = "q";
            string textNumberFactorial = "Факториал равен ";
            string textSumNumbers = "Сумма от 1 до N равна ";
            string textMaxEvenNumber = "Максимальное четное число меньше N равно";

            Console.WriteLine(startProgram);
            Console.WriteLine(entryNumber);

            _stringNumber = Console.ReadLine();

            if (_stringNumber == quitProgram)
            {
                return;
            }

            _intNumber = Int32.Parse(_stringNumber);

            for (int i = 1; i <= _intNumber; i++)
            {
                _numberFactorial = _numberFactorial * i;
                _sumNumbers = _sumNumbers + i;
                if (i % 2 == 0)
                {
                    _maxEvenNumber = i;
                }
            }

            Console.WriteLine(textNumberFactorial + _numberFactorial);
            Console.WriteLine(textSumNumbers + _sumNumbers);
            Console.WriteLine(textMaxEvenNumber + _maxEvenNumber);
            Console.ReadLine();
        }
    }
}