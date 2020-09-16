using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Eserc7
{
    class Program
    {
        /* Domande a cui rispondere per implementare un metodo:
         * 1) Cosa deve fare il metodo (il suo scopo)?
         * 2) Di quali dati ha bisogno per raggiungere il suo scopo?
         * 3) Cosa deve restituire?
         *
         * 1) Devo trovare tutte le posizioni in cui si trova l'elemento cercato
         * 2) Elemento cercato, array in cui cercare
         * 3) Un array contenente le posizioni in cui si trova l'elemento cercato
         */

        static int[] RicercaValore(int[] v, int target)
        {
            int[] arrayPosizioni;
            //l'array delle posizioni è esattamente lungo il numero di volte in cui l'elemento cercato si trova all'interno dell'array iniziale
            int conta = 0;
            for (int i = 0; i < v.Length; i++)
                if (v[i] == target)
                    conta++;
            arrayPosizioni = new int[conta];

            conta = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == target)
                {
                    arrayPosizioni[conta] = i;
                    conta++;
                }
            }

            return arrayPosizioni;
        }

        static string[] RicercaConStringhe(int[] v, int target)
        {
            string pos = "";
            for (int i = 0; i < v.Length; i++)
                if (v[i] == target)
                    pos = pos + i.ToString()+','; // 3,7,11
            return pos.Split(',');
        }

        static void Main(string[] args)
        {
            //istanziare l'array
            const int DIM = 10;
            int[] array = new int[DIM];

            //creiamo un array con valori random
            Random gen = new Random();
            for(int i=0; i<array.Length; i++)
            {
                array[i] = gen.Next(0, 10);
                Console.Write("{0,-4}", array[i]);
            }

            //chiedere il valore da ricercare
            Console.WriteLine("Inserisci il valore da ricercare");
            int valore = Convert.ToInt32(Console.ReadLine());

            //richiamo il metodo che restituisce un array di interi
            int[] posizioni = RicercaValore(array, valore);
            //visualizzo le posizioni in cui si trova l'elemento cercato
            for(int i=0; i<posizioni.Length; i++)
               Console.WriteLine(posizioni[i]);

            //richiama il metodo che restituisce un array di stringhe
            string[] pos = RicercaConStringhe(array, valore);
            foreach (string s in pos)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
