using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        //array globaal zetten
        static double[] getallen = new double[10];

        //i know the code sucks but it's mine, and i am proud of it (except the ascii art) #no copy pasta

        static void Main(string[] args)
        {
            //kleurtjes
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            // intro
            Intro();

            //het overlopen en uitrekenen van de ingeven
            IngaveOverlopen();
        }
        private static void Intro()
        {
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*                       MEET THE SOLVER OF MATH                       *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* -Voor meer info over het programma type 'info'                      *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("* -Om een berekening te maken, geef een bewerking in als: 1-2         *");
            Console.WriteLine("* -Om te rekenen met variabelen, geef een bewerking in als: 1-m2      *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("* -Om de lokale variabelen met hun waarden te tonen, type: 'locals'   *");
            Console.WriteLine("* -Om en variabele in te stellen, geef een opdracht als: m1=1         *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("* -Voor een lijst van alle ondersteunde bewerkingen, type: 'listcalc' *");
            Console.WriteLine("* -Voor informatie van de schrijver weer te geven, type: 'author'     *");
            Console.WriteLine("* -Om het rekenmachine af te sluiten type: 'exit'                     *");
            Console.WriteLine("* -If you want to facepalm type 'lantern'  (no going back)            *");
            Console.WriteLine("* -type 'ring'                                                        *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
        }//Intro bericht met regels/commands

        private static void IngaveOverlopen()
        {//begin overlopen

            do
            {
                //invoer  oproepen
                String ingave = Invoer().Trim();

                // COMMANDS

                //lantern command
                if (ingave == "lantern")
                {
                    //Lantern functie oproepen
                    Nerd();
                }
                //author command
                else if (ingave == "author")
                {
                    //author functie oproepen
                    Author();
                }
                else if (ingave == "info")
                {
                    //author functie oproepen
                    Info();
                }
                else if (ingave == "ring")
                {
                    //author functie oproepen
                    Ring();
                }
                //locals command
                else if (ingave.Equals("locals"))
                {
                    //weergeven van array "getallen"
                    for (int x = 0; x < getallen.Length; x++)
                    {
                        Console.WriteLine("M" + x + " = " + getallen[x]);
                    }
                }
                // listcalc command
                else if (ingave == "listcalc")
                {
                    Listcalc();
                }
                //exit command
                else if (ingave == "exit")
                {
                    //applicatie sluiten
                    Environment.Exit(0);
                }
                // EINDE COMMANDS


               
                //ingave splitsen op teken
                string[] deelIngave = ingave.Split('+', '-', '*', '/', '%','=');
                //variabele uitkomst
                double uitkomst;
                
                //FOR
                for (int i = 0; i < ingave.Length; i++)
                {
                    //bij herkenning van = teken wordt er een waarde in de array gestopt
                    if (ingave[i] == '=')
                    {
                        //M
                        string volledigM = deelIngave[0];
                        string nummerM = volledigM.Remove(0, 1);//enkel het nummer blijft over

                        int m = Convert.ToInt32(nummerM);// "MX" = "Mm"
                        //M

                        //waarde in array en op de juiste plaats zetten
                        getallen[m] = Convert.ToDouble(deelIngave[1]);

                        /*test
                        Console.WriteLine("Hier zit " + getallen[m]);
                        Console.WriteLine(deelIngave[1]);
                        Console.WriteLine(getallen.Length);
                        //eind test*/

                    }
                    //BEGIN bewerkingen
                    //kijk naar de tekens en voer de bewerking uit
                    else if (ingave[i] == '*')
                    {
                        uitkomst = Convert.ToDouble(deelIngave[0]) * Convert.ToDouble(deelIngave[1]);
                        Console.WriteLine("uitkomst is:" + uitkomst);
                    }
                    else if (ingave[i] == '/')
                    {
                        //kijken of er een sul je programma gebruikt en wil delen door nul
                        if (deelIngave[i] == "0")
                        {
                            DelenDoorNul();
                        }
                        else
                        {
                            uitkomst = Convert.ToDouble(deelIngave[0]) / Convert.ToDouble(deelIngave[1]);
                            Console.WriteLine("uitkomst is:" + uitkomst);
                        }
                    }
                    else if (ingave[i] == '-')
                    {
                        uitkomst = Convert.ToDouble(deelIngave[0]) - Convert.ToDouble(deelIngave[1]);
                        Console.WriteLine("uitkomst is:" + uitkomst);
                    }
                    else if (ingave[i] == '%')
                    {
                        uitkomst = Convert.ToDouble(deelIngave[0]) % Convert.ToDouble(deelIngave[1]);
                        Console.WriteLine("uitkomst is:" + uitkomst);
                    }
                    else if (ingave[i] == '+')
                    {
                        uitkomst = Convert.ToDouble(deelIngave[0]) + Convert.ToDouble(deelIngave[1]);
                        Console.WriteLine("uitkomst is:" + uitkomst);
                    }
                    //EINDE bewerkingen
                } //EINDE FOR


            }//EINDE DO
            while (true);
            //EINDE DO WHILE
        }//EINDE OVERLOPEN

        private static void Ring()
        {

            Console.WriteLine("                                              ``````                                                ");
            Console.WriteLine("                                     `````..-:::::--..``````                                        ");
            Console.WriteLine("                                ``.-/+osyhddddmmdmdddhhyso/-.```                                    ");
            Console.WriteLine("                            `..-/shdmmmmmmmmmmmmmmddmmmmdddhhs+:.```                                ");
            Console.WriteLine("                          ..-/ydmmmmmmmmmmddddddhyyso+/-.-ddddhhyo:```                              ");
            Console.WriteLine("                       `.-:ohmmmmmmmmddhhyso+:-..``       +hhhdddhhs:` ``                           ");
            Console.WriteLine("                     ..:sdmmmddhys+/:-..``         `.:+osyhhhdddddhhs:  `                          ");
            Console.WriteLine("                   `..odNNy +/-..``                 `-/syhhhhhdddddddhho` ``                        ");
            Console.WriteLine("                 ..:hmNNNy-`````.         ``````      .+yhhhddddddddhhs. ``                       ");
            Console.WriteLine("                ../mmNNmmmysosyy:     `-/osyyyyso/.     .+hhhdddddddhhhs. `.`                     ");
            Console.WriteLine("               .-:mNNNmmmmddddh:    `:shhdddhhhhhhho.     /hhhdddddddhhho` .:.                    ");
            Console.WriteLine("              `-.hmNNNmmmmdddd+`   `ohhddddddhhhhhhhy.    `shddddhhhhhhhh: `:+.                   ");
            Console.WriteLine("              :./ mNNNmmmmddddh-    /hdddddddhhhhhhhhho     +hddddhhhhhhhho  :o+-`                 ");
            Console.WriteLine("             `:`+mNNNNmmmddddy.    +hdddddddhhhhhhhhhs     +hddddhhhhhhhhs  -ss/-`                ");
            Console.WriteLine("            `--`omNNNmmmmddddh:`   .yhdddddddhhhhhhhy-    `shddddhhhhhhhhs  -syo/-`               ");
            Console.WriteLine("            --:`/mNNNNmmmmddddo.    .ohhdddhhhhhhhyo.     /hhddddhhhhhhhh: .:yyso/:`              ");
            Console.WriteLine("           ./::``dNNNNmmmmdddddo.     ./oyyyyyyso:.      /syyyhdddhhhhhhs` :+hyyoo/-`             ");
            Console.WriteLine("         `:oo:-`+mNNNmmmmmdddddy/`       `````         `..````+dddhhhhy- -:yhyyss+/-`            ");
            Console.WriteLine("         ./sy/:.`ymmmmmmmmmddddddho:.                          sddhhhy: -:ydhhyyso+/.            ");
            Console.WriteLine("       `:+syy::.`ymmmmmmmmmmmddddhs+.                ``.-:/+oshddhhs.`-:hddhhyysso/:.           ");
            Console.WriteLine("        .:osyhy::.`smmmmmmmmmmms-`           ``.:/+osyyhhhhhhhhhhhy/`.-+ddddhhyysso+/-`          ");
            Console.WriteLine("       `-/osyhhy::.`:hmmmmNNmmmy.``  `.-/+osyyhhhhhhhhhhhhhhhhhhy/`.-:yddddhhhyysso+/:-          ");
            Console.WriteLine("      `:/ osyhddh+---.:shmmNmmmm++osyhddddddhhhhhhhhhhhhhhhhhyo:..-:sdmmdddhhyyysso+//-`         ");
            Console.WriteLine("      .:+osyhhdddy/--:--/shmmmmmmmdddddddddddddddhhhhhhhhs+:--::+sdmmmddhhyyyssso++//:.         ");
            Console.WriteLine("       -/+osyyhddmmdho/::---:+yddmmmmmmdddddddddddhhyo+/---::/+shdmmdddhhhyyssssoo+++/:.         ");
            Console.WriteLine("      `-/+osyyhhddmmmmdhs+/::::::/oossyyyssssoo+/:---::/+osyhdmmmmdddhhyyyssssoooo+++/:.         ");
            Console.WriteLine("      `-/+ssyyyhhddmmmmmmmdhysoo++//::--------:/++osyhdmmmmmmmmmddhhyyso+//:--...-:://:`         ");
            Console.WriteLine("     `:/ ossyyyhhhddmmmmmmmmmmmmmddhyysooooyhddmmmNNNNNNmmmmmddhys+/:.```.```     .-.--          ");
            Console.WriteLine("     `:/ ossyyyyhhdddmmmmmmmmmNNmmmmmmmdddddmmmmNNNNmmmmddhyo+:-``    `...````   ``--.`          ");
            Console.WriteLine("     `:/ ossyyyhhhdddmmmmmNNNNNNNmmmmmmmmmmmmmmddhyso+/:-.``        .--....````  `.--`           ");
            Console.WriteLine("    `:/ ossyyyhhhddmmmmmmmNNNNmmmmmmmddhyso+/:-.```             `-/+/:-....```  `-/.            ");
            Console.WriteLine("      -/+ssyyhhhddmmmmmmmmmddhyso+/:-.``                     `-:////+/:-....````./:             ");
            Console.WriteLine("      .:+osyyhhdddmmmmdhs+/-.``                          `.-://:::::/++:-.......:-              ");
            Console.WriteLine("       - +osyyhhddmmhs/-`                            ``.-::///::::::::/o+:--.--:-`               ");
            Console.WriteLine("       `:osyhhdddy /-.`````                   ```...--:::///:----::::::+o+::::-.                 ");
            Console.WriteLine("       `/ syhhdh/...--:/+o+/::--.........```````...---:::/:--.----::::/+/::.`                   ");
            Console.WriteLine("       ./syhy:` `..-:/sys++//::::--..```      ```..--::/-......--:/::-.`                      ");
            Console.WriteLine("       `:oy /-```..-:/syso+///::---..``         ``.---::......-:::-``                         ");
            Console.WriteLine("        ./:-..``..-:+sso++//::---.``          ```....-.--:::-.`                             ");
            Console.WriteLine("          `.:--...-:/oso++//:::--.``              ``..--.``                                 ");
            Console.WriteLine("            `.:/:---:+ooo+///::--..``  ```````````.```                                      ");
            Console.WriteLine("              `...--:://///::::--------..``````                                            ");
            Console.WriteLine("                    `````````````````                                                      ");


        }//ascii ring

        private static void Info()
        {
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("*                                       INFO                                          *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* -Dit programma kan variabelen opslaan en weergeven, maar kan er niet mee rekenen :( *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("* -Bij ingave van nul bij een deling komt er een bericht                              *");
            Console.WriteLine("* -Na het ingeven van de 'lantern' command kun je niet meer terug tenzij je exit typed*");
            Console.WriteLine("*  Ik heb http://www.text-image.com/convert/ascii.html gebruikt voor de ascii art     *");
            Console.WriteLine("* -Je kan opgaven blijven ingeven to als je 'exit' typed                              *");
            Console.WriteLine("* -Locals worden weergegeven van 'M0' tot 'M9'                                        *");
            Console.WriteLine("***************************************************************************************");

        }//hier staan tips en info over het programma

        private static void DelenDoorNul()
        {
            //kleur veranderen
            ConsoleColor vorigekleur = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("********************************");
            Console.WriteLine("*             OEPS             *");
            Console.WriteLine("*        DELEN DOOR NUL        *");
            Console.WriteLine("*          IS  VOOR            *");
            Console.WriteLine("*           LOSERS             *");
            Console.WriteLine("********************************");
            //kleur terugzetten
            Console.ForegroundColor = vorigekleur;
        }

        private static void Listcalc()
        {
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*                               LISTCALC                               *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* +          1+2            //Geeft de som van de getallen weer        *");
            Console.WriteLine("* -          1-2            //Geeft het verschil van de getallen weer  *");
            Console.WriteLine("* *          1*2            //Geeft het product van de getallen weer   *");
            Console.WriteLine("* /          1/2            //Geeft het quotiënt van de getallen weer  *");
            Console.WriteLine("* %          1%2            //Geeft de delingsrest van de getallen weer*");
            Console.WriteLine("************************************************************************");
        }//LISTCALC

        public static String Invoer()
        {
            Console.Write(">");
            //variabele "ingave"
            String ingave;
            // ingave checken
            ingave = Console.ReadLine();
            //ingave terugsturen
            return ingave;
        }
        //auteur
        private static void Author()
        {



            Console.WriteLine("                              ,(((((/*,,,,,,,,,,,*/((((((.                     ");
            Console.WriteLine("                        ((,,,,                             ,,,,((              ");
            Console.WriteLine("                     (,         &@@@@@@@@@@@@@@@@@@@@@@@,,,,,,@@@@#            ");
            Console.WriteLine("                     /,,    .@@@@@@@@@@,,,,,,,,@@@@@@@@@@,,,,,,,@@             ");
            Console.WriteLine("                      *  @@@@@@@@@@@@@@@.,,,,,,,@@@@@@@@@@,,,,,/@@             ");
            Console.WriteLine("                     #@@@@@@@@@@@@@@@@@@@*,,,,,@@@@@(@@@@@@,,,@@@@             ");
            Console.WriteLine("                   @@@@@@@@@##&@@@@@@@@@@@,,,,@@@@@@ @@@@@@@,,,@@              ");
            Console.WriteLine("                   ,@@@@@@&@@&&&%#@@@@@@@@@,,,,@@@@  /@@@@@@%,,,@              ");
            Console.WriteLine("                    @@@@@@@&& &@&&&@@@@@@@@@@,,,,@@    @@@@@@@,@@@             ");
            Console.WriteLine("                      @@&@@@@&&&&&&@@@@@@@@@@,,,@ &@@@@@@@@@@&@@               ");
            Console.WriteLine("                     #@&&&&@@@&&&&&&&@@@@@@@@@@@@@@@@#  @&@@@&&@@              ");
            Console.WriteLine("                     @&&&&&&&@@&&&&&&&&&&@@@&   #@@(@(@ @(&@@@@&&/             ");
            Console.WriteLine("                    @@&&&&&&&@@@&&&&&&&@@@&&@   .@@@#@@.@@&@@@@&&@             ");
            Console.WriteLine("                   @@&&&&&&&&@@@&&&&&@@@@&&&@     @@@@@  @&&&@@&@@             ");
            Console.WriteLine("                  /%@&&&&&&&&@@@@@@@@&&&&&&@,            &(&&@&&&@#            ");
            Console.WriteLine("                 .@@&&&&&&&&&&@@@&@&&&&&&&&@             *@&&&&&&&@            ");
            Console.WriteLine("                .@(&&&&&&&&&&&&&&&&&&&&&@               @#&&&&&&(@             ");
            Console.WriteLine("               #@(@&&&&&%&&&&&&&&&&&&&&&&&@              /@(&@&@&&&@.          ");
            Console.WriteLine("              @((@&&&&&%(&&&&&&&&&&&&&&&&@               @&@&@&%&&&(@          ");
            Console.WriteLine("             @(&&&&&&&@(&&&&&&&&&&&&&&&&&&               @&@&@&&@&&&(@         ");
            Console.WriteLine("           @#(&&&&&&&@(&&%&&&&&&&&&&&&&&@               #@&&%&&&%@&&@          ");
            Console.WriteLine("         @@(&&&&&&&&@(&&%&&&&&&%&&&&&&&@                @&&&&&@&&(@&&&@&       ");
            Console.WriteLine("      @@((#&&&&&&@@@(&&&&&&&&&&&&&&&&@                @&&&&&@&&&&@&&&@&        ");
            Console.WriteLine("    @(((&&&&&&&@&@%(&&&&&&&(#&&&&&&&@                @@&&&&&@@&&%@@&&&@@       ");
            Console.WriteLine("   #@#&&&&&&&&&@@(&&&&(&&&&&((&&&&&&&&&               .@&&&&(&&@@&&(@@@&&(@    ");
            Console.WriteLine("   @&&&&&&&&&@@((&&&@(&&&&&((&&&&&&&&@&,,*,,*,,*,,,*/*,@&&&&&@@&&&(@&&&@@      ");
            Console.WriteLine("   &@&&&&&@@@((%&&&@(&@&&&&(&&@&&&&&&@@**////,,/*,,,///(&&@&&&&&@@&&&(@&&&&&(@ ");
            Console.WriteLine("    @@&@@@@(((&&&&@(&@@&&@(&&&@&&&&&&&&////////////*,,(&&&@(&&&&@@&&&&(@@&@&@   ");
            Console.WriteLine("     @@@(((#&&&&@@(&&&&&@(&&&@&&&&&&&&@(((((((((#@@@@@@&&&&(&&&&&@&&&&&(@@@*    ");
            Console.WriteLine("    @((((&&&&&&@((&&@&@@(%&&@@&&&&&&&@&@@@@@@@@@@@@@@@@&&@((&&&&&&@@&&&&((@     ");
            Console.WriteLine("     @&&&&&&&@@@@&@@&@@((&&&@&&&&&&&&@&@@@@@@@@@@@@@@@&&@@((&&&&&&@@&&&&&(@     ");
            Console.WriteLine("      @&&&&@@@@@@@@@&@((&&&@@&&&&@@&&@&@@@@@@@@@@@@@@@&&@@(#&&&&&&&@@&&&&@      ");
            Console.WriteLine("        @@&@@@@@@ @&@(((&&@@@&&&&&&&&&&@@            @&&@(((&&&&&&&&@@@@        ");
            Console.WriteLine("            @@@& @@@@@#&&&&@&&&&&@&&&&&&@*           @&&@@@@@@@&&&&&&@          ");
            Console.WriteLine("                @&&@@@@ @@&@&&&&@@&&&&&&@@           @&&@@@@     #@@@@          ");
            Console.WriteLine("               @@&&@@@   #@@&&&&@&&&&&&&@@           @@&&&@@                    ");
            Console.WriteLine("               @@&&&&@     .@@,/&&&&&&&&@.            @@@@@@                    ");
            Console.WriteLine("                                *@@&@@@@                                        ");

            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Created by Beau Roels aka:");
            Console.WriteLine("");

            Console.WriteLine(" _________          _______  _______ _________ _        _        _______             ");
            Console.WriteLine(" (__   __)|)     (|(  ____ )(       )(__   __)( )      | )    /)(  ____ )|)     (|()     ()");
            Console.WriteLine("    ) (   | )   ( || (    (/| () () |   ) (   | (      |  )  / /| (    ()| )   ( |( )   ( )");
            Console.WriteLine("    | |   | (___) || (__    | || || |   | |   | |      |  (_/ / | |      | |   | | ( (_) ) ");
            Console.WriteLine("    | |   |  ___  ||  __)   | |(_)| |   | |   | |      |   _ (  | | ____ | |   | |  (   )  ");
            Console.WriteLine("    | |   | (   ) || (      | |   | |   | |   | |      |  ( ) ) | | (_  )| |   | |   ) (   ");
            Console.WriteLine("    | |   | )   ( || (____/)| )   ( |___) (___| (____/)|  /  ) )| (___) || (___) |   | |   ");
            Console.WriteLine("    )_(   |)     (|(_______/|)     (|(_______)(_______/|_/    )/(_______)(_______)   (_)   ");


        }

        //lantern functionaliteit
        private static void Nerd()
        {
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*                               LANTERNS                              *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("* -Selecteer van welke corps je het logo wil zien                     *");
            Console.WriteLine("* -death                                                              *");
            Console.WriteLine("* -life                                                               *");
            Console.WriteLine("* -avarice                                                            *");
            Console.WriteLine("* -love                                                               *");
            Console.WriteLine("* -will                                                               *");
            Console.WriteLine("* -rage                                                               *");
            Console.WriteLine("* -indigo                                                             *");
            Console.WriteLine("* -fear                                                               *");
            Console.WriteLine("* -hope                                                               *");
            Console.WriteLine("***********************************************************************");

           
            //variabelen
            do
            {
                //ingave oproepen
                String ingave = Invoer();
                //bij correcte command juiste logo tonen
                if (ingave == "death")
                {
                    //kleur veranderen
                    ConsoleColor vorigekleur = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();

                    Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMNNmmmmNNMMMMMMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMNhs/-.`      `.:+sdNMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMms:` `.-/hd/..ohy--.` `/yNMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMd/` .ody  :MM/  sMM` `mh+` `omMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMN+ `--.NMy  :MM/  sMM`  mMh.-. `oNMMMMMMMM");
                    Console.WriteLine("MMMMMMMh. .h`  NMy  :MM/  sMM`  mMh  :s` -mMMMMMMM");
                    Console.WriteLine("MMMMMMh` :NM   NMy  :MM/  sMM`  mMh  -Mm. .mMMMMMM");
                    Console.WriteLine("MMMMMN` -NMM   NMy  :MM/  sMM`  mMh  -MMm` :MMMMMM");
                    Console.WriteLine("MMMMM+  dMMM   NMy  :MM/  sMM`  mMh  -MMMs  hMMMMM");
                    Console.WriteLine("MMMMM. .MMMM```NMy``/MM/``sMM```mMd``:MMMN  /MMMMM");
                    Console.WriteLine("MMMMM` :Ns::```::-``.::.``-::```::-``.:/yM  :MMMMM");
                    Console.WriteLine("MMMMM- .MMh:    -::::::::::::::::.   `/dMm  +MMMMM");
                    Console.WriteLine("MMMMMs  hMMMh:  .sNMMMMMMMMMMMMmo. `/dMMMo  dMMMMM");
                    Console.WriteLine("MMMMMN. .mMMMMh:  -yNMMMMMMMMNo. `/dMMMMh` /MMMMMM");
                    Console.WriteLine("MMMMMMm. -mMMMMMh:  -yNMMMMNo.  /dMMMMMh` :NMMMMMM");
                    Console.WriteLine("MMMMMMMm: `sNMMMMNh:  -yNNs.  /dMMMMMN+` /NMMMMMMM");
                    Console.WriteLine("MMMMMMMMNs` .sNMMMMMh:  ..  /dMMMMMmo. -hMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMNo. `/ymMMMMh:  /dMMMNds:` -yNMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMNd+- `.:+osy/+yso/-```:omMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMNho/:-.````.-:+sdNMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");

                    //kleur terugzetten
                    Console.ForegroundColor = vorigekleur;
                }

                else if (ingave == "life")

                {
                    //kleur veranderen
                    ConsoleColor vorigekleur = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                    Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMMMho +/yMMMM+/+sdMMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMMM`   :MMMN    /MMMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMy -`dMMM+   `MMMh    dMMMd`-yMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMM +   `mMMd    mMMo   .MMMm`   +MMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMM:   -NMM.   yMM:   oMMN-   :MMMMMMMMMMM");
                    Console.WriteLine("MMMMMMh`+NMM/  `oMMddmNMMMMNmhNMMo`  /MMm:-NMMMMMM");
                    Console.WriteLine("MMMMMd   .yMMsdMNhMM:-..mh.-:/NMdNMdsMN+   -NMMMMM");
                    Console.WriteLine("MMMMMs`  `oNMMy.  /M/   yo   `M+  -sMMd/   .dMMMMM");
                    Console.WriteLine("MMMMNMNosNNo.+N:   +h   o:   /y   `dy-sNm+yMMMMMMM");
                    Console.WriteLine("MMMM +.dMMy`   .y/   o.  :`   s`   y/   `hMMs`hMMM");
                    Console.WriteLine("MMMM:oMm:oo.    :-   `  `    .   /`    ++/NN-sMMMM");
                    Console.WriteLine("MMMMyMm`   .`                         -`  -NNhMMMM");
                    Console.WriteLine("MMMMMM:   smmmmmmmmmmmmmmmmmmmmmmmmmmmms   oMMMMMM");
                    Console.WriteLine("MMMMMN     oMMMNddddddddddddddddddMMMMo    .MMMMMM");
                    Console.WriteLine("MMMMMd      :NMMs               `yMMm-     .MMMMMM");
                    Console.WriteLine("MMMMMMs      `dMMd.            -mMMh`     `dMMMMMM");
                    Console.WriteLine("MMMMMMMd -      oMMN/          +MMM+      -mMMMMMM");
                    Console.WriteLine("MMMMMMMMMs`     :NMMs       `yMMm-     .yMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMs -    `dMMd.    -mMMy`    :yMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMdo -   oMMN:  +MMN/  `:sNMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMNho /sMMMshMMNooymMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                    //kleur terugzetten
                    Console.ForegroundColor = vorigekleur;


                }
                else if (ingave == "avarice")

                {
                    //kleur veranderen
                    ConsoleColor vorigekleur = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine();

                    Console.WriteLine("MMMMMMMMMMMMMMMNmdhyssoooooossyhdmNMMMMMMMMMMMMMMM");
                    Console.WriteLine(" MMMMMMMMMMMNdhsooooooossssssoooooooshdNMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMmyoooooohmNMMMMMMMMMMNmhooooooymMMMMMMMMM");
                    Console.WriteLine("MMMMMMMdsoooshoooyNMMMMMMMMMMMMNsooohsooosdMMMMMMM");
                    Console.WriteLine("MMMMMdsoooymMMmsoosNMMMMMMMMMMNsoosNMMmyooosdMMMMM");
                    Console.WriteLine("MMMNyooosNMMMMMNsoosmMMMMMMMMmooosNMMMMMNsoooyNMMM");
                    Console.WriteLine("MMNsoooooshmMMMMNsooodmmddmmdoooyMMMMMmhsooooosNMM");
                    Console.WriteLine("MNsooshsoooooydNMNsoooooooooooosNMMmhsooooshsoosNM");
                    Console.WriteLine("MyooomMMNdyooooosooooooohhoooooooyoooooydNMMmoooyM");
                    Console.WriteLine("dooohMMMMMMMmhsoooohhoooysooodhooooohmMMMMMMMhoood");
                    Console.WriteLine("yoooMMMMMMMMMNooosNMMdoooooomMMNsoooNMMMMMMMMMoooy");
                    Console.WriteLine("oooyMMMMMMMMMhooomMMMMmsoosmMMMMNoooyMMMMMMMMMyooo");
                    Console.WriteLine("oooyMMMMMMMMMsoooMMMMMMNssNMMMMMMooosMMMMMMMMMyooo");
                    Console.WriteLine("oooyMMMMMMMMMhooomMMMMMMNNMMMMMMNoooyMMMMMMMMMyooo");
                    Console.WriteLine("yoooMMMMMMMMMNooosNMMMMMMMMMMMMNsoooNMMMMMMMMMoooy");
                    Console.WriteLine("dooohMMMMMMMMMmsooohNMMMMMMMMNhoooomMMMMMMMMMhoood");
                    Console.WriteLine("MyooomMMMMMMMMNyooooosyhddhysoooooyNMMMMMMMMmoooyM");
                    Console.WriteLine("MNsoosmMMMMMNyooooyyooooooooooyhooooyNMMMMMNsoosNM");
                    Console.WriteLine("MMNsooodMMNyoooohNMMMNmmddmmNMMMNhooooymMMdooosNMM");
                    Console.WriteLine("MMMNyoooyyoooohNMMMMMMMMMMMMMMMMMMNhooooyyoooyNMMM");
                    Console.WriteLine("MMMMMdsooooohNMMMMMMMMMMMMMMMMMMMMMMNhooooosdMMMMM");
                    Console.WriteLine("MMMMMMMdsoooshNMMMMMMMMMMMMMMMMMMMMNdsooosdMMMMMMM");
                    Console.WriteLine("MMMMMMMMMmyoooosydmNMMMMMMMMMMNmdysooooymMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMNdhsooooooossssssoooooooshdNMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMNmdhyssoooooossyhdmNMMMMMMMMMMMMMMM");
                    //kleur terugzetten
                    Console.ForegroundColor = vorigekleur;
                }
                else if (ingave == "will")

                {
                    //kleur veranderen
                    ConsoleColor vorigekleur = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();

                    Console.WriteLine("MMMMMMMMMMMMMMMMNmdhhyyssssyyhhdmNMMMMMMMMMMMMMMMM");
                    Console.WriteLine(" MMMMMMMMMMMMNdysooooooossssooooooosydNMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMNhsooooyhdmNMMMMMMMMNmdhyooooshNMMMMMMMMM");
                    Console.WriteLine("MMMMMMMmyoooshmMMMMMMMMMMMMMMMMMMMMmhsoooymMMMMMMM");
                    Console.WriteLine("MMMMMNyoooymMMMMMMMMMMMMMMMMMMMMMMMMMMmyoooyNMMMMM");
                    Console.WriteLine("MMMMdsoosmMMNyyyyyyyyyyyyyyyyyyyyyyyyNMMmsoosdMMMM");
                    Console.WriteLine("MMMhooohMMMMMmsoooooooooooooooooooosmMMMMMhooohMMM");
                    Console.WriteLine("MMhooomMMMMMMMmyyysoooooooooooosyyymMMMMMMMmooohMM");
                    Console.WriteLine("MdooodMMMMMMMMMMNyoooossyyssooooyNMMMMMMMMMMdooodM");
                    Console.WriteLine("MsooyMMMMMMMMMMdoooshNMMMMMMNhsooodMMMMMMMMMMyoosM");
                    Console.WriteLine("doooNMMMMMMMMMdoooyMMMMMMMMMMMMyooodMMMMMMMMMNoood");
                    Console.WriteLine("yoosMMMMMMMMMNooosMMMMMMMMMMMMMMsoosNMMMMMMMMMsooy");
                    Console.WriteLine("yoosMMMMMMMMMmooohMMMMMMMMMMMMMMhooomMMMMMMMMMsooy");
                    Console.WriteLine("hoosMMMMMMMMMNsoosMMMMMMMMMMMMMMsoosNMMMMMMMMMsooy");
                    Console.WriteLine("doooNMMMMMMMMMdoooyMMMMMMMMMMMMyooodMMMMMMMMMNoood");
                    Console.WriteLine("MsooyMMMMMMMMMMdoooshmMMMMMMmhsooodMMMMMMMMMMyoosM");
                    Console.WriteLine("MdooodMMMMMMMMMMNyoooossyyssooooyNMMMMMMMMMMdooodM");
                    Console.WriteLine("MMhooomMMMMMMMmyyysoooooooooooosyyymMMMMMMMmooohMM");
                    Console.WriteLine("MMMhooohMMMMMmsoooooooooooooooooooosmMMMMMhooohMMM");
                    Console.WriteLine("MMMMdsoosmMMNyyyyyyyyyyyyyyyyyyyyyyyyNMMmsoosdMMMM");
                    Console.WriteLine("MMMMMNyoooymMMMMMMMMMMMMMMMMMMMMMMMMMMmyoooyNMMMMM");
                    Console.WriteLine("MMMMMMMmyoooshmMMMMMMMMMMMMMMMMMMMMmhsoooymMMMMMMM");
                    Console.WriteLine("MMMMMMMMMNhsooooyhdmNMMMMMMMMNmdhyooooshNMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMNdysooooooossssooooooosydNMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMNmdhyyyssssyyyhdmNMMMMMMMMMMMMMMMM");
                    //kleur terugzetten
                    Console.ForegroundColor = vorigekleur;
                }
                else if (ingave == "hope")

                {
                    //kleur veranderen
                    ConsoleColor vorigekleur = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();

                    //kleur terugzetten
                    Console.WriteLine(" They are useless");
                    Console.ForegroundColor = vorigekleur;
                }
                else if (ingave == "indigo")

                {
                    //kleur veranderen
                    ConsoleColor vorigekleur = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine();



                    Console.WriteLine("MMMMMMMMMMMMMMMMNmmddddhhhhddddmmNMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMNmdhhhhhhhhhhhhhhhhhhhhdmNMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMNdhhhhhyo +//::/ys/::/+osyhhhhddNMMMMMMMMM");
                    Console.WriteLine("MMMMMMMmdhhhyo /::::::/yhhhhs/::::::+shhhhdmMMMMMMM");
                    Console.WriteLine("MMMMMNdhhhs /:::::::/yhhhsshhhs/:::::::+yhhhdNMMMMM");
                    Console.WriteLine("MMMMmhhhy /:::::::/yhhhs/::/shhhs/:::::::+hhhhmMMMM");
                    Console.WriteLine("MMMdhhh +:::::::+yhhhs/:////:/yhhhs/:::::::shhhdMMM");
                    Console.WriteLine("MMdhhh /::::::+yhhhhsyhhhhhhhhyyhhhhy/::::::ohhhdMM");
                    Console.WriteLine("Mdhhh /::::::+oooyhhhhhysoosyhhhhhyooo/::::::ohhhdM");
                    Console.WriteLine("Nhhho::::::::::shhhs/::::::::/shhhs::::::::::yhhhN");
                    Console.WriteLine("dhhh::::::::::shhh/::::::::::::/hhhs:::::::::+hhhd");
                    Console.WriteLine("dhhy:::::::::/hhh+::::::::::::::+hhh/:::::::::hhhd");
                    Console.WriteLine("hhhs:::::::::ohhh::::::::::::::::hhho:::::::::hhhh");
                    Console.WriteLine("dhhy:::::::::/hhh+::::::::::::::+hhh/:::::::::hhhd");
                    Console.WriteLine("dhhh::::::::::shhh/::::::::::::/hhhs:::::::::+hhhd");
                    Console.WriteLine("Nhhho::::::::::shhhs/::::::::/shhhs::::::::::yhhhN");
                    Console.WriteLine("Mdhhh /::::::+oooyhhhhhysoosyhhhhhyooo+::::::ohhhdM");
                    Console.WriteLine("MMdhhh /::::::+yhhhysyhhhhhhhhyshhhhy+::::::ohhhdMM");
                    Console.WriteLine("MMMdhhh +:::::::+yhhhs/:////:/shhhy+:::::::shhhdMMM");
                    Console.WriteLine("MMMMmhhhy /:::::::+yhhhs/::/shhhy+:::::::+hhhhmMMMM");
                    Console.WriteLine("MMMMMNdhhhs /:::::::+yhhhsohhhy+:::::::+yhhhdNMMMMM");
                    Console.WriteLine("MMMMMMMmdhhhyo /::::::+yhhhhy+::::::+shhhhdmMMMMMMM");
                    Console.WriteLine("MMMMMMMMMNddhhhhyo +//::+yy+::/+osyhhhhddNMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMNmdhhhhhhhhhhhhhhhhhhhhdmNMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMNmmddddhhhhddddmmNMMMMMMMMMMMMMMMM");
                    //kleur terugzetten
                    Console.ForegroundColor = vorigekleur;

                }
                else if (ingave == "rage")

                {
                    //kleur veranderen
                    ConsoleColor vorigekleur = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();

                    Console.WriteLine("MMMMMMMMMMMMMMMMNmmmddddddddddmmmNMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMNmddddddddddddddddddddddmNMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMNmdddddmmNNMMMMMMMMMMNNmmdddddmNMMMMMMMMM");
                    Console.WriteLine("MMMMMMMmdddddmNMMMMMMMMMMMMMMMMMMMMNmdddddmMMMMMMM");
                    Console.WriteLine("MMMMMNdddddddmMMMMMMMMMMMMMMMMMMMMMMmdddddddNMMMMM");
                    Console.WriteLine("MMMMdddddmdddmMMMMMMMMMMMMMMMMMMMMMMmdddmdddddMMMM");
                    Console.WriteLine("MMNddddNMNdddmMMMMMMMMMMMMMMMMMMMMMMmdddmMNddddNMM");
                    Console.WriteLine("MMddddNMMNdddmMMMMMMMMMMMMMMMMMMMMMMmdddmMMNddddMM");
                    Console.WriteLine("MddddNMMMNddddNMMMMMMMMMMMMMMMMMMMMNddddNMMMNddddM");
                    Console.WriteLine("NdddmMMMMMNddddmMMMMMMMMMMMMMMMMMMmddddNMMMMMmdddN");
                    Console.WriteLine("ddddMMMMMMMMddddNMMNNmmddddmmNNMMNddddMMMMMMMMdddd");
                    Console.WriteLine("ddddMMMMMMMMddddNmddddddddddddddmNddddMMMMMMMMdddd");
                    Console.WriteLine("dddmMMMMMMMMddddddddmmNMMMMNNmddddddddMMMMMMMMmddd");
                    Console.WriteLine("ddddMMMMMMMMddddddmNMMMMMMMMMMMmddddddMMMMMMMMdddd");
                    Console.WriteLine("ddddMMMMMMMMdddddmMMMMMMMMMMMMMMmdddddMMMMMMMMdddd");
                    Console.WriteLine("NdddmMMMMMMMdddddMMMMMMMMMMMMMMMMdddddMMMMMMMmdddN");
                    Console.WriteLine("MddddNMMMMMMdddddMMMMMMMMMMMMMMMMdddddMMMMMMNddddM");
                    Console.WriteLine("MMddddNMMMMMdddddmMMMMMMMMMMMMMMmdddddMMMMMNddddMM");
                    Console.WriteLine("MMNddddNMMMMddddddmMMMMMMMMMMMMmddddddMMMMNddddNMM");
                    Console.WriteLine("MMMMdddddNMMddddddddmNMMMMMMNmddddddddMMNdddddMMMM");
                    Console.WriteLine("MMMMMNddddmNddddNmddddddddddddddmNddddNmddddNMMMMM");
                    Console.WriteLine("MMMMMMMmddddddddNMMNmmddddddmmNMMNddddddddmMMMMMMM");
                    Console.WriteLine("MMMMMMMMMNdddddddmNNMMMMMMMMMMNNmdddddddNMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMNmddddddddddddddddddddddmNMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMNmmmddddddddddmmmNMMMMMMMMMMMMMMMM");
                    //kleur terugzetten
                    Console.ForegroundColor = vorigekleur;
                }
                else if (ingave == "fear")

                {
                    //kleur veranderen
                    ConsoleColor vorigekleur = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();

                    Console.WriteLine("MMMMMMMMMMMMMMMNdhyoo+//////+osyhdNMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMNds +///////+oooo+///////+sdNMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMdo////+shdmNMNNNmNNMNmdhs+////odMMMMMMMMM");
                    Console.WriteLine("MMMMMMNh +///+ymMNdyo+////////+oshmMmy+///+hNMMMMMM");
                    Console.WriteLine("MMMMMh +///smMmy+/////+ossssso+/////sdMms///+hMMMMM");
                    Console.WriteLine("MMMNo///omMdo//////+NMMMMMMMMNo//////+yNmo///oNMMM");
                    Console.WriteLine("MMm +///hMMh///odd///+mMNNNNMNo///dmy//+yMMh///+mMM");
                    Console.WriteLine("MN +//+mMMMMNhdMMMm+////////////+mMMMNdMMMMMm+//+NM");
                    Console.WriteLine("Mo////oydNMMMMMMms/////oooo+////omMMMMMMNdyo////oM");
                    Console.WriteLine("h///+/////+NMMMy///+ymMMMMMMmy+///yMMMNo/////+///h");
                    Console.WriteLine("o///NNs///yMMMy///sNMMMMMMMMMMMs///sMMMh///sNN///o");
                    Console.WriteLine("///oMMo///mMMm///oMMMMMMMMMMMMMMo///mMMN///+MMo///");
                    Console.WriteLine("///sMM+///NMMd///yMMMMMMMMMMMMMMh///dMMM////MMs///");
                    Console.WriteLine("///oMMo///mMMm///oMMMMMMMMMMMMMMs///mMMN///+MMo///");
                    Console.WriteLine("o///NMh///yMMMs///yMMMMMMMMMMMMy///sMMMy///yMN///o");
                    Console.WriteLine("h///yMM+///dMMMs///+hNMMMMMMNh+///sMMMm///+NMy///h");
                    Console.WriteLine("Mo///mMm+///dMMMdo////+osso+////odMMMd+///mMm///oM");
                    Console.WriteLine("MN +//+mMm+///sNMMMmo//////////+mMMMNy///+mMm+//+NM");
                    Console.WriteLine("MMm +///hMNy////smMd///oNmmNo///hMmy////sNMh///+mMM");
                    Console.WriteLine("MMMNo///omMms////+///+NMMMMN+///+////smMmo///oNMMM");
                    Console.WriteLine("MMMMMh +///smMNho/////mMMMMMMN+////ohNMms///+hMMMMM");
                    Console.WriteLine("MMMMMMNh +///+ymMNdhsdMMMMMMMMmsydNMmy+///+yNMMMMMM");
                    Console.WriteLine("MMMMMMMMMdo////+sydmNMMMMMMMMMmdhs+////odMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMNds +///////+oooo+///////+sdNMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMNdhyoo +//////+ooyhdNMMMMMMMMMMMMMMM");
                    //kleur terugzetten
                    Console.ForegroundColor = vorigekleur;
                }
                else if (ingave == "love")

                {
                    //kleur veranderen
                    ConsoleColor vorigekleur = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine();

                    Console.WriteLine("MMMMMMMMMMMMMMMMNmddhhhhhhhhhhddmNMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMmdhhhhhhhhyyyyyyhhhhhhhhdmMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMmdhhhhyso /::---+/---::/osyhhhhdmMMMMMMMMM");
                    Console.WriteLine("MMMMMMMmhhhhyo /--------:yy:--------/oyhhhhmMMMMMMM");
                    Console.WriteLine("MMMMMmhhhhs /-----------shhy-----------/shhhhmMMMMM");
                    Console.WriteLine("MMMMdhhhs:------------ohhhhs------------:shhhdMMMM");
                    Console.WriteLine("MMNhhhh +-----:/:-----/hhhhhh+-----:/+-----+hhhhNMM");
                    Console.WriteLine("MNhhhy /-------shyso+/yhhhhhhh+/osyhy:------/yhhhNM");
                    Console.WriteLine("Mdhhh /---------yhhhhhhhhhhhhhhhhhhy:--------/hhhdM");
                    Console.WriteLine("mhhho----------:yhhhhho/::/+yhhhhy:----------ohhhm");
                    Console.WriteLine("dhhh:--------:/+shhhy:-------shhhs+/:--------:hhhd");
                    Console.WriteLine("hhhy---:/+osyhhhhhhh+---------yhhhhhhyso+/:---yhhh");
                    Console.WriteLine("hhhs:+syhhhhhhhhhhhh:---------shhhhhhhhhhhys+:shhh");
                    Console.WriteLine("hhhy----:/+osyhhhhhho--------:hhhhhhyso+/:----yhhh");
                    Console.WriteLine("dhhh:---------:/shhhh+------/yhhhs:----------:hhhd");
                    Console.WriteLine("mhhhs----------+hhhhhhyo++oshhhhhy/----------shhhm");
                    Console.WriteLine("Mdhhh +--------+hhhys+hhhhhhhhosyhhy:--------+hhhdM");
                    Console.WriteLine("MNhhhh +------+hyo/---ohhhhhhs---:+ss-------+hhhhNM");
                    Console.WriteLine("MMNhhhho----:+:-------yhhhhy:-------------ohhhhNMM");
                    Console.WriteLine("MMMMdhhhy /------------/hhhh/------------/yhhhdMMMM");
                    Console.WriteLine("MMMMMmhhhhs /-----------ohho-----------/shhhhmMMMMM");
                    Console.WriteLine("MMMMMMMmhhhhyo /:--------yy--------:/oyhhhhmMMMMMMM");
                    Console.WriteLine("MMMMMMMMMmdhhhhhyo +/::--//--::/+oyhhhhhdmMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMmdhhhhhhhhhyyyyhhhhhhhhhdmMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMNmddhhhhhhhhhhddmNMMMMMMMMMMMMMMMM");
                    //kleur terugzetten
                    Console.ForegroundColor = vorigekleur;
                }

                else if (ingave == "exit")
                {
                    //applicatie sluiten
                    Environment.Exit(0);
                }
                else
                {
                    //je kan niet meer terug (zoals het hoort)
                    Console.WriteLine("There is no mystery answer");
                }
            }
            while(true);
        }
    }
}
