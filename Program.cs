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
            //stringin cok fazla olmasi okunabilirligi azaltacagi icin ve de bitisik yazdigimiz yada kucuk buyuk harfe dikkat etmedigimiz takdirde programin calismayacagi icin islerimizi string yerine sayilar ile gorduk.
            
            //sayilarla yaptigimizda ise okulun high,primary school yada uni oldugunu anlayamiyoruz evet daha kolay ama bi sikintisi var ve bu durumu duzeltmek icinde enum kullanicaz
            
            //enumlar kodumuzu daha okunabilir yapar,enumlar sayilari anlamli sekilde isimlendirerek bizim kullanmamizi saglar.
            Person person = new Person();
            person.school = Schools.PrimarySchool;// bunu kaldirirsak constructor imiz highschool oldugu icin ABC yazacaktir.
            if (person.school.Equals(Schools.PrimarySchool))
            {
                Console.WriteLine("XYZ");
            }
            else if (person.school.Equals(Schools.HighSchool))
            {
                Console.WriteLine("ABC");
            }
            else if (person.school.Equals(Schools.University))
            {
                Console.WriteLine("123");
            }
            Console.ReadLine();
            return 0;
        }

       
    }
    enum Schools
    {
        PrimarySchool, HighSchool, University// index degerleri 0,1,2 dir ama kendiniz de deger atayabilirsiniz ornek PrimarySchool=2,HighSchool=1 gibi...
    }
    class Person
    {
        public Person()
        {
            school = Schools.HighSchool;
        }
        public Schools school;
    }
   
}
