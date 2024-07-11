using WebApp.Application.Interfaces.Repositories;

namespace WebApp.Infrastructure.Repositories
{
    public class PetRepository(BssContext bssContext) : IPetRepository
    {
        public async Task<Pet> CreatePetAsync(Pet pet) 
        { 
            await bssContext.Pets.AddAsync(pet);
            bssContext.SaveChanges();

            return pet;
        }

        public Task DeletePetAsync(long petId)
        {
            throw new NotImplementedException();
        }

        public Task<Pet> ReadPetAsync(long petId)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePetAsync(Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}
