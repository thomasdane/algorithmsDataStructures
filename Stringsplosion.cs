namespace algorithmsDataStructures
{
    class Stringsplosion
    {
        public static string Run(string input)
        {
            var result = "";

            for(var i = 0; i < input.Length; i++)
            {
                result += input.Substring(0, i + 1);
            }

            return result;
        }
    }
}
