using System;

//1.Имеется магазин с продуктами, менеджер может добавлять и удалять продукты из склада, также может видеть весь список товаров
// Покупатель, имеет 50$ на покупки, он может только покупать товары и просматривать весь перечень, примерный вид Название| Цена, $| Кол-во|,
//он может покупать определенное кол-во товаров, если его больше чем один. Стартовый набор товаров должен быть не менее 10.

namespace First
{
    internal partial class Start
    {
        private class Manager
        {
            public void ShowManagerOptions()
            {
                var userReply = "y";

                while (userReply.ToLower() == "y")
                {
                    Console.WriteLine("Choose operation: add item (1), remove item (2), show all items (3).");
                    var operation = Console.ReadLine();

                    switch (operation.ToLower())
                    {
                        case "1": AddItem(); break;
                        case "2": RemoveItem(); break;
                        case "3": ShowAll(); break;
                        default: throw new ArgumentException($"Operation '{operation}' is not recognized.");
                    }

                    Console.WriteLine("Would you like to continue? Y/N");
                    userReply = Console.ReadLine();
                }
            }

            private void AddItem()
            {
                var item = new Item();

                _store.Add(item.InitializeItem());
            }

            private void RemoveItem()
            {
                Console.WriteLine("Please enter item's name: ");
                var item = Console.ReadLine();

                for (int x = _store.Count - 1; x >= 0; --x)
                    if (_store[x].ToLower().Contains(item.ToLower()))
                    {
                        _store.Remove(_store[x]);
                        Console.WriteLine($"{item} was removed from the catalogue.");
                    }
            }

            private void ShowAll()
            {
                Console.WriteLine("Name - Price $ - Q-ty");

                foreach (var x in _store)
                    Console.WriteLine(x);
            }
        }
    }
}
