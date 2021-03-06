﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common.Api.ExigoOData
{
    public partial class Order
    {
        public static explicit operator ExigoService.Order(Order order)
        {
            var model = new ExigoService.Order();
            if (order == null) return model;            

            model.OrderID              = order.OrderID;
            model.CustomerID           = order.CustomerID;

            model.CurrencyCode         = order.CurrencyCode;
            model.WarehouseID          = order.WarehouseID;
            model.ShipMethodID         = order.ShipMethodID;
            model.OrderStatusID        = order.OrderStatusID;
            model.OrderTypeID          = order.OrderTypeID;
            model.PriceTypeID          = order.PriceTypeID;
            model.Notes                = order.Notes;

            model.AutoOrderID          = order.AutoOrderID;
            model.ReturnOrderID        = order.ReturnOrderID;
            model.ParentOrderID        = order.ParentOrderID;
            model.TransferToCustomerID = order.TransferToCustomerID;
            model.DeclineCount         = order.DeclineCount;

            model.CreatedDate          = order.CreatedDate;
            model.ModifiedDate         = order.ModifiedDate;
            model.OrderDate            = order.OrderDate;
            model.ShippedDate          = order.ShippedDate;

            model.Recipient            = new ExigoService.ShippingAddress
            {
                FirstName              = order.FirstName,
                LastName               = order.LastName,
                Company                = order.Company,
                AddressType            = ExigoService.AddressType.Other,
                Address1               = order.Address1,
                Address2               = order.Address2,
                City                   = order.City,
                State                  = order.State,
                Zip                    = order.Zip,
                Country                = order.Country,
                Email                  = order.Email,
                Phone                  = order.Phone
            };

            model.Total                = order.Total;
            model.Subtotal             = order.SubTotal;
            model.TaxTotal             = order.TaxTotal;
            model.ShippingTotal        = order.ShippingTotal;
            model.DiscountTotal        = order.DiscountTotal;
            model.DiscountPercent      = order.DiscountPercent;
            model.WeightTotal          = order.WeightTotal;
            model.BVTotal              = order.BusinessVolumeTotal;
            model.CVTotal              = order.CommissionableVolumeTotal;

            var trackingNumbers        = new List<string>();
            if (order.TrackingNumber1.IsNotEmpty()) trackingNumbers.Add(order.TrackingNumber1);
            if (order.TrackingNumber2.IsNotEmpty()) trackingNumbers.Add(order.TrackingNumber2);
            if (order.TrackingNumber3.IsNotEmpty()) trackingNumbers.Add(order.TrackingNumber3);
            if (order.TrackingNumber4.IsNotEmpty()) trackingNumbers.Add(order.TrackingNumber4);
            if (order.TrackingNumber5.IsNotEmpty()) trackingNumbers.Add(order.TrackingNumber5);
            model.TrackingNumbers      = trackingNumbers.AsEnumerable();

            model.Other1Total          = order.Other1Total;
            model.Other2Total          = order.Other2Total;
            model.Other3Total          = order.Other3Total;
            model.Other4Total          = order.Other4Total;
            model.Other5Total          = order.Other5Total;
            model.Other6Total          = order.Other6Total;
            model.Other7Total          = order.Other7Total;
            model.Other8Total          = order.Other8Total;
            model.Other9Total          = order.Other9Total;
            model.Other10Total         = order.Other10Total;

            model.Other11              = order.Other11;
            model.Other12              = order.Other12;
            model.Other13              = order.Other13;
            model.Other14              = order.Other14;
            model.Other15              = order.Other15;
            model.Other16              = order.Other16;
            model.Other17              = order.Other17;
            model.Other18              = order.Other18;
            model.Other19              = order.Other19;
            model.Other20              = order.Other20;

            if (order.Payments != null)
            {
                model.Payments         = order.Payments.Select(c => (ExigoService.Payment)c).ToList();
            }

            return model;
        }
    }
}