using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
        private void label2_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            
        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void label9_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e) {

        }
        private void label7_Click(object sender, EventArgs e) {

        }

        private void submit_Click(object sender, EventArgs e) {

            double baseconc = Convert.ToDouble(NaOHmol.Text);
            double acidamount = Convert.ToDouble(KnowAcidAmount.Text);
            double acidresult = Convert.ToDouble(KnowAcidResult.Text);
            double acidamount2 = Convert.ToDouble(UnkownAcidAmount.Text);
            double acidresult2 = Convert.ToDouble(UnknowAcidResult.Text);

            double concnaoh = baseconc * acidresult /  acidamount; //HCl
            double concunknown =  concnaoh *  acidamount2 / acidresult2;
            MessageBox.Show("NaOH conc is " + concnaoh + " mol\nConc of Unknown is " + concunknown + " mol");
            
        }

        private void KnowAcid_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void UnknowAcid_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
