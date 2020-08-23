using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Events
{
    public partial class Form1 : Form
    {
        private int point = 1000;
        public Form1()
        {
            InitializeComponent();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            var wall = sender as Button;
            var leftPoints = Convert.ToInt32(wall.Tag);
            point -= leftPoints;
            if (point <= 0)
            {
                MessageBox.Show("Oyun bitti.", "Worst Mario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            lblPoint.Text = point.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPoint.Text = point.ToString();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler, prensesi kurtardın", "The best worst Mario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            SetPosition(e.X, e.Y); ;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            var x = btn.Left + e.X;
            var y = btn.Top + e.Y;
            SetPosition(x, y);
        }

        private void SetPosition(int x, int y)
        {
            lblPosition.Text = $"({x},{y})";
        }
    }
}
