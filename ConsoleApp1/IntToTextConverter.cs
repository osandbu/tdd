namespace XUnitTestProject1
{
    public class IntToTextConverter
    {
        public static string Convert(int number)
        {
            return number switch
            {
                1 => "en",
                2 => "to",
                3 => "tre",
                4 => "fire",
                5 => "fem",
                6 => "seks",
                7 => "sju",
                8 => "åtte",
                9 => "ni",
                _ => "tall ikke støttet"
            };
        }
    }
}