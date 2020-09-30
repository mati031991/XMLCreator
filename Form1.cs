using System;
using System.Collections.Generic;
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
                DisplayinDataGride(dataGridView1, car);
            }
        }

        public void DisplayinDataGride(DataGridView sender, List<Car> items)
        {
            foreach (var item in items)
            {
                sender.Rows.Add(item.registrationNumber, item.brand, item.manufacturerYear, item.color, item.passangerCount);
            }
        }
        public void DisplayinDataGride(DataGridView sender, Car item)
        {
            sender.Rows.Add(item.registrationNumber, item.brand, item.manufacturerYear, item.color, item.passangerCount);
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
            fill.Close();
        }

        private void ReadFromFillButton_Click(object sender, EventArgs e)
        {
            FillCreator fill = new FillCreator();
            fill.Read();
            fill.Close();
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            XmlCreator xmlCreator = new XmlCreator();
            xmlCreator.Serialize(_cars);
            xmlCreator.Close();
        }

        private void DeserializeButton_Click(object sender, EventArgs e)
        {
            XmlCreator xmlCreator = new XmlCreator();
            Cars deserializedCars = xmlCreator.Deserialize();
            xmlCreator.Close();
            _cars.AddRange(deserializedCars.CarList);
            DisplayinDataGride(dataGridView1, _cars);
        }
    }
}
