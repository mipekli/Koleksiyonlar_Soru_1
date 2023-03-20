int[] sayilar = new int[20];
int[] enkucukucsayi = new int[3];
int[] enbuyukucsayi = new int[3];
int enkucuklerortalama, enkucuklertoplam = 0;
int enbuyuklerortalama, enbuyuklertoplam = 0;
for (int i = 0; i < 20; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    sayilar[i] = n;
}
Array.Sort(sayilar);
for (int j = 0; j < 3; j++)
{
    enkucukucsayi[j] = sayilar[j];
    enkucuklertoplam += enkucukucsayi[j];

}
Console.WriteLine("En küçük sayılar:" + enkucukucsayi[0] + "," + enkucukucsayi[1] + "," + enkucukucsayi[2]);

Array.Reverse(sayilar);
for (int k = 0; k < 3; k++)
{
    enbuyukucsayi[k] = sayilar[k];
    enbuyuklertoplam += enbuyukucsayi[k];

}
Console.WriteLine("En büyük sayılar:" + enbuyukucsayi[0] + "," + enbuyukucsayi[1] + "," + enbuyukucsayi[2]);

enkucuklerortalama = enkucuklertoplam / 3;
Console.WriteLine("En küçük üç sayının ortalaması" + enkucuklerortalama);
enbuyuklerortalama = enbuyuklertoplam / 3;
Console.WriteLine("En büyük üç sayının ortalaması" + enbuyuklerortalama);
Console.WriteLine("Ortalamlar Toplamı:" + enkucuklerortalama + enbuyuklerortalama);