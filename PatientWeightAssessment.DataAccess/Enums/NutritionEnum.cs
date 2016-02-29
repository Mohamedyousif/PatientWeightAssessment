using System.ComponentModel;

namespace PatientWeightAssessment.DataAccess.Enums
{
    public enum NutritionEnum
    {
        [Description("None")]
        None,
        [Description("1 – 2")]
        OneToTwo,
        [Description("3 – 4")]
        ThreeToFour,
        [Description("5 – 6")]
        FixToSix,
        [Description("More")]
        More
    }
}
