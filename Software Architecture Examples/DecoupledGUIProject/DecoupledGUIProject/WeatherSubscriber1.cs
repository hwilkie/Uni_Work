using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DecoupledGUIProject;

namespace DecoupledDLL
{
    public partial class WeatherSubscriber1 : Form, IObserver
    {
        private CurrentConditions _currentConditions;

        public WeatherSubscriber1(ISubject s)
        {
            InitializeComponent();

            _currentConditions = new CurrentConditions(s);
            _currentConditions.RegisterObserver(this);

        }

        public void Update(float temp, float humidity, int pressure)
        {
            lblDisplayTemp.Text = temp.ToString();
            lblDisplayHumidity.Text = humidity.ToString();
            lblDisplayPressure.Text = pressure.ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _currentConditions.Register();
        }

        private void btnDeRegister_Click(object sender, EventArgs e)
        {
            _currentConditions.Remove();
        }
    }
}
