using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelFinder.Entity
{
    public class Hotel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]//bu kısım Id'nin özelliklerini belirtti
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }


        [StringLength(50)]
        public string City { get; set; }
    }
}