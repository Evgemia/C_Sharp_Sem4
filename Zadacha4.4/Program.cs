// Решение с семинара
Console.Clear();
Console.Write("Введите число: ");
int num = 8;
int[] array = GetBinArray(num);
Console.Write($"[{String.Join(", ", array)}]");// замена цикла в стр. 7,8,9,10
//Console.Write($"[");
//for (int i = 0; i < num - 1; i++){
  //  Console.Write($"{array[i]}, ");
//}Console.Write($"{array[num - 1]}]");


int[] GetBinArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(2);
    }
    return result;
}



// peшение с лекции

/*void FillArray (int[] collection)
{
    int Length =  collection.Length;
    int index =0;
    while(index <Length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
        }
}
int[] array = new int[ 8];
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
    
}
FillArray(array);
PrintArray(array);*/


