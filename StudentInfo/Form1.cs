using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            string Name,Section,Address;
            Name = tName.Text;
            Section = tSect.Text;
            Address = tAdd.Text;

            string fav = cFav.Text.ToString();

            string gender = "gender";

            if (rMale.Checked) {
                gender = rMale.Text.ToString();
            }
            if (rFemale.Checked)
            {
                gender = rFemale.Text.ToString();
            }

            

            MessageBox.Show(Name + "\n" + Section + "\n" + Address + "\n" +gender + "\n" +fav,
                "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
