using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;

namespace CodeHunt13
{
    class Execises
    {
        public static bool badResult { get; set; }
        #region Ex1
                private static int Ex1(int x, int y)
                {
                    if (badResult)
                        return x + y;
                    else
                        return x * y;
                }
                public static void Ex1Check()
                {
                    int[] inputX = new int[] { 0, 2, 4, 5, 9 };
                    int[] inputY = new int[] { 3, 6, 8, 1, 7 };

                    int[] results = new int[] { 0, 12, 32, 5, 63 };

                    Console.Write("\tX\tY\tВідповідь\tРезультат\tПеревірка\n" +
                                  "\t-\t-\t---------\t---------\t---------\n");
                    for (int i = 0; i < inputX.Length; i++)
                    {
                        Console.Write("\t" + inputX[i] + "\t" + inputY[i] + "\t" + results[i] + "\t\t" + Ex1(inputX[i], inputY[i]) + "\t");
                        if (Ex1(inputX[i], inputY[i]) == results[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\tПравильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\tНеправильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                #endregion
        #region Ex2
                private static int Ex2(int number, int power)
                {
                    if (!badResult)
                        return power == 0 ? 1 : number * Ex2(number, power - 1);
                    else
                        return power == 0 ? 1 : number + Ex2(number, power - 1);
                }
                public static void Ex2Check()
                {
                    int[] inputNumber = new int[] { 1, 1, 2, 15, 10 };
                    int[] inputPower = new int[] { 0, 1, 7, 2, 3 };

                    int[] results = new int[] { 1, 1, 128, 225, 1000 };

                    Console.Write("\tNumber\tPower\tВідповідь\tРезультат\tПеревірка\n" +
                                  "\t------\t-----\t---------\t---------\t---------\n");
                    for (int i = 0; i < inputNumber.Length; i++)
                    {
                        Console.Write("\t" + inputNumber[i] + "\t" + inputPower[i] + "\t" + results[i] + "\t\t" + Ex2(inputNumber[i], inputPower[i]) + "\t");
                        if (Ex2(inputNumber[i], inputPower[i]) == results[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\tПравильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\tНеправильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                #endregion
        #region Ex3
                private static int Ex3(int i)
                {
                    if (!badResult)
                        return i > 99 ? 3 : 2;
                    else
                        return i == 34 ? 3 : 2;
                }
                public static void Ex3Check()
                {
                    int[] inputI = new int[] { 0, 12, 34, 128, 202 };

                    int[] results = new int[] { 2, 2, 2, 3, 3 };

                    Console.Write("\tI\tВідповідь\tРезультат\tПеревірка\n" +
                                  "\t-\t---------\t---------\t---------\n");
                    for (int i = 0; i < inputI.Length; i++)
                    {
                        Console.Write("\t" + inputI[i] + "\t" + results[i] + "\t\t" + Ex3(inputI[i]) + "\t");
                        if (Ex3(inputI[i]) == results[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\tПравильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\tНеправильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                #endregion
        #region Ex4
                private static char Ex4(string s, int x)
                {
                    if (!badResult)
                        return s[x];
                    else
                        return s[x + 1];
                }
                public static void Ex4Check()
                {
                    string[] inputS = new string[] { "hhhh", "asesa", "qlersd", "kdald", "sdsaos" };
                    int[] indexes = new int[] { 0, 2, 1, 3, 4 };
                    char[] results = new char[] { 'h', 'e', 'l', 'l', 'o' };

                    Console.Write("\tS\tX\tВідповідь\tРезультат\tПеревірка\n" +
                                  "\t-\t-\t---------\t---------\t---------\n");
                    for (int i = 0; i < inputS.Length; i++)
                    {
                        Console.Write("\t" + inputS[i] + "\t" + indexes[i] + "\t'" + results[i] + "'\t\t'" + Ex4(inputS[i], indexes[i]) + "'\t");
                        if (Ex4(inputS[i], indexes[i]) == results[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\tПравильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\tНеправильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                #endregion
        #region Ex5
                private static string Ex5(string s)
                {
                    if (!badResult)
                        return s.Replace(" ", "");
                    else
                        return s.Replace(" ", "_");
                }
                public static void Ex5Check()
                {
                    string[] inputS = new string[] { "th  i s  ", new string(' ', 9), "p  uz zl e", "  i   s  ", "d o  ne " };
                    string[] results = new string[] { "this", "", "puzzle", "is", "done" };

                    Console.Write("\tS\t\tВідповідь\tРезультат\tПеревірка\n" +
                                  "\t-\t\t---------\t---------\t---------\n");
                    for (int i = 0; i < inputS.Length; i++)
                    {
                        Console.Write("\t" + inputS[i] + "\t" + results[i] + "\t\t" + Ex5(inputS[i]) + "\t");
                        if (Ex5(inputS[i]) == results[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\tПравильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\tНеправильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                #endregion
        #region Ex6
                private static string Ex6(string[] list)
                {
                    if (!badResult)
                        return list[0] + list[list.Length - 1];
                    else
                        return list[0] + "a";
                }
                public static void Ex6Check()
                {
                    List<string[]> inputS = new List<string[]>() { new string[] { "a", "a", "a", "a" },
                                                                   new string[] { "q", "w", "e", "r" },
                                                                   new string[] { "s", "n", "o", "w" },
                                                                   new string[] { "r", "a", "c", "e" },
                                                                   new string[] { "b", "i", "t", "s" } };
                    string[] results = new string[] { "aa", "qr", "sw", "re", "bs" };

                    Console.Write("\tS\t\t\tВідповідь\tРезультат\tПеревірка\n" +
                                  "\t-\t\t\t---------\t---------\t---------\n");
                    for (int i = 0; i < inputS.Count; i++)
                    {
                        Console.Write("\t{ \u0022" + inputS[i][0] + "\u0022, \u0022" + inputS[i][1] + "\u0022, \u0022" + inputS[i][2] + "\u0022, \u0022" +
                           inputS[i][3] + "\u0022" + " }\t" + results[i] + "\t\t" + Ex6(inputS[i]) + "\t");
                        if (Ex6(inputS[i]) == results[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\tПравильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\tНеправильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                #endregion
        #region Ex7
        private static int[][] Ex7()
        {
            if (!badResult)
                return Enumerable.Repeat<int[]>(new int[5], 5).ToArray();
            else
                return Enumerable.Repeat<int[]>(new int[5], 2).ToArray();
        }
        public static void Ex7Check()
        {
            int[][] results = new int[][] { new int[5], new int[5], new int[5], new int[5], new int[5] };

            Console.Write("\tВідповідь\tРезультат\tПеревірка\n" +
                          "\t---------\t---------\t---------\n");
            Console.Write("\tSize = 5x5\tSize = " + Ex7().Length + "x" + Ex7()[0].Length);
            if (Ex7().Length == results.Length)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\tПравильно\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\tНеправильно\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        #endregion
        #region Ex8
                private static int Ex8(int[] numbers, int x)
                {
                    if (!badResult)
                        return numbers.ToList().Count(t => t == x);
                    else
                        return numbers.ToList().Count(t => t == x + 1);
                }
                public static void Ex8Check()
                {
                    List<int[]> inputNumbers = new List<int[]>() { new int[] { 33, 33, 33, 33 },
                                                                   new int[] { 32, 33, 33, 33 },
                                                                   new int[] { 33, 32, 32, 33 },
                                                                   new int[] { 95, 56, 25, 10},
                                                                   new int[] { 78, 78, 42, 12 } };
                    int[] x = new int[] { 32, 32, 33, 10, 68 };
                    int[] results = new int[] { 0, 1, 2, 1, 0 };

                    Console.Write("\tNumbers\t\t\t\tX\tВідповідь\tРезультат\tПеревірка\n" +
                                  "\t-------\t\t\t\t-\t---------\t---------\t---------\n");
                    for (int i = 0; i < inputNumbers.Count; i++)
                    {
                        Console.Write("\t{ \u0022" + inputNumbers[i][0] + "\u0022, \u0022" + inputNumbers[i][1] + "\u0022, \u0022" + inputNumbers[i][2] + "\u0022, \u0022" +
                           inputNumbers[i][3] + "\u0022" + " }\t" + x[i] + "\t" + results[i] + "\t\t" + Ex8(inputNumbers[i], x[i]) + "\t");
                        if (Ex8(inputNumbers[i], x[i]) == results[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\tПравильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\tНеправильно\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                #endregion
        #region Ex9
        private static string Ex9(string s)
        {
            if (!badResult)
                return new string(s.Select((t, i) => (char)((t - 97 + (i != 0 ? i * 4 + 1 : 1)) % 26 + 97)).ToArray());
            else
                return new string(s.Select((t, i) => (char)((t - 97 + (i != 0 ? i * 4 : 1)) % 26 + 97)).ToArray());
        }
        public static void Ex9Check()
        {
            string[] inputS = new string[] { "a", "aa", "adadada", "aaaaa", "adadada" };
            string[] results = new string[] { "b", "bf", "bijqryz", "bfjnr", "bijqryz" };

            Console.Write("\tS\t\tВідповідь\tРезультат\tПеревірка\n" +
                          "\t-\t\t---------\t---------\t---------\n");
            for (int i = 0; i < inputS.Length; i++)
            {
                Console.Write("\t" + inputS[i] + "\t\t" + results[i] + "\t\t" + Ex9(inputS[i]) + "\t");
                if (Ex9(inputS[i]) == results[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\tПравильно\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tНеправильно\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WindowHeight = 40;
            Console.Write("Модуль: ");
            TypeWriter("№1 CodeHunt\n");
            Console.Write("Варіант: ");
            TypeWriter("№13\n");
            Console.Write("Виконав: ");
            TypeWriter("Полторацький Д.А.\n");
            Console.Write("Група: ");
            TypeWriter("104\n");
            Console.WriteLine("Номери задач: 01.09, 03.01, 04.07, 06.04, 07.06, 09.02, 10.02, 12.01, 13.03");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  Натисніть Enter, щоб запустити перевірку");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                Console.ReadKey(true);
            }
            SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\Sound_19293.wav");
            player.Play();

            Console.ForegroundColor = ConsoleColor.Blue;

            var arr = new[]
            {
                    @"██╗      ██████╗  █████╗ ██████╗ ██╗███╗   ██╗ ██████╗ ",
                    @"██║     ██╔═══██╗██╔══██╗██╔══██╗██║████╗  ██║██╔════╝ ",
                    @"██║     ██║   ██║███████║██║  ██║██║██╔██╗ ██║██║  ███",
                    @"██║     ██║   ██║██╔══██║██║  ██║██║██║╚██╗██║██║   ██║",
                    @"███████╗╚██████╔╝██║  ██║██████╔╝██║██║ ╚████║╚██████╔╝",
                    @"╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═══╝ ╚═════╝ ",
                    
            };
            Console.WriteLine("\n\n");
            var maxLength = arr.Aggregate(0, (max, line) => Math.Max(max, line.Length));
            var x = Console.BufferWidth / 2 - maxLength / 2;
            for (int y = -arr.Length; y < Console.WindowHeight + arr.Length; y++)
            {
                ConsoleDraw(arr, x, y);
                if (y == (Console.WindowHeight / 2) - 5)
                    Thread.Sleep(1400);
                else
                    Thread.Sleep(100);
                
            }

            /////////////////////////////////////
            /////////// LOAD EXESIZES //////////
            ///////////////////////////////////

            DrawEx1(false);

            DrawEx2(false);

            DrawEx3(false);

            DrawEx4(false);

            DrawEx5(false);

            DrawEx6(false);

            DrawEx7(false);

            DrawEx8(false);

            DrawEx9(false);

            Dance();

            Console.ReadKey();
        }
        #region Ex 01.09
        private static void DrawEx1(bool badResults)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Задача номер: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("01.09\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Thread.Sleep(400);
            Console.Write(" Використаний код:\n");
            Console.WriteLine();
            Console.Write("     using System;\n" +
                          "     public class Program {\n" +
                          "         public static int Puzzle(int x, int y) {\n" +
                          "             return x " + (badResults ? "+" : "*") + " y;\n" +
                          "         }\n" +
                          "     }\n");
            Console.WriteLine();
            Thread.Sleep(300);
            Console.Write(" Перевірка:\n");
            Console.WriteLine();
            Execises.badResult = badResults;
            Execises.Ex1Check();

            Console.WriteLine("\n Натисніть Spacebar, щоб змінити щось у коді та подивитись результат.\n" +
                              " Чи Enter, щоб продовжити.");
            var key = Console.ReadKey(true).Key;
            SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\button.wav");
            while (key != ConsoleKey.Enter && key != ConsoleKey.Spacebar)
            {
                player.Play();
                key = Console.ReadKey(true).Key;
            }
            player.Play();
            if (key == ConsoleKey.Spacebar)
                DrawEx1(badResults ? false : true);
            else
                return;
        }
        #endregion
        #region Ex 03.01
                private static void DrawEx2(bool badResults)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Задача номер: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("03.01\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Thread.Sleep(400);
                    Console.Write(" Використаний код:\n");
                    Console.WriteLine();
                    Console.Write("     using System;\n" +
                                  "     public class Program {\n" +
                                  "         public static int Puzzle(int x, int y) {\n" +
                                  "             return power == 0 ? 1 : number" + (badResults ? " + " : " * ") + "Puzzle(number, power - 1);\n" +
                                  "         }\n" +
                                  "     }\n");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.Write(" Перевірка:\n");
                    Console.WriteLine();
                    Execises.badResult = badResults;
                    Execises.Ex2Check();

                    Console.WriteLine("\n Натисніть Spacebar, щоб змінити щось у коді та подивитись результат.\n" +
                                      " Чи Enter, щоб продовжити.");
                    var key = Console.ReadKey(true).Key;
                    SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\button.wav");
                    while (key != ConsoleKey.Enter && key != ConsoleKey.Spacebar)
                    {
                        player.Play();
                        key = Console.ReadKey(true).Key;
                    }
                    player.Play();
                    if (key == ConsoleKey.Spacebar)
                        DrawEx2(badResults ? false : true);
                }
                #endregion
        #region Ex 04.07
                private static void DrawEx3(bool badResults)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Задача номер: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("04.07\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Thread.Sleep(400);
                    Console.Write(" Використаний код:\n");
                    Console.WriteLine();
                    Console.Write("     using System;\n" +
                                  "     public class Program {\n" +
                                  "         public static int Puzzle(int i) {\n" +
                                  "             return i == " + (badResults ? 34 : 99) + " ? 3 : 2;\n" +
                                  "         }\n" +
                                  "     }\n");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.Write(" Перевірка:\n");
                    Console.WriteLine();
                    Execises.badResult = badResults;
                    Execises.Ex3Check();

                    Console.WriteLine("\n Натисніть Spacebar, щоб змінити щось у коді та подивитись результат.\n" +
                                      " Чи Enter, щоб продовжити.");
                    var key = Console.ReadKey(true).Key;
                    SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\button.wav");
                    while (key != ConsoleKey.Enter && key != ConsoleKey.Spacebar)
                    {
                        player.Play();
                        key = Console.ReadKey(true).Key;
                    }
                    player.Play();
                    if (key == ConsoleKey.Spacebar)
                        DrawEx3(badResults ? false : true);
                }
                #endregion
        #region Ex 06.04
                private static void DrawEx4(bool badResults)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Задача номер: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("06.04\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Thread.Sleep(400);
                    Console.Write(" Використаний код:\n");
                    Console.WriteLine();
                    Console.Write("     using System;\n" +
                                  "     public class Program {\n" +
                                  "         public static char Puzzle(string s, int x) {\n" +
                                  "             return s[" + (badResults ? "x + 1" : "x") + "];\n" +
                                  "         }\n" +
                                  "     }\n");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.Write(" Перевірка:\n");
                    Console.WriteLine();
                    Execises.badResult = badResults;
                    Execises.Ex4Check();

                    Console.WriteLine("\n Натисніть Spacebar, щоб змінити щось у коді та подивитись результат.\n" +
                                      " Чи Enter, щоб продовжити.");
                    var key = Console.ReadKey(true).Key;
                    SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\button.wav");
                    while (key != ConsoleKey.Enter && key != ConsoleKey.Spacebar)
                    {
                        player.Play();
                        key = Console.ReadKey(true).Key;
                    }
                    player.Play();
                    if (key == ConsoleKey.Spacebar)
                        DrawEx4(badResults ? false : true);
                }
                #endregion
        #region Ex 07.06
                private static void DrawEx5(bool badResults)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Задача номер: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("07.06\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Thread.Sleep(400);
                    Console.Write(" Використаний код:\n");
                    Console.WriteLine();
                    Console.Write("     using System;\n" +
                                  "     public class Program {\n" +
                                  "         public static string Puzzle(string s) {\n" +
                                  "             return s.Replace(\u0022 \u0022, \u0022" + (badResults ? "_" : "") + "\u0022);\n" +
                                  "         }\n" +
                                  "     }\n");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.Write(" Перевірка:\n");
                    Console.WriteLine();
                    Execises.badResult = badResults;
                    Execises.Ex5Check();

                    Console.WriteLine("\n Натисніть Spacebar, щоб змінити щось у коді та подивитись результат.\n" +
                                      " Чи Enter, щоб продовжити.");
                    var key = Console.ReadKey(true).Key;
                    SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\button.wav");
                    while (key != ConsoleKey.Enter && key != ConsoleKey.Spacebar)
                    {
                        player.Play();
                        key = Console.ReadKey(true).Key;
                
                    }
                    player.Play();
                    if (key == ConsoleKey.Spacebar)
                        DrawEx5(badResults ? false : true);
                }
                #endregion
        #region Ex 09.02
                private static void DrawEx6(bool badResults)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Задача номер: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("09.02\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Thread.Sleep(400);
                    Console.Write(" Використаний код:\n");
                    Console.WriteLine();
                    Console.Write("     using System;\n" +
                                  "     public class Program {\n" +
                                  "         public static string Puzzle(string[] list) {\n" +
                                  "             return list[0] + " +(badResults ? "\u0022a\u0022" : "list[list.Length - 1]") + ";\n" +
                                  "         }\n" +
                                  "     }\n");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.Write(" Перевірка:\n");
                    Console.WriteLine();
                    Execises.badResult = badResults;
                    Execises.Ex6Check();

                    Console.WriteLine("\n Натисніть Spacebar, щоб змінити щось у коді та подивитись результат.\n" +
                                      " Чи Enter, щоб продовжити.");
                    var key = Console.ReadKey(true).Key;
                    SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\button.wav");
                    while (key != ConsoleKey.Enter && key != ConsoleKey.Spacebar)
                    {
                        player.Play();
                        key = Console.ReadKey(true).Key;
                    }
                    player.Play();
                    if (key == ConsoleKey.Spacebar)
                        DrawEx6(badResults ? false : true);
                }
                #endregion
        #region Ex 10.02
                private static void DrawEx7(bool badResults)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Задача номер: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("10.02\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Thread.Sleep(400);
                    Console.Write(" Використаний код:\n");
                    Console.WriteLine();
                    Console.Write("     using System;\n" +
                                  "     using System.Linq;\n" +
                                  "     public class Program {\n" +
                                  "         public static int[][] Puzzle() {\n" +
                                  "             return Enumerable.Repeat<int[]>(new int[" + (badResults ? "2" : "5") + "], 5).ToArray();\n" +
                                  "         }\n" +
                                  "     }\n");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.Write(" Перевірка:\n");
                    Console.WriteLine();
                    Execises.badResult = badResults;
                    Execises.Ex7Check();

                    Console.WriteLine("\n Натисніть Spacebar, щоб змінити щось у коді та подивитись результат.\n" +
                                      " Чи Enter, щоб продовжити.");
                    var key = Console.ReadKey(true).Key;
                    SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\button.wav");
                    while (key != ConsoleKey.Enter && key != ConsoleKey.Spacebar)
                    {
                        player.Play();
                        key = Console.ReadKey(true).Key;
                    }
                    player.Play();
                    if (key == ConsoleKey.Spacebar)
                        DrawEx7(badResults ? false : true);
                }
                #endregion
        #region Ex 12.01
        private static void DrawEx8(bool badResults)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Задача номер: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("12.01\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Thread.Sleep(400);
            Console.Write(" Використаний код:\n");
            Console.WriteLine();
            Console.Write("     using System;\n" +
                          "     using System.Linq;\n" +
                          "     public class Program {\n" +
                          "         public static int Puzzle(int[] numbers, int x) {\n" +
                          "             return numbers.ToList().Count(t => t == " + (badResults ? "x + 1" : "x") + ");\n" +
                          "         }\n" +
                          "     }\n");
            Console.WriteLine();
            Thread.Sleep(300);
            Console.Write(" Перевірка:\n");
            Console.WriteLine();
            Execises.badResult = badResults;
            Execises.Ex8Check();

            Console.WriteLine("\n Натисніть Spacebar, щоб змінити щось у коді та подивитись результат.\n" +
                              " Чи Enter, щоб продовжити.");
            var key = Console.ReadKey(true).Key;
            SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\button.wav");
            
            while (key != ConsoleKey.Enter && key != ConsoleKey.Spacebar)
            {
                player.Play();
                key = Console.ReadKey(true).Key;
            }
            player.Play();
            if (key == ConsoleKey.Spacebar)
                DrawEx8(badResults ? false : true);
        }
        #endregion
        #region Ex 13.03
        private static void DrawEx9(bool badResults)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Задача номер: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("13.03\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Thread.Sleep(400);
            Console.Write(" Використаний код:\n");
            Console.WriteLine();
            Console.Write("     using System;\n" +
                          "     using System.Linq;\n" +
                          "     public class Program {\n" +
                          "         public static string Puzzle(string s) {\n" +
                          "             return new string(s.Select((t, i) => (char)((t - 97 + (i != 0 ? i * " + (badResults ? "4" : "4 + 1") + " : 1)) % 26 + 97)).ToArray());\n" +
                          "         }\n" +
                          "     }\n");
            Console.WriteLine();
            Thread.Sleep(300);
            Console.Write(" Перевірка:\n");
            Console.WriteLine();
            Execises.badResult = badResults;
            Execises.Ex9Check();

            Console.WriteLine("\n Натисніть Spacebar, щоб змінити щось у коді та подивитись результат.\n" +
                              " Чи Enter, щоб продовжити.");
            var key = Console.ReadKey(true).Key;
            SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\button.wav");

            while (key != ConsoleKey.Enter && key != ConsoleKey.Spacebar)
            {
                player.Play();
                key = Console.ReadKey(true).Key;
            }
            player.Play();
            if (key == ConsoleKey.Spacebar)
                DrawEx9(badResults ? false : true);
        }
        #endregion

        private static void TypeWriter(string inputText)
        {
            
            for (int i = 0; i < inputText.Length; i++)
            {
                SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\button.wav");
                player.Play();
                Console.Write(inputText[i]);
                Thread.Sleep(100);
            }
        }
        private static void ConsoleDraw(IEnumerable<string> lines, int x, int y)
        {
            if (x > Console.WindowWidth) return;
            if (y > Console.WindowHeight) return;

            var trimLeft = x < 0 ? -x : 0;
            int index = y;

            x = x < 0 ? 0 : x;
            y = y < 0 ? 0 : y;

            var linesToPrint =
                from line in lines
                let currentIndex = index++
                where currentIndex > 0 && currentIndex < Console.WindowHeight
                select new
                {
                    Text = new String(line.Skip(trimLeft).Take(Math.Min(Console.WindowWidth - x, line.Length - trimLeft)).ToArray()),
                    X = x,
                    Y = y++
                };

            Console.Clear();
            foreach (var line in linesToPrint)
            {
                Console.SetCursorPosition(line.X, line.Y);
                Console.Write(line.Text);
            }
        }
        private static void Dance()
        {
            SoundPlayer player = new SoundPlayer(@"..\..\assets\sounds\Michael_Jackson_Billie_Jean_-_8bit_chiptune_cover.wav");
            player.Play();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            var sprites = new List<string[]>()
            {
                #region Sprite1
                new string[]
                           { @"                                                 ",
                            @"                                                 ",
                            @"                                                 ",
                            @"                                                 ",
                            @"                         cMM;                    ",
                            @"                       ,MMMMM@                   ",
                            @"                       iMM7XMM:                  ",
                            @"                       .M@  7MM$                 ",
                            @"                       .M6    MMM1               ",
                            @"                        M6     oMMW              ",
                            @"                     U26MMEW:   iMM7             ",
                            @"                   zW9MM7;6E#6  .oMMi            ",
                            @"                   MM#@M0   EM;   QM:            ",
                            @"                   $M;6M;   9M: . WM,            ",
                            @"                     0MM@MMM2. 9M;ZM,            ",
                            @"                      QMc...AMMMMiAM,            ",
                            @"                      iMMMMM@Q@M$.8M,            ",
                            @"                        MM8#@MW;  WM,            ",
                            @"                      .AMMM6oc  . 0M,            ",
                            @"             1MMM6    QMn;:    .i8MM  @MM@.      ",
                            @"           ;M$7XMMM: QMM      :.cMB:ZMMW7IME     ",
                            @"           nMS   CMo MB     .:,9MMi MM    MM     ",
                            @"           iM9  oMMi.MA   .ii,,#M.  @MM,  M@     ",
                            @"             6MMMB ;MMv  .:,,IMM@   ZMMMMM.      ",
                            @"                io 8M;  .7zSMM$0A.YME.           ",
                            @"                t@MMMMM$$MMMM@ .#Mb.             ",
                            @"             vMMMM..,iCbb2c   9MMM@c             ",
                            @"           ;##X;:;not7     iSbMB.:c9@z           ",
                            @"           SM1     .CMI   .MM       MM           ",
                            @"            .oBBBW00BMt   .B@00QBBB0;.           ", },
                #endregion
                #region Sprite2
                                new string[]
                                           { @"                                                 ",
                                            @"                                                 ",
                                            @"                                                 ",
                                            @"                         .Iz.                    ",
                                            @"                       .9MMMMz                   ",
                                            @"                       iMMEWMM.                  ",
                                            @"                       .MM  AMM1                 ",
                                            @"                       .Mb   iMMM,               ",
                                            @"                        M6    .$MME              ",
                                            @"                     i.;MMic.   YMM.             ",
                                            @"                   iS#MMQQMM$i  ,$MMi            ",
                                            @"                   MMA$MX   0Mi   WM:            ",
                                            @"                   @MoWMS   ZMi   WM,            ",
                                            @"                   .iI@MW$M@U. c#ibM,            ",
                                            @"                      @Mtii:n@MMM;AM,            ",
                                            @"                      7MMMM@M@@MM:9M,            ",
                                            @"                        MMQ###M2  WM,            ",
                                            @"                       iMM@#@E   .BM,            ",
                                            @"          i8Zoi       WM$bn     . 0M,    C292    ",
                                            @"        :6@@@MMB.     ZM      ..iSMM:  tMMM@@#7  ",
                                            @"        zM1   EM0   .UMM.    .i.;MM:  .MM.   MM  ",
                                            @"        YMS  :@Mn   .M@.  ...::2MMX    MM2   MM  ",
                                            @"          WMMMMM@z :MMt   .:;,.BMM#A .E@MMMMMv   ",
                                            @"                tM#MMMY  .::,CMM# .MM@Q          ",
                                            @"                   WM:  .c7tMMM:                 ",
                                            @"                 :$MMMM6ZMMMMM.                  ",
                                            @"                t@i;AE$@@$C  7@c                 ",
                                            @"             Y@#MMU           MM#@@W             ",
                                            @"           ;##2tviY8$W.    E#W77zU60MI           ",
                                            @"           SMS      UM#   iMM       MM           ",
                                            @"            .oBBBBBQAi.    .X0WBBBB0;.           ", },
                #endregion
                #region Sprite3
                new string[]
                           { @"                       iW@Wi                      ",
                            @"                      BMt.ZME                     ",
                            @"                      8MC.0MM.                    ",
                            @"                     vMM, :WMM.                   ",
                            @"                    iMMi    #M@:                  ",
                            @"                    .M1      0M#                  ",
                            @"  iMMMM;           tMMMB.7MM@MM9           cMMMM, ",
                            @".@M,.oMM@        vMb   vM0 . .MMM.       .MMMC.:M$",
                            @".MM    MM        YM7 2. Mo o. @MM.       .MM    @M",
                            @" EMi,zMM$        .@A ..;@b.,..EMM.        WMMz,.zW",
                            @"  .MM@#M$v;.       QMM$C .@#M@70M.     .i:EM@MM$  ",
                            @"        nbMMZn:    0Mn;cCXcvizMMM.  in9MMSc       ",
                            @"          .7oMMW8i XMMMMMMMMMM6@M  ZMMtv          ",
                            @"              ivMME@MM#0EE0M0. IM##M7             ",
                            @"                   $M:tMMMMi   $Mv                ",
                            @"                   6M        ..WM                 ",
                            @"                   QM       .::@M.                ",
                            @"                   WM.       XMMW                 ",
                            @"                   BM.  .... ;Mo                  ",
                            @"                   BM, ....iC#ME                  ",
                            @"                   BM.   ...#Mz                   ",
                            @"                   $M.  ..v#MM                    ",
                            @"                   EMMMMXEMM2                     ",
                            @"                    .MMMMMM@.                     ",
                            @"                    .0i    0U                     ",
                            @"                   tMU     XM@.                   ",
                            @"                   Y2       iW                    ",
                            @"               B@@BMM0.    7MMM@@@c               ",
                            @"           :@M@8Azt;AM#   :MMiX2A9#MM7            ",
                            @"           CM@      MME   .MMo     tMM            ",
                            @"           i##QWBBBt:..    .,;bBBBQW@I            " },
#endregion
                #region Sprite4
                new string[]
                           { @"                                                 ",
                            @"                     .:.                          ",
                            @"                   :AMMMS.                        ",
                            @"                   @M8:$M$                        ",
                            @"                 .2MMA.UMA                        ",
                            @"                 ,MM;  ,MME                       ",
                            @"                UMMo    .MM.                      ",
                            @"                #Mt      BMi                      ",
                            @"                8MMMMMz:#MMME                     ",
                            @"              iMMB  . WM    WMi                   ",
                            @"   I6;        ,MM$ .C 6M  t IM;     itIA:         ",
                            @" YBMMM#8c     .M@n7XCt6EI17vzn    :$MM@M@S.       ",
                            @".MM   2MM     .M@b@0o1  ;IWMz     $M9   AMt       ",
                            @".MM   ZMM     .MMMbobE$#QbWMz     oM$.  oM7       ",
                            @"  tMMMMM9     .MbYMMMMMM@@MMo     .MMMMME.        ",
                            @"   .   7MMv   .MA  6M#Q0E#MMS   .Z@A.             ",
                            @"        .@M@. ;ME   .@MMM: M# .AMMi               ",
                            @"          c@#E@M@i.        MM0W#z                 ",
                            @"               8MMc       .M6                     ",
                            @"                EM; .     ,M8                     ",
                            @"                WMMn.  .  ,M0                     ",
                            @"                 zM@...   .MQ                     ",
                            @"                  MMMc..  .M0                     ",
                            @"                   EMMBUMMMMz                     ",
                            @"                   .MMMMMMMMi                     ",
                            @"                   66      WQ.                    ",
                            @"                  B$.      vM@                    ",
                            @"               W@MMi        .M@@@@c               ",
                            @"           :@M@Zo7vZ@Mv    ZMM0zU9#MM7            ",
                            @"           CM@      9M@   iMM      tMM            ",
                            @"           i##QWBBBQAi.    .X0WBBBQW@I            " },
#endregion
                #region Sprite5
                new string[]
                           { @"                                                  ",
                            @"                                                  ",
                            @"                                                  ",
                            @"                                                  ",
                            @"                                                  ",
                            @"                     #M0                          ",
                            @"                   IMMMMMX                        ",
                            @"                   @MEv#MQ                        ",
                            @"                 cMMW  2MZ                        ",
                            @"               :MMMi   .ME                        ",
                            @"              :MME.    .MA                        ",
                            @"             i$M9    90@MM1E:                     ",
                            @"             MME: n#0ICiMMBZ6.                    ",
                            @"             $M.   MM   7MM$MM:                   ",
                            @"             WMi.  QM    BMi0M:                   ",
                            @"             $Mv$M. iMMM#MM@;                     ",
                            @"             $M;#MMM@;.. QM.                      ",
                            @"             $M:7MM#$MMMMMI                       ",
                            @"             BM, .ZMMMWQM:                        ",
                            @"             BM.   .6I$MMM;                       ",
                            @"       zMMMY IMMc.     ccMM.   i@MM@              ",
                            @"     cMW7XMM@.YM#..      ZMMi WMM0X6M8            ",
                            @"     UM7   CM. MM@i..     tM6 MM    MM            ",
                            @"     vM2  9MM,  #Mt.,:.   .MZ WM@. .M@            ",
                            @"       EMMMMMi  YMM@;...   $M@ .MMM@.             ",
                            @"            tM#.iQ$MM0tt,   BM.:A                 ",
                            @"              o@@c nMMMMMEMMMMM@8.                ",
                            @"             .QMMM#i  ,S8E2;,. oMMME              ",
                            @"           iW0v:,tM#SC     :71z7i;tE@I            ",
                            @"           nMt      XMU   .MM..     MM            ",
                            @"            .oBBBW00BMt   .B@00QBBB0;.            " },
#endregion
                #region Sprite6
                new string[]
                           { @"                                                  ",
                            @"                                                  ",
                            @"                                                  ",
                            @"                     Xzc                          ",
                            @"                   cMMMM@:                        ",
                            @"                   #MM8MMW                        ",
                            @"                 .@MM  6M8                        ",
                            @"                0MMz   :Mb                        ",
                            @"              :MMMi    .MZ                        ",
                            @"             .2MQ    ;;2M@.i                      ",
                            @"             @MMv  i6MM#EMMMZi                    ",
                            @"             #M. . MM   .MMUMMi                   ",
                            @"             WMi   @M   ,@Mn@M:                   ",
                            @"             BMvbW  c#M@ZMMEv.                    ",
                            @"             $M;@MM@Qci:.WM;                      ",
                            @"             $Mi6MM@@MMM@M#                       ",
                            @"             $M, i@M#@$#Mv                        ",
                            @"             $M:   vM@@@ME                        ",
                            @"    ;8ZS:    $M, .    ,WBMM.      .tI9o           ",
                            @"  :Z@@@MMW.  @M@;.       QM     .nMMM@M$c         ",
                            @"  9MY   QMA  .EM$...     WMMi   ,MM.   MM         ",
                            @"  tM7  i@M7    MM$i..    .6M$    MMS   MM         ",
                            @"   .$MMMMM@t :QMMMY.ii.    MMo .0@MMMMM;          ",
                            @"          SM @Mt 7MMB:.:.   @MM#Wb                ",
                            @"                  @MM8YY,   QM:                   ",
                            @"                   0MMMM@1WMMMMt                  ",
                            @"                  E0  .#@@$bUo;Q@                 ",
                            @"             Y@@#MM:          :MMM@Q              ",
                            @"           ;##UISY;6@#,    A$WScc1U0MI            ",
                            @"           SMS      6M#   :MM       MM            ",
                            @"            .oBBBBBQAi.    .X0WBBBB0;.            " },
#endregion
                #region Sprite7
                new string[]
                           { @"                     .S@@n.                       ",
                            @"                    .M@.iMM.                      ",
                            @"                   .IMM:iMM                       ",
                            @"                   WM@c  #M0.                     ",
                            @"                 .IMM.   .$M#                     ",
                            @"                 ;MM,      MQ                     ",
                            @" ZMMMB           .MM@MM@.;MMM@.           #MMMQ   ",
                            @"Wc..MMMc        ZMM7 ..cM9   cMB        SMM@..QM; ",
                            @"M    nMz        WMM. A. M1 o, MM        bMc   CMX ",
                            @"0c,,MMM:        ZMMv.,.;@b.,..@6        :MMM,.A@i ",
                            @" nMM@@@o;i       bM10M@#t .@#MM        ::X@@MMMC  ",
                            @"      ;A@M@S7     2MM@c;vcCXc;@M    .7S@MWX,      ",
                            @"         itBMM: tM8#MMMMMMMMMM  2EMM07,           ",
                            @"            .@M0M@  1M@0EEE@MMQ@Mo:.              ",
                            @"                #M:   EMMM@,ZM;                   ",
                            @"                8Mi         oM                    ",
                            @"                $MS..       0M.                   ",
                            @"                7MM$.       QM.                   ",
                            @"                  M#  ....  WM.                   ",
                            @"                 .MMZ;. ..  QM.                   ",
                            @"                  iMMc .    0M.                   ",
                            @"                   AMMI...  8M.                   ",
                            @"                    iMMMX0MMMM.                   ",
                            @"                     8MMMMMM1                     ",
                            @"                    .0i    Et                     ",
                            @"                   SM9     cM@.                   ",
                            @"                   7I       iW                    ",
                            @"               B@@BMM0.    7MMM@@@c               ",
                            @"           :@M@8Azt; AM#   :MMiX2A9#MM7           ",
                            @"           CM@      MME   .MMo     tMM            ",
                            @"           i##QWBBBt:..    .,;bBBBQW@I            " },
#endregion
                #region Sprite8
                new string[]
                           { @"                                                  ",
                            @"                          ::                      ",
                            @"                       .;@MM@:                    ",
                            @"                       ;MMvvMM.                   ",
                            @"                        M@,;MM@:                  ",
                            @"                      cMM6  ,$M#                  ",
                            @"                      $M;    ,MM@.                ",
                            @"                      BM.     :MM.                ",
                            @"                   .iMMMMziMMMMMM:                ",
                            @"                   MM    QM.   iMM0               ",
                            @"         SAz7      MM .X IM  X .MM8       :tIUi   ",
                            @"       7W@MMMMv    ;E1cXtAEU1C7Y0Mb     :WMM@M@1. ",
                            @"       MM   iMM.     MM11  iIA#EZMb     QME   1MC ",
                            @"       MM   zMM     .MM6b$#QEUt@MMU     tM#.  XM7 ",
                            @"        7MMMMME     .MM@@MM@@MM87M0     .MMMMM0.  ",
                            @"         .   cMMY    MMM$000M@. .M0    A@9.       ",
                            @"              .#M@: iMY 0MMM7   :M@ .2MM;         ",
                            @"                ;@#E#MX       .i2MMQW#U           ",
                            @"                     Mb       .@M#,               ",
                            @"                    .M0    ... WM                 ",
                            @"                    .MQ  ....c0MM.                ",
                            @"                    .MQ   ...YM#.                 ",
                            @"                    .MQ  ..:bMMX                  ",
                            @"                    .MMMM#2MMM                    ",
                            @"                     8MMMMMMMo                    ",
                            @"                    iB,     i@v                   ",
                            @"                   XM1       bMt                  ",
                            @"               B@@#Mn         MM#@c               ",
                            @"           :@M@8A2tMM@i   .Q @W7726#MM7           ",
                            @"           CM@      7M@   iMM      tMM            ",
                            @"           i##QWBBBQAi.    .X0WBBBQW@I            " },
#endregion
            };
            while (true)
            {
                for (int i = 0; i < sprites.Count; i++)
                {
                    Console.WriteLine("\n\n");
                    var maxLength = sprites[i].Aggregate(0, (max, line) => Math.Max(max, line.Length));
                    var x = Console.BufferWidth / 2 - maxLength / 2;

                    ConsoleDraw(sprites[i], x, 2);
                    Thread.Sleep(95);
                }
                
            }
        }
    }
}
