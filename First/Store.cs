using System;

//1.Имеется магазин с продуктами, менеджер может добавлять и удалять продукты из склада, также может видеть весь список товаров
// Покупатель, имеет 50$ на покупки, он может только покупать товары и просматривать весь перечень, примерный вид Название| Цена, $| Кол-во|,
//он может покупать определенное кол-во товаров, если его больше чем один. Стартовый набор товаров должен быть не менее 10.

namespace First
{
    internal partial class Start
    {
        private class Store
        {
            public void WelcomeMenu()
            {
                CreateCatalogue();

                Console.WriteLine("Helllo!!!!!!!");
                var customer = new Customer();
                var manager = new Manager();

                while (true)
                {
                    Console.WriteLine("Are you a client (C) or a manager (M)?");
                    var userInput = Console.ReadLine();

                    if (userInput.ToLower() == "c")
                        customer.ShowClientOptions();
                    else if (userInput.ToLower() == "m")
                        if (ValidateManager())
                            manager.ShowManagerOptions();
                        else
                            Console.WriteLine("Wrong password. Please try again.");
                    else
                        Console.WriteLine($"Invalid operation {userInput}. Please try again.");
                }
            }

            private bool ValidateManager()
            {
                Console.WriteLine("Please enter the password: ");
                var managerPassword = Console.ReadLine();

                return managerPassword == password;
            }

            private static void CreateCatalogue()
            {
                _store.Add("Towel - 5 - 3");
                _store.Add("Bag - 8 - 2");
                _store.Add("Shoes - 10 - 12");
                _store.Add("Jeans - 12 - 6");
                _store.Add("Hat - 3 - 2");
                _store.Add("Blouse - 9 - 7");
                _store.Add("Gloves - 2 - 3");
                _store.Add("Sunglasses - 9 - 1");
                _store.Add("Skirt - 4 - 4");
                _store.Add("Socks - 14 - 1");
            }
        }
    }
}
