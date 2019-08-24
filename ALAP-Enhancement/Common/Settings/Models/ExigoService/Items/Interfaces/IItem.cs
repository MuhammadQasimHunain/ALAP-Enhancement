﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExigoService
{
    public interface IItem : IShoppingCartItem
    {
        int ItemID { get; set; }
        string ItemDescription { get; set; }
        decimal Weight { get; set; }
        int ItemTypeID { get; set; }

        string TinyImageUrl { get; set; }
        string SmallImageUrl { get; set; }
        string LargeImageUrl { get; set; }

        string ShortDetail1 { get; set; }
        string ShortDetail2 { get; set; }
        string ShortDetail3 { get; set; }
        string ShortDetail4 { get; set; }
        string LongDetail1 { get; set; }
        string LongDetail2 { get; set; }
        string LongDetail3 { get; set; }
        string LongDetail4 { get; set; }

        bool IsVirtual { get; set; }
        bool AllowOnAutoOrder { get; set; }

        bool IsGroupMaster { get; set; }
        string GroupMasterItemDescription { get; set; }
        string GroupMembersDescription { get; set; }
        IEnumerable<ItemGroupMember> GroupMembers { get; set; }

        int PriceTypeID { get; set; }
        string CurrencyCode { get; set; }
        decimal Price { get; set; }
        decimal BV { get; set; }
        decimal CV { get; set; }
        decimal OtherPrice1 { get; set; }
        decimal OtherPrice2 { get; set; }
        decimal OtherPrice3 { get; set; }
        decimal OtherPrice4 { get; set; }
        decimal OtherPrice5 { get; set; }
        decimal OtherPrice6 { get; set; }
        decimal OtherPrice7 { get; set; }
        decimal OtherPrice8 { get; set; }
        decimal OtherPrice9 { get; set; }
        decimal OtherPrice10 { get; set; }

        string Field1 { get; set; }
        string Field2 { get; set; }
        string Field3 { get; set; }
        string Field4 { get; set; }
        string Field5 { get; set; }
        string Field6 { get; set; }
        string Field7 { get; set; }
        string Field8{ get; set; }
        string Field9{ get; set; }
        string Field10 { get; set; }

        bool OtherCheck1 { get; set; }
        bool OtherCheck2 { get; set; }
        bool OtherCheck3 { get; set; }
        bool OtherCheck4 { get; set; }
        bool OtherCheck5 { get; set; }

        // IShoppingCartItem Properties
        Guid ID { get; set; }
        string ItemCode { get; set; }
        decimal Quantity { get; set; }
        string ParentItemCode { get; set; }
        string GroupMasterItemCode { get; set; }
        string DynamicKitCategory { get; set; }
        ShoppingCartItemType Type { get; set; }
    }
}
