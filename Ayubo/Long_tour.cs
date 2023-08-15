using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ayubo
{
    public partial class Long_tour : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DINPCM0;Initial Catalog=Ayubo;Integrated Security=True");
        public Long_tour()
        {
            InitializeComponent();
            packagetype();
        }

        public void packagetype()
        {

            string sql = "select * from New_Package";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string packgename = myreader.GetString(1);
                    comboBox2.Items.Add(packgename);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Long_tour_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from New_Package where p_name='" + comboBox2.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {

                    string id = myreader.GetInt32(0).ToString();
                    
                    string rate = myreader.GetString(2);
                    txtkms.Text = rate;
                    string vehiclenigtrate = myreader.GetString(5);
                    textBox1.Text = vehiclenigtrate;
                    string mxkm = myreader.GetString(9);
                    textBox3.Text = mxkm;
                    string mxhour = myreader.GetString(5);
                    textBox2.Text = mxhour;
                    string dnr = myreader.GetString(3);
                    textBox4.Text = dnr;
                    string ekc = myreader.GetString(4);
                    textBox13.Text = ekc;


                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime Rent_Date = dateTimePicker1.Value.Date;
            DateTime Return_Date = dateTimePicker2.Value.Date;

            int Dateiff = ((TimeSpan)(Return_Date - Rent_Date)).Days;
            textBox5.Text = Dateiff.ToString();

            if (txtkms.Text != "")
            {
                

                int tnfd, vnr, divernr, ans;
                tnfd = int.Parse(textBox5.Text);
                vnr = int.Parse(textBox1.Text);
                divernr = int.Parse(textBox4.Text);
                ans = ((vnr + divernr) * tnfd);
                textBox6.Text = ans.ToString();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "" && textBox7.Text != "")
            {




                int startkm, endkm, ans;
                startkm = int.Parse(textBox8.Text);
                endkm = int.Parse(textBox7.Text);



                ans = (endkm - startkm);

                textBox11.Text = ans.ToString();

                int nok, mx, ans2;
                nok = int.Parse(textBox11.Text);
                mx= int.Parse(textBox3.Text);



                ans2 = (nok - mx);

                textBox12.Text = ans2.ToString();


            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtkms.Text != "")
            {


                

                int packge_rate, total_night_rate, no_of_extra_km, extra_km_charge, no_of_days, ans;
                packge_rate = int.Parse(txtkms.Text);
                total_night_rate = int.Parse(textBox6.Text);
                no_of_extra_km = int.Parse(textBox12.Text);
                extra_km_charge = int.Parse(textBox13.Text);
                no_of_days = int.Parse(textBox5.Text);
                ans = ((no_of_extra_km * extra_km_charge) + (total_night_rate )+(packge_rate* no_of_days));
                txttotal.Text = ans.ToString();























            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            txtkms.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            textBox5.Clear();
            textBox6.Clear();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            textBox11.Clear();
            textBox13.Clear();
            textBox7.Clear();
            textBox12.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txttotal.Clear();
            textBox8.Clear();
            textBox11.Clear();
            textBox13.Clear();
            textBox7.Clear();
            textBox12.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            textBox5.Clear();
            textBox6.Clear();
            comboBox2.Text = "";
            txtkms.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
