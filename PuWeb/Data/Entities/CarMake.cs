using System;
using System.ComponentModel.DataAnnotations;
using PuWeb.Data.Entities.Common;

namespace PuWeb.Data.Entities
{
	public class CarMake: BaseDeletableModel
	{
		public CarMake()
		{
            this.Cars = new HashSet<Car>();
		}

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public DateTime FoundedIn { get; set; }

        [Required]
        [StringLength(100)]
        public string FoundedBy { get; set; }

        [Required]
        [StringLength(100)]
        public string Headquarters { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}

