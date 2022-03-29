﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PuWeb.Data.Entities.Common
{
	public class BaseModel
	{
		public BaseModel()
		{
		}

        [Key]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public string CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}

