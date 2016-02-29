using PatientWeightAssessment.DataAccess.Enums;

namespace PatientWeightAssessment.DataAccess
{
    public class OverAllHealth
    {
        public HealthRatingEnum OverAllHealthRating { get; set; }
        public DepressionEnum HowOftenDepressed { get; set; }
        public ExerciseEnum HowOftenExcercise { get; set; }
        public GeneralEnum HowOftenSmoke { get; set; }
        public string CigarettesPerDay { get; set; }
        public GeneralEnum HowOftenDrinkAlcohol { get; set; }
        public string AlcoholsPerWeek { get; set; }
        public GeneralEnum HowOftenFastFood { get; set; }
        public SleepEnum HowOftenRestfulSleep { get; set; }
        public int HoursOfSleepPerNight { get; set; }
        public string CurrentMedication { get; set; }
        public string Dosage { get; set; }
        public string StartingDate { get; set; }
        public string DietaryRestrictions { get; set; }
        public string HowOftenHeadaches { get; set; }
    }
}
