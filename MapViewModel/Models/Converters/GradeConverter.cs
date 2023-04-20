namespace MapViewModel.Models.Converters
{
    public static class GradeConverter
    {
        private static Dictionary<int, string> _seriesSPE = new()
        {
            { 1, "G2" },
            { 2, "G3" },
            { 3, "G4" },
            { 4, "G5" },
            { 5, "1º ano" },
            { 6, "2º ano" },
            { 7, "3º ano" },
            { 8, "4º ano" },
            { 9, "5º ano" },
            { 10, "6º ano" },
            { 11, "7º ano" },
            { 12, "8º ano" },
            { 13, "9º ano" },
            { 14, "1ª série" },
            { 15, "2ª série" },
            { 16, "Prepara intensivo / Prepara positivo" },
            { 17, "3ª série" },
            { 18, "G1" }
        };

        public static string ConvertToSPESerie(this int? me)
        {
            if (!me.HasValue)
                return string.Empty;

            _seriesSPE.TryGetValue(me.Value, out string result);
            return result;
        }


        public static string ConvertToNomeNivelEnsinoSPE(this string me)
        {
            return me switch
            {
                "MEDIO" => "EM",
                "INFANTIL" => "EI",
                "FUND_1" => "EF1",
                "FUND_2" => "EF2",
                _ => "PRE",
            };
        }
    }
}
