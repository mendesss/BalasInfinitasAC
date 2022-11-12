using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;


namespace AC
{
    



    public partial class Form1 : Form
    {
        Mem meme = new Mem();
        string bala = "ac_client.exe+0x0016F338,8,F8,140";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = meme.GetProcIdFromName("ac_client");
            if (PID > 0)

            {
                meme.OpenProcess(PID);
                timer1.Start();

            }

        }

        private void timer1_Tick(object sender, EventArgs e)

            
        {
            if (checkBox1.Checked){ 
            meme.WriteMemory(bala, "int", "999999");
                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
