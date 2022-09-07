
using System;

namespace LeapYears;

 
 public class LeapYearsSolution
 {
       
   public static void Run()
   {
       printNext20LeapYears();
   }
             
    private static void printNext20LeapYears()

       {
          var year =  DateTime.Now.Year;
          var count = 0; 
    
       
        Console.WriteLine("---- Next Leap Years ----");
         while (count < 20) 
    {
       year += 1;
         if (year % 4 == 0)   
     {
        Console.WriteLine(" {0}. {1} ", count + 1, year);    
         count+=1;  

      }
     }

   }          
}


