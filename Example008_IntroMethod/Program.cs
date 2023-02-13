int Max(int arg1, int arg2, int arg3)
{
  int result =arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}

int num1 = 12;
int num2 = 13;
int num3 = 14;
int num4 = 22;
int num5 = 23;
int num6 = 24;
int num7 = 352;
int num8 = 33;
int num9 = 34;

int max1 = Max(num1, num2, num3);
int max2 = Max(num4, num5, num6);
int max3 = Max(num7, num8, num9);
int max = Max(max1, max2, max3);

/*int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
if (num4 > max) max = num4;
if (num5 > max) max = num5;
if (num6 > max) max = num6;
if (num7 > max) max = num7;
if (num8 > max) max = num8;
if (num9 > max) max = num9;
*/

Console.WriteLine(max);