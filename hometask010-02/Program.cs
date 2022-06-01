// Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] words = {"Op", "en", "mi", "nd", "fo", "r a", "diffe", "rent", "vi", "ew", "\nA", "nd", "Not", "hing", "el", "se", "mat", "ters", "!", " "};
// Length of list MUST be even!!

string[] MergingElts(string[] words)
{
    string[] mergedwords = new string[words.Length / 2];

    for (int i = 0, j = 0; i < mergedwords.Length; i ++, j +=2)
    {
        mergedwords[i] = words[j] + words[j + 1];
    }
    return mergedwords;
}

void PrintWords(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write(mass[i] + " ");
}

PrintWords(MergingElts(words));
