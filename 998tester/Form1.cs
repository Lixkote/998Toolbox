
using RibbonLib;
using RibbonLib.Interop;
using System.Diagnostics;
using System.Windows.Forms;

namespace _998tester
{
    public partial class Form1 : Form
    {
        private Ribbon _ribbon = new Ribbon();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/Lixkote/998tester",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
        }
    }
}