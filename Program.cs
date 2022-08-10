Console.Write("Введите количество строк, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine());      
string[] strs = new string[n];           
for (int i = 0; i < n; i++)
{
Console.Write("Введите строку №{0}:\r\n    ", i + 1);
strs[i] = Console.ReadLine();       
}
for (int i = 0; i < n; i++)
{
if (strs[i]. Length >  3)
strs[i] = null;
}
strs = strs.Where(i => i != null).ToArray();
