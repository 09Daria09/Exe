using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.Input();
        }
        class Card
        {
            private string name;
            private string numberCard;
            private string cvc;
            private int dateCompletionM;
            private int dateCompletionY;
            public Card()
            {
                name = null;
                numberCard = null;
                cvc = null;
                dateCompletionM = 0;
                dateCompletionY = 0;
            }
            public string Name
            {
                get => name;
                set => name = value;
            }
            public string NumberCard
            {
                get => numberCard;
                set => numberCard = value;
            }
            public string Cvc
            {
                get => cvc;
                set => cvc = value;
            }
            public int DateCompletionM
            {
                get => dateCompletionM;
                set => dateCompletionM = value;
            }
            public int DateCompletionY
            {
                get => dateCompletionY;
                set => dateCompletionY = value;
            }
            public void Input()
            {
                try
                {
                    Console.Write("Введите номер карты: ");
                    numberCard = Console.ReadLine();
                    char[] num = numberCard.ToCharArray();
                    if (num.Length != 16)
                        throw new Exception("!!!Неправильный номер карты!!!");
                    for (int i = 0; i < num.Length; i++)
                    {
                        bool index = char.IsLetter(numberCard, i);
                        if(index == true)
                            throw new Exception("!!!Неправильный номер карты, вы ввели букву!!!");
                    }

                    Console.Write("Введите ФИО: ");
                    name = Console.ReadLine();

                    Console.Write("Введите CVC: ");
                    cvc = Console.ReadLine();
                    char[] numCvc = cvc.ToCharArray();
                    if (numCvc.Length != 3)
                        throw new Exception("!!!Неправильный номер CVC!!!");

                    for (int i = 0; i < numCvc.Length; i++)
                    {
                        bool index = char.IsLetter(cvc, i);
                        if (index == true)
                            throw new Exception("!!!Неправильный номер карты, вы ввели букву!!!");
                    }

                    Console.Write("Введите дату завершения работы карты \n месяц: ");
                    dateCompletionM = Convert.ToInt32(Console.ReadLine());
                    if (dateCompletionM > 12 || dateCompletionM < 1)
                        throw new Exception("!!!Неправильный месяц!!!");

                    Console.Write("год: ");
                    dateCompletionY = Convert.ToInt32(Console.ReadLine());
                    if (dateCompletionY > 2027 || dateCompletionY < 2022)
                        throw new Exception("!!!Неправильный год!!!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            public override string ToString()
            {
                return $"Номер карты: {numberCard}\nФИО: {name}\nCVC: {cvc}\nДата завершения работы карты: {dateCompletionM}/{dateCompletionY}";
            }
        }
    }
}

