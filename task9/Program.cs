//9cu tapsirigin helli
Console.Write("Cumleni yaz:");
int a = 0;
string sentence = Console.ReadLine();
for (int i = 0; i < sentence.Length; i++)
{
    if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
    {
        a++;
    }
}
Console.WriteLine($"Saitlerin sayi {a} ededdir");


