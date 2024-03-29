using Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Modles
{
    public static class Carwash
    {
        public static void Preparer(Voiture v)
        {
            Console.WriteLine("je prepare la voiture :" + v.Plaque);
        }
        public static void Laver(Voiture v)
        {
            Console.WriteLine("je lave la voiture :" + v.Plaque);
        }
        public static void Secher(Voiture v)
        {
            Console.WriteLine("je seche la voiture :" + v.Plaque);
        }
        public static void Finaliser(Voiture v)
        {
            Console.WriteLine("je finalise la voiture :" + v.Plaque);
        }

        public static void Traiter(Voiture v)
        {
            test del;
            del = Preparer;
            del += Laver;
            del += Secher;
            del += Finaliser;
            del(v);
        }

        public static void TraiterAno(Voiture v)
        {
            test del;
            del = delegate(Voiture v) { Console.WriteLine("je prepare la voiture :"); };
            del += delegate (Voiture v) { Console.WriteLine("je lave la voiture :"); };
            del += delegate (Voiture v) { Console.WriteLine("je seche la voiture :"); };
            del += delegate (Voiture v) { Console.WriteLine("je finalise la voiture :"); };
            del(v);
        }


        /*  private void Préparer(Voiture v) qui affiche « je prépare la voiture : {plaque} »
            private void Laver(Voiture v) qui affiche « je lave la voiture : {plaque} »
            private void Secher(Voiture v) qui affiche « je sèche la voiture : { plaque} »
            private void Finaliser(Voiture v) qui affiche « je finalise la voiture : { plaque} »
            public voidTraiter(Voiture v) qui exécute les 4 méthodes précédentes dans l’ordre à l’aide d’un délégué*/
    }
}
