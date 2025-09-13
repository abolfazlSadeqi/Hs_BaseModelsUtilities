namespace Hs_BaseModelsUtilities.Constants
{
   
    public static class RegexPatterns
    {
        public const string Email = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
        public const string Phone = @"^\+?\d{7,15}$";
        public const string Url = @"^(http|https)://[^\s/$.?#].[^\s]*$";
        public const string IPv4 = @"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$";
        public const string IPv6 = @"^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$";
        public const string PostalCode = @"^\d{5}(-\d{4})?$";
        public const string CreditCard = @"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14})$";
        public const string IBAN = @"^[A-Z]{2}\d{2}[A-Z0-9]{1,30}$";
        public const string SWIFT = @"^[A-Z]{6}[A-Z0-9]{2}([A-Z0-9]{3})?$";
        public const string GUID = @"^[{(]?[0-9A-Fa-f]{8}(-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}[)}]?$";
        public const string Base64 = @"^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$";
        public const string HexColor = @"^#?([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$";
        public const string Username = @"^[a-zA-Z0-9_]{3,20}$";
        public const string PasswordSimple = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$";
        public const string PasswordComplex = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#\$%\^&\*]).{10,}$";
        public const string MACAddress = @"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$";
      

    }


}
