using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.Command
{
    public class Sugar
    {
        public const int OFF = 0;
        public const int HIGH = 5;
        private int level;

        public Sugar()
        {
            level = OFF;
        }

        public void RaiseLevel()
        {
            if (level < HIGH)
                level++;
            Console.WriteLine("Sugar level {0}", level);
        }
        public void DropLevel()
        {
            if (level > OFF)
                level--;
            Console.WriteLine("Sugar level {0}", level);
        }
    }
}
