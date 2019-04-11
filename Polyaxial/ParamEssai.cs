using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyaxial
{
    class ParamEssai
    {
        private static string repertoire = @"C:\GMines\Polyaxial";
        private static string nomfichier = "";
        private static int numessai = 1;
        private static double cote1 = 30;
        private static double cote2 = 30;
        private static double cote3 = 30;
        private static double sigmabp = 0;
        private static double sigmamp = 10;
        private static double sigmahp = 700;
        private static DateTime date = Convert.ToDateTime(DateTime.Now);

        public static string Repertoire { get => repertoire; set => repertoire = value; }
        public static string Nomfichier { get => nomfichier; set => nomfichier = value; }
        public static int Numessai { get => numessai; set => numessai = value; }
        public static double Cote1 { get => cote1; set => cote1 = value; }
        public static double Cote2 { get => cote2; set => cote2 = value; }
        public static double Cote3 { get => cote3; set => cote3 = value; }
        public static double Sigmabp { get => sigmabp; set => sigmabp = value; }
        public static double Sigmamp { get => sigmamp; set => sigmamp = value; }
        public static double Sigmahp { get => sigmahp; set => sigmahp = value; }
        public static DateTime Date { get => date; set => date = value; }
    }
}
