namespace Lab1
{
    public class StreetCleaner
    {
        public int numberOfBrooms;
        public int[] degreeOfWear = new int[5];
        public static int numberOfStreetCleaners;

        public StreetCleaner()
        {
            numberOfBrooms = 8;
            degreeOfWear = new int[5]{1,2,3,4,5};
            numberOfStreetCleaners = 10;
            numberOfStreetCleaners++;
        }

        public StreetCleaner(int NumberOfBrooms)
        {
            numberOfBrooms = NumberOfBrooms;
            numberOfStreetCleaners++;
        }
        public StreetCleaner(int NumberOfBrooms, int[] DegreeOfWear)
        {
            numberOfBrooms = NumberOfBrooms;
            degreeOfWear = DegreeOfWear;
            numberOfStreetCleaners++;
        }
        public StreetCleaner(int NumberOfBrooms, int[] DegreeOfWear, int NumberOfStreetCleaners)
        {
            numberOfBrooms = NumberOfBrooms;
            degreeOfWear = DegreeOfWear;
            numberOfStreetCleaners = NumberOfStreetCleaners;
            numberOfStreetCleaners++;
        }
        public StreetCleaner(StreetCleaner streetCleaner)
        {
            numberOfBrooms = streetCleaner.numberOfBrooms;
            degreeOfWear = streetCleaner.degreeOfWear;
            numberOfStreetCleaners++;
        }

        public void PrintFields()
        {
            string[] degreeOfWearResult = degreeOfWear.Select(i => i.ToString()).ToArray();
            Console.WriteLine($"Number of brooms: {numberOfBrooms}; degrees of wear: {String.Join(",", degreeOfWearResult)}; number of street cleaners {numberOfStreetCleaners}.");
        }
    }
}