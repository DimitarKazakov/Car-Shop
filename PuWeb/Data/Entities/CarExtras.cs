using System;
using PuWeb.Data.Entities.Common;

namespace PuWeb.Data.Entities
{
	public class CarExtras: BaseDeletableModel
	{
		public CarExtras()
		{
		}

        public int CarId { get; set; }
        public Car Car { get; set; }

        public int ExtraId { get; set; }
        public Extra Extra { get; set; }
    }
}

