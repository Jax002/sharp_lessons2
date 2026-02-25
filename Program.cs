
using sharp_lessons2;

Console.WriteLine("Старт");

//1. Створіть декілька об'єктів вантажу (Record). Спробуйте скопіювати один за допомогою ключового слова with, змінивши лише назву.
CargoManifest cargo1 = new CargoManifest("Еда", 150.5, "Продовольствия");
CargoManifest cargo2 = new CargoManifest("Вычислительная техника", 50.0, "Оборудвание");
CargoManifest cargo3 = new CargoManifest("Скафандры", 30, "Одежда");

CargoManifest cargo4 = cargo1 with { Name = "Вода" };
CargoManifest cargo5 = cargo2 with { Name = "Ноутбук" };

// 2.Створіть екземпляр корабля.
SpaceShip ship = new SpaceShip("Луна", 750.0);

//3. Додайте вантажі на корабель, перевіряючи, чи не перевищує загальна вага вантажів максимальну вантажопідйомність корабля.
ship.AddCargo(cargo1);
ship.AddCargo(cargo2);
ship.AddCargo(cargo3);
ship.AddCargo(cargo4);
ship.AddCargo(cargo5);


//4. Задайте початкові координати структурою та відправте корабель у політ до нової точки.
Coordinates startPos = new Coordinates(15, 4, 7);
ship.CurrentPosition = startPos;
Console.WriteLine($"Стартовая позиция: ({startPos.x}, {startPos.y}, {startPos.z})");


Coordinates target = new Coordinates(124, 231, 234);
ship.FlyTo(target);

//5. Виведіть інформацію про корабель, його поточні координати та список вантажів на борту.
Console.WriteLine($"Имя корабля: {ship.Name}");
Console.WriteLine($"Координаты корабля: ({ship.CurrentPosition.x}, {ship.CurrentPosition.y}, {ship.CurrentPosition.z})");

Console.WriteLine("Список грузов на корабле:");
foreach (CargoManifest cargo in ship._cargoList)
{
    Console.WriteLine($"  - {cargo.Name}");
}