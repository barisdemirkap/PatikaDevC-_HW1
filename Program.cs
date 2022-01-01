using System;
namespace Homework1
{
        //  class Question1
        //{
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Pozitif bir sayi girin") ;
        //   int n = int.Parse(Console.ReadLine()) ;
        //
        //    List <int> numbers = new List<int>() ;
        //    for (int i=0; i<n ; i++)
        //    {
        //       numbers.Add(int.Parse(Console.ReadLine())) ;
        //    }
        //
        //    for (int i=0; i<n ; i++)
        //    {
        //       if(numbers[i]%2==0)
        //            {
        //                Console.WriteLine("cift sayi: " + numbers[i]);
        //            }
        //    }
        //
        //}
        //
        //
        //
        //}

    //class Question2
    //{
    //    static void Main(string[] args)
    //    {   Console.WriteLine("Pozitif birinci sayi girin") ;
    //        int n = int.Parse(Console.ReadLine()) ;
    //        Console.WriteLine("Pozitif ikinci sayi girin") ;
    //        int m = int.Parse(Console.ReadLine()) ;
    //        List<int> numbers = new List<int>() ;
    //
    //        for (int i=0; i<n ; i++)
    //        {
    //           numbers.Add(int.Parse(Console.ReadLine())) ;
    //        }
    //         for (int i=0; i<n ; i++)
    //           {
    //              if(numbers[i]%m==0)
    //                   {
    //                       Console.WriteLine("bolunen sayi: " + numbers[i]);
    //                   }
    //            
    //    
    //
    //
    //    }
    //
    //    Console.ReadLine() ;
    //    }
    //}
    class Question3
    {
        static void Main(string[] args)
        {       
                Console.WriteLine("Pozitif bir sayi girin") ;
                int n = int.Parse(Console.ReadLine()) ;
                List<string> users = new List<string>() ;
                Console.WriteLine("kullanici isimlerini girin") ;
                for(int i = 0; i<n ; i++)
                {   
                    users.Add(Convert.ToString(Console.ReadLine())) ; 
                }
                
                users.Reverse();
                Console.WriteLine(String.Join(',', users)) ;
               // for(int i = 0; i<n ; i++)
                //{   
                //   Console.WriteLine(users[i]) ;
                //   
                //}
                Console.ReadLine() ;


    }
    }
}

    
