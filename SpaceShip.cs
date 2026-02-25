using System;
using System.Collections.Generic;
using System.Text;

namespace sharp_lessons2
{
    internal class SpaceShip
    {
        private double _fuel;
        public List<CargoManifest> _cargoList;
        public readonly string Name;
        public Coordinates CurrentPosition;
        public double MaxCapacity;

        public SpaceShip(string name, double maxCapacity)
        {
            Name = name;
            MaxCapacity = maxCapacity;
            _fuel = 1000;
            _cargoList = new List<CargoManifest>();
            CurrentPosition = new Coordinates(0, 0, 0);
        }

        public SpaceShip(string name, double maxCapacity, Coordinates startPosition) : this(name, maxCapacity)
        {
            CurrentPosition = startPosition;
        }

        public void AddCargo(CargoManifest item)
        {
            double currentWeight = 0;
            foreach (var cargo in _cargoList)
            {
                currentWeight += cargo.Weight;
            }

            if (currentWeight + item.Weight <= MaxCapacity)
            {
                _cargoList.Add(item);
                Console.WriteLine($"Груз '{item.Name}' добавлен");
            }
            else
            {
                Console.WriteLine($"Ошибка: Превышен лимит веса");
            }
        }

        public void FlyTo(Coordinates newPosition)
        {
            double distance = CurrentPosition.GetDistance(newPosition);
            double fuelNeeded = distance / 10;

            if (_fuel >= fuelNeeded)
            {
                _fuel -= fuelNeeded;
                CurrentPosition = newPosition;
                Console.WriteLine($"Полет выполнен. Остаток топлива: {_fuel}");
            }
            else
            {
                Console.WriteLine("Ошибка: Недостаточно топлива");
            }
        }
    }
}
