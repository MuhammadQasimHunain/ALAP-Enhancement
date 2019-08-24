﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExigoService
{
    public interface IItemGroupMember
    {
        string ItemCode { get; set; }
        string MasterItemCode { get; set; }

        string MemberDescription { get; set; }
        int SortOrder { get; set; }

        Item Item { get; set; }
    }
}