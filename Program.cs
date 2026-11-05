using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Restaurant {
        public int id { get; set; }
        public String name { get; set; }
        public String type { get; set; }
        public double rating { get; set; }

        public Restaurant(int id,string name,string type,double rating) 
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.rating = rating;
        }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant> {
            new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
            new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
            new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
            }

            foreach (var r in restaurants)
            {
                Console.WriteLine($"ID : {r.id} | Name : {r.name} | Type : {r.type} | Rating : {r.rating}");
            }

            if (restaurants.Count > 0)
            {
                // หาร้านที่มีคะแนนสูงสุด (ใช้ OrderByDescending แล้วเลือกตัวแรก)
                var maxRatingRestaurant = restaurants.OrderByDescending(r => r.rating).First();

                // หาร้านที่มีคะแนนต่ำสุด (ใช้ OrderBy แล้วเลือกตัวแรก)
                var minRatingRestaurant = restaurants.OrderBy(r => r.rating).First();

                Console.WriteLine("--- ร้านที่คะแนนสูงสุด ---");
                Console.WriteLine($"ID : {maxRatingRestaurant.id} | Name : {maxRatingRestaurant.name} | Type : {maxRatingRestaurant.type} | Rating : {maxRatingRestaurant.rating}");

                Console.WriteLine("\n--- ร้านที่คะแนนต่ำสุด ---");
                Console.WriteLine($"ID : {minRatingRestaurant.id} | Name : {minRatingRestaurant.name} | Type : {minRatingRestaurant.type} | Rating : {minRatingRestaurant.rating}");
            }
        }
        // กรองเฉพาะร้านที่มี rating ตั้งแต่ 4.5 ขึ้นไป
        var filteredRestaurants = restaurants.Where(r => r.rating >= 4.5);

foreach (var r in filteredRestaurants)

    {
    Console.WriteLine($"ID : {r.id} | Name : {r.name} | Type : {r.type} | Rating : {r.rating}");

}
}

}//
