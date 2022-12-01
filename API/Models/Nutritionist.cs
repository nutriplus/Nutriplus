namespace API.Models;

      public class Nutritionist
       {
           public int Id { get; set; }
           public AppUser AppUser { get; set; }
           public DateTime CreatedAt { get; set; }
           public DateTime UpdatedAt { get; set; }
        }
