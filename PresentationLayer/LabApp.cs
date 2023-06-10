using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LabApp : Form
    {
        public LabApp()
        {
            InitializeComponent();
        }

        private void petriDishBtn_Click(object sender, EventArgs e)
        {
            PetriDishForm petriDishForm = new();
            petriDishForm.ShowDialog();
        }
        private void cupboardBtn_Click(object sender, EventArgs e)
        {
            CupboardForm cupboardForm = new CupboardForm();
            cupboardForm.ShowDialog();
        }
    }
}
