using System;

namespace Dot_Net{
public class ExForeach {

    public static void exemplo01(){

        string [] myArray = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

        foreach(string cont in myArray){
            
            if(cont.StartsWith("B")){

            Console.WriteLine(cont);
            }
         }
    }  
}
}