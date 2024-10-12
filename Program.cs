// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// int tipine alamayacağı kadar büyük bir değer verdiğinizde sistem kendisi bir exception üretiyor
// bazı durumlarda biz kendimiz de bir exception üretebiliriz

// exception firlatmak 
int deger =0;
try
{
    string veri  = Console.ReadLine();

    // validasyon, alınan değer içerisinde harf var mı ?
    
    bool isLetter =false;
    for(int i = 0; i < veri.Length;i++){

        if(char.IsLetter(veri[i])){
            isLetter = true;
            break;
        }
    }
    if(isLetter){

        throw new InvalidOperationException("Girdiğin verinin içerisinde harf var.");
    }
    else{
             deger = int.Parse(veri);

    }


    if (deger < 50)
    {
        // Kendi exceptionumuzu fırlattık, derleyici 12. satıra geldiğinde, uygulama crash olacaktır.
        throw new Exception("Değeriniz 50'den küçük");

        // bir case'i düşünemediğimizde, bu case'dan kaynaklı bir exception gelebilir
        // bu tarz exceptionları try catch blokları ile yakalarız

        // bazı durumlarda, kendi exceptionlarımızı da fırlatmak isteyebiliriz.

        // 
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}