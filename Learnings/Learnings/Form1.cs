using System.Windows.Forms.Design;

namespace Learnings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Displayinfo(object sender, EventArgs e)
        {
            String info = "Firstname: " + fname.Text +
                "\nMiddlename: " + mname.Text + 
                "\nLastname: " + lname.Text +
                "\nBirthdate: " + Date.Text + 
                "\nCivil Status: " + cvstat.Text;

            if (male.Checked) {
                info = info + "\nGender: Male";
            }
            else {
                info = info + "\nGender: Female";
            }

            info = info + "\n\nSports";

            if (basket.Checked) {
                info = info + "\nBasketball";
            }
            if (badminton.Checked) {
                info = info + "\nBadminton";
            }
            if (volley.Checked) {
                info = info + "\nVolleyball";
            }

            MessageBox.Show(info,"Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
