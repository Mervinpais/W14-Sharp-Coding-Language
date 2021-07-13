using System;
using System.IO;
using System.Collections.Generic;

namespace W14_Sharp_coding_language
{
    public class Error_Codes 
    {
        public static String Reading_No_File_Error = "0xr00001";
    }
    public class Read_errors : Exception
    {
        //Overriding the Message property
        public override string Message
        {
            get
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return $"Please make sure there is a .txt file in W14-Sharp >> W14-Sharp_coding_language >> bin >> Debug >> netcoreapp3.1 \nPlease close this program, insert your file, then reopen this program and then type in 'read *file name*.txt' \n Error_Code: " + Error_Codes.Reading_No_File_Error + "\n Error_Name: READING_NO_FILE_ERROR \n";
            }
        }
    }
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
        public static String if_statement_contains;  //* This is where most of the variable are kept, its like a storage room where a commands takes a variable and
        public static String var_string;             //* then keeps it back once its done.
        public static Boolean var_bool;
        public static String ask;
        public static String func;
        public static String variable1;
        public static String variable2;
        public static String variable3;
        public static String variable4;
        public static String variable5;
        public static int num2;
        public static int num1;
        public static int Math_result;
    }
    
    //class Variable  //! WARNING! do not even think of uncommenting this code, im sure it will cause alot of errors(or maybe just 1 idk)
    //{
        //private string name; // field
        //public string Name   // property
        //{
            //get { return name; }
            //set { name = value; }
        //}
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //string code0;
            string codeline; //Mervin
            bool program_loaded;
            program_loaded = true;
            Console.WriteLine("W14# Coding Terminal");
            Console.WriteLine("======================");
            while (program_loaded == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    codeline = Console.ReadLine();
                    if (codeline.StartsWith("Say"))//thinks
                    {
                        Console.Write(codeline.Substring(4));
                    }
                    if (codeline.StartsWith("math"))//he
                    {
                        Global.num1 = Convert.ToInt32(codeline.Substring(5,1));
                        Global.num2 = Convert.ToInt32(codeline.Substring(7,1));
                        if (codeline.Substring(6,1) == "+")
                        {
                                Global.num2 = Convert.ToInt32(codeline.Substring(7,1));
                                Global.Math_result = Global.num1 + Global.num2;
                                Console.WriteLine(Global.Math_result);
                        }
                        else if (codeline.Substring(6,1) == "-")
                        {
                                Global.num2 = Convert.ToInt32(codeline.Substring(7,1));
                                Global.Math_result = (Global.num1 - Global.num2);
                                Console.WriteLine(Global.Math_result);
                        }
                        else if (codeline.Substring(6,1) == "*")
                        {
                                Global.num2 = Convert.ToInt32(codeline.Substring(7,1));
                                Global.Math_result = Global.num1 * Global.num2;
                                Console.WriteLine(Global.Math_result);
                        }
                        else if (codeline.Substring(6,1) == "/")
                        {
                                Global.num2 = Convert.ToInt32(codeline.Substring(7,1));
                                Global.Math_result = Global.num1 / Global.num2;
                                Console.WriteLine(Global.Math_result);
                        }
                    }
                    if (codeline == "help")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("=====Help and Commands=====");
                        Console.WriteLine("");
                        Console.WriteLine("Hello there, im Mervin_help_assistant, let me show you some of the commands");
                        Console.WriteLine("help - to get help on commands");
                        Console.WriteLine("math - used for math operations");
                        Console.WriteLine("about_ - if you wanted to know about my creator more");
                        Console.WriteLine("");
                    }
                    if (codeline == "about")
                    {
                        Console.WriteLine("=============About============");//baby
                        Console.WriteLine("Version 2.2.4");
                        Console.WriteLine("Contact: mervinpaismakeswindows14@gmail.com");
                    }
                    if (codeline.StartsWith("read"))
                    {
                        try {
                            if (codeline.Substring(4) == "")
                            {
                                throw new Read_errors();
                                
                            } else if (codeline.Substring(4) == "") {
                                string readText = File.ReadAllText(codeline.Substring(5) + ".txt");  // Read the contents of the file
                                Console.WriteLine(readText);  // Output the content
                            }
                        }
                        catch (Read_errors Error)
                        {
                            Console.WriteLine(Error.Message);
                        }
                    }
                    if (codeline == "time")
                    {
                        string Date_and_time = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
                        Console.WriteLine(Date_and_time);
                    }
                    if (codeline == "stop"){
                        Environment.Exit(-1);                    
                    }
                    /*if (codeline.StartsWith("if")){
                        if (codeline.Contains("string")) {
                            if (codeline != ""){
                                if (codeline.EndsWith("{}")){
                                    Console.WriteLine("Enter the command you want in the if statement");
                                    if (codeline.Contains("Say")){
                                        if (codeline.Contains("}")){
                                            Console.WriteLine("Done!");
                                        }
                                    }
                                    else if (codeline.Contains("var")){
                                        if (codeline.Substring(4) != "var")
                                            {
                                                string variable_name_holder = codeline.Substring(3);
                                                Variable variable = new Variable(); //! why did i even add this.. its SOOO buggy...
                                                variable.Name = codeline.Substring(3);
                                                Console.WriteLine(codeline + " has been created");
                                                Console.Beep();
                                                Console.WriteLine("");
                                                Console.WriteLine(variable.Name); 
                                            }
                                            else if (codeline.Substring(4) == ("var"))
                                            {
                                                Console.WriteLine("ERROR; You can't make a variable without a name or with the same operator");
                                            }
                                    }
                                    else if (codeline.Contains("null")) {
                                        Console.WriteLine("ok, done!");
                                    }*/
                    /*if (codeline.StartsWith("MPTHMAPTIAGBAFTMCOIJSB"))
                    {
                        Console.WriteLine("hello there, i know you are interested about this programming language, sadly i may have frequent updates since i have school and exams + the homework they me and its just too much, im not saying that my school is bad and all but im just tired of the work they give us poor students trying to win 'Graduation'.");
                        Console.WriteLine("This programming lanuage is a very simple, but fun program that lets me have my dream come true");
                        Console.WriteLine("I was insprired by 2 things to make this computer lanuage, 1. Dani the youtuber who makes normal games but with the most funny and just likes making jokes in his game, 2. Scratch, this was the 2nd inperation that made me make my own lanuage(since scratch had feature that were not there and needed ether modding or some other shit idk ");
                        Console.WriteLine("Some actual stuff");
                        Console.WriteLine("This program was made since i had free time and decided to make something. So yea, the reason why the word 'Sharp' or # is there at the end? well its because its made with the help of c#, since i love its easy and simple use");
                    } */
                    /*if (codeline.StartsWith("var")) //! this code block(or aka if statment) has been commented out since it is unneccessary and not needed in the language's current state
                    {
                        if (codeline.Substring(4) != "var")
                        {
                            string variable_name_holder = codeline.Substring(3);
                            Variable variable = new Variable();
                            variable.Name = codeline.Substring(3);
                            Console.WriteLine(codeline + " has been created");
                            Console.Beep();
                            Console.WriteLine("");
                            Console.WriteLine(variable.Name);
                        }
                        else if (codeline.Substring(4) == ("var"))
                        {
                            Console.WriteLine("ERROR; You can't make a variable without a name or with the same operator");
                        }
                    } */
            }
        }
    }
}