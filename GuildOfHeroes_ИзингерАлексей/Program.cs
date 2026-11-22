Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");

// Самостоятельная часть: склад гильдии, класс Product
Console.WriteLine();
Console.WriteLine(">>> Склад гильдии <<<");

Product healingPotion = new Product("   Зелье лечения   ", 50, 10);
Product ropeCoil = new Product("Моток верёвки", 20, 3);
Product brokenStock = new Product("   ", -5, -3);

Console.WriteLine($"Создание: [{healingPotion.Title}], цена {healingPotion.Price}, на складе {healingPotion.Quantity}");
Console.WriteLine($"Создание: [{ropeCoil.Title}], цена {ropeCoil.Price}, на складе {ropeCoil.Quantity}");
Console.WriteLine($"Неверные данные: [{brokenStock.Title}], цена {brokenStock.Price}, на складе {brokenStock.Quantity}");

bool sold = healingPotion.Sell(4);
Console.WriteLine($"Продажа 4 шт.: {sold}, осталось {healingPotion.Quantity}");

bool soldTooMany = healingPotion.Sell(100);
Console.WriteLine($"Продажа 100 шт.: {soldTooMany}, осталось {healingPotion.Quantity}");

bool soldRest = healingPotion.Sell(6);
Console.WriteLine($"Продажа остатка 6 шт.: {soldRest}, осталось {healingPotion.Quantity}");

healingPotion.Restock(25);
healingPotion.Restock(-5);
healingPotion.Restock(2147483647);
Console.WriteLine($"Пополнение 25, затем -5 и 2147483647: на складе {healingPotion.Quantity}");

bool priceChanged = healingPotion.ChangePrice(65);
bool priceRejected = healingPotion.ChangePrice(0);
Console.WriteLine($"Новая цена 65: {priceChanged}; цена 0: {priceRejected}; итоговая цена {healingPotion.Price}");

Console.WriteLine($"Моток верёвки без изменений: цена {ropeCoil.Price}, на складе {ropeCoil.Quantity}");
