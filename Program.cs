namespace Uge_4_Fødselsdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Navn = Ask("Navn: ");
                int Alder = Int32.Parse(Ask("Alder: "));
                string Adresse = Ask("Adresse: ");
                int Fødselsdage = Int32.Parse(Ask("Hvor mange fødselsdage: "));

                Person MigSelv = new Person(Navn, Alder, Adresse);

                MigSelv.Fødselsdag(Fødselsdage);

                Console.WriteLine(MigSelv.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine( "Fejl:");
                Console.WriteLine( ex.Message);
                Console.WriteLine("Programmet afsluttes!");
            }
        }
        static string  Ask(string s)
        {
            String Answer = String.Empty;
            while (String.IsNullOrWhiteSpace(Answer))
            {
                Console.Write(s);
                Answer = Console.ReadLine();
            }
            return Answer;
        }
    }
}