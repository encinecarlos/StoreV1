namespace StoreV1.Interfaces
{
    public interface ITax
    {
        void SetTaxInformation(decimal value, string placeName);
        decimal GetTaxValue();
        string GetTaxLocation();
    }
}