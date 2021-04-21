using System;

//1.Имеется магазин с продуктами, менеджер может добавлять и удалять продукты из склада, также может видеть весь список товаров
// Покупатель, имеет 50$ на покупки, он может только покупать товары и просматривать весь перечень, примерный вид Название| Цена, $| Кол-во|,
//он может покупать определенное кол-во товаров, если его больше чем один. Стартовый набор товаров должен быть не менее 10.

namespace First
{
    internal partial class Start
    {
        private class Customer
        {
            public void ShowClientOptions()
            {
                int wallet = 50;
                var userReply = "y";

                while (userReply.ToLower() == "y")
                {
                    Console.WriteLine("Choose operation: buy item (1), show all items (2).");
                    var operation = Console.ReadLine();

                    switch (operation.ToLower())
                    {
                        case "1": wallet = BuyItem(wallet); break;
                        case "2": ShowAll(); break;
                        default: throw new ArgumentException($"Operation '{operation}' is not recognized.");
                    }

                    Console.WriteLine("Would you like to continue? Y/N");
                    userReply = Console.ReadLine();
                }
            }

            private int BuyItem(int wallet)
            {
                var userReply = "y";

                while (userReply.ToLower() == "y")
                {
                    Console.WriteLine("Please enter item's name: ");
                    var item = Console.ReadLine();

                    if (int.TryParse(item, out int wrongItem))
                    {
                        Console.WriteLine("There is no such item in the catalogue.");
                        break;
                    }

                    var boughtItem = String.Empty;

                    for (int x = _store.Count - 1; x >= 0; --x)
                    {
                        var forCheck = _store[x].ToLower().Replace("- ", "").Split(" ");

                        if (forCheck[0].ToLower() == item.ToLower())
                        {
                            boughtItem = _store[x];
                            _store.Remove(_store[x]);
                        }
                    }

                    if (boughtItem == "")
                    {
                        Console.WriteLine("There is no such item in the catalogue.");
                        break;
                    }

                    var itemValues = boughtItem.Replace("- ", "").Split(" ");

                    Console.WriteLine("How many items would you like to purchase?");
                    var quantity = int.Parse(Console.ReadLine());

                    if (quantity <= 0)
                    {
                        Console.WriteLine("At least 1 item should be indicated!");
                        _store.Add($"{itemValues[0]} - {itemValues[1]} - {itemValues[2]}");
                        break;
                    }
                    
                    if (!((int.Parse(itemValues[1]) * quantity) > wallet + 1))
                    {
                        wallet -= int.Parse(itemValues[1]) * quantity;
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money on your balance.");
                        _store.Add($"{itemValues[0]} - {itemValues[1]} - {itemValues[2]}");
                        break;
                    }

                    int newQuantity = int.Parse(itemValues[2]);

                    if (!(quantity > int.Parse(itemValues[2])))
                    {
                        newQuantity -= quantity;
                    }
                    else
                    {
                        Console.WriteLine("There are not enough items in the store.");
                        _store.Add($"{itemValues[0]} - {itemValues[1]} - {itemValues[2]}");
                        break;
                    }

                    _store.Add($"{itemValues[0]} - {itemValues[1]} - {newQuantity}");
                    Console.WriteLine($"You bought {quantity} {item}(-s). Your current balance is {wallet}.\nWould you like to continue shopping? Y/N");
                    userReply = Console.ReadLine();
                }

                return wallet;
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
