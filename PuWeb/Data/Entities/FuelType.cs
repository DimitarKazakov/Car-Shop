using System;
using System.ComponentModel.DataAnnotations;
using PuWeb.Data.Entities.Common;

namespace PuWeb.Data.Entities
{
	public class FuelType: BaseModel
	{
		public FuelType()
		{
			this.Cars = new HashSet<Car>();
		}

		[Required]
		[StringLength(100)]
		public string Fuel { get; set; }

		[Range(0, 10)]
		public decimal CurrentPrice { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}

