namespace BlazorAppEduardo.Entities
{
    public class RiskCategory
    {
        public int Id { get; set; }
        public RiskLevel England { get; set; }
        public RiskLevel Scotland { get; set; }
        public string Wales { get; set; }
        public string NorthernIreland { get; set; }
    }
}
