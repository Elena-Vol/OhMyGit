// В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в".
// Покажите все сочетания из Т букв, которые можно построить из букв этого алфавита.

int n = 0;
void FindWords(string alphavit, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphavit.Length; i++)
    {
        word[length] = alphavit[i];
        FindWords(alphavit, word, length + 1);
    }
}

FindWords("аисв", new char[3]);