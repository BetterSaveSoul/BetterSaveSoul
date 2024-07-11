namespace WebApp.Models.Pet
{
    public class RegisterPetVM
    {
        public string? Name { get; set; }

        public int SpeciesId { get; set; }

        public int? BreedId { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public short? Gender { get; set; }

        public string? Color { get; set; }

        public string? Size { get; set; }

        public short HealthStatus { get; set; }

        public bool Vaccinated { get; set; }

        public bool NeuteredStatus { get; set; }

        public string? Description { get; set; }

        public int? OwnerProfileId { get; set; }
    }
}
