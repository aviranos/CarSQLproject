using System.Windows.Forms;

namespace NewCarProjectV1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form3 FormsearchCar = new Form3();
        Form4 FormADDNEWCAR = new Form4();

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {
            FormADDNEWCAR.ShowDialog();
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {
            
            FormsearchCar.ShowDialog();
            
        }
    }
}
