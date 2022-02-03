namespace boots
{
    public class Tovar
    {
        public string Brend { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public uint Kolvo { get; set; }
        public int Summa { get; set; }

    }
    // Просмотр списка текущих магазинов, Выбор одного из магазинов с какими-либо действиями, Удаление по номеру, Редактирование магазина
    //  В магазине : вывод товара (бренд, модель, размер, цена за единицу, тип обуви( мужская, женская), количество, суммарную стоимость всей продукции, добвление товара в магазин(0 мужская, 1- женская) Удаление товара, редактирование товара.
}
