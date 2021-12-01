namespace Complex742.Models.Equipments
{
    public class Work
    {
        public int workId { get; set; }
        public TypeWork? typeWork { get; set; }
        public DateTime lastDateTime { get; set; } //the date when the work was done
        public Equipment? equipment { get; set; }
        public string? result { get; set; }
        public string? comment { get; set; }

    }
}
