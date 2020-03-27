using System;
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

            int index = Array.IndexOf(Enum.GetValues(type.GetType()), type);
            switch (index)
            {
                case 0:
                    str += "\nИспользованный фрукт: Яблоко";
                    break;
                case 1:
                    str += "\nИспользованный фрукт: Груша ";
                    break;
                case 2:
                    str += "\nИспользованный фрукт: Вишня";
                    break;
                case 3:
                    str += "\nИспользованный фрукт: Апельсин";
                    break;
                case 4:
                    str += "\nИспользованный фрукт: Персик";
                    break;

            }
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

            int index = Array.IndexOf(Enum.GetValues(type.GetType()), type);
            switch (index)
            {
                case 0:
                    str += "\nВид:Coca-Cola";
                    break;
                case 1:
                    str += "\nВид:Pepsi";
                    break;
                case 2:
                    str += "\nВид:Sprie";
                    break;
                case 3:
                    str += "\nВид:Fanta";
                    break;
                case 4:
                    str += "\nВид:Mirinda";
                    break;
            }
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
    public enum AlcoType { Пиво,Водка,Вино,Шампанское,Виски};

    //для класса Alcohol - родительский класс  Drinks
    public class Alcohol : Drinks
    {
        public double alcoContent = 0;
        public  AlcoType type = 0; 

        public override String GetInfo()
        {
            var str = "Алкоголь";
            str += String.Format("\nКрепость: {0}", this.alcoContent);
            str += String.Format("\nТип: {0}", this.type);
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