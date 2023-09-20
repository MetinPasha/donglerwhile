namespace dongulerwhile;
class Program
{
    static void Main(string[] args)
    {
        //While
        Console.WriteLine("Bir sayi giriniz ");
        int n = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0; 

        while (sayac<= n)
        {
            toplam+=sayac;
            sayac ++;
        }

        Console.WriteLine(toplam/n);

        char charerdad = 'a';

        while (charerdad<='z')
        {
            Console.WriteLine(charerdad);
            charerdad ++;
        } 

        Console.WriteLine("***** Foreach *****");
        string[] arabalar = {"BMV","FORD","DACİA","AUDİ","MERSEDES","FERRARİ"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}
