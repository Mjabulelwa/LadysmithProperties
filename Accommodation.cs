using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LadysmithProperties.Model
{
    public class Accommodation
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccommodationId { get; set; }
        public string AccommodationName { get; set; }
        public string AccommodationDescription { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal AccommodationPrice { get; set; }

        public string ImageUrls { get; set; }
    }
}
