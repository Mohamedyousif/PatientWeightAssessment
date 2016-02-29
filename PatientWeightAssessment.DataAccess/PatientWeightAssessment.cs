using RavenDBHelper;

namespace PatientWeightAssessment.DataAccess
{
    public class PatientWeightAssessment
    {
        public PatientWeightAssessment()
        {
            GeneralInfo = new General();
            HistoryOfInfo = new HistoryOf();
            MedicalHistoryInfo = new MedicalHistory();
            NutritionInfo = new Nutrition();
            OverAllHealthInfo = new OverAllHealth();
            ExerciseInfo = new Exercise();
            OtherInfo = new Other();
        }

        public General GeneralInfo { get; set; }
        public HistoryOf HistoryOfInfo { get; set; }
        public MedicalHistory MedicalHistoryInfo { get; set; }
        public Nutrition NutritionInfo { get; set; }
        public OverAllHealth OverAllHealthInfo { get; set; }
        public Exercise ExerciseInfo { get; set; }
        public Other OtherInfo { get; set; }
    }

    public class PatientWeightAssessmentDao : Dao<PatientWeightAssessment>
    {
        public PatientWeightAssessmentDao(bool inMemory = false):
            base(inMemory)
        {

        }
    }
}
