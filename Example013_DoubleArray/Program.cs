/*
string[,] table = new string[2,5];
table[1,2] = "слово";
for(int rows=0;rows<2;rows++)
{
  for(int columns=0;columns<5;columns++)
  {
    Console.Write($"-{table[rows,columns]}-");
  }
  Console.WriteLine();
}

void FillArray(int[,] matr)
{
   for (int rows = 0; rows < matr.GetLength(0); rows++)
  {
    for (int columns = 0; columns < matr.GetLength(1); columns++)
    {
      matr[rows,columns] = new Random().Next(1,10);
    }
  }
}


void PrintArray(int[,] matr)
{

  for (int rows = 0; rows < matr.GetLength(0); rows++)
  {
    for (int columns = 0; columns < matr.GetLength(1); columns++)
    {
      Console.Write($"{matr[rows, columns]} ");
    }
    Console.WriteLine();
  }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/
/*
int[,] pic = new int[,]
{
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,1,1,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
  {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0},
  {0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
  {0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};

/*
void PrintArray(int[,] matr)
{

  for (int rows = 0; rows < matr.GetLength(0); rows++)
  {
    for (int columns = 0; columns < matr.GetLength(1); columns++)
    {
      Console.Write($"{matr[rows, columns]} ");
    }
    Console.WriteLine();
  }
};
*/
/*
void PrintImage(int[,] matr)
{

  for (int rows = 0; rows < matr.GetLength(0); rows++)
  {
    for (int columns = 0; columns < matr.GetLength(1); columns++)
    {
      if (matr[rows,columns] == 0)Console.Write(" ");
      else Console.Write("+");
    }
    Console.WriteLine();
  }
};

void FillImage(int row, int col)
{
  if (pic[row,col]==0)
  {
    pic[row,col]=1;
    FillImage(row-1,col);
    FillImage(row,col-1);
    FillImage(row+1,col);
    FillImage(row,col+1);
  }
}
PrintImage(pic);
FillImage(14,14);
PrintImage(pic);
*/

/*
double Factorial(int n)
{
  if (n == 1) return 1;
  else return (n * Factorial(n - 1));
}

for(int i=1;i<40;i++)
Console.WriteLine($"{i}! = {Factorial(i)}");
*/

double Fibonacci(int n)
{
  if (n == 1 || n == 2) return 1;
  else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 40; i++)
  Console.WriteLine(Fibonacci(i));