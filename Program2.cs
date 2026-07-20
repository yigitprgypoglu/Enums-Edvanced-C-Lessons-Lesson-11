using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3
{
    internal class Program
    {

        static int Main(string[] args)
        {
            /*Console.WriteLine(items) satırında items nesnesini yazdırdığında, .NET arka planda bu nesnenin ToString() metodunu çağırır. Enum'larda ToString() metodu, 
            değerin sayısal karşılığını değil, o değerin ismini (string karşılığını) dönecek şekilde override edilmiştir. Bu yüzden ekranda sayıları değil, enum isimlerini görürsün
            */
            foreach (var items in Enum.GetValues(typeof(Schools)))//getname kullanamamazin sebebi getnames fonksiyonumuz elemanlari bir dizi olarak almazken getvalues fonksiyonumuz elemanlari bir dizi olarak alir ve dongude kullanmak icin daha mantiklidir.
            { 
                Console.WriteLine(items);
            }

            /*
            string[] schools=Enum.GetNames(typeof(Schools));//yukaridakinin aynisi farkli yol ile

            foreach (var item in schools)
            {
                Console.WriteLine(item);
            }
            */
            /*
            Console.WriteLine(typeof(Program));
            Console.WriteLine(typeof(int));//typeof bize parantez icine yazdigimiz seyin tipini verir.
            Console.WriteLine(Enum.Parse(typeof(Schools),"1"));//1 bize primaryschool dondurcektir parantez icine primaryschool da yazabiliriz
            Console.WriteLine(Enum.GetName(typeof(Schools),1));//burada da getname bize 1 yazdigimiz icin school enum inda bununla eslesen primaryschool u dondurecektir.
            
            */
            Console.ReadLine();
            return 0;
        }

       
    }
    enum Schools
    {
        PrimarySchool, HighSchool, University

    }
}
