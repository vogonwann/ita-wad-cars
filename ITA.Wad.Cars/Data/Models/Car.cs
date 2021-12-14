using System.ComponentModel.DataAnnotations;

namespace ITA.Wad.Cars.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Brand { get; set; }
        [Required]
        [MaxLength(50)]
        public string Model { get; set; }
        [Required]
        public short ProductionYear { get; set; }
        [Required]
        public int EngineCapacity { get; set; }
        [Required]
        public short Power { get; set; }
        [Required]
        [MaxLength(50)]
        public string Chassis { get; set; }
        [Required]
        [MaxLength(50)]
        public string FuelType { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        [MaxLength(512)]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [MaxLength(512)]
        public string Contact { get; set; }
    }
}
