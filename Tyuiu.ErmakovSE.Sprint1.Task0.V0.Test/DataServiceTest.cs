using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ErmakovSE.Sprint1.Task0.V24.Lib;


namespace Tyuiu.ErmakovSE.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            // Создаем объект
            DataService ds = new DataService();

            // Ожидаемое значение
            double wait = 2.0;

            // Получаем фактическое значение
            double res = ds.Calculate();

            // Сравниваем
            Assert.AreEqual(wait, res);
        }
    }
}
