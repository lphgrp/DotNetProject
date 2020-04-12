using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }
         public static void Method(IMyInterface instance1, IMyInterface instance2)
    {
        if (instance1 == instance2) // Noncompliant, will do reference equality check, but was that intended? MyClass overrides Equals.
        {
            Console.WriteLine("Equal");
        }
    }
    }
}
