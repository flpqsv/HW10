using System;

//1.Имеется магазин с продуктами, менеджер может добавлять и удалять продукты из склада, также может видеть весь список товаров
// Покупатель, имеет 50$ на покупки, он может только покупать товары и просматривать весь перечень, примерный вид Название| Цена, $| Кол-во|,
//он может покупать определенное кол-во товаров, если его больше чем один. Стартовый набор товаров должен быть не менее 10.

namespace First
{
    internal partial class Start
    {
        public class Item
        {
            private string name { get; set; }
            private int price { get; set; }
            private int quantity { get; set; }

            public string InitializeItem() //same item name - exception
            {
                Console.WriteLine("Please enter the item's name: ");
                name = ValidateName();

                Console.WriteLine("Please enter the item's price: ");
                price = int.Parse(Console.ReadLine());

                Console.WriteLine("How many items do you want to add to the catalogue: ");
                quantity = int.Parse(Console.ReadLine());

                var item = $"{name} - {price} - {quantity}";

                return item;
            }

            private string ValidateName()
            {
                var name = Console.ReadLine();

                for (int x = _store.Count - 1; x >= 0; --x)
                {
                    var forCheck = _store[x].ToLower().Replace("- ", "").Split(" ");

                    if (forCheck[0].ToLower() == name.ToLower())
                        throw new ArgumentException($"Item with the '{name}' already exists in the catalogue.");
                }

                return name;
            }
        }
    }
}
