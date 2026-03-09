using System;

namespace ArrayStats;

class Program
{
    static void Main(string[] args)
    {
        int[] numeri = { 7, 2, 9, 4, 9 };

        // OBIETTIVO:
        // - Trova il valore massimo nell'array (es: 9)
        // - Conta quante volte compare un certo valore (es: 9 compare 2 volte)

        // STEP 1) Chiama TrovaMax(numeri) e salva il risultato in una variabile
        int massimo = TrovaMax(numeri);

        // STEP 2) Chiama ContaOccorrenze(numeri, 9) e salva il risultato
        int quante = ContaOccorrenze(numeri, 9);

        // STEP 3) Stampa:
        //         - il massimo
        //         - quante volte compare 9
        Console.WriteLine($"Max: {massimo}");
        Console.WriteLine($"Occorrenze di 9: {quante}");

    }

    static int TrovaMax(int[] arr)
    {
        // SCOPO DEL METODO:
        // - guardare tutti i numeri dell'array
        // - tenere in una variabile il più grande trovato finora
   
        // IDEA:
        // 1) Parti dicendo: "per ora il massimo è il primo numero"
        int max = arr[0];
        // 2) Poi guardi gli altri numeri uno per uno, partendo dal secondo:
        for(int i = 1; i < arr.Length; i++)
        {

        // 3) Ogni volta chiedi:
        //    "arr[i] è più grande di max?"
        //    - se sì: aggiorna max (max = arr[i])            
            if(arr[i] > max)
            {
                max = arr[i];
            }
        }

        // 4) Alla fine ritorni max
        return max;
    }

    static int ContaOccorrenze(int[] arr, int valore)
    {
        // SCOPO DEL METODO:
        // - contare quante volte "valore" appare dentro arr

        // 1) Parti con un contatore a 0:
        int count = 0;

        // 2) Scorri tutto l'array:
        for(int i = 0; i < arr.Length; i++)
        {
        // 3) Ogni volta chiedi:
        //    "arr[i] è uguale a valore?"
        //    - se sì: count++
            if(arr[i] == valore)
            {
                count++;
            }
        }

        // 4) Alla fine ritorni count
        return count; 
    }
}