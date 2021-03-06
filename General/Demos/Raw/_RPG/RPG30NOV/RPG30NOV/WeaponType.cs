﻿using System;
using System.Collections.Generic;

namespace RPG30NOV
{
    public partial class WeaponType
    {
        public WeaponType()
        {
            WeaponModels = new HashSet<WeaponModel>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int HandsRequired { get; set; }

        public ICollection<WeaponModel> WeaponModels { get; set; }
    }
}
