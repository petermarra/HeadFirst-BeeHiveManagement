using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHiveManagement
{
    public partial class Form1 : Form
    {

        Queen queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] {"Nector collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nector collector", "Honey manufacturing", "Egg care", "Baby bee tutoring" , "Hive maintenance", "Sting patrol" });
            queen = new Queen(workers);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void assignWork_Click(object sender, EventArgs e)
        {
            if (!queen.AssignWork(workerBeeJob.Text, (int)shifts.Value))
            {
                MessageBox.Show($"Unable to assign {workerBeeJob.Text} for {shifts.Value} shifts");
            }
        }
    }
}
