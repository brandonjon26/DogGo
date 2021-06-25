using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();
        void AddDog(Dog dog);
        List<Dog> GetDogsByOwnerId(int ownerId);
        Dog GetDogById(int id);
        void UpdateDog(Dog dog);
        void DeleteDog(int id);
    }
}