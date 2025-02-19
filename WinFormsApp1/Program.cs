using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class WinFormsApp1 : Form
    {
        public WinFormsApp1()
        {
            this.Text = "test";
            this.Width = 800;
            this.Height = 600;
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WinFormsApp1());
        }
    }
}