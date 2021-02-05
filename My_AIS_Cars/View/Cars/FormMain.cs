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
using My_AIS_Cars.View.Cars;

namespace My_AIS_Cars.View
{
    public partial class FormMain : Form
    {
        private ControllerFormMain controller;

        public FormMain()
        {
            InitializeComponent();
            controller = new ControllerFormMain(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            controller.RefreshDataGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            controller.OpenFormAdd();
            controller.RefreshDataGrid();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            controller.RefreshDataGrid();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
          controller.UpdateCar();
          controller.RefreshDataGrid();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            controller.DeleteCar();
            controller.ClearFields();
            controller.RefreshDataGrid();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            controller.ClearAll();
            controller.RefreshDataGrid();
        }

        private void dataGridViewCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.FillFieldsBySelectedCar();
        }

        private void dataGridViewCars_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            controller.SortColumnByIndex(e.ColumnIndex);
            controller.ClearFields();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controller.OpenFormSearch();
            controller.RefreshDataGrid();

        }

        private void comboBoxModelsCars_Click(object sender, EventArgs e)
        {
            controller.RefreshComboBox();
        }
    }
}
