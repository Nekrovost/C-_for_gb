// string[,] table=new string[2, 5];
// table[1, 2]="слово123";
// for (int rows=0; rows<2; rows++)
// {
//     for (int cols=0; cols<5; cols++)
//     {
//         Console.WriteLine($"-{table[rows, cols]}-");
//     }
// }


int[,] table=new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int rows=0; rows<table.GetLength(0); rows++)
    {
        for (int cols=0; cols<table.GetLength(1); cols++)
        {
            Console.Write($"{table[rows, cols]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(1,10);
        }
    }
}

PrintArray(table);
FillArray(table);
Console.WriteLine();
PrintArray(table);