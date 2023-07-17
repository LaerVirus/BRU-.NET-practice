﻿using System;
using System.Collections.Generic;

namespace BuildShopDataAccessLayer
{
    public partial class ItemsCategory
    {
        public ItemsCategory()
        {
            Items = new HashSet<Item>();
        }

        public int Guid { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Item> Items { get; set; }
    }
}
