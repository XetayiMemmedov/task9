//9cu tapsirigin helli
using System.Text;

//Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.Write("Cumleni yaz:");
int a = 0;
string sentence = Console.ReadLine();
Console.WriteLine(sentence);
for (int i = 0; i < sentence.Length; i++)
{
    if (sentence[i] == 'a' || sentence[i] == 'ə' || sentence[i] == 'ü' || sentence[i] == 'ı' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u' || sentence[i]=='e')
    {
        a++;
    }
}
Console.WriteLine($"Saitlerin sayi {a} ededdir");


