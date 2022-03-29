using System;
using PuWeb.Data.Entities.Common;

namespace PuWeb.Data.Entities
{
	public class CarTunings: BaseDeletableModel
	{
		public CarTunings()
		{
		}

        public int CarId { get; set; }
        public Car Car { get; set; }

        public int TuningId { get; set; }
        public Tuning Tuning { get; set; }
    }
}

