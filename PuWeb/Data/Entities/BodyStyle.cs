using System;
using System.ComponentModel.DataAnnotations;
using PuWeb.Data.Entities.Common;

namespace PuWeb.Data.Entities
{
	public class BodyStyle: BaseModel
	{
		public BodyStyle()
		{
			this.Cars = new HashSet<Car>();
		}

		[Required]
		[StringLength(100)]
        public string Name { get; set; }

		[Required]
		[StringLength(1000)]
		public string Description { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}

