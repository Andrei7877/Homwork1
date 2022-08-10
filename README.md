Console.Write("Введите количество строк, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine());       // Считываем строку, переводим в число.
string[] strs = new string[n];           //Объявляем массив строк длиной n (которую ввёл пользователь)
for (int i = 0; i < n; i++)
{
Console.Write("Введите строку №{0}:\r\n    ", i + 1);
strs[i] = Console.ReadLine();       //Заполняем его
}
for (int i = 0; i < n; i++)  
{
if (strs[i]. Length >  3) // Выделяем элементы больше 3
strs[i] = null; // Обнуляем их
}
strs = strs.Where(i => i != null).ToArray(); // Создаем такойже массив но в меньших размерах с таким же именем
Console.WriteLine("Cтроки в которых меньше либо равно три знака:"); // Выводим оставшиеся элементы на экран манитора
for (int i = 0; i < strs.Length; i++)
 Console.WriteLine(strs [i]);
 
 
