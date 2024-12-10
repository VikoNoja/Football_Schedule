using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int dayofthemonth = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
