// See https://aka.ms/new-console-template for more information

string[] CibiPreferiti = { "pizza", "carbonara", "olive fritte", "patate","gelato","boo"};
Console.WriteLine("Ci sono " + (CibiPreferiti.Length) + " oggetti");

for (int i = 0; i < CibiPreferiti.Length; i++) 
{
    Console.Write(i + 1 + " ");
    Console.WriteLine(CibiPreferiti[i]);

}
Console.WriteLine("Cibo preferito: " + CibiPreferiti[0]);
Console.WriteLine("Cibo meno preferito: " + (CibiPreferiti [CibiPreferiti.Length - 1]));
if (CibiPreferiti.Length % 2 != 0)
{
    Console.WriteLine("Cibo di meta: " + (CibiPreferiti[CibiPreferiti.Length / 2]));
}
else
{
    Console.WriteLine("Cibo di meta: " + (CibiPreferiti[CibiPreferiti.Length / 2]));
    Console.WriteLine("Cibo di meta: " + (CibiPreferiti[CibiPreferiti.Length / 2 - 1]));
}