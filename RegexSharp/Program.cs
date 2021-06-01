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
        private static string userinput;
        private static StringBuilder builderl = new StringBuilder();
        private static StringBuilder builderr = new StringBuilder();
        public static void Main(string[] args)
        {
            Op();

            userinput = "b v c*";
            userinput = RemoveWhitespace(userinput);


            int prio = 0;
            for (int i = 0; i < userinput.Length; i++)
            {
                if(ops.TryGetValue(userinput[i].ToString(), out int num))
                {
                    if (prio < num)
                    {
                        prio = num;
                    }
                }

            }
            userinput.Split()

            for (int i = 0; i < userinput.Length; i++)
            {
                if (ops.TryGetValue(userinput[i].ToString(), out int num))
                {
                    
                }
                builderl.Append(userinput[i].ToString());
            }


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
            Calc(userinput);
        }

        public static string Calc(string reg)
        {

            
            currentchar = userinput[0];
            userinput = userinput.Remove(1);

            if (currentchar == '(')
            {

            }
            else if (ops.TryGetValue(currentchar.ToString(), out int val) && currentchar != '(')
            {
                throw new Exception("invalid input");
            }
            else
            {

            }
            return "";
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
            ops.Add("⧺", 600);

            
        }

        public static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }




    }
}
