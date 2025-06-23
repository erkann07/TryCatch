
bool input = false;
int kareAl(int sayi)
{
    return sayi * sayi;
}
while (!input)
{
    try
    {
        Console.Write("Bir sayı giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sayınızın karesi: " + kareAl(sayi));
        input = true;
    }
    catch(Exception ex)
    {
        Console.WriteLine("Hatalı veri girdiniz lütfen bir sayı giriniz.");
    }
}