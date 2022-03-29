using System;
using System.ComponentModel.DataAnnotations;
using PuWeb.Data.Entities.Common;

namespace PuWeb.Data.Entities
{
	public class Car: BaseDeletableModel
	{
		public Car()
		{
            this.CarExtras = new HashSet<CarExtras>();
            this.CarTunings = new HashSet<CarTunings>();
        }

        [Required]
        [StringLength(100)]
        public string Model { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public bool IsAutomatic { get; set; }

        [Range(10, 1500)]
        public int Power { get; set; }

        [Range(2, 10)]
        public int Doors { get; set; }

        public bool IsLeftSteering { get; set; }

        public DateTime Year { get; set; }

        [Range(0, 1000000)]
        public decimal Price { get; set; }

        [Range(0, 30)]
        public decimal Consumption { get; set; }

        [Range(500, 5000)]
        public decimal Weight { get; set; }

        [Range(1, 25)]
        public decimal Acceleration { get; set; }

        [Range(60, 500)]
        public decimal MaxSpeed { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }

        public int BodyStyleId { get; set; }
        public BodyStyle BodyStyle { get; set; }

        public int CarLevelId { get; set; }
        public CarLevel CarLevel { get; set; }

        public int ConditionId { get; set; }
        public Condition Condition { get; set; }

        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; }

        public int CarMakeId { get; set; }
        public CarMake CarMake { get; set; }

        public ICollection<CarExtras> CarExtras { get; set; }

        public ICollection<CarTunings> CarTunings { get; set; }
    }
}

