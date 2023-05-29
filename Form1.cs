using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mart
{
    public partial class Form1 : Form
    {
        int tp = 0;
        int tpr = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            label13.Text = d.ToString();
            label13.Visible = true;
            groupBox1.Visible = true;
            if (checkBox1.Checked)
            {
                tpr += 1;
                label22.Text = numericUpDown1.Value.ToString();
                label16.Text = ("Apple").ToString();
                if (comboBox1.SelectedItem.ToString() == "High")
                {
                    int hpa = 200;
                    int a = Convert.ToInt32(numericUpDown1.Value);
                    int ap = a * hpa;
                    label28.Text = ap.ToString();
                    tp += ap;
                }
                else
                {
                    int mpa = 150;
                    int a = Convert.ToInt32(numericUpDown1.Value);
                    int apm = a * mpa;
                    label28.Text = apm.ToString();
                    tp += apm;
                }
            }
            if (checkBox2.Checked)
            {
                tpr += 1;
                label27.Text = numericUpDown2.Value.ToString();
                label17.Text = ("Orange").ToString();
                if (comboBox2.SelectedItem.ToString() == "High")
                {
                    int hpo = 300;
                    int a = Convert.ToInt32(numericUpDown2.Value);
                    int ap = a * hpo;
                    label29.Text = ap.ToString();
                    tp += ap;
                }
                else
                {
                    int mpo = 200;
                    int a = Convert.ToInt32(numericUpDown2.Value);
                    int apm = a * mpo;
                    label29.Text = apm.ToString();
                    tp += apm;
                }
            }
            if (checkBox3.Checked)
            {
                tpr += 1;
                label24.Text = numericUpDown3.Value.ToString();
                label18.Text = ("Mango").ToString();
                if (comboBox3.SelectedItem.ToString() == "High")
                {
                    int hpm = 150;
                    int a = Convert.ToInt32(numericUpDown3.Value);
                    int ap = a * hpm;
                    label34.Text = ap.ToString();
                    tp += ap;
                }
                else
                {
                    int mpm =120 ;
                    int a = Convert.ToInt32(numericUpDown3.Value);
                    int apm = a * mpm;
                    label34.Text = apm.ToString();
                    tp += apm;
                }
            }
            if (checkBox4.Checked)
            {
                tpr += 1;
                label23.Text = numericUpDown4.Value.ToString();
                label19.Text = ("Peach").ToString();
                if (comboBox4.SelectedItem.ToString() == "High")
                {
                    int hpp = 250;
                    int a = Convert.ToInt32(numericUpDown4.Value);
                    int ap = a * hpp;
                    label33.Text = ap.ToString();
                    tp += ap;
                }
                else
                {
                    int mpp = 200;
                    int a = Convert.ToInt32(numericUpDown4.Value);
                    int apm = a * mpp;
                    label33.Text = apm.ToString();
                    tp += apm;
                }
            }
            if (checkBox5.Checked)
            {
                tpr += 1;
                label25.Text = numericUpDown5.Value.ToString();
                label20.Text = ("Pineapple").ToString();
                if (comboBox5.SelectedItem.ToString() == "High")
                {
                    int hpp = 1000;
                    int a = Convert.ToInt32(numericUpDown5.Value);
                    int ap = a * hpp;
                    label32.Text = ap.ToString();
                    tp += ap;
                }
                else
                {
                    int mpp = 800;
                    int a = Convert.ToInt32(numericUpDown5.Value);
                    int apm = a * mpp;
                    label32.Text = apm.ToString();
                    tp += apm;
                }
            }
            if (checkBox6.Checked)
            {
                tpr += 1;
                label26.Text = numericUpDown4.Value.ToString();
                label21.Text = ("Strawberries").ToString();
                if (comboBox6.SelectedItem.ToString() == "High")
                {
                    int hpp = 90;
                    int a = Convert.ToInt32(numericUpDown6.Value);
                    int ap = a * hpp;
                    label31.Text = ap.ToString();
                    tp += ap;
                }
                else
                {
                    int mpp = 60;
                    int a = Convert.ToInt32(numericUpDown6.Value);
                    int apm = a * mpp;
                    label31.Text = apm.ToString();
                    tp += apm;
                }
            }
            if (radioButton1.Checked)
            {
                tp += 20;
            }

            tproducts.Text = tpr.ToString();
            tprice.Text = tp.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = true;
                comboBox1.Enabled = true;       
            }
            else
            {
                numericUpDown1.Enabled = false;
                comboBox1.Enabled = false;
                comboBox1.Text = " ";
                label16.Text = (" ").ToString();
                label22.Text = (" ").ToString();
                label28.Text = (" ").ToString();
            }

           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown2.Enabled = true;
                comboBox2.Enabled = true;
            }
            else
            {
                numericUpDown2.Enabled = false;
                comboBox2.Enabled = false;
                comboBox2.Text = " ";
                label17.Text = (" ").ToString();
                label27.Text = (" ").ToString();
                label29.Text = (" ").ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                numericUpDown3.Enabled = true;
                comboBox3.Enabled = true;
            }
            else
            {
                numericUpDown3.Enabled = false;
                comboBox3.Enabled = false;
                comboBox3.Text = " ";
                label18.Text = (" ").ToString();
                label24.Text = (" ").ToString();
                label34.Text = (" ").ToString();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                numericUpDown4.Enabled = true;
                comboBox4.Enabled = true;
            }
            else
            {
                numericUpDown4.Enabled = false;
                comboBox4.Enabled = false;
                comboBox4.Text = " ";
                label19.Text = (" ").ToString();
                label23.Text = (" ").ToString();
                label33.Text = (" ").ToString();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                numericUpDown5.Enabled = true;
                comboBox5.Enabled = true;
            }
            else
            {
                numericUpDown5.Enabled = false;
                comboBox5.Enabled = false;
                comboBox5.Text = " ";
                label20.Text = (" ").ToString();
                label25.Text = (" ").ToString();
                label32.Text = (" ").ToString();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                numericUpDown6.Enabled = true;
                comboBox6.Enabled = true;
            }
            else
            {
                numericUpDown6.Enabled = false;
                comboBox6.Enabled = false;
                comboBox6.Text = " ";
                label21.Text = (" ").ToString();
                label26.Text = (" ").ToString();
                label31.Text = (" ").ToString();
            }
        }

        
    }
}
