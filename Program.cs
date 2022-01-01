using System;
namespace Homework1
{
          class Question1
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayi girin") ;
           int n = int.Parse(Console.ReadLine()) ;
        
            List <int> numbers = new List<int>() ;
            for (int i=0; i<n ; i++)
            {
               numbers.Add(int.Parse(Console.ReadLine())) ;
            }
        
            for (int i=0; i<n ; i++)
            {
               if(numbers[i]%2==0)
                    {
                        Console.WriteLine("cift sayi: " + numbers[i]);
                    }
            }
        
        }
        
        
        
        }

    class Question2
    {
        static void Main(string[] args)
        {   Console.WriteLine("Pozitif birinci sayi girin") ;
      int n = int.Parse(Console.ReadLine()) ;
      Console.WriteLine("Pozitif ikinci sayi girin") ;
      int m = int.Parse(Console.ReadLine()) ;
      List<int> numbers = new List<int>() ;
               for (int i=0; i<n ; i++)
                       numbers.Add(int.Parse(Console.ReadLine())) ;
                  for (int i=0; i<n ; i++)
              {
                if(numbers[i]%m==0)            {
                       Console.WriteLine("bolunen sayi: " + numbers[i]);
                   }
            
    


    }

    Console.ReadLine() ;
    }
}
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
                
               for(int i = 0; i<n ; i++)
                {   
                   Console.WriteLine(users[i]) ;
                   
                }
                Console.ReadLine() ;
   
   
    }
    }
   class Question4
        {
            static void Main(string[]args)
            {
                Console.WriteLine("Bir cumle yazin") ;
                string sentence = Convert.ToString(Console.ReadLine()) ;
                int count1 = 0;
                int count2 = 0;
                for(int i= 0 ; i<sentence.Length ; i++) 
                {
                    if (sentence[i]!=' ')
                    {   if ((i+1)==sentence.Length)
                            {
                                count1++ ;
                            }
                        else
                        {
                            if(sentence[i+1]==' ')
                            {
                                 count1++;
                                 count2--;
                            }
                        }

                    }

                    count2++ ;
                }
                Console.WriteLine("kelime sayisi:" + count1);
                Console.WriteLine("harf sayisi:" + count2);
                
                Console.ReadLine();
            
            }
        }
}

    
