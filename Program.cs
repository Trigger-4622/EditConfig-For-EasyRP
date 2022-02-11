using IniFile_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EditConfig
{
    
    class Program
    {
        public static string wae { get; private set; }

        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 35);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"_______________________________________________________________________________________________"); Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"   ____                __  _          _____     _  _  _                                        "); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"  / ___| ___   _ __   / _|(_)  __ _  | ____| __| |(_)| |_  ___   _ __                          "); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@" | |    / _ \ | '_ \ | |_ | | / _` | |  _|  / _` || || __|/ _ \ | '__|                         "); Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" | |___| (_) || | | ||  _|| || (_| | | |___| (_| || || |_| (_) || |                            "); Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"  \____|\___/ |_| |_||_|  |_| \__, | |_____|\__,_||_| \__|\___/ |_|                            "); Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"  ____           _____       _|___/                         _  _    _  _     __   ____   ____  "); Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@" | __ )  _   _  |_   _|_ __ (_)  __ _   __ _   ___  _ __  _| || |_ | || |   / /_ |___ \ |___ \ "); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@" |  _ \ | | | |   | | | '__|| | / _` | / _` | / _ \| '__||_  ..  _|| || |_ | '_ \  __) |  __) |"); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@" | |_) || |_| |   | | | |   | || (_| || (_| ||  __/| |   |_  ..  _||__   _|| (_) |/ __/  / __/ "); Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" |____/  \__, |   |_| |_|   |_| \__, | \__, | \___||_|     |_||_|     |_|   \___/|_____||_____|"); Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"         |___/                  |___/  |___/                                                   "); Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"_______________________________________________________________________________________________"); Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("");


            string Location = ("config.ini");
            try
            {
                using (StreamReader reader = new StreamReader(File.OpenRead(Location)))
                {
                    string fileContent = reader.ReadToEnd();
                    //Console.WriteLine(fileContent);
                    //Console.WriteLine("_______________________________________________________________________________________________\n");
                    reader.Close();

                    var MyIni = new IniFile("config.ini");

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Options: \n");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[Identifiers]"); Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1.) ClientID\n");
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[State]"); Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("2.) State");
                    Console.WriteLine("3.) Details ");
                    Console.WriteLine("4.) StartTimestamp");
                    Console.WriteLine("5.) EndTimestamp\n");
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[Images]"); Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("6.) LargeImage");
                    Console.WriteLine("7.) LargeImageTooltip");
                    Console.WriteLine("8.) SmallImage");
                    Console.WriteLine("9.) SmallImageTooltip\n");
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("10/Else .) Exit"); Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("11.) Print config.ini\n"); Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("Please Enter Your Choise: ");
                    
                    int Choise = 0;
                    Choise = Convert.ToInt32(Console.ReadLine());
                    string var1;
                    switch (Choise)
                    {
                        case 1:
                            Console.WriteLine("ClientID\n");
                            Console.WriteLine("Enter ClientID: ");
                            var1 = Console.ReadLine();
                            Console.WriteLine("Trying To Change To: " + var1);
                            if (MyIni.KeyExists("ClientID", "Identifiers"))
                            {
                                MyIni.Write("ClientID", var1, "Identifiers");
                                Console.WriteLine("Operation Completed!");
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            Console.ReadKey();
                            break;

                            case 2:
                            Console.WriteLine("State\n");
                            Console.WriteLine("Enter State: ");
                            var1 = Console.ReadLine();
                            Console.WriteLine("Trying To Change To: " + var1);
                            if (MyIni.KeyExists("State", "State"))
                            {
                                MyIni.Write("State", var1, "State");
                                Console.WriteLine("Operation Completed!");
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            Console.ReadKey();
                            break;

                            case 3:
                            Console.WriteLine("State\n");
                            Console.WriteLine("Enter State: ");
                            var1 = Console.ReadLine();
                            Console.WriteLine("Trying To Change To: " + var1);
                            if (MyIni.KeyExists("Details", "State"))
                            {
                                MyIni.Write("Details", var1, "State");
                                Console.WriteLine("Operation Completed!");
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            Console.ReadKey();
                            break;

                            case 4:
                            Console.WriteLine("StartTimestamp\n");
                            Console.WriteLine("Enter StartTimestamp: ");
                            var1 = Console.ReadLine();
                            Console.WriteLine("Trying To Change To: " + var1);
                            if (MyIni.KeyExists("StartTimestamp", "State"))
                            {
                                MyIni.Write("StartTimestamp", var1, "State");
                                Console.WriteLine("Operation Completed!");
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            Console.ReadKey();
                            break;

                            case 5:
                            Console.WriteLine("EndTimestamp\n");
                            Console.WriteLine("Enter EndTimestamp: ");
                            var1 = Console.ReadLine();
                            Console.WriteLine("Trying To Change To: " + var1);
                            if (MyIni.KeyExists("EndTimestamp", "State"))
                            {
                                MyIni.Write("EndTimestamp", var1, "State");
                                Console.WriteLine("Operation Completed!");
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            Console.ReadKey();
                            break;

                            case 6:
                            Console.WriteLine("LargeImage\n");
                            Console.WriteLine("Enter LargeImage: ");
                            var1 = Console.ReadLine();
                            Console.WriteLine("Trying To Change To: " + var1);
                            if (MyIni.KeyExists("LargeImage", "Images"))
                            {
                                MyIni.Write("LargeImage", var1, "Images");
                                Console.WriteLine("Operation Completed!");
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            Console.ReadKey();
                            break;

                            case 7:
                            Console.WriteLine("LargeImageTooltip\n");
                            Console.WriteLine("Enter LargeImageTooltip: ");
                            var1 = Console.ReadLine();
                            Console.WriteLine("Trying To Change To: " + var1);
                            if (MyIni.KeyExists("LargeImageTooltip", "Images"))
                            {
                                MyIni.Write("LargeImageTooltip", var1, "Images");
                                Console.WriteLine("Operation Completed!");
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            Console.ReadKey();
                            break;

                            case 8:
                            Console.WriteLine("SmallImage\n");
                            Console.WriteLine("Enter SmallImage: ");
                            var1 = Console.ReadLine();
                            Console.WriteLine("Trying To Change To: " + var1);
                            if (MyIni.KeyExists("SmallImage", "Images"))
                            {
                                MyIni.Write("SmallImage", var1, "Images");
                                Console.WriteLine("Operation Completed!");
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            Console.ReadKey();
                            break;

                            case 9:
                            Console.WriteLine("SmallImageTooltip\n");
                            Console.WriteLine("Enter SmallImageTooltip: ");
                            var1 = Console.ReadLine();
                            Console.WriteLine("Trying To Change To: " + var1);
                            if (MyIni.KeyExists("SmallImageTooltip", "Images"))
                            {
                                MyIni.Write("SmallImageTooltip", var1, "Images");
                                Console.WriteLine("Operation Completed!");
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }
                            Console.ReadKey();
                            break;

                            case 10:
                            System.Environment.Exit(1);
                            break;

                            case 11:
                                Console.WriteLine(fileContent);
                                Console.ReadKey();
                                break;

                            case 12:
                            
                                Console.WriteLine("Enter Delay (In milliseconds) : ");
                                int milliseconds = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Amount Of Pictures: ");
                                int pics = Convert.ToInt32(Console.ReadLine());
                                string[] large_image = new string[pics];

                            for (int i = 0; i < pics; i++)
                            {
                                Console.WriteLine("Enter Image Number " + ( i + 1 ) + " Out Of: " + pics);
                                large_image[i] = Console.ReadLine();
                            }
                            Console.WriteLine("In Order To Turn Off Please Type \"Off\" ");
                            Thread t = new Thread(new ThreadStart(ThreadProc));
                            t.Start();
                            wae = "On";
                            while (wae == "On" )
                            {
                                for(int i = 0; i < large_image.Length; i++)
                                {
                                    MyIni.Write("LargeImage", large_image[i], "Images");
                                    Thread.Sleep(milliseconds);
                                }
                            }
                            break;

                        default:
                                System.Environment.Exit(1);
                                break;

                    }
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine("Config.ini file was not found! \nPlease enter the location of Config.ini !");

                Console.WriteLine("Enter Location: (Such as \"C:Users/Desktop/{ folder}\") ");
                Location = Console.ReadLine();
                var MyIni = new IniFile(Location + @"\config.ini");
                StreamReader reader = new StreamReader(File.OpenRead(Location + @"\config.ini"));
                string fileContent = reader.ReadToEnd();
                reader.Close();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Options: \n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[Identifiers]"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1.) ClientID\n");
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[State]"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("2.) State");
                Console.WriteLine("3.) Details ");
                Console.WriteLine("4.) StartTimestamp");
                Console.WriteLine("5.) EndTimestamp\n");
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[Images]"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("6.) LargeImage");
                Console.WriteLine("7.) LargeImageTooltip");
                Console.WriteLine("8.) SmallImage");
                Console.WriteLine("9.) SmallImageTooltip\n");
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("10/Else .) Exit"); Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("11.) Print config.ini\n"); Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Please Enter Your Choise: ");

                int Choise = 0;
                Choise = Convert.ToInt32(Console.ReadLine());
                string var1;
                switch (Choise)
                {
                    case 1:
                        Console.WriteLine("ClientID\n");
                        Console.WriteLine("Enter ClientID: ");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Trying To Change To: " + var1);
                        if (MyIni.KeyExists("ClientID", "Identifiers"))
                        {
                            MyIni.Write("ClientID", var1, "Identifiers");
                            Console.WriteLine("Operation Completed!");
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("State\n");
                        Console.WriteLine("Enter State: ");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Trying To Change To: " + var1);
                        if (MyIni.KeyExists("State", "State"))
                        {
                            MyIni.Write("State", var1, "State");
                            Console.WriteLine("Operation Completed!");
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("State\n");
                        Console.WriteLine("Enter State: ");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Trying To Change To: " + var1);
                        if (MyIni.KeyExists("Details", "State"))
                        {
                            MyIni.Write("Details", var1, "State");
                            Console.WriteLine("Operation Completed!");
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("StartTimestamp\n");
                        Console.WriteLine("Enter StartTimestamp: ");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Trying To Change To: " + var1);
                        if (MyIni.KeyExists("StartTimestamp", "State"))
                        {
                            MyIni.Write("StartTimestamp", var1, "State");
                            Console.WriteLine("Operation Completed!");
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("EndTimestamp\n");
                        Console.WriteLine("Enter EndTimestamp: ");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Trying To Change To: " + var1);
                        if (MyIni.KeyExists("EndTimestamp", "State"))
                        {
                            MyIni.Write("EndTimestamp", var1, "State");
                            Console.WriteLine("Operation Completed!");
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.WriteLine("LargeImage\n");
                        Console.WriteLine("Enter LargeImage: ");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Trying To Change To: " + var1);
                        if (MyIni.KeyExists("LargeImage", "Images"))
                        {
                            MyIni.Write("LargeImage", var1, "Images");
                            Console.WriteLine("Operation Completed!");
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.WriteLine("LargeImageTooltip\n");
                        Console.WriteLine("Enter LargeImageTooltip: ");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Trying To Change To: " + var1);
                        if (MyIni.KeyExists("LargeImageTooltip", "Images"))
                        {
                            MyIni.Write("LargeImageTooltip", var1, "Images");
                            Console.WriteLine("Operation Completed!");
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        Console.ReadKey();
                        break;

                    case 8:
                        Console.WriteLine("SmallImage\n");
                        Console.WriteLine("Enter SmallImage: ");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Trying To Change To: " + var1);
                        if (MyIni.KeyExists("SmallImage", "Images"))
                        {
                            MyIni.Write("SmallImage", var1, "Images");
                            Console.WriteLine("Operation Completed!");
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        Console.ReadKey();
                        break;

                    case 9:
                        Console.WriteLine("SmallImageTooltip\n");
                        Console.WriteLine("Enter SmallImageTooltip: ");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Trying To Change To: " + var1);
                        if (MyIni.KeyExists("SmallImageTooltip", "Images"))
                        {
                            MyIni.Write("SmallImageTooltip", var1, "Images");
                            Console.WriteLine("Operation Completed!");
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        Console.ReadKey();
                        break;

                    case 10:
                        System.Environment.Exit(1);
                        break;

                    case 11:
                        Console.WriteLine(fileContent);
                        Console.ReadKey();
                        break;

                    case 12:

                        Console.WriteLine("Enter Delay (In milliseconds) : ");
                        int milliseconds = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Amount Of Pictures: ");
                        int pics = Convert.ToInt32(Console.ReadLine());
                        string[] large_image = new string[pics];

                        for (int i = 0; i < pics; i++)
                        {
                            Console.WriteLine("Enter Image Number " + (i + 1) + " Out Of: " + pics);
                            large_image[i] = Console.ReadLine();
                        }
                        Console.WriteLine("In Order To Turn Off Please Type \"Off\" ");
                        Thread t = new Thread(new ThreadStart(ThreadProc));
                        t.Start();
                        wae = "On";
                        while (wae == "On")
                        {
                            for (int i = 0; i < large_image.Length; i++)
                            {
                                MyIni.Write("LargeImage", large_image[i], "Images");
                                Thread.Sleep(milliseconds);
                            }
                        }
                        break;

                    default:
                        System.Environment.Exit(1);
                        break;

                }
            }
        }



        public static void ThreadProc()
        {
            while (true)
            {
                wae = Console.ReadLine();
                if (wae == "Off")
                {
                    System.Environment.Exit(1);
                }
            }
        }
    }
}


