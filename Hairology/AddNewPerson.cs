using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hairology
{
    public partial class AddNewPerson : UserControl
    {
        private string _type;
        public AddNewPerson()
        {
            InitializeComponent();
            ConfigureForm();
        }
        private void ConfigureForm()
        {
            if (_type == "Customer")
            {
                lblAddNewPerson.Text = "Add New " + _type;
            }
            else if (_type == "Employee")
            {
                lblAddNewPerson.Text = "Add New " + _type;
            }
        }
        public void SetPersonType(string person)
        {
            _type = person;
            ConfigureForm();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_type + " [NAME] was inserted into the database successfully", _type + " Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
