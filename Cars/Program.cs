namespace Cars
{
    using Modles;
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture("1086");
            Carwash.Traiter(v);
            Carwash.TraiterAno(v);
        }
    }
}
