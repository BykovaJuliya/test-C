// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых <либо=3символам

string[] arrayA = new string[4] {"hello","2", "word","321"};
string[] arrayB = new string[arrayA.Length] ;
void SecondArray(string[] arrayA, string[] arrayB)
{
    int count=0;
    for (int i=0; i<arrayA.Length; i++)
    {
        if(arrayA[i].Length<=3)
         {
            arrayB[count]=arrayA[i];
            count++;
          }
    }
}
void PrintArray(string[] array)
{
    for (int i=0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} "); 
       
    }
    Console.WriteLine(
}
SecondArray(arrayA, arrayB);
PrintArray(arrayB);
