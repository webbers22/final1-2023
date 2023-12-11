
var array = new string[4] { "Жук", "Сук", "Дерево", "Окно" };
var arrayNew = new string[array.Length];

void FindLength(string[] array, string[] arrayNew)
{
    var i = 0;
    for (var j = 0; j < array.Length; j++)
        if (array[j].Length <= 3)
        {
            arrayNew[i] = array[j];
            i++;
        }
}

FindLength(array, arrayNew);

Console.Write("Start array: ");
Console.WriteLine(string.Join(" ", array));

Console.Write("Final array: ");
Console.WriteLine(string.Join(" ", arrayNew));