using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_chart_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 1;
        Point location;
        Point startinglocation;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            startinglocation = button1.Location;
            location = e.Location;

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                button1.Left += e.X - (location.X);
                button1.Top += e.Y - (location.Y);
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = new Button();
            btn.Size = button1.Size;
            btn.Location = button1.Location;
            btn.Text = counter.ToString();
            btn.Name = counter.ToString();
            Controls.Add(btn);
            counter++;
            button1.Location = startinglocation;
        }
    }
}
