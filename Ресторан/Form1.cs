using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ресторан
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P8NOCPV\SQLEXPRESS;Initial Catalog=Restorant;Integrated Security=True");
        SqlCommand cmd;



        const double Price_checkbox1 = 14;
        const double Price_checkbox2 = 40;
        const double Price_checkbox3 = 120;
        const double Price_checkbox4 = 140;
        const double Price_checkbox5 = 80;
        const double Price_checkbox6 = 120;
        const double Price_checkbox7 = 140;
        const double Price_checkbox8 = 140;
        const double Price_checkbox9 = 140;
        const double Price_checkbox24 = 100;
        const double Price_checkbox23 = 150;
        const double Price_checkbox22 = 200;
        const double Price_checkbox21= 180;
        const double Price_checkbox20 = 200;
        const double Price_checkbox19 = 200;
        const double Price_checkbox18 = 50;
        const double Price_checkbox17 = 50;
        const double Price_checkbox15 = 50;
        const double Price_checkbox13 = 50;
        const double Price_checkbox16 = 50;
        const double Price_checkbox14 = 50;
        const double Price_checkbox12 = 50;
        const double Price_checkbox11 = 70;
        const double Price_checkbox10 = 200;

        double iTax, isubTotal, iTotal, cost, iChange;



        public Form1()
        {
            InitializeComponent();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Прифатете дека сакате да излезете од системот", "Ресторант", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        //===================================================RestTextBoxes()==================
        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null; 

            func = (controls) =>
         {
             foreach (Control control in controls)
                 if (control is TextBox)
                     (control as TextBox).Text = "0";
                 else
                     func(control.Controls);
         };
            func(Controls);
        }
        //====================================================================EnableCheckBoxes()==================
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        //==============================================================RestCheckBoxes()==================
        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked=false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }




        private void button5_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox26.Text = DateTime.Now.ToLongDateString();
            textBox27.Text = DateTime.Now.ToLongTimeString();

            ComboBox1.Items.Add(" ");
            ComboBox1.Items.Add("Кеш");
            ComboBox1.Items.Add("Master Card ");
            ComboBox1.Items.Add("Visa Card ");
            ComboBox1.Items.Add("Debit Card ");

            EnableTextBoxes();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();
                
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();

            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();

            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox5.Enabled = true;
                textBox5.Text = "";
                textBox5.Focus();

            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();

            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();

            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }

        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = "";
                textBox8.Focus();

            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox9.Enabled = true;
                textBox9.Text = "";
                textBox9.Focus();

            }
            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox10.Enabled = true;
                textBox10.Text = "";
                textBox10.Focus();

            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {
                textBox25.Enabled = true;
                textBox25.Text = "";
                textBox25.Focus();

            }
            else
            {
                textBox25.Enabled = false;
                textBox25.Text = "0";
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                textBox24.Enabled = true;
                textBox24.Text = "";
                textBox24.Focus();

            }
            else
            {
                textBox24.Enabled = false;
                textBox24.Text = "0";
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                textBox23.Enabled = true;
                textBox23.Text = "";
                textBox23.Focus();

            }
            else
            {
                textBox23.Enabled = false;
                textBox23.Text = "0";
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                textBox22.Enabled = true;
                textBox22.Text = "";
                textBox22.Focus();

            }
            else
            {
                textBox22.Enabled = false;
                textBox22.Text = "0";
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                textBox21.Enabled = true;
                textBox21.Text = "";
                textBox21.Focus();

            }
            else
            {
                textBox21.Enabled = false;
                textBox21.Text = "0";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                textBox20.Enabled = true;
                textBox20.Text = "";
                textBox20.Focus();

            }
            else
            {
                textBox20.Enabled = false;
                textBox20.Text = "0";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                textBox19.Enabled = true;
                textBox19.Text = "";
                textBox19.Focus();

            }
            else
            {
                textBox19.Enabled = false;
                textBox19.Text = "0";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                textBox18.Enabled = true;
                textBox18.Text = "";
                textBox18.Focus();

            }
            else
            {
                textBox18.Enabled = false;
                textBox18.Text = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                textBox16.Enabled = true;
                textBox16.Text = "";
                textBox16.Focus();

            }
            else
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox14.Enabled = true;
                textBox14.Text = "";
                textBox14.Focus();

            }
            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                textBox17.Enabled = true;
                textBox17.Text = "";
                textBox17.Focus();

            }
            else
            {
                textBox17.Enabled = false;
                textBox17.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox15.Enabled = true;
                textBox15.Text = "";
                textBox15.Focus();

            }
            else
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox13.Enabled = true;
                textBox13.Text = "";
                textBox13.Focus();

            }
            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.Text == "Кеш" )
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[23];
            itemcost[0] = Convert.ToDouble(textBox1.Text) * Price_checkbox1;
            itemcost[1] = Convert.ToDouble(textBox3.Text) * Price_checkbox2;
            itemcost[2] = Convert.ToDouble(textBox4.Text) * Price_checkbox3;
            itemcost[3] = Convert.ToDouble(textBox5.Text) * Price_checkbox4;
            itemcost[4] = Convert.ToDouble(textBox6.Text) * Price_checkbox5;
            itemcost[5] = Convert.ToDouble(textBox7.Text) * Price_checkbox6;
            itemcost[6] = Convert.ToDouble(textBox8.Text) * Price_checkbox7;
            itemcost[7] = Convert.ToDouble(textBox9.Text) * Price_checkbox8;
            itemcost[8] = Convert.ToDouble(textBox10.Text) * Price_checkbox9;
            itemcost[9] = Convert.ToDouble(textBox25.Text) * Price_checkbox24;
            itemcost[10] = Convert.ToDouble(textBox24.Text) * Price_checkbox23;
            itemcost[11] = Convert.ToDouble(textBox23.Text) * Price_checkbox22;
            itemcost[12] = Convert.ToDouble(textBox22.Text) * Price_checkbox21;
            itemcost[13] = Convert.ToDouble(textBox21.Text) * Price_checkbox20;
            itemcost[14] = Convert.ToDouble(textBox20.Text) * Price_checkbox19;
            itemcost[15] = Convert.ToDouble(textBox19.Text) * Price_checkbox18;
            itemcost[16] = Convert.ToDouble(textBox17.Text) * Price_checkbox16;
            itemcost[17] = Convert.ToDouble(textBox15.Text) * Price_checkbox14;
            itemcost[18] = Convert.ToDouble(textBox18.Text) * Price_checkbox17;
            itemcost[19] = Convert.ToDouble(textBox16.Text) * Price_checkbox15;
            itemcost[20] = Convert.ToDouble(textBox14.Text) * Price_checkbox13;
            itemcost[21] = Convert.ToDouble(textBox13.Text) * Price_checkbox12;
            itemcost[22] = Convert.ToDouble(textBox12.Text) * Price_checkbox11;

            double cost, iTax, iTotal, isubTotal;
            if (ComboBox1.Text == "Кеш" )
            {
                isubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6]  +
                    itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + 
                    itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20] +
                    itemcost[21] + itemcost[22];
                label8.Text = Convert.ToString(isubTotal);
                iTax = isubTotal * 5 / 100;
                label7.Text = Convert.ToString(iTax);
                iTotal = (isubTotal + iTax);
                label10.Text = Convert.ToString(iTotal);


                iChange = Convert.ToDouble(textBox2.Text);
                cost = iChange - (iTax + iTotal);
                label6.Text = Convert.ToString(cost);

                
            }    
            else
            {
                
                    isubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] +
                        itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] +
                        itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20] +
                        itemcost[21] + itemcost[22];
                    label8.Text = Convert.ToString(isubTotal);
                    iTax = isubTotal * 5 / 100;
                    label7.Text = Convert.ToString(iTax);
                    iTotal = (isubTotal + iTax);
                    label10.Text = Convert.ToString(iTotal);
            
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(" insert into Smetka values ('" + textBox1.Text + "' , '" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox25.Text + "','" + textBox24.Text + "','" + textBox23.Text + "','" + textBox22.Text + "','" + textBox21.Text + "','" + textBox20.Text + "','" + textBox19.Text + "','" + textBox18.Text + "','" + textBox16.Text + "','" + textBox14.Text + "','" + textBox17.Text + "','" + textBox15.Text + "','" + textBox13.Text + "','" + textBox12.Text + "','" + textBox11.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show ("Успешно зачувано");
            con.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            EnableTextBoxes();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox12.Enabled = true;
                textBox12.Text = "";
                textBox12.Focus();

            }
            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox11.Enabled = true;
                textBox11.Text = "";
                textBox11.Focus();

            }
            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }
    }
}
    

