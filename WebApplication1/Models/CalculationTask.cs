namespace WebApplication1.Models
{
    public class CalculationTask
    {
        public Guid Id { get; set; }
        public CalcStatus Status { get; set; }
        public int ProgressPercentage { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Result { get; set; }
        public bool CanCancel { get; set; }
    }

    public enum CalcStatus { InProgress, Completed, Failed }
}
