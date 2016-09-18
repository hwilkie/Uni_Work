using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DecoupledGUIProject;

namespace DecoupledDLL
{
    public partial class WeatherPublisher : Form
    {
        private WeatherData weatherData = new WeatherData();
        private float temp;
        private float humidity;
        private int pressure;


        public WeatherPublisher()
        {
            InitializeComponent();
        }
    }
}
