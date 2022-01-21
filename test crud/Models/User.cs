using System.Collections.Generic;

namespace test_crud.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public List<FavoriteItem> favoriteItems { get; set; } = new List<FavoriteItem>();
    }
}
