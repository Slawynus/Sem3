Console.Write("N");
int N = Convert.ToInt32(Console.ReadLine());
String a1 = N.ToString();
String a2 = a1.ToString();
String a3 = a2.ToString();
String a4 = a3.ToString();
String a5 = a4.ToString();

if (a1 == a5 && a2 == a4)
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("нет");
}
