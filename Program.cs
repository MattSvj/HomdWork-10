/*
string[] names = {"Pavel", "Anna", "Denis"};

int CountEven(string[] words)
{
    int count = 0;
    for(int i = 0; i < words.Length; i++)
    {
        if(words[i].Length % 2 == 0) count++;
    }

    return count;
}

Console.WriteLine(CountEven(names));
*/

//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
/*

string[] names = {"awe", "wer", "ert", "uty", "yyu"};

int CountEven(string[] words)
{
    int count = 0;
    for(int i = 0; i < words.Length; i++)
    {
        if(words[i][0] == 'a' | words[i][0] == 'e' | words[i][0] == 'i' | words[i][0] == 'o' | words[i][0] == 'u' | words[i][0] == 'y') count++;
    }

    return count;
}

Console.WriteLine(CountEven(names));

*/

//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

string[] names = {"qwe", "wer", "ert", "rty", "tyu", "yui"};

string CountEven(string[] words)
{   
    string[] wordsq = {};
    for(int i = 0; i < words.Length - 1; i += 2)
    {
        wordsq[i] = words[i] + words[i+1];
    }

    return wordsq[0];
}

Console.WriteLine(CountEven(names));

//blizko