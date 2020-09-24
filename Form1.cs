using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLSerializer
{
    public partial class Form1 : Form
    {
        private List<Car> _cars;
        public Form1()
        {
            InitializeComponent();
            _cars = new List<Car>();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidFields())
            {
                Car car = new Car(RejestrationNumberBox.Text, BrandBox.Text, Int32.Parse(YearBox.Text), ColorBox.Text, Int32.Parse(PasangerCountBox.Text));
                _cars.Add(car);
                dataGridView1.Rows.Add(RejestrationNumberBox.Text, BrandBox.Text, YearBox.Text, ColorBox.Text, PasangerCountBox.Text);
            }
        }

        private bool ValidFields()
        {
            bool validator = true;
            int result = -1;
            if (String.IsNullOrEmpty(RejestrationNumberBox.Text))
            {
                validator = false;
                MessageBox.Show("Uzupełnij " + label1.Text.ToString());
                return false;
            }
            if (String.IsNullOrEmpty(BrandBox.Text))
            {
                validator = false;
                MessageBox.Show("Uzupełnij " + label2.Text.ToString());
                return false;
            }
            if (String.IsNullOrEmpty(YearBox.Text))
            {
                validator = false;
                MessageBox.Show("Uzupełnij " + label3.Text.ToString());
                return false;
            }

            if (!Int32.TryParse(YearBox.Text, out result))
            {
                validator = false;
                MessageBox.Show("W polu  " + label3.Text.ToString() + " nie ma liczby");
                return false;
            }
            if (String.IsNullOrEmpty(ColorBox.Text))
            {
                validator = false;
                MessageBox.Show("Uzupełnij " + label4.Text.ToString());
                return false;
            }
            if (String.IsNullOrEmpty(PasangerCountBox.Text))
            {
                validator = false;
                MessageBox.Show("Uzupełnij " + label5.Text.ToString());
                return false;
            }
            if (!Int32.TryParse(PasangerCountBox.Text, out result))
            {
                validator = false;
                MessageBox.Show("W polu  " + label5.Text.ToString() + " nie ma liczby");
                return false;
            }
            return validator;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _cars.Clear();
            dataGridView1.Rows.Clear();
        }

        private void SaveToFillButton_Click(object sender, EventArgs e)
        {
            FillCreator fill = new FillCreator();
            fill.Write(_cars);
        }
    }
}
