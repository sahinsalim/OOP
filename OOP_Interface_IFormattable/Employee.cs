using System.Globalization;

namespace OOP_Interface_IFormattable
{
    public class Employee : IFormattable
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string FullName => $"{Title} {FirstName} {Lastname}";

        public override string ToString()
        {
            return this.ToString("F", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (String.IsNullOrEmpty(format))
                format = "F";
            if(formatProvider == null)
                formatProvider = CultureInfo.CurrentCulture;
            switch (format.ToUpper())
            {
                case "F":
                    return $"{FullName}";
                case "FI":
                    return $"{ID,-3} {Title,-7} {FirstName,-10} {Lastname,-15}";
                case "JN":
                    return $"{Lastname} {FirstName}";
                case "S":
                    return $"{Lastname} {FirstName[0]}";
                default:
                    throw new FormatException(String.Format("The {0] is not supported.",format));
            }
        }
    }
}
