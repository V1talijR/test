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

            Label napis = new Label();
            napis.Text = "sprawdzamy napisy";
            napis.AutoSize = true;
            napis.Font = new System.Drawing.Font("Arial", 14);
            napis.Location = new System.Drawing.Point(50, 50);

            this.Controls.Add(napis);
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