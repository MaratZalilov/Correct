Console.WriteLine($"Введите слово");
string select = Console.ReadLine();

void GetCounts()
{
    int count = 0;
    char[] char1 = new char[] { '!', '?', ' ','.',',' };
    foreach (char word in select)
    {
        foreach (char c in char1)
        {
            if (word == c)
            {
                break;
            }

            count++;
        }
    }
    Console.WriteLine($"{count}");
}
void GetConsonants()
{
    int count = 0;
    char[] sogl = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
    foreach (char word in select)
    {
        for (int i = 0; i < sogl.Length; i++)
        {
            if (word == sogl[i])
            {
                count++;
            }
        }
    }
    Console.WriteLine($"{count}");
}
void GetVowels() 
{
    int count1 = 0;
    char[] gl = new char[] { 'а', 'я', 'у', 'ю', 'о', 'е', 'ё', 'э', 'и', 'ы' };
    foreach (char word in select)
    {
        for (int j = 0; j < gl.Length; j++)
        {
            if (word == gl[j])
            {
                count1++;
            }
        }
    }
    Console.WriteLine($"{count1}");
}
void GetInfo()
{
    GetVowels();
    GetConsonants();
    GetCounts();
}
GetInfo();
