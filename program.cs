using v26;

Rumus rumus = new Rumus();
Console.WriteLine("Luas persegi panjang ");
Console.Write("masukkan p : ");
int p = Convert.ToInt16(Console.ReadLine());
Console.Write("masukkan l : ");
int l = Convert.ToInt16(Console.ReadLine());
Console.Write($"luas persegi dengan p :{p} dan l :{l} adalah : ");
Console.WriteLine(rumus.persegi(p,l));
