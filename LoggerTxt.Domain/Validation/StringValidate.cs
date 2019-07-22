namespace LoggerTxt.Domain.Validation
{
    public static class StringValidate
    {
        public static string RemoveEspecialCaractere(this string value)
        {
            return value.Replace(@"\","").Replace("/","").Replace(":","")
                        .Replace("*","").Replace("?", "").Replace("<", "")
                        .Replace(">", "").Replace("|", "").Replace(" ","");
        }
    }
}
