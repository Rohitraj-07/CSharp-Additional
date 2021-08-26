using System;

namespace Named_parameters
{
    class Program
    {
        public static string GetCohortDetails(string CohortName, string GencCount, string Mode, string Track, string CurrentModule)
        {
            return $"It is {CohortName} with {GencCount} GenCs undergoing training for {Track} thru {Mode}. The current module of training is {CurrentModule}.";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetCohortDetails("INTADM21DF016", "27", "PARC", ".Net", "FullStack"));
            Console.WriteLine(GetCohortDetails("27", ".Net", "FullStack", "INTADM21DF016", "PARC"));
            Console.WriteLine(GetCohortDetails(Track: ".Net", CohortName: "INTADM21DF016", CurrentModule: "FullStack", GencCount:"27", Mode:"PARC"));
            
        }

        
    }
}
