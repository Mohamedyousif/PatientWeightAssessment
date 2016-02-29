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
            cmbNutritionCoffeeTea.SelectedValue = "Never";
            cmbNutritionCoffeeTea.SelectedIndex = 0;

            cmbNutritionEatOut.SelectedValue = "Never";
            cmbNutritionEatOut.SelectedIndex = 0;

            cmbNutritionFruitsDoYouEat.SelectedValue = "None";
            cmbNutritionFruitsDoYouEat.SelectedIndex = 0;

            cmbNutritionGrainsDoYouEat.SelectedValue = "None";
            cmbNutritionGrainsDoYouEat.SelectedIndex = 0;

            cmbNutritionMeatDoYouEat.SelectedValue = "None";
            cmbNutritionMeatDoYouEat.SelectedIndex = 0;

            cmbNutritionSnack.SelectedValue = "Never";
            cmbNutritionSnack.SelectedIndex = 0;

            cmbNutritionSugar.SelectedValue = "None";
            cmbNutritionSugar.SelectedIndex = 0;

            cmbNutritionVegetablesDoYouEat.SelectedValue = "None";
            cmbNutritionVegetablesDoYouEat.SelectedIndex = 0;
        }
    }
}
