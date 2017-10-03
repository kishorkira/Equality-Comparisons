using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Button btn1 = new Button
            {
                Text = "Button"
            };
            Button btn2 = new Button
            {
                Text = "Button"
            };

            Console.WriteLine(btn1 == btn2);
            Console.WriteLine(btn1.Equals(btn2));

            float f1 = 4.0000001f;
            float f2 = 4.0000000f;
            Console.WriteLine(f1 == f2);
            float f3 = 5.075f;
            float f4 = 1.025f;
            Console.WriteLine(f3 + f4);
            Console.WriteLine((f3 + f4) == 6.1f);

        }
    }
}
