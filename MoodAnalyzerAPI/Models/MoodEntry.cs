// This class defines the structure of each mood/tracker entry record that we are going to store/retrieve
namespace MoodAnalyzerAPI.Models
{
    public class MoodEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public int SleepQuality { get; set; }
        public int StressLevel { get; set; }
        public int ExerciseLevel { get; set; }
        public string JournalText { get; set; } = string.Empty;
        public double SentimentScore { get; set; }
    }
}