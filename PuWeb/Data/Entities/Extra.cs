using System;
using System.ComponentModel.DataAnnotations;
using PuWeb.Data.Entities.Common;

namespace PuWeb.Data.Entities
{
	public class Extra: BaseModel
	{
		public Extra()
		{
            this.CarExtras = new HashSet<CarExtras>();
        }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(0, 10000)]
        public decimal UsualPrice { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Brand { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public ICollection<CarExtras> CarExtras { get; set; }
    }
}

