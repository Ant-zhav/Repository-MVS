namespace Complex742.Models.Equipments
{
    public class PropertyValue
    {
        public int propertyValueId { get; set; }
        public Equipment? equipment { get; set; }
        public Property? property { get; set; }
        public string? value { get; set; }
    }
}
