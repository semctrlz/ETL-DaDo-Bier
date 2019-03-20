using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL_DaDo_Bier
{
    class Program
    {
        #region Imagens

        public static string ImgDado = "\n" +
"                                    `....`                                 \n" +
"                                .:+osssssss+:-`                            \n" +
"                           `-/osssso:....-/sssso/-.                        \n" +
"                       .:+osssssssso:-...-+sssssssss+:-`                   \n" +
"                  `-/osssssssssssssssssssssssssssssssssso/-.               \n" +
"              .:+osssoooosssssssssssssooosssssssssssssooossss+:-`          \n" +
"         `-/+sssss+.`    `./ssssss+.`    `./sssssso-`  ` `.:ssssso/-`      \n" +
"       `/ssssssssso:.````.:+sssssso:.````.-+sssssso:.````.-+sssssssss+.    \n" +
"       /sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss    \n" +
"       /sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssso    \n" +
"       -sssssssssssssssssssssssssso/:----:/+ssssssssssssssssssssssssss/    \n" +
"       `sssssssssss/ossssssssssss:```````````sssssssssssss+ossssssssss-    \n" +
"        /ssssssssss+:.-/osssssssso/-.`````-:osssssssss+:.-/sssssssssss     \n" +
"        -sssssssssssss+:.`-/osssssssssssssssssssss+:.`-+sssssssssssss/     \n" +
"         ossssssssssssssso:.`.:/osssssssssssss+:.``:+ssssssssssssssss.\n" +
"         /sssssssssssssssssso/.``.:+osssss+:.```:+sssssssssssssssssso\n" +
"         .ssssssssssssssssssssso/.`````.`````:+sssssssssssssssssssss/     \n" +
"          ossssssssssssssssssssssso-``````.+ssssso++ssssssssssssssss.\n" +
"          /sssssssssssssssssssssssss/````-ssssss-`` osssssssssssssss\n" +
"          .sssssssss+`./sssssssssssss-```ssssso`````sssss+sssssssss/     \n" +
"           ossssssss/```-ssssssssssss/``-sssss.````/sss:``:ssssssss.\n" +
"           /sssssssss.```-sssssssssss+ `:sssss````+sss.```+sso:+sso\n" +
"           .ssssssssss-```ssssssssssso``/sssss+:+ssss+ ``/ss/``-ss/     \n" +
"            osssssssssso/ossssssssssss``+sssssssssssso::osso``.oss.\n" +
"            .ossssssssssssssssssssssss` osssssssssssssssssss:/sss-      \n" +
"              ./ssssssssssssssssssssss.ssssssssssssssssssssss+-`          \n" +
"                 ./ossssssssssssssssss-`sssssssssssssssssss+-`             \n" +
"                    .:osssssssssssssss:`ssssssssssssssss/-                 \n" +
"                       `:+ssssssssssss/.sssssssssssso/.                    \n" +
"                          `:+sssssssssssssssssssso:.                       \n" +
"                             `-+ssssssssssssss+:`                          \n" +
"                                 -/osssssss+:`                             \n" +
"                                    .://:.`\n";

        public static string Titulo = "\n" +
"        _____ _____ _       ____            _         ____  _\n" +
"       | ____|_   _| |     |  _ \\  __ _  __| | ___   | __ )(_) ___ _ __ \n" +
"       |  _|   | | | |     | | | |/ _` |/ _` |/ _ \\  |  _ \\| |/ _ \\ '__|\n" +
"       | |___  | | | |___  | |_| | (_| | (_| | (_) | | |_) | |  __/ |\n" +
"       |_____| |_| |_____| |____/ \\__,_|\\__,_|\\___/  |____/|_|\\___|_|\n";

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine(ImgDado);
            Console.WriteLine(Titulo);
            Console.WriteLine("");

            bool total = args.Contains("total");

            args = args.Where(val => val != "total").ToArray();

            foreach (string nome in args)
            {
                DispararETL(nome, total);
            }

            Console.ReadKey();
        }

        private static void DispararETL(string nome, bool total)
        {
            
        }

    }
}
