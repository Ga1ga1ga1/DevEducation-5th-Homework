using Arrays;
int[] a = ArrayClass.CreateRandom(5);
Console.WriteLine("Сгенерированный массив:");
ArrayClass.Write(a);

Console.WriteLine("Минимальный элемент:");
Console.WriteLine(ArrayClass.FindMin(a));

Console.WriteLine("Максимальный элемент:");
Console.WriteLine(ArrayClass.FindMax(a));

Console.WriteLine("Индекс минимального элемента:");
Console.WriteLine(ArrayClass.FindIndexOfMinElement(a));

Console.WriteLine("Индекс максимального элемента:");
Console.WriteLine(ArrayClass.FindIndexOfMaxElement(a));

Console.WriteLine("Сумма элементов с нечетным индексом:");
Console.WriteLine(ArrayClass.FindSumOfElementsWithOddIndexes(a));

int[] b = ArrayClass.Reverse(a);
Console.WriteLine("Реверс массива:");
ArrayClass.Write(b);

Console.WriteLine("Количество элементов с нечетным индексом:");
Console.WriteLine(ArrayClass.FindNumberOfElementsWithOddIndex(a));

Console.WriteLine("Результат сотировки пузырьком по возрастанию:");
int[] bubbleSort = ArrayClass.DoBubbleSortingInAscendingOrder(a);
ArrayClass.Write(bubbleSort);



