// See https://aka.ms/new-console-template for more information


/********************** C#101 ÖDEV -1   ****************************

AŞAĞIDA 4 ADET ÖDEVİN ÇÖZÜMÜ YER ALMAKTADIR. İSTEDİĞİNİZ ÖDEVİ AKTİF HALE GETİREBİLİRSİNİZ

*/




// 4. Bir konsol uygulamasında kullanıcıdan bir cümle yazmasını isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.WriteLine("Bir cümle giriniz");
string s= Console.ReadLine().Trim();
if (s.Length==0)
    Console.WriteLine("Kelime girmediniz: ");
else 
    s.CountWithoutSpace();

public static class ExtensionMethods {

    public static void CountWithoutSpace (this string s) {

        int letterCount=0;
        int wordCount=1;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Equals (' ')){
                wordCount++;
                continue;
            }
                
            else 
                letterCount++;
        }

Console.WriteLine("Toplam harf sayısı: " + letterCount);
Console.WriteLine("Toplam kelime sayısı: " + wordCount);


    }

}

/* //3. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Console.Write("Kelime miktarınızı  giriniz: ");

int n = Convert.ToInt32(Console.ReadLine());
string [] kelimeler = new string [n];

for (int i = 0; i < n; i++)
{
    Console.Write((i+1) + ". kelimeyi giriniz: ");
    kelimeler[i] = Console.ReadLine();
}
Array.Reverse(kelimeler);
Console.WriteLine("Girdiğiniz kelimeleri tersten yazdırıyorum: ");
foreach (var item in kelimeler)
{
    Console.WriteLine(item);
} */


/* // 2. Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında 
//kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e 
//eşit yada tam bölünenleri console'a yazdırın.

Console.WriteLine("Pozitif iki adet sayı giriniz..");
Console.Write("1.sayı: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("2.sayı: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(n + " adet sayı giriniz");
int [] sayilar = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write((i+1) +  ". sayıyı giriniz: ");
    sayilar[i]= Convert.ToInt32(Console.ReadLine());
}

PrintEqualOrDivided(sayilar,m);

void PrintEqualOrDivided( int [] sayilar, int m){

    foreach (var sayi in sayilar)
    {
        if (sayi % m ==0)
            Console.WriteLine(sayi);
    }
} */


/* 
//  1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında 
//kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift 
//olanlar console'a yazdırın.

Console.WriteLine("Girilecek pozitif sayılardan çift olanlar ekrana yazılacak...");
Console.Write("Sayı miktarını giriniz: ");
int adet;
while (true){
    try
    {
        adet= Convert.ToInt32(Console.ReadLine());
        break;    
    }
    catch (System.Exception)
    {
        Console.WriteLine("Lütfen pozitif bir sayı giriniz..");
    }
}



int[] sayilar= new int[adet];
for (int i = 0; i < adet; i++)
{
    Console.Write(i +  ". sayıyı giriniz: ");
    sayilar[i]= Convert.ToInt32(Console.ReadLine());
}
    sayilar.PrintEvenNumbers();


public static class ExtensionMethods {

    public static void PrintEvenNumbers (this int[] sayilar){
        bool evenNumberExists=false;
        foreach (var item in sayilar)
        {
            if (item%2 ==0 && !evenNumberExists) {
                Console.WriteLine("Çift sayılar: ");
                Console.WriteLine(item);
                evenNumberExists=true;
            } else if (item%2==0)
                Console.WriteLine(item);                
        }

        if (!evenNumberExists)
            Console.WriteLine("Girdiğiniz sayılar arasında çift sayı yoktur");
    }

} */
