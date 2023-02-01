var cars = new List<Car>
{
    new ("Жигули", "Красный", 12345),
    new ("Мерседес", "Голубой", 60543),
    new ("Тайота", "Чёрный", 21345),
    new ("Хёндай", "Голубой", 22000),
    new ("Хонда", "Желтый", 350000),

};

var groups = from car in cars
             group car by car.Colour;

foreach (var group in groups)
{
    Console.WriteLine(group.Key);

    foreach (var car in group)
    {
        Console.WriteLine($" {car.Name} {car.Price}");
    }
}

record Car(string Name, string Colour, int Price);
//не смог сделать с пересечением, поэтому просто решил показать метод группировки 