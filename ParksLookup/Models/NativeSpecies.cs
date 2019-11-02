namespace ParksLookup.Models
{
    public class NativeSpecies
    {
        
        public int NativeSpeciesId { get; set; }
        public int ParkId { get; set; }
        public string Kingdom { get; set; }
        public string Class { get; set; }
        public string Species { get; set; }
        public string CommonName { get; set; }
        public string SpeciesDescription { get; set; }
        public string ConservationStatus { get; set; }

        public virtual Park Park { get; set; }
        
    }

}