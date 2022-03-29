using System;
using System.ComponentModel.DataAnnotations;
using PuWeb.Data.Entities.Common;

namespace PuWeb.Data.Entities
{
	public class Tuning: BaseModel
	{
		public Tuning()
		{
            this.CarTunings = new HashSet<CarTunings>();
        }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Function { get; set; }

        [Required]
        [StringLength(100)]
        public string Brand { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public ICollection<CarTunings> CarTunings { get; set; }
    }
}

