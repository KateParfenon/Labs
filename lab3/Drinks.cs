﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab3
{
    //тут перечислили фрукты
    public enum FruitType
    {
        Apple  , Pear  , Cherry  , Orange , Peach
    };

    //для класса Juice - родительский класс  Drinks
    public class Juice : Drinks
    {
       
        //Свойства из какого фрукта и наличие мякоти
        public FruitType type =0; 
        public bool pulp = false;

        //Переопределяем GetInfo 
        public override String GetInfo()
        {
            
            var str = "Сок";

            var mapping = new Dictionary<FruitType, String> //Не получалось,потому что писала String string или int string и пыталась индексы связать
            {
                [FruitType.Apple] = "\nИспользованный фрукт: Яблоко",
                [FruitType.Pear] = "\nИспользованный фрукт: Груша ",
                [FruitType.Cherry] = "\nИспользованный фрукт: Вишня",
                [FruitType.Orange] = "\nИспользованный фрукт: Апельсин",
                [FruitType.Peach] = "\nИспользованный фрукт: Персик",
            };
            str += mapping[type];

            if (pulp == true)
            {
                str += "\nС мякотью";
            }
            else
            { 
            str += "\nБез мякоти";
            }
            str += String.Format("\nОбъём: {0}", this.volume);

            return str;
        }

        //Генерируем значения для Juice 
        public static Juice Generate()
        {
            //Список возможных объемов
            List<string> volumes = (new string[] { "0,33 л", "0,5 л", "0,75 л", "1 л", "1,5 л" }).ToList();

            //возвращаем новый Juice с рандомными свойствами 
            return new Juice
            {
                //фрукт берем из enum (там 5 элементов)
                type = (FruitType)rnd.Next(5),
                // Мякоть выбираем из вариантов есть\нет) поэтому 2
                pulp = rnd.Next() % 2 == 0 ,
                //Рандомно из листа объемов
                volume = volumes[rnd.Next(volumes.Count)]
            };
        }
    }
    //Дальльше все так же,не буду повторяться 
    public enum SodaType { Coca_Cola, Pepsi, Sprie, Fanta, Mirinda };

    //для класса Soda - родительский класс  Drinks
    public class Soda : Drinks
    {
        public SodaType type = 0; 
        public int bubbles = 0;

        
        public override String GetInfo()
        {
            var str = "Газировка";

            var mapping = new Dictionary<SodaType, String> //Не получалось,потому что писала String string или int string и пыталась индексы связать
            {
                [SodaType.Coca_Cola] = "\nВид:Coca-Cola",
                [SodaType.Pepsi] = "\nВид:Pepsi",
                [SodaType.Sprie] = "\nВид:Sprie",
                [SodaType.Fanta] = "\nВид:Fanta",
                [SodaType.Mirinda] = "\nВид:Mirinda",
            };
            str += mapping[type];
            str += String.Format("\nКоличество пузыриков: {0}", this.bubbles);
            str += String.Format("\nОбъём: {0}", this.volume);
            return str;
        }
        public static Soda Generate()
        {
            List<string> volumes = (new string[] { "0,3 л", "0,5 л", "0,75 л", "1 л", "1,5 л" }).ToList();

            return new Soda
            {
                type = (SodaType)rnd.Next(5),
                bubbles = rnd.Next() % 100,
                volume = volumes[rnd.Next(volumes.Count)]
        };
        }
    }
    public enum AlcoType { Bear,Vodka,Wine, Champagne, Whiskey };

    //для класса Alcohol - родительский класс  Drinks
    public class Alcohol : Drinks
    {
        public double alcoContent = 0;
        public  AlcoType type = 0; 

        public override String GetInfo()
        {
            var str = "Алкоголь";
            var mapping = new Dictionary<AlcoType, String> 
            {
                [AlcoType.Bear] = "\nТип:Пиво",
                [AlcoType.Vodka] = "\nТип:Водка",
                [AlcoType.Wine] = "\nТип:Вино",
                [AlcoType.Champagne] = "\nТип:Шампанское",
                [AlcoType.Whiskey] = "\nТип:Виски",
            };
            str += mapping[type];
            str += String.Format("\nОбъём: {0}", this.volume);
            return str;
        }
        public static Alcohol Generate()
        {
            List<string> volumes = (new string[] { "0,33 л", "0,5 л", "0,75 л", "1 л", "1,5 л" }).ToList();
            return new Alcohol
            {
                type = (AlcoType)rnd.Next(5),
                alcoContent = rnd.Next() % 95,
                volume = volumes[rnd.Next(volumes.Count)]
            };
        }
    }
    //Родительский класс
    public class Drinks
    {
        //Общее свойство для всех напитков
        public  string volume;
        //Чтобы каждый раз новый рандом не создавать,чтобы значения разные были
        protected static Random rnd = new Random();
        //Метод выдает информацию о напитке
        public virtual String GetInfo()
        {
            return "";
        }
    }
}