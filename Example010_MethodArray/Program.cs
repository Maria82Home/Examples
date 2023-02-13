int[] array = {12,93,36,49,57,63,75,84,93,32};
int n = array.Length;
int find = 93;
int index = 0;

while(index<n)
{
  if (array[index]==find)
  {
    Console.WriteLine(index);
    break;
  }
  index++;
}