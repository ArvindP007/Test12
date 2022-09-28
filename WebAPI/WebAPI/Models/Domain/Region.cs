namespace WebAPI.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string RegionName { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long population { get; set; }

        //Navigation Properties
        public IEnumerable<Walk> Walks { get; set; }
        

    }
}
