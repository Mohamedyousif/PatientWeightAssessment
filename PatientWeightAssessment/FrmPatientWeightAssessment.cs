using System;
using System.Windows.Forms;
using PatientWeightAssessment.DataAccess;
using PatientWeightAssessment.DataAccess.Enums;
using PatientWeightAssessment.UserControls;

namespace PatientWeightAssessment
{
    public partial class FrmPatientWeightAssessment : Form
    {
        Control[] tabControl;
        TabControl.TabPageCollection tabPages;

        public FrmPatientWeightAssessment()
        {
            InitializeComponent();
        }

        private void FrmPatientWeightAssessment_Load(object sender, EventArgs e)
        {
            tabControl = Controls.Find("tbPatientWeightAssessment", true);
            if (tabControl != null)
            {
                tabPages = ((TabControl)tabControl[0]).TabPages;
                tabPages[0].Controls.Add(new GeneralUC());
                tabPages[1].Controls.Add(new MedicalHistoryUC());
                tabPages[2].Controls.Add(new HistoryOfUC());
                tabPages[3].Controls.Add(new OverAllHealthUC());
                tabPages[4].Controls.Add(new NutritionUC());
                tabPages[5].Controls.Add(new ExerciseUC());
                tabPages[6].Controls.Add(new OtherUC());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var patientWeightAssessment = new DataAccess.PatientWeightAssessment();
            var generalInfoUC = (GeneralUC)tabPages[0].Controls[0];

            // General Info
            var generalInfo = patientWeightAssessment.GeneralInfo;
            generalInfo.PatientName = generalInfoUC.txtGeneralName.Text.Trim();
            generalInfo.DOB = generalInfoUC.dtGeneralDOB.Value.ToShortDateString();
            generalInfo.Height = generalInfoUC.txtGeneralHeight.Text.Trim();
            generalInfo.Weight = generalInfoUC.txtGeneralWeight.Text.Trim();
            generalInfo.Race = generalInfoUC.txtGeneralRace.Text.Trim();

            if (generalInfoUC.rbMale.Checked)
                generalInfo.Gender = "Male";
            else if (generalInfoUC.rbFemale.Checked)
                generalInfo.Gender = "Female";
            else
                generalInfo.Gender = "Unknown";

            generalInfo.Phone = generalInfoUC.txtGeneralPhone.Text.Trim();

            // Medical History
            var medicalHistoryInfoUC = (MedicalHistoryUC)tabPages[1].Controls[0];
            var medicalHistoryInfo = patientWeightAssessment.MedicalHistoryInfo;

            medicalHistoryInfo.DateOfLastCheckUp = medicalHistoryInfoUC.dtCheckUp.Value.ToShortDateString();
            medicalHistoryInfo.Allegies = medicalHistoryInfoUC.txtMedicalAllergies.Text.Trim();
            medicalHistoryInfo.BloodPressure = medicalHistoryInfoUC.txtMedicalBloodPressure.Text.Trim();
            medicalHistoryInfo.Cholesterol = medicalHistoryInfoUC.txtMedicalCholestrol.Text.Trim();
            medicalHistoryInfo.Injuries = medicalHistoryInfoUC.txtMedicalInjuries.Text.Trim();
            medicalHistoryInfo.PreviousMedications = medicalHistoryInfoUC.txtMedicalPreviousMedications.Text.Trim();
            medicalHistoryInfo.Surguries = medicalHistoryInfoUC.txtMedicalSurgeries.Text.Trim();

            // History Of
            var historyOfInfoUC = (HistoryOfUC)tabPages[2].Controls[0];

            var historyOfInfo = patientWeightAssessment.HistoryOfInfo;
            historyOfInfo.Cancer = new HowItsRelated
            {
                Me = historyOfInfoUC.chkHistoryOfCancerMe.Checked,
                IsRelation = historyOfInfoUC.chkHistoryOfCancerRelation.Checked,
                Relation = historyOfInfoUC.txtHistoryOfCancer.Text.Trim()
            };
            historyOfInfo.Diabetes = new HowItsRelated
            {
                Me = historyOfInfoUC.chkHistoryOfDiabetes.Checked,
                IsRelation = historyOfInfoUC.chkHistoryOfDiabetesRelation.Checked,
                Relation = historyOfInfoUC.txtHistoryOfDiabetes.Text.Trim()
            };
            historyOfInfo.Stroke = new HowItsRelated
            {
                Me = historyOfInfoUC.chkHistoryOfStroke.Checked,
                IsRelation = historyOfInfoUC.chkHistoryOfStrokeRelation.Checked,
                Relation = historyOfInfoUC.txtHistoryOfStroke.Text.Trim()
            };
            historyOfInfo.HeartDisease = new HowItsRelated
            {
                Me = historyOfInfoUC.chkHistoryOfHeartDisease.Checked,
                IsRelation = historyOfInfoUC.chkHistoryOfHeartDiseaseRelation.Checked,
                Relation = historyOfInfoUC.txtHistoryOfHeartDisease.Text.Trim()
            };
            historyOfInfo.HeartAttack = new HowItsRelated
            {
                Me = historyOfInfoUC.chkHistoryOfHeartAttack.Checked,
                IsRelation = historyOfInfoUC.chkHistoryOfHeartAttackRelation.Checked,
                Relation = historyOfInfoUC.txtHistoryOfHeartAttack.Text.Trim()
            };
            historyOfInfo.Depression = new HowItsRelated
            {
                Me = historyOfInfoUC.chkHistoryOfDepression.Checked,
                IsRelation = historyOfInfoUC.chkHistoryOfDepressionRelation.Checked,
                Relation = historyOfInfoUC.txtHistoryOfDepression.Text.Trim()
            };
            historyOfInfo.BipolarDisorder = new HowItsRelated
            {
                Me = historyOfInfoUC.chkHistoryOfBipolarDisorder.Checked,
                IsRelation = historyOfInfoUC.chkHistoryOfBipolarDisorderRelation.Checked,
                Relation = historyOfInfoUC.txtHistoryOfBipolarDisorder.Text.Trim()
            };
            historyOfInfo.Headaches = new HowItsRelated
            {
                Me = historyOfInfoUC.chkHistoryOfHeadaches.Checked,
                IsRelation = historyOfInfoUC.chkHistoryOfHeadachesRelation.Checked,
                Relation = historyOfInfoUC.txtHistoryOfHeadaches.Text.Trim()
            };
            historyOfInfo.Constipation = new HowItsRelated
            {
                Me = historyOfInfoUC.chkHistoryOfConstipation.Checked,
                IsRelation = historyOfInfoUC.chkHistoryOfConstipationRelation.Checked,
                Relation = historyOfInfoUC.txtHistoryOfConstipation.Text.Trim()
            };
            historyOfInfo.SleepDisorders = new HowItsRelated
            {
                Me = historyOfInfoUC.chkHistoryOfSleepDisorders.Checked,
                IsRelation = historyOfInfoUC.chkHistoryOfSleepDisordersRelation.Checked,
                Relation = historyOfInfoUC.txtHistoryOfSleepDisorders.Text.Trim()
            };
            historyOfInfo.Obesity = new HowItsRelated
            {
                Me = historyOfInfoUC.chkHistoryOfObesity.Checked,
                IsRelation = historyOfInfoUC.chkHistoryOfObesityRelation.Checked,
                Relation = historyOfInfoUC.txtHistoryOfObesity.Text.Trim()
            };

            // Over all Health
            var overAllHealthInfoUC = (OverAllHealthUC)tabPages[3].Controls[0];
            var overAllHealthInfo = patientWeightAssessment.OverAllHealthInfo;

            overAllHealthInfo.OverAllHealthRating = (HealthRatingEnum)Enum.Parse(typeof(HealthRatingEnum), overAllHealthInfoUC.cbOverAllHealthRate.SelectedValue.ToString());
            overAllHealthInfo.HowOftenDepressed = (DepressionEnum)Enum.Parse(typeof(DepressionEnum), overAllHealthInfoUC.cbFeelDepressed.SelectedValue.ToString());
            overAllHealthInfo.HowOftenExcercise = (ExerciseEnum)Enum.Parse(typeof(ExerciseEnum), overAllHealthInfoUC.cbExercise.SelectedValue.ToString());
            overAllHealthInfo.HowOftenSmoke = (GeneralEnum)Enum.Parse(typeof(GeneralEnum), overAllHealthInfoUC.cbSmoke.SelectedValue.ToString());
            overAllHealthInfo.HowOftenDrinkAlcohol = (GeneralEnum)Enum.Parse(typeof(GeneralEnum), overAllHealthInfoUC.cbDrinkAlcohol.SelectedValue.ToString());
            overAllHealthInfo.HowOftenFastFood = (GeneralEnum)Enum.Parse(typeof(GeneralEnum), overAllHealthInfoUC.cbEatFastFood.SelectedValue.ToString());
            overAllHealthInfo.HowOftenRestfulSleep = (SleepEnum)Enum.Parse(typeof(SleepEnum), overAllHealthInfoUC.cbRestfulSleep.SelectedValue.ToString());

            overAllHealthInfo.CigarettesPerDay = overAllHealthInfoUC.txtCigarettesPerDay.Text.Trim();
            overAllHealthInfo.AlcoholsPerWeek = overAllHealthInfoUC.txtAlcoholPerWeek.Text.Trim();
            overAllHealthInfo.HoursOfSleepPerNight = int.Parse(overAllHealthInfoUC.txtHoursOfSleepPerNight.Text.Trim());
            overAllHealthInfo.CurrentMedication = overAllHealthInfoUC.txtCurrentMedication.Text.Trim();
            overAllHealthInfo.StartingDate = overAllHealthInfoUC.dtStartingDate.Value.ToString();
            overAllHealthInfo.DietaryRestrictions = overAllHealthInfoUC.txtDietaryRestrictions.Text.Trim();
            overAllHealthInfo.HowOftenHeadaches = overAllHealthInfoUC.txtHowOftenHeadaches.Text.Trim();

            // Nutrition Info
            var nutritionInfoUC = (NutritionUC)tabPages[4].Controls[0];
            var nutritionInfo = patientWeightAssessment.NutritionInfo;

            nutritionInfo.Vegetables = (NutritionEnum)Enum.Parse(typeof(NutritionEnum), nutritionInfoUC.cmbNutritionVegetablesDoYouEat.SelectedValue.ToString());
            nutritionInfo.Fruits = (NutritionEnum)Enum.Parse(typeof(NutritionEnum), nutritionInfoUC.cmbNutritionFruitsDoYouEat.SelectedValue.ToString());
            nutritionInfo.Grains = (NutritionEnum)Enum.Parse(typeof(NutritionEnum), nutritionInfoUC.cmbNutritionGrainsDoYouEat.SelectedValue.ToString());
            nutritionInfo.Meat = (NutritionEnum)Enum.Parse(typeof(NutritionEnum), nutritionInfoUC.cmbNutritionMeatDoYouEat.SelectedValue.ToString());
            nutritionInfo.SugarOrCarbs = (NutritionEnum)Enum.Parse(typeof(NutritionEnum), nutritionInfoUC.cmbNutritionSugar.SelectedValue.ToString());
            nutritionInfo.Snack = (SnackEnum)Enum.Parse(typeof(SnackEnum), nutritionInfoUC.cmbNutritionSnack.SelectedValue.ToString());
            nutritionInfo.CoffeeTea = (DrinkEnum)Enum.Parse(typeof(DrinkEnum), nutritionInfoUC.cmbNutritionCoffeeTea.SelectedValue.ToString());
            nutritionInfo.EatOut = (EatEnum)Enum.Parse(typeof(EatEnum), nutritionInfoUC.cmbNutritionEatOut.SelectedValue.ToString());
            nutritionInfo.MealsPerDay = int.Parse(nutritionInfoUC.txtNutritionMealsPerDay.Text.Trim());
            nutritionInfo.EatSameTime = nutritionInfoUC.cbNutritionEatSameTimeYes.Checked;
            nutritionInfo.SkipMeal = nutritionInfoUC.cbNutritionSkipMealsYes.Checked;
            nutritionInfo.CaloriesPerMeal = nutritionInfoUC.txtNutritionCaloriesEatPerMeal.Text.Trim();
            nutritionInfo.CaloriesPerDay = nutritionInfoUC.txtNutritionCaloriesEatPerDay.Text.Trim();
            nutritionInfo.ShopWithAGroceryList = nutritionInfoUC.cbNutritionShopWithAGroceryListYes.Checked;
            nutritionInfo.PlanMealsInAdvance = nutritionInfoUC.cbNutrititionPlanMealsYes.Checked;
            nutritionInfo.UseSugarOrButterSubstitutes = nutritionInfoUC.cbNutritionSugarYes.Checked;
            nutritionInfo.DrinkDietSoda = nutritionInfoUC.cbNutritionDietSodaYes.Checked;
            nutritionInfo.WakeupHungryAtNight = nutritionInfoUC.cbNutritionHungryAtNightYes.Checked;
            nutritionInfo.WhenDoYouFeelHungriest = nutritionInfoUC.txtNutritionWhenYouFeelHungriest.Text.Trim();
            nutritionInfo.SnackAtNight = nutritionInfoUC.cbNutritionSnackAtNightYes.Checked;
            nutritionInfo.EatWhenStressedOrSad = nutritionInfoUC.cbNutritionEatWhenStressedYes.Checked;
            nutritionInfo.StressedOrSad = nutritionInfoUC.cbNutritionCurrentlyStressedYes.Checked;
            nutritionInfo.FoodsYouCrave = nutritionInfoUC.txtNutritionFoodsYouCarve.Text.Trim();
            nutritionInfo.FoodsYouDislike = nutritionInfoUC.txtNutritionFoodsYouDislike.Text.Trim();

            // Exercise Info
            var exerciseInfoUC = (ExerciseUC)tabPages[5].Controls[0];
            var exerciseInfo = patientWeightAssessment.ExerciseInfo;
            exerciseInfo.DaysPerWeekOnCardio = int.Parse(exerciseInfoUC.txtExercisePerWeekOnCardio.Text.Trim());
            exerciseInfo.DaysPerWeekOnStrength = int.Parse(exerciseInfoUC.txtExercisePerWeekOnStrength.Text.Trim());
            exerciseInfo.LengthOfTimeSpentOnCardio = int.Parse(exerciseInfoUC.txtExerciseTimeSpentOnCardio.Text.Trim());
            exerciseInfo.LengthOfTimeSpentOnStrength = int.Parse(exerciseInfoUC.txtExerciseTimeSpentOnStrength.Text.Trim());
            exerciseInfo.InjuriesOrConditionsInterfere = exerciseInfoUC.txtExerciseInjuriesOrConditions.Text.Trim();

            // Other Info
            var otherInfoUC = (OtherUC)tabPages[6].Controls[0];
            var otherInfo = patientWeightAssessment.OtherInfo;

            otherInfo.WeightAtBirth = otherInfoUC.txtOtherWeightAtBirth.Text.Trim();
            otherInfo.WeightFiveYearsAgo = otherInfoUC.txtOtherWeight5yrsAgo.Text.Trim();
            otherInfo.WeightSixMonthAgo = otherInfoUC.txtOtherWeight6MonthsAgo.Text.Trim();
            otherInfo.HeaviestWeight = otherInfoUC.txtOtherHeaviestWeight.Text.Trim();
            otherInfo.HeaviestWeightAge = int.Parse(otherInfoUC.txtOtherHeaviestWeightAge.Text.Trim());
            otherInfo.LightestWeight = otherInfoUC.txtOtherLightestWeight.Text.Trim();
            otherInfo.LightestWeightAge = int.Parse(otherInfoUC.txtOtherLightestWeightAge.Text.Trim());
            otherInfo.TargetWeight = otherInfoUC.txtOtherTargetWeight.Text.Trim();
            otherInfo.EatingDisorders = otherInfoUC.txtOtherEatingDisorders.Text.Trim();
            otherInfo.LengthOfTime = otherInfoUC.txtOtherLengthOfTime.Text.Trim();
            otherInfo.WeightLossOrGainBegin = otherInfoUC.txtOtherWeightLossOrGainBegin.Text.Trim();
            otherInfo.LiveWithOverweight = otherInfoUC.cbOtherLiveWithOverweightYes.Checked;

            var patientWeightAssessmentDao = new PatientWeightAssessmentDao(false);
            patientWeightAssessmentDao.Save(patientWeightAssessment);

            MessageBox.Show("Saved Successfully!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //TODO: Clean up the UI controls.
        }
    }
}
