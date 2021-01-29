using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_AIS_Cars.Model;
using My_AIS_Cars.Model.Entities;
using My_AIS_Cars.View.Cars;

namespace My_AIS_Cars.Controller
{
    class ControllerFormSearch
    {
        private FormMainSearch formSearch;
        private DBManager db;

        public ControllerFormSearch(FormMainSearch formSearch)
        {
            this.formSearch = formSearch;
            db = DBManager.GetInstance();
        }

        public void RefreshDataGridSearch()
        {
            formSearch.dataGridViewSearch.DataSource = null;
            formSearch.dataGridViewSearch.DataSource = db.TableCars.Rows;

            formSearch.dataGridViewSearch.Columns["Id"].Visible = false;
            formSearch.dataGridViewSearch.Columns["idModel"].Visible = false;
            formSearch.dataGridViewSearch.Columns["Body"].HeaderText = "Кузов";
            formSearch.dataGridViewSearch.Columns["Year"].HeaderText = "Год выпуска";
            formSearch.dataGridViewSearch.Columns["Balance"].HeaderText = "Количество";
            formSearch.dataGridViewSearch.Columns["Price"].HeaderText = "Цена";
            formSearch.dataGridViewSearch.Columns["Credit"].HeaderText = "Автокредит";
            formSearch.dataGridViewSearch.Columns["Model"].HeaderText = "Модель";

            formSearch.dataGridViewSearch.ClearSelection();
        }

        public void RefreshComboBox()
        {
            formSearch.comboBoxModel.DataSource = null;
            formSearch.comboBoxModel.DataSource = db.TableModels.Rows;
        }

        public void SearchByParam()
        {
            List<Car> searchedCars = new List<Car>();

            if (formSearch.comboBoxModel.Text == "")
            {
                searchedCars = db.TableCars.Rows;
            }
            else
            {
                searchedCars =
                    db.TableCars.Rows.FindAll(item => item.model.ToString() == formSearch.comboBoxModel.Text);
            }

            if (formSearch.maskedTextBoxPrice.Text != "")
            {
                searchedCars = searchedCars.FindAll(item => item.Price <= Convert.ToInt32(formSearch.maskedTextBoxPrice.Text));
            }

            if (formSearch.checkBoxCredit.Checked)
            {
                searchedCars = searchedCars.FindAll(item => item.Credit);
            }
            else
            {
                searchedCars = searchedCars.FindAll(item => !item.Credit);
            }

            formSearch.dataGridViewSearch.DataSource = null;
            formSearch.dataGridViewSearch.DataSource = searchedCars;

            formSearch.dataGridViewSearch.Columns["Id"].Visible = false;
            formSearch.dataGridViewSearch.Columns["idModel"].Visible = false;
            formSearch.dataGridViewSearch.Columns["Body"].HeaderText = "Кузов";
            formSearch.dataGridViewSearch.Columns["Year"].HeaderText = "Год выпуска";
            formSearch.dataGridViewSearch.Columns["Balance"].HeaderText = "Количество";
            formSearch.dataGridViewSearch.Columns["Price"].HeaderText = "Цена";
            formSearch.dataGridViewSearch.Columns["Credit"].HeaderText = "Автокредит";
            formSearch.dataGridViewSearch.Columns["Model"].HeaderText = "Модель";

        }

    }
}
