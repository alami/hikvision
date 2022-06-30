namespace Core.Entities
{
    public class Tariff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public Resolution Resolution { get; set; }
        public int ResolutionId { get; set; }
        public Period Period { get; set; }
        public int PeriodId { get; set; }
    }
}
