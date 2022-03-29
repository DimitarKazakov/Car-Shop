using System;
namespace PuWeb.Data.Entities.Common
{
	public class BaseDeletableModel: BaseModel
	{
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string? DeletedBy { get; set; }
    }
}

