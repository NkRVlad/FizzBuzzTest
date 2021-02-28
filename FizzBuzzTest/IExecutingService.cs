using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    public interface IExecutingService
    {
        List<string> resultTestData1(IEnumerable<int> temp);
        void showResultTestData1();
        List<string> resultTestData3(IEnumerable<string> temp);
        void showResultTestData3();
        List<string> resultTestData2(IEnumerable<int> temp);
        void showResultTestData2();
        void writeToFile();

    }
}
