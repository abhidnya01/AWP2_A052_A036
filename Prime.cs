using System;
namespace Practical1d
{
 public class Prime 
   {  
     public static void Main(string[] args)  
      {  
          int n, i, num=0, flag=0;    
          Console.Write("Enter the Number to check Prime: ");    
          n = int.Parse(Console.ReadLine());  
          num=n/2;    
          for(i = 2; i <= num; i++)    
          {    
           if(n % i == 0)    
            {    
             Console.Write("Number is not Prime.");    
             flag=1;    
             break;    
            }    
          }    
          if (flag==0) {  
           Console.Write("Number is Prime.");
	}       
      
   }  
}
}