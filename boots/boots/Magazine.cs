using System;
using System.Collections.Generic;
using System.Linq;


namespace boots
{
    public class Magazine
    {
        public List<Tovar> Tovar { get; set; }

        public string Name { get; set; }
        public string Adress { get; set; }
        public Magazine()
        {
            Tovar = new List<Tovar>();
        }

        public void ShowMag()
        {
            if (Tovar.Count==0)
            {
                Console.WriteLine("Товара нету");
            }
            else
            {
                foreach (Tovar tovars in Tovar)
                {
                    Console.WriteLine($"Бренд: {tovars.Brend}, Модель: {tovars.Model}, Цена: {tovars.Price}, Тип обуви: {tovars.Type}, Количество: {tovars.Kolvo}");
                }
            }
        }

        public void AddMag()
        {
            Console.WriteLine("Сколько пар обуви:");
            int j = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < j; i++)

            {
                Tovar newTovar = new Tovar();
                Console.WriteLine("Введите бренд:");
                newTovar.Brend = Console.ReadLine();
                Console.WriteLine("Введите модель:");
                newTovar.Model = Console.ReadLine();
                Console.WriteLine("Введите цену:");
                newTovar.Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите тип обуви:");
                newTovar.Type = Console.ReadLine();
                Console.WriteLine("Введите количество:");
                newTovar.Kolvo = (uint)Convert.ToInt16(Console.ReadLine());
                Tovar.Add(newTovar);

            }
        }

        public void DeleteMag()
        {
            if (Tovar.Count > 0)
            {

                Console.WriteLine("Сколько позиций обуви удалить:");

                int j = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < j; i++)
                {
                    var userRem = Tovar.FirstOrDefault(us => us.Price > 0);
                    if (userRem != null)
                        Tovar.Remove(userRem);
                }
                ShowMag();
            }
            else
            {
                Console.WriteLine("Нету обуви");
            }
        }

        public int Basket()
        {
            ShowMag();
            
                Console.WriteLine("Введите номер товара для покупки:");
                int vibor = Convert.ToInt32(Console.ReadLine());
                var sum = Tovar.ElementAt(vibor - 1);
                Console.WriteLine("Введите количество товара:");
                int kol = Convert.ToInt32(Console.ReadLine());
                int pokupka = 0;
                           for (int i = 0; i < kol; i++)
             {
                   sum.Kolvo--;
                    pokupka += sum.Price;
                
              }
            return pokupka;
          
        }

        public void MegaBasket()
        {
           
            int summa = 0, ochered = Basket();
            Console.WriteLine("Покупки закончены? Введите yes/no:");
           
            switch (Console.ReadLine())
            {
                case "yes":   
                    break;
                case "no":
                    MegaBasket();
                    break;
            }
           
            summa += ochered;
            Console.WriteLine($"Сумма составляет: " + summa);
        }

        
        public void RedactMag()
        {
            Console.WriteLine("Введите номер товара:");
            int setected = Convert.ToInt32(Console.ReadLine());
            var tov = Tovar.ElementAt(setected - 1);
            Tovar.Remove(tov);
            Console.WriteLine("Введите бренд:");
            tov.Brend = Console.ReadLine();
            Console.WriteLine("Введите модель:");
            tov.Model = Console.ReadLine();
            Console.WriteLine("Введите цену:");
            tov.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите тип обуви:");
            tov.Type = Console.ReadLine();
            Console.WriteLine("Введите количество:");
            tov.Kolvo = (uint)Convert.ToInt16(Console.ReadLine());
            Tovar.Add(tov);
            ShowMag();
        }
        
    }

    // Просмотр списка текущих магазинов, Выбор одного из магазинов с какими-либо действиями, Удаление по номеру, Редактирование магазина
    //  В магазине : вывод товара (бренд, модель, размер, цена за единицу, тип обуви( мужская, женская), количество, суммарную стоимость всей продукции, добвление товара в магазин(0 мужская, 1- женская) Удаление товара, редактирование товара.
}
