using PatientWeightAssessment.DataAccess.Enums;

namespace PatientWeightAssessment.DataAccess
{
    public class Nutrition
    {
        public NutritionEnum Vegetables { get; set; }
        public NutritionEnum Fruits { get; set; }
        public NutritionEnum Grains { get; set; }
        public NutritionEnum Meat { get; set; }
        public NutritionEnum SugarOrCarbs { get; set; }
        public SnackEnum Snack { get; set; }
        public DrinkEnum CoffeeTea { get; set; }
        public EatEnum EatOut { get; set; }
        public int MealsPerDay { get; set; }
        public bool EatSameTime { get; set; }
        public bool SkipMeal { get; set; }
        public string CaloriesPerMeal { get; set; }
        public string CaloriesPerDay { get; set; }
        public bool ShopWithAGroceryList { get; set; }
        public bool PlanMealsInAdvance { get; set; }
        public bool UseSugarOrButterSubstitutes { get; set; }
        public bool DrinkDietSoda { get; set; }
        public string WhenDoYouFeelHungriest { get; set; }
        public bool WakeupHungryAtNight { get; set; }
        public bool SnackAtNight { get; set; }
        public bool EatWhenStressedOrSad { get; set; }
        public bool StressedOrSad { get; set; }
        public string FoodsYouCrave { get; set; }
        public string FoodsYouDislike { get; set; }
    }
}
