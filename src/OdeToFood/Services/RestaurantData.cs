using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurants();
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id=1, Name="In N Out"},
                new Restaurant {Id=2, Name = "Thai Spice"},
                new Restaurant {Id=3, Name = "Haiko Sushi"}
            };
        } 
        public IEnumerable<Restaurant> GetRestaurants()
        {
            return _restaurants;
        }
    }
}
