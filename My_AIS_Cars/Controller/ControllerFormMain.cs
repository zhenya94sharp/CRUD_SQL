using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_AIS_Cars.Model;
using My_AIS_Cars.View;
using My_AIS_Cars.Controller;
using My_AIS_Cars.Model.Entities;
using My_AIS_Cars.View.Cars;

namespace My_AIS_Cars.Controller
{
    class ControllerFormMain
    {
        private FormMain form;
        private DBManager db;
        private bool crashConnection;

        private void ReopenConnection()
        {
            if (crashConnection)
            {
                db.Reopen();
                crashConnection = false;
            }
        }

        public ControllerFormMain(FormMain form)
        {
            this.form = form;

            ReopenConnection();

            db = DBManager.GetInstance();
        }

        public void RefreshDataGrid()
        {
            try
            {
                ReopenConnection();

                form.dataGridViewCars.DataSource = null;

                form.dataGridViewCars.DataSource = db.TableCars.Rows;

                form.dataGridViewCars.Columns["Id"].Visible = false;
                form.dataGridViewCars.Columns["idModel"].Visible = false;
                form.dataGridViewCars.Columns["Model"].HeaderText = "Модель";
                form.dataGridViewCars.Columns["Body"].HeaderText = "Кузов";
                form.dataGridViewCars.Columns["Year"].HeaderText = "Год выпуска";
                form.dataGridViewCars.Columns["Balance"].HeaderText = "Количество";
                form.dataGridViewCars.Columns["Price"].HeaderText = "Цена";
                form.dataGridViewCars.Columns["Credit"].HeaderText = "Автокредит";


                form.dataGridViewCars.ClearSelection();
            }
            catch
            {
                MessageBox.Show("Ошибка соединения, повторите запрос позднее");
            }
        }

        public void DeleteCar()
        {
            if (form.textBoxId.Text == "")
            {
                MessageBox.Show("Ошибка. Выберите строку для удаления!");
                return;
            }

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить автомобиль?", "Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ReopenConnection();

                    Car selectedCar = (Car)form.dataGridViewCars.SelectedRows[0].DataBoundItem;

                    db.TableCars.DeleteCarByID(selectedCar.Id);
                }
                catch
                {
                    MessageBox.Show("Ошибка соединения, повторите запрос позднее");
                }
            }
        }

        public void ClearFields()
        {
            form.textBoxBody.Clear();

            form.maskedTextBoxBalance.Clear();
            form.maskedTextBoxPrice.Clear();
            form.dateTimePickerDt.Value = DateTime.Now;
            form.checkBoxCredit.Checked = false;
        }

        public void FillFieldsBySelectedCar()
        {
            if (form.dataGridViewCars.SelectedRows.Count == 0)
            {
                return;
            }

            Car selectedCar = form.dataGridViewCars.SelectedRows[0].DataBoundItem as Car;

            form.comboBoxModelsCars.Text = selectedCar.model.Model;
            form.textBoxId.Text = selectedCar.Id.ToString();
            form.textBoxBody.Text = selectedCar.Body;
            form.dateTimePickerDt.Value = selectedCar.Year;
            form.maskedTextBoxBalance.Text = selectedCar.Balance.ToString();
            form.maskedTextBoxPrice.Text = selectedCar.Price.ToString();
            form.checkBoxCredit.Checked = selectedCar.Credit;
        }

        public void ClearAll()
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить всё?", "Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ReopenConnection();
                    db.TableCars.ClearAllCar();
                }
                catch
                {
                    MessageBox.Show("Ошибка соединения, повторите запрос позднее");
                }
            }
        }

        public void UpdateCar()
        {
            if (form.textBoxId.Text == "")
            {
                MessageBox.Show("Ошибка. Выберите строку для обновления!");
                return;
            }

            if (form.comboBoxModelsCars.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля");
                return;
            }

            if (form.textBoxBody.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля");
                return;
            }

            if (form.maskedTextBoxPrice.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля");
                return;
            }

            if (form.maskedTextBoxBalance.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля");
                return;
            }

            try
            {
                ReopenConnection();



                Car сar = new Car()
                {
                    Id = Convert.ToInt32(form.textBoxId.Text),
                    idModel = (form.comboBoxModelsCars.SelectedItem as ModelCar).Id,
                    Body = form.textBoxBody.Text,
                    Year = form.dateTimePickerDt.Value,
                    Balance = Convert.ToInt32(form.maskedTextBoxBalance.Text),
                    Price = Convert.ToInt32(form.maskedTextBoxPrice.Text),
                    Credit = form.checkBoxCredit.Checked,
                    model = form.comboBoxModelsCars.SelectedItem as ModelCar
                };
                db.TableCars.UpdateCar(сar);
            }
            catch
            {
                MessageBox.Show("Ошибка соединения, повторите запрос позднее");
            }
        }

        public void SortColumnByIndex(int indexColumn)
        {
            List<Car> cars = (List<Car>)form.dataGridViewCars.DataSource;

            List<Car> sortedCars = new List<Car>();

            switch (indexColumn)
            {
                case 1:
                    sortedCars = cars.OrderByDescending(item => item.idModel).ToList();
                    break;

                case 2:
                    sortedCars = cars.OrderByDescending(item => item.Body).ToList();
                    break;

                case 3:
                    sortedCars = cars.OrderByDescending(item => item.Year).ToList();
                    break;

                case 4:
                    sortedCars = cars.OrderByDescending(item => item.Balance).ToList();
                    break;

                case 5:
                    sortedCars = cars.OrderByDescending(item => item.Price).ToList();
                    break;

                case 6:
                    sortedCars = cars.OrderByDescending(item => item.Credit).ToList();
                    break;
            }
            form.dataGridViewCars.DataSource = sortedCars;
        }

        public void OpenFormSearch()
        {
            new FormMainSearch().ShowDialog();
        }

        public void OpenFormAdd()
        {
            new FormAdd().ShowDialog();
        }

        public void OpenFormUpdate()
        {
            new FormUpdateCar().ShowDialog();
        }
    }
}
