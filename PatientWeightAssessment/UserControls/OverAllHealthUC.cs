using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientWeightAssessment.UserControls
{
    public partial class OverAllHealthUC : UserControl
    {
        public OverAllHealthUC()
        {
            InitializeComponent();
        }

        private void OverAllHealthUC_Load(object sender, EventArgs e)
        {
            cbDrinkAlcohol.SelectedIndex = 0;
            cbEatFastFood.SelectedIndex = 0;
            cbExercise.SelectedIndex = 0;
            cbFeelDepressed.SelectedIndex = 0;
            cbOverAllHealthRate.SelectedIndex = 0;
            cbRestfulSleep.SelectedIndex = 0;
            cbSmoke.SelectedIndex = 0;
        }
    }
}
