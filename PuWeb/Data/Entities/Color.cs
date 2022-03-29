using System;
using System.ComponentModel.DataAnnotations;
using PuWeb.Data.Entities.Common;

namespace PuWeb.Data.Entities
{
	public class Color: BaseModel
	{
		public Color()
		{
			this.Cars = new HashSet<Car>();
		}

		[Required]
		[StringLength(10)]
		public string Code { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}

