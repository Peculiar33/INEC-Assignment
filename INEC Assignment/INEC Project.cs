using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INEC_Assignment
{
    internal class INEC_Project
    {
        public void VoterReg(List<string> InecReg)
        {
            string output;
            Console.WriteLine("Enter Voters Name");
            string newVoterName=Console.ReadLine();
            foreach (string name in InecReg)
            {
                if (name == newVoterName)
                {
                    Console.WriteLine("This name has been registered"); 

                }
            }

        }
    }
}
