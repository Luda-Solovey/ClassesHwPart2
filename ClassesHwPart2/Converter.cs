namespace ClassesHwPart2
{
    public class Converter(double usdToGrn, double eurToGrn, double gbtTogrn)
    {
        public double UsdToGrn { get; } = usdToGrn;

        public double EurToGrn { get; } = eurToGrn;

        public double GbtToGtn { get; } = gbtTogrn;

        //якщо конвертуємо іншу валюту в гривну

        public double ConvertUsdToGrn(double amount)
        {
            return amount * UsdToGrn;
        }

        public double ConvertEurToGrn(double amount)
        {
            return amount * EurToGrn;
        }

        public double ConvertGbtToGrn(double amount)
        {
            return amount * GbtToGtn;
        }

        //якщо конвертуємо гривну в іншу валюту

        public double ConvertGrnToUsd(double amount)
        {
            return amount / UsdToGrn;
        }

        public double ConvertGrnToEur(double amount)
        {
            return amount / EurToGrn;
        }

        public double ConvertGrnToGbt(double amount)
        {
            return amount / GbtToGtn;
        }

    }
}
