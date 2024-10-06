using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int studentId;

            if (int.TryParse(textBox1.Text, out studentId))
            {
                string lname = textBox2.Text;
                string fname = textBox3.Text;


                // Simple validation for empty input
                if (!string.IsNullOrWhiteSpace(fname) && !string.IsNullOrWhiteSpace(lname))
                {
                    // Add the student information to the ListBox
                    listBox1.Items.Add($"{studentId}");
                    listBox2.Items.Add($"{fname}");
                    listBox3.Items.Add($"{lname}");

                    // Clear the textboxes after adding
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter both Last Name, First Name and Student ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
