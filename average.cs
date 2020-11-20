/***********************************************************************
*Program: Average                                                      *
*Description: Program that calculates the average grade of a student   *
*Autor: Marín Montoro, Pablo                                           *
***********************************************************************/

using System;

public class Average
{
    public static void Main()
    {
        Double totalNotes = 0, note, counterNotes = 0, averageNote;
        String mark;

        Console.Write("Insert a mark: ");
        mark=Console.ReadLine();	 

        while(mark != "end")
        {  
            note = Convert.ToDouble(mark);

            counterNotes++;
            totalNotes += note;

            Console.Write("Insert a mark: ");
            mark = Console.ReadLine();
        }

        if(counterNotes != 0)
        {
	        averageNote=totalNotes/counterNotes;

            Console.WriteLine("The average is {0}.",averageNote);
        }
    }
}
