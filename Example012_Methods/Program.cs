﻿//Task1. Дан текст. В нём нужно все пробелы заменить чёрточками, мааленькие буквы «к»
//заменить большими «К», а большие «С» заменить на маленькие «с».

/*
string Replace(string text, char oldValue, char newValue)
{
  string result = String.Empty;
  int length = text.Length;
  for (int i = 0; i < length; i++)
  {
    if (text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
  }
  return result;
}

string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы.Вы дадите мне чаю ?";

string newText = Replace(text, ' ','|');
Console.WriteLine(newText);

newText = Replace(newText, 'к','К');
Console.WriteLine(newText);

newText = Replace(newText, 'С','с');
Console.WriteLine(newText);
*/

//Task2. Отсортировать массив.

int[] arr = {3,5,7,1,9,1,5};

void PrintArray(int[] array)
{
  int count = array.Length;
  for(int i=0; i<count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void SelectionSort(int[] array)
{
  for(int i=0; i<array.Length-1; i++)
  {
    int minPosition = i;
    for(int j=i+1; j<array.Length; j++)
    {
      //if(array[j]<array[minPosition])minPosition=j;
      if(array[j]>array[minPosition])minPosition=j;
    }
    int temporary = array[i];
    array[i]=array[minPosition];
    array[minPosition]=temporary;
  }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);