namespace WebApp.Application.Interfaces.Repositories
{
    public interface IPetRepository
    {
        Task<Pet> CreatePetAsync(Pet pet);
        Task<Pet> ReadPetAsync(long petId);
        Task UpdatePetAsync(Pet pet);
        Task DeletePetAsync(long petId);
    }
}
