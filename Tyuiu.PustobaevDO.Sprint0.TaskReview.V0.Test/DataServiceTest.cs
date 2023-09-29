using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PustobaevDO.Sprint0.TaskReview.V0.Lib;



namespace Tyuiu.PustobaevDO.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {             
            public bool CheckCalc(int x, int y, int z)
            {
                DataService dataService = new DataService();
                int result = dataService.Calc(x, y, z);
                return result == (x + y + z) * 5;
            }
        
    }
}
