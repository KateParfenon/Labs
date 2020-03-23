using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        //Типа очередь напитков
        List<Drinks> drinksList = new List<Drinks>();
        public Form1()
        {
            InitializeComponent();
            //Чтобы при загрузке сразу стояли нолики
            ShowInfo();
        }
        //кнопка заполнить
        private void BtnFill_Click(object sender, EventArgs e)
        {
            //Если был предыдущий список,его очищаем
            this.drinksList.Clear();
            var rnd = new Random();
            //Автомат на 10 напитков , рандомно добавляем напитки в список
            for (var i = 0; i < 10; ++i)
            {
                //всего 3 арианта напитков
                switch (rnd.Next() % 3) 
                {
                    case 0:
                        this.drinksList.Add(Juice.Generate());
                        break;
                    case 1:
                        this.drinksList.Add(Soda.Generate());
                        break;
                    case 2:
                        this.drinksList.Add(Alcohol.Generate());
                        break;

                }
            }
            //чтобы при заполнении показывалость сразу какой напиток следующий
            var Queue = this.drinksList[0];
            if (Queue is Juice)
            {
                txtQueue.Text = "Следующий напиток: Сок";
            }
            else if (Queue is Soda)
            {
                txtQueue.Text = "Следующий напиток: Газировка";
            }
            else if (Queue is Alcohol)
            {
                txtQueue.Text = "Следующий напиток: Алкоголь";
            }
            //Инфа о количестве нпитков
            ShowInfo();
        }

        private void ShowInfo()
        {
            //счетчики для напитков
            int JuiceCount = 0;
            int SodaCount = 0;
            int AlcoholCount = 0;

          //Проеряем каждый элемент
            foreach (var drink in this.drinksList)
            {
                //Если он сок то добавляем к счетчику 1
                if (drink is Juice) 
                {
                    JuiceCount += 1;
                }
                //Если газировка то... и т.д
                else if (drink is Soda)
                {
                    SodaCount += 1;
                }
                else if (drink is Alcohol)
                {
                    AlcoholCount += 1;
                }
            }
            //по итогу почситаи сколько чего в автомате
            //и вывели на форму
            txtInfo.Text = "Сок\tСода\tАлкоголь"; 
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", JuiceCount, SodaCount, AlcoholCount);
        }
        //кнопка взять
        private void BtnGet_Click(object sender, EventArgs e)
        {
            //Если количество элементов в списке 0 то напитков нет то пишем что их нет
            if (this.drinksList.Count == 0)
            {
                txtOut.Text = "Автомат пустой,заполните.";
                txtQueue.Text = "";
                return;
            }
            var Drinks = this.drinksList[0];

           //Если элементов 1 то он последний и нужно убирать уже очередь

            if (this.drinksList.Count == 1)
            {
                txtQueue.Text = "Это последний напиток в автомате";
                
            }
            //Если еще не 1 элемент то проверяем следующий и пишем какой он
            else
            {
                var Queue = this.drinksList[1];
                if (Queue is Juice)
                {
                    txtQueue.Text = "Следующий напиток: Сок";
                }
                else if (Queue is Soda)
                {
                    txtQueue.Text = "Следующий напиток: Газировка";
                }
                else if (Queue is Alcohol)
                {
                    txtQueue.Text = "Следующий напиток: Алкоголь";
                }
            }
            //убираем  первый элемент
            
            this.drinksList.RemoveAt(0);
            //Показываем его свойства
            txtOut.Text = Drinks.GetInfo();
            //Обновляем инфу о наличии напитков
            ShowInfo();
        }
    }
}


