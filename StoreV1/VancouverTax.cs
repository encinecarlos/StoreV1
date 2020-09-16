using StoreV1.Interfaces;

namespace StoreV1
{
    public class VancouverTax : ITax
    {
        public string Place { get; set; }
        public decimal Value { get; set; }

        public VancouverTax()
        {
            Place = "Vancouver";
            Value = (decimal) 0.05;
        }

        public void SetTaxInformation(decimal value, string placeName)
        {
            Place = placeName;
            Value = value;
        }

        public decimal GetTaxValue()
        {
            return Value;
        }

        public string GetTaxLocation()
        {
            return Place;
        }
    }
}