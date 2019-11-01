namespace ParksLookup.Models
{
    public class NativeSpeciesPark
    {
        public int NativeSpeciesParkId { get; set; }
        public int ParkId { get; set; }
        public int NativeSpeciesId { get; set; }
        public Park Park { get; set; }
        public NativeSpecies NativeSpecies { get; set; }
    }
}