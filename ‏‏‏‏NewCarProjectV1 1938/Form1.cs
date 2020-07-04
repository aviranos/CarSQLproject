using System;
using System.Windows.Forms;

namespace NewCarProjectV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form mainform = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCARSDataSet.UsersT' table. You can move, or remove it, as needed.
            this.usersTTableAdapter.Fill(this.dBCARSDataSet.UsersT);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform.ShowDialog();


        }
    }
}
