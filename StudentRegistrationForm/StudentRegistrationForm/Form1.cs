using System.Text;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= DateTime.Now.Year; i++) Year.Items.Add(i);
        }

        private void studentRegistrationForm_Click(object sender, EventArgs e)
        {

        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void lastNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_Click(object sender, EventArgs e)
        {

        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleName_Click(object sender, EventArgs e)
        {

        }

        private void middleNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void preferNotToSay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void programToApply_Click(object sender, EventArgs e)
        {

        }

        private void Program_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registerStudent_Click(object sender, EventArgs e)
        {
            string lname = lastNameText.Text;
            string fname = firstNameText.Text;
            string mname = middleNameText.Text;
            string gender = Male.Checked ? "Male" : Female.Checked ? "Female" : preferNotToSay.Checked ? "Preferred Not to Say" : "";
            string day = Day.SelectedItem?.ToString();
            string month = Month.SelectedItem?.ToString();
            string year = Year.SelectedItem?.ToString();
            string program = Program.SelectedItem?.ToString();

            StringBuilder registeredStudent = new StringBuilder(lname);

            MessageBox.Show("Student name: " + fname + " " + mname + " " + lname + "\nGender: " + gender + "\nDate of Birth: " + day + " " + month + " " + year + "\nProgram: " + program);
        }

        private void Picture_Click(object sender, EventArgs e)
        {

        }
    }
}
