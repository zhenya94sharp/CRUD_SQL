using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_AIS_Cars.Controller;

namespace My_AIS_Cars.View.Cars
{
    public partial class FormAdd : Form
    {
        private ControllerFormAdd controllerFormAdd;

        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            controllerFormAdd=new ControllerFormAdd(this);
            controllerFormAdd.RefreshComboBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            controllerFormAdd.AddCar();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            controllerFormAdd.Cancel();
        }
    }
}
