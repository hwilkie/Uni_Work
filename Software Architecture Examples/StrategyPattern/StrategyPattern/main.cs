using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StrategyLibrary;
using StrategyLibrary.Duck_Types;
using StrategyLibrary.FlyBehaviours;

namespace StrategyPattern
{
    public partial class main : Form
    {
        private Duck _myDuck;

        public main()
        {
            InitializeComponent();
        }

        private void InitializeDuck()
        {
            if (RadDecoy.Checked) _myDuck = new DecoyDuck();
            if (RadRedHead.Checked) _myDuck = new RedHeadDuck();
            if (radRubber.Checked) _myDuck = new RubberDuck();
            if (radMallard.Checked) _myDuck = new MallardDuck();

            DynamicallyChangeFlyBehaviour(_myDuck);

        }

        private void DynamicallyChangeFlyBehaviour(Duck duck)
        {
            if (radRocketPowered.Checked) duck.FlyBehaviour = new FlyRocketPowered();
            if (radNoWay.Checked) duck.FlyBehaviour = new FlyNoWay();
            if (radWithWings.Checked) duck.FlyBehaviour = new FlyWithWings();
        }

        private void btnDisplayDuck_Click(object sender, EventArgs e)
        {
            InitializeDuck();
            lbloutput.Text = _myDuck.Display();
        }

        private void btnFlyDuck_Click(object sender, EventArgs e)
        {
            InitializeDuck();
            lbloutput.Text = _myDuck.PerformFly();
        }

        private void btnQuackDuck_Click(object sender, EventArgs e)
        {
            InitializeDuck();
            lbloutput.Text = _myDuck.PerformQuack();
        }
    }
}
