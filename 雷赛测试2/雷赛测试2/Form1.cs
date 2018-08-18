using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using csLTDMC;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Int16 i;
        private void Form1_Load(object sender, EventArgs e)
        {
            LTDMC.dmc_board_init();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LTDMC.dmc_board_close();

        }

        private void start_Click(object sender, EventArgs e)
        {
            LTDMC.dmc_set_profile(0, 0, 500, 5000, 0.01, 0.01, 500);
            LTDMC.dmc_pmove(0, 0, 200000, 0);


        }

        private void stop_Click(object sender, EventArgs e)
        {
            LTDMC.dmc_stop(0, 0, 0);

        }
    }
}
