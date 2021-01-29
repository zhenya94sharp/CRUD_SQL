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
    public partial class FormMainSearch : Form
    {
        private ControllerFormSearch controllerFormSearch;

        public FormMainSearch()
        {
            InitializeComponent();
        }

        private void FormMainSearch_Load(object sender, EventArgs e)
        {
            controllerFormSearch=new ControllerFormSearch(this);
            controllerFormSearch.RefreshComboBox();
            controllerFormSearch.RefreshDataGridSearch();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controllerFormSearch.SearchByParam();
        }
    }
}
