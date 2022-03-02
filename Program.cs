
Console.WriteLine("Введите адрес");
string adres = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите длину здания");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину здания");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту здания");
int high = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите этажность здания");
int floor = Convert.ToInt32(Console.ReadLine());
Building building = new Building(adres, length, width, high);
MultiBuilding multiBuilding = new MultiBuilding(adres, length, width, high, floor);
Console.WriteLine(multiBuilding.Print());


class Building
{
    string adres { get; set; }
    int length { get; set; }
    int width { get; set; }
    int high { get; set; }

    public Building(string adres, int length, int width, int high)
    { 
    this.adres = adres;
    this.length = length;
    this.width = width;
    this.high = high;
    }

    public string Print()
    {
        return $"Адрес здания: {adres}\nДлина здания: {length} \nШирина здания: {width} \nВысота здания: {high}";
    }

}
class MultiBuilding : Building
{
    public int floor { get; set; }
    public MultiBuilding(string adres, int length, int width, int high, int floor)
        : base(adres, length, width, high)
    {
        this.floor = floor;
    }
    public string Print()
    {
        string result = base.Print();
        result += $"\nЭтажность: {floor}";
        return result;
    }
}