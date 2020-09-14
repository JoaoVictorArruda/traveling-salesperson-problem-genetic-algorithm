using System;
using System.Windows.Forms;

namespace traveling_salesperson_problem_genetic_algorithm
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConfiguracaoForm());
        }
    }
}
