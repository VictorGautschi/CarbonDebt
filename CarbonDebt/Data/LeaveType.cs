﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CarbonDebt.Models
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
