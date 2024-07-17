using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class MovieLicense
    {
        private readonly Discount _discount;
        private readonly LicenseType _licenseType;
        private readonly SpecialOffer _specialOffer;
        public string Movie { get; }
        public DateTime PurchaseTime { get; }

        public MovieLicense(string movie, DateTime purchaseTime, Discount discount,LicenseType licenseType, SpecialOffer specialOffer=SpecialOffer.None)
        {
            Movie = movie;
            PurchaseTime = purchaseTime;
            _discount = discount;
            _licenseType = licenseType;
            _specialOffer = specialOffer;
        }

        public decimal GetPrice()
        {
            int discount = GetDiscount();
            decimal multiplier = 1 - discount / 100m;
            return GetBasePrice() * multiplier;
        }

        private int GetDiscount()
        {
            return _discount switch
            {
                Discount.None => 0,
                Discount.Military => 10,
                Discount.Senior => 20,

                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private decimal GetBasePrice()
        {
            return _licenseType switch
            {
                LicenseType.TwoDays => 4,
                LicenseType.LifeLong => 8,

                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public DateTime? GetExpirationDate()
        {
            DateTime? expirationDate = GetBaseExpirationDate();
            TimeSpan extension = GetSpecialOfferExtension();

            return expirationDate?.Add(extension);
        }

        private DateTime? GetBaseExpirationDate()
        {
            return _licenseType switch
            {
                LicenseType.TwoDays => PurchaseTime.AddDays(2)  as DateTime?,
                LicenseType.LifeLong => null,

                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private TimeSpan GetSpecialOfferExtension()
        {
            return _specialOffer switch
            {
                SpecialOffer.None => TimeSpan.Zero,
                SpecialOffer.TwoDaysExtension => TimeSpan.FromDays(2),

                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }

    public enum Discount
    {
        None,
        Military,
        Senior
    }

    public enum LicenseType
    {
        TwoDays,
        LifeLong
    }

    public enum SpecialOffer
    {
        None,
        TwoDaysExtension
    }
}