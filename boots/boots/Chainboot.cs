using System;
using System.Collections.Generic;
using System.Linq;

namespace boots
{
    public class Chainboot // здесь надо попробовать переопределение методов Show, Add, delete
    {
        public List<Magazine> Chain { get; set; }

        public Chainboot ()
        {
            Chain = new List<Magazine>();
        }

        public void  ShowChain()
        {
            if (Chain.Count >0)
            {
                foreach (var chain in Chain) 
                { Console.WriteLine($" Название: {chain.Name}, Адресс: {chain.Adress}"); }
               
            }
            else
            {
                Console.WriteLine("Магазинов нету");
            }
        }
        public void  AddChain()
        {

            Console.WriteLine("Сколько магазинов:");

            int j = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < j; i++)

            {
                Magazine newMagazine = new Magazine();
                Console.WriteLine("Введите Название:");
                newMagazine.Name = Console.ReadLine();
                Console.WriteLine("Введите город:");
                newMagazine.Adress = Console.ReadLine();
                Chain.Add(newMagazine);
                ;

            }
        }

        public void DeleteChain()
        {


            if (Chain.Count > 0)
            {

                Console.WriteLine("Сколько салонов удалить:");

                int j = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < j; i++)
                {
                    Magazine userRem = Chain.FirstOrDefault(us => us.Name != null);
                    if (userRem != null)
                        Chain.Remove(userRem);
                }
                ShowChain();
            }
            else
            {
                Console.WriteLine("Нету салонов");
            }

        }

        public void Spisok()
        {
            if (Chain.Count ==0)
            {
                Console.WriteLine("Магазинов нету");
            }
            else
            {
                foreach(var mag in Chain)
                {
                    Console.WriteLine($"Название: {mag.Name}, Адресс: {mag.Adress}");
                    if(mag.Tovar.Count == 0)
                    {
                        Console.WriteLine("Товара нету");
                    }
                    else
                    {
                        mag.ShowMag();
                    }
                }
            }
        }
    }
    // Просмотр списка текущих магазинов, Выбор одного из магазинов с какими-либо действиями, Удаление по номеру, Редактирование магазина
    //  В магазине : вывод товара (бренд, модель, размер, цена за единицу, тип обуви( мужская, женская), количество, суммарную стоимость всей продукции, добвление товара в магазин(0 мужская, 1- женская) Удаление товара, редактирование товара.
}
