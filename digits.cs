/***********************************************************************
*Program: Digits                                                       *
*Description: Program that calculates the number digits                *
*Author: Marín Montoro, Pablo                                           *
***********************************************************************/


using System;

class digits
{
    static void Main()
    {
        int oneDigitNumber = 0, twoDigitNumber = 0, 
        threeDigitNumber = 0, moreDigitNumber= 0;
     
         Console.WriteLine("Insert a number: ");
         string inputData = Console.ReadLine();
      
         while(inputData != "end")
         {
		     int inputNumber = Convert.ToInt32(inputData);
       
		     if(inputNumber != 0)
             {
				/* We evaluate the division ratio to find out the 
				   number of digits in the entry number */
		         if(inputNumber/10 == 0)
			     {
				     oneDigitNumber ++;  
			     }
			     else
			     {
		             if (inputNumber/100 == 0)
		             {
		                 twoDigitNumber ++; 
				     }
                     else
                     {
                         if (inputNumber/1000 == 0)
                         {
                             threeDigitNumber ++; 
			             }
                         else
                         {
                             moreDigitNumber ++;  
                         }
                     }
                 }
               
                 inputData = Console.ReadLine();
             }
	     }

         Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
         oneDigitNumber, twoDigitNumber, threeDigitNumber, 
         moreDigitNumber); 
    }
}


