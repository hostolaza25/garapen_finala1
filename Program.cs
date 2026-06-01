namespace _3POO_3
{
    /// <summary>
    /// Programaren klase nagusia.
    /// Aplikazioaren exekuzioa hemen hasten da.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Programaren sarrera-puntua.
        /// Irratsaioa klasearen objektuak sortu eta haien funtzionamendua probatzen du.
        /// </summary>
        /// <param name="args">Komando-lerroko argumentuak.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("NIRE IRRATIA");

            // EITB irratiaren objektua sortu
            Irratsaioa eitb = new Irratsaioa(104.3, "eitb musika");

            // KISS FM irratiaren objektua sortu (eraikitzaile lehenetsia erabiliz)
            Irratsaioa kissfm = new Irratsaioa();

            Console.Write("EITB >");
            eitb.seefrek();

            Console.Write("KISS FM >");
            kissfm.seefrek();

            // Frekuentzia jaitsi eta berriro erakutsi
            kissfm.jaitsi();

            Console.Write("KISS FM >");
            kissfm.seefrek();
        }
    }
}