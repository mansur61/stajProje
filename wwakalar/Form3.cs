
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wwakalar;

namespace grafikselGosterim
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            textBox1.BackColor = Color.Red;

            textBox2.BackColor = Color.Blue;
            textBox3.BackColor = Color.Yellow;
            textBox4.BackColor = Color.Green;
            textBox5.BackColor = Color.Orange;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int not1 = 0;
            int not2 = 0;
            int not3 = 0;
            int not4 = 0;
            int not5 = 0;
            try
            {
                not1 = int.Parse(textBox1.Text);
                not2 = int.Parse(textBox2.Text);
                not3 = int.Parse(textBox3.Text);
                not4 = int.Parse(textBox4.Text);
                not5 = int.Parse(textBox5.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            float total = not1 + not2 + not3 + not4 + not5;

            float deg1 = (not1 / total) * 360;
            float deg2 = (not2 / total) * 360;
            float deg3 = (not3 / total) * 360;
            float deg4 = (not4 / total) * 360;
            float deg5 = (not5 / total) * 360;


            Pen p = new Pen(Color.Black, 5);
            Graphics g = this.CreateGraphics();
            Rectangle rec = new Rectangle(textBox1.Location.X + textBox1.Size.Width + 10, 12, 150, 150);

            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Blue);
            Brush b3 = new SolidBrush(Color.Yellow);
            Brush b4 = new SolidBrush(Color.Green);
            Brush b5 = new SolidBrush(Color.Orange);
            g.Clear(Form3.DefaultBackColor);
            g.DrawPie(p, rec, 0, deg1);
            g.FillPie(b1, rec, 0, deg1);
            g.DrawPie(p, rec, deg1, deg2);
            g.FillPie(b2, rec, deg1, deg2);
            g.DrawPie(p, rec, deg2 + deg1, deg3);
            g.FillPie(b3, rec, deg2 + deg1, deg3);
            g.DrawPie(p, rec, deg3 + deg2 + deg1, deg4);
            g.FillPie(b4, rec, deg3 + deg2 + deg1, deg4);
            g.DrawPie(p, rec, deg4 + deg3 + deg2 + deg1, deg5);
            g.FillPie(b5, rec, deg4 + deg3 + deg2 + deg1, deg5);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Durum"].Points.AddXY("Max", 33);
            this.chart1.Series["Durum"].Points.AddXY("carl", 20);
            this.chart1.Series["Durum"].Points.AddXY("Mark", 50);
            this.chart1.Series["Durum"].Points.AddXY("Alli", 40);

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 formkapa = new Form2();
            formkapa.Close();
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }
    }
}
