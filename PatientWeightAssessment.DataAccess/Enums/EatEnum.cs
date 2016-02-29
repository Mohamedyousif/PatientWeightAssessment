using System.ComponentModel;

namespace PatientWeightAssessment.DataAccess.Enums
{
    public enum EatEnum
    {
        [Description("Never")]
        Never,
        [Description("Occasionally")]
        Occasionally,
        [Description("Weekly")]
        Weekly,
        [Description("Daily")]
        Daily,
        [Description("Always")]
        Always
    }
}
