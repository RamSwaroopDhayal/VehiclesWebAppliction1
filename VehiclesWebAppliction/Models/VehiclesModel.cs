using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VehiclesWebAppliction.Models
{
    public class VehiclesModel
    {
        [Key]
        [MaxLength(50)]
        [DisplayName("Vehicle ID")]
        public string vehicle_id { get; set; }
        [MaxLength(17)]
        [DisplayName("Vin")]
        public string vin { get; set; }
        [MaxLength(100)]
        [DisplayName("Make")]
        public string make { get; set; }
        [MaxLength(100)]
        [DisplayName("Model")]
        public string model { get; set; }

        public string year { get; set; }
        [MaxLength(500)]
        [DisplayName("Thumbnail")]
        public string thumbnail_url { get; set; }
    }
}
