using System;

namespace INEC_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {// list of Arrays to loop through
            List<string> InceReg = new List<string> {

                "Peter Ojo",
                "favour Ahmed",
                "Musa Litten",
                "Mmasi Faith",
                "Kate Philip",
                "favour Ahmed",
                "Musa Litten",
                "John peterson",
                "felix kate",
                "Godsent Isa",
                "Peter Ojo",
                "Mmasi Faith",
                "Temi liun",
                "Kemi Alex"
            };
            IDictionary<string, int> InceRegDic = new Dictionary<string, int>();
            //use of hashSet to sort out the names and findout how times the a person name appear.
            HashSet<string> InecRegUnique=InceReg.ToHashSet();
            foreach (var name in InceReg)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n\n\n");
            foreach (var hashName in InecRegUnique)
            {
                int count = 0;
                foreach(var name in InceReg)
                {
                    if (name == hashName)
                    {
                        count++; 
                    }

                }

                InceRegDic.Add(hashName, count);
            }

            foreach (var kv in InceRegDic)
            {
                if (kv.Value == 1)

                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{kv.Key} registered {kv.Value}times");
                }

            }
            
        }
    }
}


