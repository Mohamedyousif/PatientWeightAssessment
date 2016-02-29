using System.ComponentModel;

namespace PatientWeightAssessment.DataAccess.Enums
{
    public enum DrinkEnum
    {
        [Description("Restful")]
        Never,
        [Description("Occasionally")]
        Occasionally,
        [Description("1 cup per day")]
        One,
        [Description("2 – 3 cups")]
        TwoToThree,
        [Description("4+ cups")]
        FourPlus
    }
}
