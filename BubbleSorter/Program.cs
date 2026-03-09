using System;

namespace ArraySortTraining;

class Program
{
    static void Main(string[] args)
    {
        int[] numeri = { 7, 2, 9, 4, 9 };

        // OBIETTIVO:
        // - Ordinare un array con un metodo esterno usando Selection Sort
        // - Scegliere se ordinare in modo crescente o decrescente con un bool (desc)

        // STEP 1) Decidi se vuoi ordine decrescente o crescente
        bool desc = true;

        // STEP 2) Chiama Ordinatore(numeri, desc) e salva l'array ordinato
        int[] ordinato = Ordinatore(numeri, desc);

        // STEP 3) Stampa l'array ordinato
        for(int i = 0; i < numeri.Length; i++)
        {
            Console.WriteLine(numeri[i]);
        }
    }

    static int[] Ordinatore(int[] arr, bool desc)
    {
        // SCOPO DEL METODO:
        // - Riordinare gli elementi dell'array usando SELECTION SORT
        // - In base a desc:

        // IDEA (Selection Sort):
        // Per ogni posizione i (da sinistra a destra):
        // 1) Assumi che il "migliore" sia arr[i]
        // 2) Cerca nel resto dell'array (da i+1 in poi) un elemento migliore:
        //    - se desc: migliore = più grande
        //    - se non desc: migliore = più piccolo
        // 3) Se trovi un migliore, scambia arr[i] con arr[indiceMigliore]

        // STEP A) Primo ciclo: posizione da riempire (i)
        // -1 perché l'ultima posizione si sistema da sola
        for(int i = 0; i < arr.Length - 1; i++)
        {
            // STEP B) Dentro, salva l'indice del migliore:
            int indiceMigliore = i;

            // STEP C) Secondo ciclo: cerca nel resto dell'array (j)
            for(int j = i +1; j < arr.Length; j++)
            {

                // STEP D) Confronto:
                if(desc == true)
                {
                    if(arr[j] > arr[indiceMigliore])
                    {
                        indiceMigliore= j;
                    }
                }
                else
                {
                    if(arr[j] < arr[indiceMigliore])
                    {
                        indiceMigliore= j;
                    }
                }
                // STEP E) Dopo aver trovato il migliore, se indiceMigliore != i:
                // fai lo swap (scambio) con una variabile temp:
            }

            if(indiceMigliore != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[indiceMigliore];
                    arr[indiceMigliore] = temp;
                }
        }

        // STEP F) Alla fine ritorna arr (ordinato)
        return arr; 
    }
}