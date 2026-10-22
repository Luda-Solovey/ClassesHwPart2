namespace ClassesHwPart2
{
    public class Converter(double usdToGrn, double eurToGrn, double gbtTogrn)
    {
        public double UsdRate { get; } = usdToGrn;

        public double EurRate { get; } = eurToGrn;

        public double GbtRate { get; } = gbtTogrn;

        //якщо конвертуємо іншу валюту в гривну

        public double ConvertUsdToGrn(double amount)
        {
            return amount * UsdRate;
        }

        public double ConvertEurToGrn(double amount)
        {
            return amount * EurRate;
        }

        public double ConvertGbtToGrn(double amount)
        {
            return amount * GbtRate;
        }

        //якщо конвертуємо гривну в іншу валюту

        public double ConvertGrnToUsd(double amount)
        {
            return amount / UsdRate;
        }

        public double ConvertGrnToEur(double amount)
        {
            return amount / EurRate;
        }

        public double ConvertGrnToGbt(double amount)
        {
            return amount / GbtRate;
        }

    }
}
