using System.ComponentModel;

namespace PatientWeightAssessment.DataAccess.Enums
{
    public enum SnackEnum
    {
        [Description("Never")]
        Never,
        [Description("Rarely")]
        Rarely,
        [Description("1 – 2 times per day")]
        OneToTwo,
        [Description("Between every meal")]
        BetweenEveryMeal
    }
}
