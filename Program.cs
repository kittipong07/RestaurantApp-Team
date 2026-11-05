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
        static void AddRestaurant(List<Restaurant> restaurants)
        {
            Console.WriteLine("--- เพิ่มร้านอาหารใหม่ ---");

            // สร้าง ID อัตโนมัติโดยอิงจากจำนวนสมาชิกที่มีอยู่เดิม (หรือจะรับค่าจากคีย์บอร์ดเพิ่มก็ได้)
            int id = restaurants.Count > 0 ? restaurants[restaurants.Count - 1].id + 1 : 1;

            Console.Write("ป้อนชื่อร้าน: ");
            string name = Console.ReadLine();

            Console.Write("ป้อนประเภทอาหาร: ");
            string type = Console.ReadLine();

            Console.Write("ป้อนคะแนน (เช่น 4.5): ");
            double rating;
            while (!double.TryParse(Console.ReadLine(), out rating))
            {
                Console.Write("กรุณากรอกตัวเลขคะแนนให้ถูกต้อง: ");
            }

            // สร้าง Object และ Add เข้า List
            Restaurant newRestaurant = new Restaurant(id, name, type, rating);
            restaurants.Add(newRestaurant);

            Console.WriteLine("เพิ่มร้านอาหารสำเร็จ!\n");
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
            AddRestaurant(restaurants);
        }
        // กรองเฉพาะร้านที่มี rating ตั้งแต่ 4.5 ขึ้นไป
        var filteredRestaurants = restaurants.Where(r => r.rating >= 4.5);

foreach (var r in filteredRestaurants)

    {
    Console.WriteLine($"ID : {r.id} | Name : {r.name} | Type : {r.type} | Rating : {r.rating}");

}
}

}//
