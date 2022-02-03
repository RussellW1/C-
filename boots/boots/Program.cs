using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace boots
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var mag = new Chainboot();
            MainMenu(mag);
           

        }

        public static void MainMenu(Chainboot mag)
        {
            Console.WriteLine("Выберете действие с магазинами");
            Console.WriteLine("1) Добавление магазина:");
            Console.WriteLine("2) Удаление магазина:");
            Console.WriteLine("3) Показать список магазинов:");
            Console.WriteLine("4) Перейти к выбору магазина:");
            Console.WriteLine("5) Выход.");

            

            switch (Console.ReadLine())
            {
                case "1":
                    mag.AddChain();
                    mag.ShowChain();
                    MainMenu(mag);
                    break;
                case "2":
                    mag.DeleteChain();
                    mag.ShowChain();
                    MainMenu(mag);
                    break;
                case "3":
                    mag.Spisok();
                    MainMenu(mag);
                    break;
                case "4":
                    Console.WriteLine("Введите номер магазина");
                    int setected = Convert.ToInt32(Console.ReadLine());
                    var tovar = mag.Chain.ElementAt(setected - 1);
                    Menu(tovar);
                    break;
                case "5":
                    break;

             }

          
        }

        public static void Menu(Magazine tov)
        {
            
            Console.WriteLine("Выберете действие с товаром");
            Console.WriteLine("1) Добавление товара:");
            Console.WriteLine("2) Редактирование товара:");
            Console.WriteLine("3) Удаление товара:");
            Console.WriteLine("4) Перейти в корзину:");
            Console.WriteLine("5) Показать список магазинов");
            Console.WriteLine("6) Выход.");

            var mag = new Chainboot();
            switch (Console.ReadLine())
            {
                case "1":
                    tov.AddMag();
                    tov.ShowMag();
                    Menu(tov);
                    break;
                case "2":
                    tov.RedactMag();
                    Menu(tov);
                    break;
                case "3":
                    tov.DeleteMag();
                    tov.ShowMag();
                    Menu(tov);
                    break;
                case "4":
                    tov.MegaBasket();
                    Menu(tov);
                    break;
                case "5":
                    MainMenu(mag);
                    break;
                case "6":
                    { break; }

            }
            
        }

        // Просмотр списка текущих магазинов, Выбор одного из магазинов с какими-либо действиями, Удаление по номеру, Редактирование магазина
        //  В магазине : вывод товара (бренд, модель, размер, цена за единицу, тип обуви( мужская, женская), количество, суммарную стоимость всей продукции, добвление товара в магазин(0 мужская, 1- женская) Удаление товара, редактирование товара.
    }
}
