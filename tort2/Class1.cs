using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tortik
{
    internal class css1
    {
        string buyFile = "C:\\Users\\Onya\\OneDrive\\Рабочий стол\\eee.txt";
        css2 arrow = new css2();
        private int sum = 0;
        ConsoleKeyInfo kay = Console.ReadKey();
        public int menu()
        {
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер тора");
            Console.WriteLine("  Вкус торта");
            Console.WriteLine("  Колличество тортов");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Завершить заказ");
            int pos = arrow.strelka();
            return pos;
        }
        public void menuForma()
        {
            int priceF1 = 500;
            int priceF3 = 750;
            Console.WriteLine("   1. Круглый" + "-" + priceF1);
            Console.WriteLine("   2. Квадратный" + "-" + priceF1);
            Console.WriteLine("   2. Седречко" + "-" + priceF3);
            arrow.strelka();
            int pos = arrow.strelka();
            arrow.strelka();
            if (kay.Key != ConsoleKey.Enter)
            {
                if (pos == 0)
                {
                    sum += priceF1;
                    File.AppendAllText(buyFile, "Круглый");
                }
                else if (pos == 1)
                {
                    sum += priceF1;
                    File.AppendAllText(buyFile, "Квадратный");
                }
                else
                {
                    sum += priceF3;
                    File.AppendAllText(buyFile, "Седречко");
                }
            }
        }
        public void menuRazmer()
        {
            int priceR1 = 150;
            int priceR2 = 250;
            int priceR3 = 350;
            Console.WriteLine("   1. Маленький (Диаметр - 15см)" + "-" + priceR1);
            Console.WriteLine("   1. Средний (Диаметр - 22см)" + "-" + priceR2);
            Console.WriteLine("   2. Большой (Диаметр - 30см)" + "-" + priceR3);
            arrow.strelka();
            int pos = arrow.strelka();
            if (kay.Key != ConsoleKey.Enter)
            {
                if (pos == 0)
                {
                    sum += priceR1;
                    File.AppendAllText(buyFile, ", маленький");
                }
                else if (pos == 1)
                {
                    sum += priceR2;
                    File.AppendAllText(buyFile, ", средний");
                }
                else
                {
                    sum += priceR3;
                    File.AppendAllText(buyFile, ", большой");
                }
            }
        }
        public void menuVkus()
        {
            int priceV1 = 100;
            int priceV2 = 300;
            int priceV3 = 250;
            Console.WriteLine("   1. Ванильный" + "-" + priceV1);
            Console.WriteLine("   2. Клубничный" + "-" + priceV2);
            Console.WriteLine("   2. Шоколадный" + "-" + priceV3);
            arrow.strelka();
            int pos = arrow.strelka();
            if (kay.Key != ConsoleKey.Enter)
            {
                if (pos == 0)
                {
                    sum += priceV1;
                    File.AppendAllText(buyFile, ", ванильный");
                }
                else if (pos == 1)
                {
                    sum += priceV2;
                    File.AppendAllText(buyFile, ", клубничный");

                }
                else
                {
                    sum += priceV3;
                    File.AppendAllText(buyFile, ", шоколадный");
                }
            }
        }
        public void menuKolichestvo()
        {
            int priceK1 = 400;
            int priceK2 = 750;
            int priceK3 = 925;
            Console.WriteLine("   1 торт" + "-" + priceK1);
            Console.WriteLine("   2 торт" + "-" + priceK2);
            Console.WriteLine("   3 торта" + "-" + priceK3);
            arrow.strelka();
            int pos = arrow.strelka();
            if (kay.Key != ConsoleKey.Enter)
            {
                if (pos == 0)
                {
                    sum += priceK1;
                    File.AppendAllText(buyFile, ", 1 торт");
                }
                else if (pos == 1)
                {
                    sum += priceK2;
                    File.AppendAllText(buyFile, ", 2 торта");
                }
                else
                {
                    sum += priceK3;
                    File.AppendAllText(buyFile, ", 3 торта");
                }
            }
        }
        public void menuGlazur()
        {
            int priceG1 = 400;
            int priceG2 = 100;
            int priceG3 = 250;
            Console.WriteLine("   1. Карамельная поливка" + "-" + priceG1);
            Console.WriteLine("   2. Крем" + "-" + priceG2);
            Console.WriteLine("   3. Жидкий шоколад" + "-" + priceG3);
            arrow.strelka();
            int pos = arrow.strelka();
            if (pos > 2)
            {
                pos = 2;
            }
            if (kay.Key != ConsoleKey.Enter)
            {
                if (pos == 0)
                {
                    sum += priceG1;
                    File.AppendAllText(buyFile, ", карамельная поливка");
                }
                else if (pos == 1)
                {
                    sum += priceG1;
                    File.AppendAllText(buyFile, ", карамельная поливка");
                }
                else
                {
                    sum += priceG2;
                    File.AppendAllText(buyFile, ", жидкий шоколад");
                }
            }
        }
        public void menuDekor()
        {
            int priceD1 = 150;
            int priceD2 = 350;
            int priceD3 = 500;
            Console.WriteLine("   1. Шоколадная посыпка" + "-" + priceD1);
            Console.WriteLine("   2. Ягоды" + "-" + priceD2);
            Console.WriteLine("   3. Сладкие фотографии" + "-" + priceD3);
            arrow.strelka();
            int pos = arrow.strelka();
            if (kay.Key != ConsoleKey.Enter)
            {
                if (pos == 0)
                {
                    sum += priceD1;
                    File.AppendAllText(buyFile, ", шоколадная посыпка");
                }
                else if (pos == 1)
                {
                    sum += priceD2;
                    File.AppendAllText(buyFile, ", ягоды");
                }
                else
                {
                    sum += priceD3;
                    File.AppendAllText(buyFile, ", сладкие фотографии");
                }
            }
        }
        public void exit()
        {

            File.AppendAllText(buyFile, Environment.NewLine);
            string s1 = sum.ToString();
            DateTime data = DateTime.Now;
            File.AppendAllText(buyFile, "Текущая дата:" + data);
            File.AppendAllText(buyFile, Environment.NewLine);
            File.AppendAllText(buyFile, "Цена заказа:" + s1);
            File.AppendAllText(buyFile, Environment.NewLine);
            File.AppendAllText(buyFile, Environment.NewLine);
            sum = 0;
        }
    }
}

