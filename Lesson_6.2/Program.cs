// парсинг входной строки

using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
              .Replace("(", "")             //убираем скобочки
              .Replace(")", "")
              ;
Console.WriteLine(text);
var data = text.Split(" ")  //Разбиваем текст на пары
                .Select(item => item.Split(','))    //получаем массив координат
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) //получаем массив кортежей
                .Where(e => e.x % 2 == 0)   //делаем выборку чётных в кортеже
                .Select(point => (point.x * 10, point.y + 10))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    /*for (int k = 0; k < data[i].Length; k++)  //Это вывод для массива координат
    {
        Console.WriteLine(data[i][k]);
    }
    */
    //Console.WriteLine();
}