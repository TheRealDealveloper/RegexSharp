using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegexSharp
{
    public static class Program
    {
        private static Dictionary<string, int> ops = new Dictionary<string, int>();
        private static Dictionary<string, int> r = new Dictionary<string, int>();
        private static char currentchar;
        private static string userregex;
        private static string userinputcheck;
        private static StringBuilder builderl = new StringBuilder();
        private static StringBuilder builderr = new StringBuilder();
        private static List<State> states = new List<State>();
        public static void Main(string[] args)
        {
            Op();

            userregex = "avb*";
            userregex = RemoveWhitespace(userregex);

            userinputcheck = "bb";

            var result = Calc(userregex,currentchar);



            //for (int i = 0; i < userinput.Length; i++)
            //{
            //    if (ops.TryGetValue(userinput[i].ToString(), out int num))
            //    {

            //    }
            //    builderl.Append(userinput[i].ToString());
            //}


            //if (ops.TryGetValue(s.ToString(), out int val))
            //{
            //    if (s=='(')
            //    {
            //        builder.Append(s);

            //    }

            //}
            //switch (s)
            //{


            //    default:
            //        break;
            //}
            //builder.Append(userinput[0]);




            Console.ReadLine();
        }

        private static char ReturnOperator(string userinput)
        {
            int prio = 0;
            for (int i = 0; i < userinput.Length; i++)
            {
                if (ops.TryGetValue(userinput[i].ToString(), out int num))
                {
                    if (prio < num)
                    {
                        prio = num;
                        currentchar = userinput[i];
                    }
                }

            }
            if (prio!=0)
            {
                return currentchar;
            }
            return ' ';
        }

        public static bool Calc(string input, char currentopchar)
        {

            currentopchar = ReturnOperator(input);
            //var trim = input.Split(currentopchar, 2);

            //switch (currentopchar)
            //{
            //    case 'v':
            //        states.Add(new State 
            //        {
            //            Name = "or",
            //            Left = trim[0],
            //            Right = trim[1],
            //            Operator = currentchar.ToString()
            //        });
            //        break;
            //    default:
            //        break;
            //}

            if (currentopchar != ' ')
            {
                var trim = input.Split(currentopchar, 2);
                bool flag = false;
                string newinput;

                switch (currentopchar)
                {
                    case 'v':
                        foreach (string item in trim)
                        {
                            if (Calc(item, currentopchar)) flag = !flag;
                        }
                        break;
                    case '#':
                        foreach (string item in trim)
                        {
                            if (Calc(item, currentopchar)) flag = !flag;
                        }
                        break;
                    case '+':
                        if (userinputcheck != String.Empty)
                        {
                            newinput = String.Join("", userinputcheck.Split(trim[0]));
                            if (String.Empty == newinput)
                            {
                                return true;
                            }
                        }
                        break;
                    case '*':
                        newinput = String.Join("", userinputcheck.Split(trim[0]));
                        if (String.Empty == newinput)
                        {
                            return true;
                        }
                        break;
                    default:
                        break;
                }

                return flag;
            }
            else
            {
                if (input == userinputcheck)
                {
                    return true;
                }
            }



            return false;
        }

        public static string Rules(string a, string b)
        {
            throw new NotImplementedException();
        }

        public static void Op()
        {
            ops.Add("(", 1);
            ops.Add(")", 1);
            ops.Add("+", 100);
            ops.Add("v", 700);
            ops.Add("*", 200);
            ops.Add("#", 600);

            
        }

        

        public static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }




    }
}
