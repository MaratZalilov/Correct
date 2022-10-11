Console.WriteLine($"Введите слово");
string select = Console.ReadLine();

void GetCounts()
{
    bool a = false;
    int count = 0;
    char[] char1 = new char[] { '!', '?', ' ','.',',' };
    foreach (char word in select)
    {
        foreach (char c in char1)
        {
            if (word == c)
            {
                a = true;
                
            }
           
            
        }
        if(a == false) 
        { 
            count++; 
        }
        a = false;
    }
    Console.WriteLine($"Количество букв в слове - {count}");
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
    Console.WriteLine($"Количество согласных в слове - {count}");
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
    Console.WriteLine($"Количество гласных в слове - {count1}");
}
void GetInfo()
{
    GetVowels();
    GetConsonants();
    GetCounts();
}
GetInfo();
