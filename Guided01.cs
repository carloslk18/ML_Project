using System;
using System.Security.Cryptography.X509Certificates;

namespace Dot_Net{

public class Guided01{

    public static void StudentScores(){

        int currentAssignments = 4;

        int [] sophiaScore = {90, 86, 87, 98};
        int [] andrewScore = {92, 89, 81, 96};
        int [] emmaScore = {90, 85, 87, 98};
        int [] loganScore = {90, 95, 87, 88};
        
        int sophiaSum;
        int sandrewSum; 
        int emmaSum;
        int loganSum;

        double sofiaSocore;
        double andrewSocore;
        double emmaSocore;
        double loganSocore;


       string [] students = {"Sophia", "Andrew", "Emma", "Logan"};

       foreach (string names in students){

            Console.WriteLine(names);
       }
    }
}
}