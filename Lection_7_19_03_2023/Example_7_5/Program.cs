// Задача 5. В некотором машинном алфавите имеются четыре буквы:
//  "а", "и", "с" и "в".
// Покажите все слова, состоящие из Т букв,
// которые можно построить из бкув этого алфавита.

char[] s = {'а', 'и', 'с', 'в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for(int j = 0; j < count; j++)
    {
        System.Console.WriteLine($"{n++, -5} {s[i]} {s[j]}");
    }
}

System.Console.WriteLine();

int t = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
    if(length == word.Length)
    {
        System.Console.WriteLine($"{t++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);