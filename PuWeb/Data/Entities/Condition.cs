using System;
using System.ComponentModel.DataAnnotations;
using PuWeb.Data.Entities.Common;

namespace PuWeb.Data.Entities
{
	public class Condition: BaseModel
	{
		public Condition()
		{
            this.Cars = new HashSet<Car>();
		}

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Reason { get; set; }

        [Required]
        [StringLength(1000)]
        public string Explanation { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}

