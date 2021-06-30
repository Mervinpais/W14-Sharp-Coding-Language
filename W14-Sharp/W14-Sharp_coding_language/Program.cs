using System;

namespace W14_Sharp_coding_language
{
    public class Global
    {
        //public static string name;
        //public static String Name { get; set; }
        //public static String code1;
        //public static String code2;
        //public static int repeat_times;
        //public static String store_code_say;
        //public static String store_code_repeat;
        //public static String repeat_store1;
        public static String if_statement_contains;
        public static String var_string;
        public static Boolean var_bool;
        public static String ask;
        public static String func;
        public static String variable1;
        public static String variable2;
        public static String variable3;
        public static String variable4;
        public static String variable5;
}

    class Program
    {

        static void Main(string[] args)
        {

            //string code0;
            string codeline; //Mervin
            Console.WriteLine("W14# Coding Terminal");
            bool program_starting = true;
            while (program_starting == true)
            {
                bool program_working = true;//pais
                while (program_working == true)
                {
                    codeline = Console.ReadLine();
                    if (codeline.StartsWith("Say"))//thinks
                    {
                        Console.Write(codeline.Substring(3));
                    }
                    if (codeline.StartsWith("math"))//he
                    {
                        Console.WriteLine("enter num1");
                        Console.Beep();
                        int num1_cache = Convert.ToInt32(Console.ReadLine());//makes
                        Console.WriteLine("enter num2");
                        Console.Beep();
                        int num2_cache = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("what is the operator?(example; add,minus,multiply and division)");//a
                        Console.Beep();
                        string math_Operator = Console.ReadLine();
                        if (math_Operator == "add")//program
                        {
                            Console.Write(num1_cache);
                            Console.Write(" + ");
                            Console.WriteLine(num2_cache);
                            Console.WriteLine(num1_cache + num2_cache);
                        }//that
                        else if (math_Operator == "minus")//is
                        {
                            Console.Write(num1_cache);
                            Console.Write(" - ");
                            Console.WriteLine(num2_cache);//a
                            Console.WriteLine(num1_cache - num2_cache);
                        }
                        else if (math_Operator == "multiplication")//game
                        {
                            Console.Write(num1_cache);
                            Console.Write(" * ");
                            Console.WriteLine(num2_cache);//but
                            Console.WriteLine(num1_cache * num2_cache);
                        }
                        else if (math_Operator == "division")//after
                        {
                            Console.Write(num1_cache);
                            Console.Write(" / ");
                            Console.WriteLine(num2_cache);//that
                            Console.WriteLine(num1_cache / num2_cache);
                        }
                        else//mervin
                        {
                            Console.ForegroundColor = ConsoleColor.Red;//codes
                            Console.WriteLine("===============================================");
                            Console.WriteLine("):");
                            Console.WriteLine("System halt ERROR; Can't recognise math operator, please type in math again to retry");
                            Console.ForegroundColor = ConsoleColor.White;//ok
                        }
                    }
                    if (codeline == "crash_test")//in
                    {
                        Console.Beep();
                        Console.BackgroundColor = ConsoleColor.Blue;//just
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                                                          ");
                        Console.WriteLine("):                                                                        ");
                        Console.WriteLine("The System.main has crashed, please close and reopen this program         ");
                        Console.WriteLine("                                                                          ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (codeline == "help")
                    {
                        Console.WriteLine("=========Loading help========");//seconds
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("Hello there, im Mervin_help_assistant, let me show you some of the commands");
                        Console.WriteLine("help - to get help on commands");
                        Console.WriteLine("math - used for SIMPLE math operations");
                        Console.WriteLine("crash_test - ...");
                        Console.WriteLine("about_ - if you wanted to know about my creator more");
                        Console.WriteLine("");
                    }
                    if (codeline == "about_")
                    {
                        Console.WriteLine("=============About============");//baby
                        Console.WriteLine("Version 2.1.4");
                        Console.WriteLine("Contact: mervinpaismakeswindows14@gmail.com");
                    }
                    if (codeline.StartsWith("MPTHMAPTIAGBAFTMCOIJSB"))
                    {
                        Console.WriteLine("hello there, i know you are interested about this programming language, sadly i may have frequent updates since i have school and exams + the homework they me and its just too much, im not saying that my school is bad and all but im just tired of the work they give us poor students trying to win 'Graduation'.");
                        Console.WriteLine("This programming lanuage is a very simple, but fun program that lets me have my dream come true");
                        Console.WriteLine("I was insprired by 2 things to make this computer lanuage, 1. Dani the youtuber who makes normal games but with the most funny and just likes making jokes in his game, 2. Scratch, this was the 2nd inperation that made me make my own lanuage(since scratch had feature that were not there and needed ether modding or some other shit idk ");
                        Console.WriteLine("Some actual stuff");
                        Console.WriteLine("This program was made since i had free time and decided to make something. So yea, the reason why the word 'Sharp' or # is there at the end? well its because its made with the help of c#, since i love its easy and simple use");
                    }
                    //if (codeline.StartsWith("func"))
                    //{
                    //    Console.WriteLine("name?");
                    //    Console.Beep();
                    //    Global.func = Console.ReadLine();
                    //    Console.WriteLine("do you want add any code into the function?(Y/N)");
                    //    if (codeline.Contains("y"))
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Red;
                    //        Console.WriteLine("Code not complete error; this part of the code hasn't been completed :( ");
                    //        Console.ForegroundColor = ConsoleColor.White;
                    //    }
                    //    else
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Red;
                    //        Console.WriteLine("Code not complete error; this part of the code hasn't been completed :( ");
                    //        Console.ForegroundColor = ConsoleColor.White;
                    //        //Console.WriteLine("ok, please note that we can't edit the func since this version of W14# has no edit option");
                    //    }
                    //}
                    //if (codeline.Contains("var"))
                    //{
                    //    Console.Write(codeline + " has been created");
                    //    Console.Beep();

                    //} else
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Red;
                    //    Console.WriteLine("Code not complete error; this part of the code hasn't been completed :( ");
                    //    Console.ForegroundColor = ConsoleColor.White;
                    //    //Global.variable1 = codeline.Substring(3);//this means it will skip the first 3 letters in the code i type in and make a variable out of it
                    //}
                    //if (codeline == "create if-statement") 
                    //{
                    //    Console.WriteLine("what does the if statment contain?");
                    //    Global.if_statement_contains = Console.ReadLine();
                    //    Console.WriteLine("does your if statment contain a variable? if yes, whats the name of it");
                    //}
                    //if (codeline == "create variable")
                    //{
                    //    Console.WriteLine("type?(example; string, bool, int etc.)");
                    //    Global.ask = Console.ReadLine();
                    //    if (Global.ask == "string")
                    //    {
                    //        Console.WriteLine("Then what is the name of it");
                    //        Global.var_string = Console.ReadLine();
                    //    }

                    //}


                    //if (codeline == "/?")
                    //{
                    //    Console.WriteLine("=====COMMAND LIST=====");
                    //    Console.WriteLine("/? - Shows all commands in a list");
                    //    Console.WriteLine("/? + command name - Gives info on what the command does example; '/? Say'");
                    //    Console.WriteLine("Say - Used for displaying text on screen");
                    //}
                    //if (codeline == "Say")
                    //{
                    //    Global.store_code_say = codeline;
                    //    Console.WriteLine("What text do you want to display");
                    //    //program_working = false;
                    //    string say_var_string_say_command = Console.ReadLine();
                    //    if (say_var_string_say_command != "Say")
                    //    {
                    //        //Console.WriteLine("===Code Set===");
                    //        //Console.WriteLine("Compiling code...");
                    //        //System.Threading.Thread.Sleep(1000);
                    //        //Console.WriteLine(store_the_code0);

                    //        //Console.WriteLine(say_varbiable_string_say_command);
                    //        Global.code1 = say_var_string_say_command;
                    //    }
                    //    else
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Red;
                    //        Console.WriteLine("System ERROR; Can't use the command 'Say' in the command that is currently going on (command going on: Say)");
                    //        Console.ForegroundColor = ConsoleColor.White;
                    //    }


                    //}

                    //if (codeline == "repeat")
                    //{
                    //    Console.WriteLine("what command would you like to repeat(type in the command name only)");
                    //    string say_var_string_repeat_command = Console.ReadLine();
                    //    Console.WriteLine("now how many times?(enter an int/a number only");
                    //    Global.repeat_times = Convert.ToInt32(Console.ReadLine());
                    //    Global.code2 = say_var_string_repeat_command;
                    //    Global.repeat_store1 = Global.code2 + " " + Global.repeat_times;
                    //}

                    //if (codeline == "")
                    //{

                    //}

                    //if (codeline == "Show current code.old")
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Red;
                    //    Console.WriteLine("System ERROR; system can't use 'Show current code.old' since it is deprecated and unuseable");
                    //    Console.ForegroundColor = ConsoleColor.White;
                    //}

                    ////The '/? command-name' section code
                    //if (codeline == "/? Say")
                    //{
                    //    Console.WriteLine("===HOW TO USE===");
                    //    Console.WriteLine("Firstly, type in the command and hit enter(type 'Say' and then press the 'Enter' key on the keyboard");
                    //    Console.WriteLine("Then, type in whatever you text want to display on the screen");
                    //    Console.WriteLine("====USES OF THE COMMAND====");
                    //    Console.WriteLine("If you want to show some text on screen , example, for if you wanted to give instructions to the user if you are making an app");
                    //    Console.WriteLine("====DEV INFO====");
                    //    Console.WriteLine("This Command was made on W14# Version 1.0 and updated in the same version");
                    //}
                    //if (codeline == "SCTP")
                    //{
                    //Console.Write("Preparing, give us a sec...");
                    //System.Threading.Thread.Sleep(1000);
                    //Console.WriteLine("===Your Code should be below this message===");
                    //Console.WriteLine("");
                    //if (Global.store_code_say == "" && Global.repeat_store1 == "" && Global.code1 == "")//nothing is used and no code has been writen by the user
                    //{
                    //     Console.ForegroundColor = ConsoleColor.Red;
                    //     Console.WriteLine("Compiling ERROR; it looks like you havn't typed in any code yet, please type in some code before compiling");
                    //     Console.ForegroundColor = ConsoleColor.White;

                    //} else if (Global.store_code_say == "" && Global.code1 == "" && Global.repeat_store1 == "") // if the say func is used/typed in by the user
                    //{
                    //    Console.WriteLine(Global.store_code_say + " == " + Global.code1);
                    //    Console.WriteLine("");
                    //} else if (Global.repeat_store1 == "" && Global.store_code_say != "" && Global.code1 != "") // if the repeat func is used/typed in by the user
                    //{
                    //    Console.WriteLine(Global.store_code_repeat + "'" + Global.code2 + "'" + " for " + Global.repeat_times + " amount of times");
                    //}
                    //else //If all of the conditions are met then
                    //{
                    //    Console.WriteLine(Global.store_code_say + " == " + Global.code1);
                    //    Console.WriteLine("");
                    //    Console.WriteLine(Global.repeat_store1);
                    //}


                    //Console.WriteLine("=================================================");
                    //Console.WriteLine("If the code is having the text set to 'missing/unused code', this means that the code is null. So, the shell sets it to 'missing/unused code' so the program doesn't break");
                    //Console.WriteLine("=================================================");
                    //                    }
                    //                }
                    //}
                }
            }
        }
    }
}
