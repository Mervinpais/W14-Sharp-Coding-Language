using System;

namespace W14_Sharp_coding_language
{
    public class Global
    {
        public static string name;
        public static String Name { get; set; }
        public static String code1 = "missing/unused code";
        public static String code2 = "missing/unused code";
        public static int repeat_times;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //string code0;
            string codeline;
            Console.WriteLine("W14# Coding Terminal");
            bool program_starting = true;
            while (program_starting == true)
            {
                bool program_working = true;
                while (program_working == true)
                {
                    codeline = Console.ReadLine();
                    if (codeline == "/?")
                    {
                        Console.WriteLine("=====COMMAND LIST=====");
                        Console.WriteLine("/? - Shows all commands in a list");
                        Console.WriteLine("/? + command name - Gives info on what the command does example; '/? Say'");
                        Console.WriteLine("Say - Used for displaying text on screen");
                    }
                    if (codeline == "Say")
                    {
                        Console.WriteLine("What text do you want to display");
                        //program_working = false;
                        string say_varbiable_string_say_command = Console.ReadLine();
                        if (say_varbiable_string_say_command != "Say")
                        {
                            string store_the_code1 = say_varbiable_string_say_command;
                            //Console.WriteLine("===Code Set===");
                            //Console.WriteLine("Compiling code...");
                            //System.Threading.Thread.Sleep(1000);
                            //Console.WriteLine(store_the_code0);

                            //Console.WriteLine(say_varbiable_string_say_command);
                            Global.code1 = store_the_code1;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("System ERROR; Can't use the command 'Say' in the command that is currently going on (command going on: Say)");
                            Console.ForegroundColor = ConsoleColor.White;
                        }


                    }

                    if (codeline == "repeat")
                    {
                        Console.WriteLine("what command would you like to repeat(type in the command name only)");
                        string say_varbiable_string_repeat_command = Console.ReadLine();
                        Console.WriteLine("now how many times?(enter an int/a number only");
                        Global.repeat_times = Convert.ToInt32(Console.ReadLine());
                        Global.code2 = say_varbiable_string_repeat_command;
                    }

                    if (codeline == "")
                    {

                    }

                    if (codeline == "Show current code.old")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("System ERROR; system can't use 'Show current code.old' since it is deprecated and unuseable");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    //The '/? command-name' section code
                    if (codeline == "/? Say")
                    {
                        Console.WriteLine("===HOW TO USE===");
                        Console.WriteLine("Firstly, type in the command and hit enter(type 'Say' and then press the 'Enter' key on the keyboard");
                        Console.WriteLine("Then, type in whatever you text want to display on the screen");
                        Console.WriteLine("====USES OF THE COMMAND====");
                        Console.WriteLine("If you want to show some text on screen , example, for if you wanted to give instructions to the user if you are making an app");
                        Console.WriteLine("====DEV INFO====");
                        Console.WriteLine("This Command was made on W14# Version 1.0 and updated in the same version");
                    }
                    if (codeline == "Show current code")
                    {
                        Console.WriteLine("Preparing, give us a sec.");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("Preparing, give us a sec..");
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Preparing, give us a sec...");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("===Your Code should be below this message===");
                        Console.WriteLine("");
                        Console.WriteLine("Say " + "'" + Global.code1 + "'");
                        Console.WriteLine("");
                        Console.WriteLine("Repeat " + "'" + Global.code2 + "'" + " for " + "'" + Global.repeat_times + "'" + " amount of times");
                        Console.WriteLine("=================================================");
                        Console.WriteLine("If the code is having the text set to 'missing/unused code', this means that the code is null(which means 'nothing') so the shell sets it to 'missing/unused code' so the program doesn't break");
                        Console.WriteLine("=================================================");
                    }
                }
            }
        }
    }
}
