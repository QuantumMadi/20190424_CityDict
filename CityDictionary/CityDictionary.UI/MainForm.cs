using CityDictionary.DataAccess;
using CityDictionary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CityDictionary.UI
{
    public partial class MainForm : Form
    {
        private List<City> cities;
        private ContextServices contextServices;
        private int maximumFigureInNumber = 6;
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            txtBoxNumber.MaxLength = maximumFigureInNumber;        
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            contextServices = new ContextServices();
            cities = contextServices.GetCities();
            List<string> citiesNames = new List<string>();
            foreach (var city in cities)
            {
                citiesNames.Add(city.Name);
            }
            comboBoxCity.Items.AddRange(citiesNames.ToArray<object>());
        }

        private void SubmitNumber(object sender, EventArgs e)
        {
            if (long.TryParse(txtBoxNumber.Text, out long result))
            {
                if (txtBoxNumber.Text.Length == maximumFigureInNumber)
                {
                    contextServices.AddNewNumber(cities[comboBoxCity.SelectedIndex], txtBoxNumber.Text);
                    MessageBox.Show("Number Saved");
                    txtBoxNumber.Clear();
                }
                else { MessageBox.Show("Invalid data"); txtBoxNumber.Clear(); }
            }
            else MessageBox.Show("InvalidData");
            txtBoxNumber.Clear();
        }
    }
}
