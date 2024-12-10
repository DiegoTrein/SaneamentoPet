using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using SaneamentoPet.Models;

namespace SaneamentoPet.Client.Services
{
    public class PetService
    {
        private readonly HttpClient _httpClient;

        public PetService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Pet>> GetPetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Pet>>("api/Pet");
        }

        public async Task<Pet> GetPetAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Pet>($"api/Pet/{id}");
        }

        public async Task AddPetAsync(Pet pet)
        {
            await _httpClient.PostAsJsonAsync("api/Pet", pet);
        }

        public async Task UpdatePetAsync(Pet pet)
        {
            await _httpClient.PutAsJsonAsync($"api/Pet/{pet.chip_id}", pet);
        }

        public async Task DeletePetAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/Pet/{id}");
        }
    }
}
