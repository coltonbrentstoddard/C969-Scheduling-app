using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp3
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private U07wZGEntities dbContext = new U07wZGEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            dbContext.customers.Load(); 
                

            customerBindingSource.DataSource = dbContext.customers.Local; 
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            customerBindingSource.EndEdit();
            
            try
            {
                dbContext.SaveChanges(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("All must contain values"); 
            }
        }
    }
}
