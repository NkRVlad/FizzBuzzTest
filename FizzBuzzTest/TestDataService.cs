using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzTest
{
    public class TestDataService
    {
        public IEnumerable<int> GetTestData1()
        {
            return Enumerable.Range(0, 17);
        }

        public IEnumerable<int> GetTestData2()
        {
            return Enumerable.Range(0, 21);
        }

        public IEnumerable<string> GetTestData3()
        {
            return new string[]
            {
                "V422R651",
                "V422R395",
                "V422R682",
                "V402R673",
                "V422R651",
                "V422R650",
                "V402R651",
            };
        }
    }
}
