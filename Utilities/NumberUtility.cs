using Impactly_PDF_Generator.Extensions;
using Impactly_PDF_Generator.Models.Enums;

namespace Impactly_PDF_Generator.Utilities
{
    public interface INumberUtility
    {
        decimal RoundDouble(decimal inputValue);
        string AbbreviateNumber(AbbreviateTypeEnum abbreviateType, int decimalPoint, decimal number, LanguageEnum lang, CurrencyEnum currency);
        decimal LowerAccuracy(decimal value, int decimalPlaces);
        decimal ConvertToPercentage(decimal value);
        string PlaceholderReplacer(decimal value, string? affix = "");
    }

    public class NumberUtility : INumberUtility
    {
        public decimal RoundDouble(decimal inputValue)
        {
            return Math.Round(inputValue, 2, MidpointRounding.AwayFromZero);
        }

        public string AbbreviateNumber(
            AbbreviateTypeEnum abbreviateType, 
            int decimalPoint, 
            decimal number, 
            LanguageEnum lang, 
            CurrencyEnum currency)
        {
            //var currency = "kr";
            var thousand = "";
            var million = "";
            var billion = "";
            var trillion = "";

            if (abbreviateType == AbbreviateTypeEnum.Currency)
            {
                thousand = (int)lang == 1 ? " k" : $" t{currency.GetDescription()}.";
                million = (int)lang == 1 ? " m" : $" mio. {currency.GetDescription()}.";
                billion = (int)lang == 1 ? " b" : $" mia. {currency.GetDescription()}.";
                trillion = (int)lang == 1 ? " tn" : $" tn. {currency.GetDescription()}.";
            }
            else if (abbreviateType == AbbreviateTypeEnum.Population)
            {
                thousand = (int)lang == 1 ? " thousands" : " tusind";
                million = (int)lang == 1 ? " million" : " mio";
                billion = (int)lang == 1 ? " billions" : " mia";
                trillion = (int)lang == 1 ? " trillion" : " billion";
            }

            var suffix = number < 0 ? "- " : "";
            var numberAbs = Math.Abs(number);

            if (numberAbs < 1000)
            {
                if (abbreviateType == AbbreviateTypeEnum.Currency)
                {
                    return numberAbs.ToString("#0").Replace(",", ".") + " " + currency.GetDescription();
                }
                else if (abbreviateType == AbbreviateTypeEnum.Population)
                {
                    return numberAbs.ToString("#0").Replace(",", ".");
                }
            }

            if (numberAbs < 10_000)
            {
                if (numberAbs % 1000 >= 100)
                    return suffix + Math.Round(numberAbs / 1000m, decimalPoint, MidpointRounding.ToZero).ToString().Replace(",", ".") + thousand;

                return (numberAbs / 1000m).ToString($"{suffix}#{thousand}").Replace(",", ".");
            }

            if (numberAbs < 1_000_000)
            {
                if (numberAbs % 1000 >= 100)
                    return suffix + Math.Round(numberAbs / 1000m, decimalPoint, MidpointRounding.ToZero).ToString().Replace(",", ".") + thousand;

                return (numberAbs / 1000m).ToString($"{suffix}#{thousand}").Replace(",", ".");
            }

            if (numberAbs < 1_000_000_000)
            {
                return suffix + Math.Round(numberAbs / 1_000_000m, decimalPoint, MidpointRounding.ToZero).ToString().Replace(",", ".") + million;
            }

            if (numberAbs < 1_000_000_000_000)
            {
                return suffix + Math.Round(numberAbs / 1_000_000_000m, decimalPoint, MidpointRounding.ToZero).ToString().Replace(",", ".") + billion;
            }

            if (numberAbs < 1_000_000_000_000_000)
            {
                return suffix + Math.Round(numberAbs / 1_000_000_000_000m, decimalPoint, MidpointRounding.ToZero).ToString().Replace(",", ".") + trillion;
            }

            return (numberAbs / 1000000m).ToString($"{suffix}#,0.0{billion}").Replace(",", ".");
        }

        public decimal LowerAccuracy(decimal value, int decimalPlaces)
        {
            bool isNegative = value < 0;
            decimal factor = (decimal)Math.Pow(10, decimalPlaces);
            decimal roundedValue = Math.Round(Math.Abs(value) * factor) / factor;
            if (isNegative)
            {
                roundedValue *= -1;
            }

            return roundedValue;
        }


        public decimal ConvertToPercentage(decimal value)
        {
            return Math.Round(value * 100, 1, MidpointRounding.AwayFromZero);
        }

        public string PlaceholderReplacer(decimal value, string? affix = "")
        {
            if ( value == 0 )
            {
                return "I/O";
            }
            return value.ToString() + affix;
        }
    }

}
