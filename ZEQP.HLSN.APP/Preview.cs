using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;
using System.IO;
using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Camera.Hikvision
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        #region  控件随动

        private void Preview_SizeChanged(object sender, EventArgs e)
        {
            //panel1.Size = new Size(this.Width - 16, this.Height - 74);
        }
        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size((panel1.Width - 1 * 2) / 3, (panel1.Height - 1 * 2) / 3);
            pictureBox2.Location = new System.Drawing.Point((panel1.Width - 1 * 2) / 3 + 1, 0);
            pictureBox3.Location = new System.Drawing.Point((panel1.Width - 1 * 2) / 3 * 2 + 2, 0);
            pictureBox4.Location = new System.Drawing.Point(0, (panel1.Height - 1 * 2) / 3 + 1);
            pictureBox7.Location = new System.Drawing.Point(0, (panel1.Height - 1 * 2) / 3 * 2 + 2);
            pictureBox5.Location = new System.Drawing.Point(pictureBox2.Location.X, pictureBox4.Location.Y);
            pictureBox6.Location = new System.Drawing.Point(pictureBox3.Location.X, pictureBox4.Location.Y);
            pictureBox8.Location = new System.Drawing.Point(pictureBox2.Location.X, pictureBox7.Location.Y);
            pictureBox9.Location = new System.Drawing.Point(pictureBox3.Location.X, pictureBox7.Location.Y);

            pictureBox5.Size = pictureBox4.Size = pictureBox3.Size = pictureBox2.Size = pictureBox1.Size;
            pictureBox9.Size = pictureBox8.Size = pictureBox7.Size = pictureBox6.Size = pictureBox5.Size;
        }
        #endregion

        #region  放缩画面

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            //this.WindowState = FormWindowState.Normal;
            //this.panel1.Dock = DockStyle.None;


            pictureBox1.Dock = DockStyle.None;
            //pictureBox2.Enabled = true;

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //Rectangle ret = Screen.GetWorkingArea(this);

            //this.panel1.ClientSize = new Size(ret.Width, ret.Height);
            //this.panel1.Dock = DockStyle.Fill;
            //this.panel1.BringToFront();

            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BringToFront();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.BringToFront();
        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Dock = DockStyle.None;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.BringToFront();
        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox3.Dock = DockStyle.None;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.BringToFront();
        }

        private void pictureBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox4.Dock = DockStyle.None;
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.BringToFront();
        }

        private void pictureBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox5.Dock = DockStyle.None;
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.BringToFront();
        }

        private void pictureBox6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox6.Dock = DockStyle.None;
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox7.Dock = DockStyle.Fill;
            pictureBox7.BringToFront();
        }

        private void pictureBox7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox7.Dock = DockStyle.None;
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox8.Dock = DockStyle.Fill;
            pictureBox8.BringToFront();
        }

        private void pictureBox8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox8.Dock = DockStyle.None;
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox9.Dock = DockStyle.Fill;
            pictureBox9.BringToFront();
        }

        private void pictureBox9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox9.Dock = DockStyle.None;
        }


        #endregion

       
    }
}
