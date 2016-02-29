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
            cbDrinkAlcohol.SelectedValue = "Never";

            cbEatFastFood.SelectedIndex = 0;
            cbEatFastFood.SelectedValue = "Never";

            cbExercise.SelectedIndex = 0;
            cbExercise.SelectedValue = "Never";

            cbFeelDepressed.SelectedIndex = 0;
            cbFeelDepressed.SelectedValue = "Never";

            cbOverAllHealthRate.SelectedIndex = 0;
            cbOverAllHealthRate.SelectedValue = "Great";

            cbRestfulSleep.SelectedIndex = 0;
            cbRestfulSleep.SelectedValue = "Restful";

            cbSmoke.SelectedIndex = 0;
            cbSmoke.SelectedValue = "Never";
        }
    }
}
