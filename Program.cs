using Restaurant;


List<Item> menuItems = new List<Item>
            {
                new Drink("Чай", 1.5),
                new Drink("Кофе", 2.0),
                new Snack("Суп", 3.0),
                new Snack("Второе", 4.0)
            };

Console.WriteLine("Меню ресторана:");
foreach (var item in menuItems)
{
    item.Display();
}