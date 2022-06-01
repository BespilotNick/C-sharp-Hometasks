// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

string[] words = { "Hello", "Everybody", "Who", "Read", "It", "I", "Wish", "You", "Happy", "And", "Lucky",
                    "never", "give", "up", "and", "remember", "that", "you", "are", "not", "alone"};

void NumOfVowel(string[] mass)
{
    string vowels = "AEIOUYaeiouy";        // Можно написать гласные в одном экземпляре, но я пока не разобрался как
    int vownum = 0;                        // привести все буквы элементов массива к одному регистру без создания нового массива

    for (int i = 0; i < mass.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (mass[i][0] == vowels[j])
            {
                vownum++;
                Console.WriteLine(mass[i]);
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("There are " + vownum + " words in the list starts from vowel");
}

Console.WriteLine();
NumOfVowel(words);
Console.WriteLine();