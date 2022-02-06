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
                new DessertCandy("jjj", 1234.2m, 89.7m, "fse", "daw", true),
                new PorousCandy("aaaaaa", 1233.4m, 19m, "none", "none", true, true),
                new PorousCandy("BBB", 12.4m, 21m, "none", "none", true, true),
                new PorousCandy("GGG", 133.4m, 18m, "none", "none", false, true)
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
            child.Gift.GetDescriptionGift();
            var candies = child.SearchDessertPorousCandy();
            Console.WriteLine("ОО, я нашел дессертные, пористые конфеты:");
            for (int i = 0; i < candies.Length; i++)
            {
                Console.WriteLine($"{i + 1}) Имя - {candies[i].Name} Цена - {candies[i].Price} Вес - {candies[i].GetWeight()}");
            }

            child.PickUpGift();
        }
    }
}
