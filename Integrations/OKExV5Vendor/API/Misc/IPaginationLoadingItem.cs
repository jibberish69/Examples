using System;

namespace OKExV5Vendor.API.Misc
{
    interface IPaginationLoadingItem
    {
        public string AfterId { get; }
        public DateTime Time { get; }
    }
}
