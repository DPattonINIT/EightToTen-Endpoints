using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen_Endpoints.Services
{
    public class RestaurantPickerService
    {
          private readonly Dictionary<string, List<string>> _restaurants = new Dictionary<string, List<string>>
        {
            { "fastfood", new List<string> { "McDonald's", "Chick-fil-A", "Wendy's", "Jack in the Box", "Taco Bell", "Del Taco", "El Pollo Loco", "KFC", "POPEYES", "WingStop" } },
            { "italian", new List<string> { "Olive Garden", "De Vinci's Delicatessen", "Maggiano's Little Italy", "Angelina's Spaghetti House", "Mezzo Ristorante", "Pietro's Trattoria","Garlic Brothers Restaurant and Bar", "Papapavlo's Bistro & Bar", "The Kitchen @ Stonebrier", "Gian's Delicatessen" } },
            { "mexican", new List<string> { "Chipotle", "Don Jorge's Tacos", "Tu Pueblito Taqueria", "El Chilango Chido", "Chela's Mexican Grill", "Mexico Lindo Restaurant", "Fuego Taqueria", "Octavio's", "EL Senor Frog" } },
            { "chinese", new List<string> { "Johnny Wokker", "Oriental Chef", "Peking Restaurant", "China Town", "Tsing Tao Restaurant","New Shanghai Restaurant","Chow To Go Chinese Restaurant","New Yen Ching Restaurant", "Prosperity Szechuan Cuisine", "Dynasty Seafood Restaurant" } },
            { "japanese", new List<string> { "Sushi Samba", "Benihana", "Tokyo Joe's", "Izakaya Den", "Shirasoni Japanese Restaurant", "Cocoro Bistro Sushi Bar", "Toyo Sushi", "Domo Japanese Sushi Grill and Bar", "Jimmie's Place", "ShoMi Japanese Cuisine" } }
        };

        public string PickRandomRestaurant(string category)
        {
            if (_restaurants.ContainsKey(category.ToLower()))
            {
                var random = new Random();
                var restaurants = _restaurants[category.ToLower()];
                int index = random.Next(restaurants.Count); 
                return restaurants[index]; 
            }
            else
            {
                return "Category not found. Please choose from: fastfood, italian, mexican, chinese, japanese.";
            }
        }
    }
    }
