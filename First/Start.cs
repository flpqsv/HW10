using System.Collections.Generic;
using System.Linq;
using System.Data;

//1.Имеется магазин с продуктами, менеджер может добавлять и удалять продукты из склада, также может видеть весь список товаров
// Покупатель, имеет 50$ на покупки, он может только покупать товары и просматривать весь перечень, примерный вид Название| Цена, $| Кол-во|,
//он может покупать определенное кол-во товаров, если его больше чем один. Стартовый набор товаров должен быть не менее 10.

namespace First
{
    internal partial class Start
    {
        private static readonly List <string> _store = new List <string>();
        private static readonly string  password = "manager123";

        private class MainActions
        {
            public static void Main(string[] args)
            {
                var store = new Store();

                store.WelcomeMenu();
            }
        }
    }
}
