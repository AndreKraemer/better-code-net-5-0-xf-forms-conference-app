using ConferenceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dr. Holger Schwichtenberg", Description="Von .NET Framework über .NET Core zu .NET 5.0: Status, Migrationswege und Aufwände" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Rainer Stropek", Description="Was ist neu in C# 9.0?" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Christian Wenz", Description="ASP.NET Core 5.0 und Blazor 5.0" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "André Krämer", Description="Mobile Entwicklung mit .NET 5" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dr. Holger Schwichtenberg", Description="Die Neuerungen in Entity Framework Core 5.0" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Rainer Stropek", Description="Neuerungen in .NET 5.0" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Tim Cadenbach", Description="Windows UI Library 3 (WinUI3) als Alternative zu WPF und UWP" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Immo Landwerth", Description="Ausblick auf .NET 6" }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}