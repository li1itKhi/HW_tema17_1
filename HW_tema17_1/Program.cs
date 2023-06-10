int[] arr = new int[9]; //инициализация одномерного массива

for(int i=0; i<arr.Length; i++) //добавление элементов в одномерный массив
{
    Console.Write($"Введите {i+1} элемент массива: ");
    arr[i]=int.Parse(Console.ReadLine()); //функция добавления
}

Console.WriteLine();
 
for(int i=0; i<arr.Length; i++) //цикл вывода элементов
{
    Console.Write(arr[i]+" ");
}

Console.WriteLine("\n\nКакой элемент Вы хотите заменить на значение 200? ");
int i_poz = int.Parse(Console.ReadLine()); //переменная для выбора/ввода позиции

for(int i=0; i<arr.Length; i++) //цикл для изменения элемента в заданной позиции
{
    if (i == i_poz - 1) arr[i] = 200; //условие, при котором мы меняем элемент

    Console.Write(arr[i]+" ");
}