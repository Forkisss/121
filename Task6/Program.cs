
using Task6;

Address myAddress = new Address();


myAddress.Index = "07445";
myAddress.Country = "Україна";
myAddress.City = "Нова Каховка";
myAddress.Street = "Істроична";
myAddress.House = "35";
myAddress.Apartment = "10";


Console.WriteLine("Індекс: " + myAddress.Index);
Console.WriteLine("Країна: " + myAddress.Country);
Console.WriteLine("Місто: " + myAddress.City);
Console.WriteLine("Вулиця: " + myAddress.Street);
Console.WriteLine("Будинок: " + myAddress.House);
Console.WriteLine("Квартира: " + myAddress.Apartment);