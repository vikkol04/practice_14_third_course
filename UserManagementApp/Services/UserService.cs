using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UserManagementApp.Models;

namespace UserManagementApp
{
    public class UserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<User>>("api/users");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching users: {ex.Message}");
                return new List<User>();
            }
        }

        public async Task AddUserAsync(User user)
        {
            await _httpClient.PostAsJsonAsync("api/users", user);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _httpClient.PutAsJsonAsync($"api/users/{user.Id}", user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/users/{id}");
        }
    }
}
