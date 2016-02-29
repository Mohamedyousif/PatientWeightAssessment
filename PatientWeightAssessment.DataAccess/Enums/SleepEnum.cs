using System.ComponentModel;

namespace PatientWeightAssessment.DataAccess.Enums
{
    public enum SleepEnum
    {
        [Description("Restful")]
        Restful,
        [Description("Restful")]
        OnceOrTwice,
        [Description("Often")]
        Often,
        [Description("Fitful")]
        Fitful
    }
}
