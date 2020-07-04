using NewCarProjectV1.DBCARSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCarProjectV1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        CarsTTableAdapter CarsTabeladd = new CarsTTableAdapter();
      
        

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCARSDataSet.ColorT' table. You can move, or remove it, as needed.
            this.colorTTableAdapter.Fill(this.dBCARSDataSet.ColorT);
            // TODO: This line of code loads data into the 'dBCARSDataSet.ModelT' table. You can move, or remove it, as needed.
            this.modelTTableAdapter.Fill(this.dBCARSDataSet.ModelT);
            // TODO: This line of code loads data into the 'dBCARSDataSet.CompanyT' table. You can move, or remove it, as needed.
            this.companyTTableAdapter.Fill(this.dBCARSDataSet.CompanyT);
            // TODO: This line of code loads data into the 'dBCARSDataSet.ייצרנים' table. You can move, or remove it, as needed.
            this.ייצרניםTableAdapter.Fill(this.dBCARSDataSet.ייצרנים);



         

            // TODO: This line of code loads data into the 'dBCARSDataSet.CarsT' table. You can move, or remove it, as needed.
            this.carsTTableAdapter.Fill(this.dBCARSDataSet.CarsT);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable myTable = dBCARSDataSet.Tables["CarsT"];
            DataRow currentRow = null;
            //dBCARSDataSet.CarsT.AddCarsTRow()
            carsTTableAdapter.Update(dBCARSDataSet);
            carsTBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dBCARSDataSet);
            MessageBox.Show("add seccsess");


        }

        private void combCOMPANY_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = combCOMPANY.Text;
            // TODO get all 'DEGEM' from Models where company = value  - DATABASE
            //'SELECT * FROM Model WHERE Company = '+value       <- Query
             
            // TODO insert all query from DB to combModel


        }
    }
}
