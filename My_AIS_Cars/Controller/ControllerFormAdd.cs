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
    class ControllerFormAdd
    {
        private FormAdd formAdd;
        private DBManager db;

        public ControllerFormAdd(FormAdd formAdd)
        {
            this.formAdd = formAdd;
            db=DBManager.GetInstance();
        }

        public void AddCar()
        {
            if (formAdd.comboBoxModelsCars.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля ");
                return;
            }

            if (formAdd.textBoxBody.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля ");
                return;
            }

            if (formAdd.maskedTextBoxBalance.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля ");
                return;
            }

            if (formAdd.maskedTextBoxPrice.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля ");
                return;
            }

            try
            {
                Car car = new Car()
                {
                    model = formAdd.comboBoxModelsCars.SelectedItem as ModelCar,
                    idModel = (formAdd.comboBoxModelsCars.SelectedItem as ModelCar).Id,
                    Body = formAdd.textBoxBody.Text,
                    Year = formAdd.dateTimePickerDt.Value,
                    Balance = Convert.ToInt32(formAdd.maskedTextBoxBalance.Text),
                    Price = Convert.ToInt32(formAdd.maskedTextBoxPrice.Text),
                    Credit = formAdd.checkBoxCredit.Checked
                };

                db.TableCars.AddNewCar(car);
            }
            catch
            {
                MessageBox.Show("Ошибка соединения, повторите запрос позднее");
            }
            formAdd.Close();
        }

        public void Cancel()
        {
            formAdd.Close();
        }

        public void RefreshComboBox()
        {
            formAdd.comboBoxModelsCars.DataSource = null;
            formAdd.comboBoxModelsCars.DataSource = db.TableModels.Rows;
        }
    }
}
