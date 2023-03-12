/*Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше или равна 3 символам. 
Первоначальный массив или задан изначально, или задается с клавиатуры, на выбор.*/
string [] OurArray = ToFillArrayWithStringsFromConsole ();
System.Console.WriteLine();
PrintArray (OurArray);
OurArray = ToPickStringsOf3OrLessSymbols (OurArray);
System.Console.WriteLine();
PrintArray (OurArray);

string [] ToPickStringsOf3OrLessSymbols (string [] OurArray)
{
 int FinalArraySize=0;
 for (int i=0; i <OurArray.GetLength(0); i++)
 {
    if (OurArray[i].Length <= 3)
    {
     FinalArraySize++;
    }
 }
 if (FinalArraySize==0)
 {
    string [] FinalArray = new string [1];
    System.Console.WriteLine("All the strings are longer than 3 symbols");
    return FinalArray;
 }
 else 
 {
  string [] FinalArray = new string [FinalArraySize];
  int iFin = 0;
  for (int i=0; i< OurArray.GetLength(0); i++)
  {
    if (OurArray[i].Length <= 3)
    {
        FinalArray[iFin] = OurArray[i];
        iFin++;
    }
  }
 return FinalArray;
 }
}

string [] ToFillArrayWithStringsFromConsole ()
{
    System.Console.WriteLine("Enter the size of the array: ");
    int InitialArraySize = Convert.ToInt32(System.Console.ReadLine());
    string [] InitialArray = new string [InitialArraySize];
    string OurString;
    for (int i=0; i<InitialArray.GetLength(0); i++)
    {
      System.Console.WriteLine("Enter your text: ");
      OurString = System.Console.ReadLine();
      InitialArray[i]= OurString;
    }
    return InitialArray;
}

void PrintArray (string [] OurArray)
{
    string JoinedArray = string.Join(",", OurArray);
    System.Console.WriteLine (JoinedArray);
}