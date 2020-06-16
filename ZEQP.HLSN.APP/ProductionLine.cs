using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera.Hikvision
{
    public partial class ProductionLine : Form
    {
        LoadRecord LoadRecordForm = new LoadRecord();
        ProductionStatistics ProductionStatisticsForm = new ProductionStatistics();
        FailureStatistics FailureStatisticsForm = new FailureStatistics();
        public ProductionLine()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("E:\\ZEQP\\Repositories_Code\\ZEQP.HLSN\\DOC\\PL_R.png");
            pictureBox2.Image = Image.FromFile("E:\\ZEQP\\Repositories_Code\\ZEQP.HLSN\\DOC\\PL_N.png");
            pictureBox3.Image = Image.FromFile("E:\\ZEQP\\Repositories_Code\\ZEQP.HLSN\\DOC\\PL_G.png");
            pictureBox4.Image = Image.FromFile("E:\\ZEQP\\Repositories_Code\\ZEQP.HLSN\\DOC\\PL_N.png");
            pictureBox5.Image = Image.FromFile("E:\\ZEQP\\Repositories_Code\\ZEQP.HLSN\\DOC\\PL_R.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("E:\\ZEQP\\Repositories_Code\\ZEQP.HLSN\\DOC\\PL_N.png");
            pictureBox2.Image = Image.FromFile("E:\\ZEQP\\Repositories_Code\\ZEQP.HLSN\\DOC\\PL_N.png");
            pictureBox3.Image = Image.FromFile("E:\\ZEQP\\Repositories_Code\\ZEQP.HLSN\\DOC\\PL_N.png");
            pictureBox4.Image = Image.FromFile("E:\\ZEQP\\Repositories_Code\\ZEQP.HLSN\\DOC\\PL_N.png");
            pictureBox5.Image = Image.FromFile("E:\\ZEQP\\Repositories_Code\\ZEQP.HLSN\\DOC\\PL_N.png");
        }

        private void button_LR_Click(object sender, EventArgs e)
        {
            LoadRecordForm.Show();
        }

        private void button_ps_Click(object sender, EventArgs e)
        {
            ProductionStatisticsForm.Show();
        }

        private void button_fs_Click(object sender, EventArgs e)
        {
            FailureStatisticsForm.Show();
        }
    }
}
