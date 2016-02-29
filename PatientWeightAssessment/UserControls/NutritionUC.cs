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
    public partial class NutritionUC : UserControl
    {
        public NutritionUC()
        {
            InitializeComponent();
        }

        private void NutritionUC_Load(object sender, EventArgs e)
        {
            cmbNutritionCoffeeTea.SelectedIndex = 0;
            cmbNutritionEatOut.SelectedIndex = 0;
            cmbNutritionFruitsDoYouEat.SelectedIndex = 0;
            cmbNutritionGrainsDoYouEat.SelectedIndex = 0;
            cmbNutritionMeatDoYouEat.SelectedIndex = 0;
            cmbNutritionSnack.SelectedIndex = 0;
            cmbNutritionSugar.SelectedIndex = 0;
            cmbNutritionVegetablesDoYouEat.SelectedIndex = 0;
        }
    }
}
