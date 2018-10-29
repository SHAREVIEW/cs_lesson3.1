using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {

        //goto语句
        start:
        int myInteger = 5;
        goto addVa1;
        writeResult:
        Console.WriteLine("myInteger = {0}", myInteger );
        goto start;
        addVa1:
        myInteger += 10;
        goto writeResult;





        }
    }
}
