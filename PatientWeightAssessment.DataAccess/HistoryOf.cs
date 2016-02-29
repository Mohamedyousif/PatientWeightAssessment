namespace PatientWeightAssessment.DataAccess
{
    public class HowItsRelated
    {
        public bool Me { get; set; }
        public bool IsRelation { get; set; }
        public string Relation { get; set; }
    }

    public class HistoryOf
    {
        public HowItsRelated Cancer { get; set; }
        public HowItsRelated Diabetes { get; set; }
        public HowItsRelated Stroke { get; set; }
        public HowItsRelated HeartDisease { get; set; }
        public HowItsRelated HeartAttack { get; set; }
        public HowItsRelated Depression { get; set; }
        public HowItsRelated BipolarDisorder { get; set; }
        public HowItsRelated Headaches { get; set; }
        public HowItsRelated Constipation { get; set; }
        public HowItsRelated SleepDisorders { get; set; }
        public HowItsRelated Obesity { get; set; }
    }
}
