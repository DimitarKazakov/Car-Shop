using System;
using System.ComponentModel.DataAnnotations;
using PuWeb.Data.Entities.Common;

namespace PuWeb.Data.Entities
{
	public class CarLevel: BaseModel
	{
		public CarLevel()
		{
			this.Cars = new HashSet<Car>();
		}

		[Required]
		[StringLength(100)]
		public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}

