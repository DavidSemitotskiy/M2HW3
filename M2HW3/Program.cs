using System;

namespace M2HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BoxGift box = new BoxGift(new Candy[]
            {
                new СandyWithStuffing("Roshen", 123.2m, 12.4m, "daw"),
                new CandyWithAdditive("hhh", 111.3m, 12m, "da", "dadaw"),
                new DessertCandy("dAD", 1234.2m, 89.7m, "fse", "daw", true),
                new PorousCandy("jjj", 1231.5m, 212.12m, "none", "none", true, true),
                new PorousCandy("GGG", 123.5m, 212.12m, "none", "none", true, false),
                new PorousCandy("jjj", 1231.5m, 212.12m, "none", "none", true, true),
            });
            box.AddCandy(new DessertCandy("kkk", 154.1m, 32.3m, "карамельная", "пудра", true));
            Console.WriteLine("Массив до сортировки по цене");
            box.GetDescriptionGift();
            Array.Sort(box.Candies);
            Console.WriteLine("Массив после сортировки по цене");
            box.GetDescriptionGift();
            Child child = new Child("David", box);
            Console.WriteLine("Ребенок съел одну конфету:");
            child.EatCandy();
            child.LookAtGift();
            var candies = child.SearchDessertPorousCandy();
            if (candies == null || candies.Length == 0)
            {
                Console.WriteLine("Я не нашел дессертные, пористые конфеты");
            }
            else
            {
                Console.WriteLine("ОО, я нашел дессертные, пористые конфеты:");
                for (int i = 0; i < candies.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) Имя - {candies[i].Name} Цена - {candies[i].Price} Вес - {candies[i].GetWeight()}");
                }
            }

            child.PickUpGift();
        }
    }
}
