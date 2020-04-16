using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtEkran.Clear();
            txtNazwa.Clear();
            txtPredkosc.Clear();
            txtProcesor.Clear();
            txtRodzajRAM.Clear();
            txtSizeRAM.Clear();
            rtxtDane.Clear();
            chbXP.Checked = false;
            chbVista.Checked = false;
            chbLinux.Checked = false;
            lblSystem3.Text = " ";
            label1.Text = " ";
            label3.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void chbLinux_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLinux.Checked == true)
            {
                lblSystem3.Text = "Linux";
                chbXP.Checked = false;
                chbXP.Enabled = false;
                chbVista.Checked = false;
                chbVista.Enabled = false;
            }
            else
            {
                chbXP.Checked = false;
                chbXP.Enabled = true;
                chbVista.Checked = false;
                chbVista.Enabled = true;
            }


        }

        private void chbVista_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVista.Checked == true)
            {
                lblSystem3.Text = "Windows Vista";
                chbXP.Checked = false;
                chbXP.Enabled = false;
                chbLinux.Checked = false;
                chbLinux.Enabled = false;
            }
            else
            {
                chbXP.Checked = false;
                chbXP.Enabled = true;
                chbLinux.Checked = false;
                chbLinux.Enabled = true;
            }

        }

        private void chbXP_CheckedChanged(object sender, EventArgs e)
        {
            if (chbXP.Checked == true)
            {
                lblSystem3.Text = "Windows XP";
                chbVista.Checked = false;
                chbVista.Enabled = false;
                chbLinux.Checked = false;
                chbLinux.Enabled = false;
            }
            else
            {
                chbVista.Checked = false;
                chbVista.Enabled = true;
                chbLinux.Checked = false;
                chbLinux.Enabled = true;
            }

        }

        private void txtEkran_TextChanged(object sender, EventArgs e)
        {
            label5.Text = txtEkran.Text + " cali";  
        }

        private void txtRodzajRAM_TextChanged(object sender, EventArgs e)
        {
            label3.Text = txtSizeRAM.Text + " GB " + txtRodzajRAM.Text;
        }

        private void txtSizeRAM_TextChanged(object sender, EventArgs e)
        {
            label3.Text = txtSizeRAM.Text + " GB " + txtRodzajRAM.Text;
        }

        private void txtPredkosc_TextChanged(object sender, EventArgs e)
        {
            label7.Text = txtProcesor.Text + " " + txtPredkosc.Text + " Ghz";
        }

        private void txtProcesor_TextChanged(object sender, EventArgs e)
        {
            label7.Text = txtProcesor.Text + " " + txtPredkosc.Text + " Ghz";           
        }

        private void txtNazwa_TextChanged(object sender, EventArgs e)
        {
            label1.Text = txtNazwa.Text;
        }

        private void gupKomputer_Enter(object sender, EventArgs e)
        {

        }

        private void btnDane_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dane klijenta :"
                + rtxtDane.Text + Environment.NewLine + " Sposub platnosci to " + cmbBank.Text 
                + Environment.NewLine
                +" termin platnosci :"+lblday.Text+"."+lblMonth.Text+"."+lblYear.Text,"Dane Sprzedarzy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            
            
            
            
           
        }

        private void vscrDay_Scroll(object sender, ScrollEventArgs e)
        {
            int liczba = vscrDay.Value;
            lblday.Text = Convert.ToString(liczba);
        }

        private void vscrMonth_Scroll(object sender, ScrollEventArgs e)
        {
            int liczba = vscrMonth.Value;
            lblMonth.Text = Convert.ToString(liczba);
                
        }

        private void vscrYear_Scroll(object sender, ScrollEventArgs e)
        {
            int liczba = vscrYear.Value;
            lblYear.Text = Convert.ToString(liczba);
            
        }

        private void lblday_Click(object sender, EventArgs e)
        {
            int liczba = vscrDay.Value;
            lblday.Text = Convert.ToString(liczba);
        }

        private void lblMonth_Click(object sender, EventArgs e)
        {
            int liczba = vscrMonth.Value;
            lblMonth.Text = Convert.ToString(liczba);
        }

        private void lblYear_Click(object sender, EventArgs e)
        {
            int liczba = vscrYear.Value;
            lblYear.Text = Convert.ToString(liczba);

        }

        private void vscrMonth_Scroll_1(object sender, ScrollEventArgs e)
        {
            int liczba = vscrMonth.Value;
            lblMonth.Text = Convert.ToString(liczba);
        }

        
    }
}
