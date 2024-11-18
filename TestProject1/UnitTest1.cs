using ClassLibrary1;
using ClassLibrary2;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        MobileOperator MobileOperator = new MobileOperator();
        SpecialMobileOperator SpecialMobileOperator = new SpecialMobileOperator();

        //Добавление информации (дочерний класс)
        [TestMethod]
        public void Add()
        {
            List<SpecialMobileOperator> expetedList = new List<SpecialMobileOperator>()
            {
                new SpecialMobileOperator("МТС", 25, 1, "Роуминг", true, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги")
            };
            List<SpecialMobileOperator> actualList = new List<SpecialMobileOperator>();
            SpecialMobileOperator.AddOperator(actualList, "МТС", 25, 1, "Роуминг", true, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги");
            Assert.AreEqual(SpecialMobileOperator.GetInfo(expetedList[0]), SpecialMobileOperator.GetInfo(actualList[0]));
        }

        //Удаление информации (дочерний класс)
        [TestMethod]
        public void firstOverloadRemove()
        {
            List<SpecialMobileOperator> expetedList = new List<SpecialMobileOperator>()
            {
                new SpecialMobileOperator("МТС", 25, 1, "Роуминг", true, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги"),
            };
            List<SpecialMobileOperator> actualList = new List<SpecialMobileOperator>()
            {
                new SpecialMobileOperator("МТС", 25, 1, "Роуминг", true, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги"),
                new SpecialMobileOperator("Билайн", 25, 1, "Роуминг", true, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги")
            };
            SpecialMobileOperator.RemoveOperator(actualList, "Билайн");
            Assert.AreEqual(expetedList.Count, actualList.Count);
        }

        //Удаление информации (дочерний класс)
        [TestMethod]
        public void secondOverloadRemove()
        {
            List<SpecialMobileOperator> expetedList = new List<SpecialMobileOperator>()
            {
                new SpecialMobileOperator("МТС", 25, 1, "Роуминг", true, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги"),
            };
            List<SpecialMobileOperator> actualList = new List<SpecialMobileOperator>()
            {
                new SpecialMobileOperator("МТС", 25, 1, "Роуминг", true, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги"),
                new SpecialMobileOperator("Билайн", 25, 1, "Роуминг", true, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги")
            };
            SpecialMobileOperator.RemoveOperator(actualList, 1);
            Assert.AreEqual(expetedList.Count, actualList.Count);
        }

        //Подсчет качества если есть наличие платы за каждое соединение (дочерний класс)
        [TestMethod]
        public void QualityTrue()
        {
            SpecialMobileOperator = new SpecialMobileOperator("МТС", 4, 25.0, "Роуминг", true, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги");

            Assert.AreEqual(0.7 * (100 * 25 / 4), SpecialMobileOperator.Quality(SpecialMobileOperator, SpecialMobileOperator));
        }

        //Подсчет качества если нет наличия платы за каждое соединение (дочерний класс)
        [TestMethod]
        public void QualityFalse()
        {
            SpecialMobileOperator = new SpecialMobileOperator("МТС", 4, 25, "Роуминг", false, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги");

            Assert.AreEqual(1.5 * (100 * 25 / 4), SpecialMobileOperator.Quality(SpecialMobileOperator, SpecialMobileOperator));
        }

        //Вывод информации(дочерний класс)
        [TestMethod]
        public void GetInfo()
        {
            SpecialMobileOperator SpecialMobileOperator = new SpecialMobileOperator("МТС", 25, 1, "Роуминг", true, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги");
            Assert.AreEqual("МТС251Роуминг0True2G(999)111-11-11сбор платежей за свои услуги", SpecialMobileOperator.GetInfo(SpecialMobileOperator));
        }

        //Добавление информации (базовый класс)
        [TestMethod]
        public void mainAdd()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("МТС", 25, 1, "Роуминг", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>();
            MobileOperator.AddOperator(actualList, new MobileOperator("МТС", 25, 1, "Роуминг", 0));
            Assert.AreEqual(MobileOperator.GetInfo(expetedList[0]), MobileOperator.GetInfo(actualList[0]));
        }

        //Добавление информации (базовый класс) перегрузка
        [TestMethod]
        public void firstOverloadAdd()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("МТС", 25, 1, "Роуминг", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>();
            MobileOperator.AddOperator(actualList, new MobileOperator("МТС", 25, 1, "Роуминг", 0));
            Assert.AreEqual(SpecialMobileOperator.GetInfo(expetedList[0]), SpecialMobileOperator.GetInfo(actualList[0]));
        }

        //Добавление информации (базовый класс) перегрузка
        [TestMethod]
        public void secondOverloadAdd()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("МТС", 25, 1, "Роуминг", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>();
            MobileOperator.AddOperator(actualList, "МТС", 25, "Роуминг", 1);
            Assert.AreEqual(MobileOperator.GetInfo(expetedList[0]), MobileOperator.GetInfo(actualList[0]));
        }

        //Удаление информации (базовый класс)
        [TestMethod]
        public void mainRemove()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("МТС", 25, 1, "Роуминг", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>()
            {
                new MobileOperator("МТС", 25, 1, "Роуминг", 0),
                new MobileOperator("Билайн", 25, 1, "Роуминг", 0)
            };
            MobileOperator.RemoveOperator(actualList, "Билайн");
            Assert.AreEqual(expetedList.Count, actualList.Count);
        }

        //Удаление информации (базовый класс) перегрузка
        [TestMethod]
        public void firstMainOverloadRemove()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("МТС", 25, 1, "Роуминг", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>()
            {
                new MobileOperator("МТС", 25, 1, "Роуминг", 0),
                new MobileOperator("Билайн", 25, 1, "Роуминг", 0)
            };
            MobileOperator.RemoveOperator(actualList, 1);
            Assert.AreEqual(expetedList.Count, actualList.Count);
        }

        //Удаление информации (базовый класс) перегрузка
        [TestMethod]
        public void secondMainOverloadRemove()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("МТС", 25, 1, "Роуминг", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>()
            {
                new MobileOperator("МТС", 25, 1, "Роуминг", 0),
                new MobileOperator("Билайн", 26, 1, "Роуминг", 0)
            };
            MobileOperator.RemoveOperator(actualList, 26.0);
            Assert.AreEqual(expetedList.Count, actualList.Count);
        }

        //Подсчет качества (базовый класс)
        [TestMethod]
        public void mainQuality()
        {
            MobileOperator = new MobileOperator("МТС", 4, 25, "Роуминг", 0);

            Assert.AreEqual(100 * 25 / 4, MobileOperator.Quality(SpecialMobileOperator, MobileOperator));
        }

        //Вывод информации(базовый класс)
        [TestMethod]
        public void mainGetInfo()
        {
            MobileOperator MobileOperator = new MobileOperator("МТС", 25, 1, "Роуминг", 0);
            Assert.AreEqual("МТС251Роуминг0", MobileOperator.GetInfo(MobileOperator));
        }

        //Длина номера не верная
        [TestMethod]
        public void incorrectLength()
        {
            Assert.AreEqual(false, SpecialMobileOperator.correctNumber("1111111-11-11"));
        }

        //Нулевой элемент номера не (
        [TestMethod]
        public void incorrect0Element()
        {
            Assert.AreEqual(false, SpecialMobileOperator.correctNumber("1111)111-11-11"));
        }

        //Четвертый элемент номера не )
        [TestMethod]
        public void incorrect4Element()
        {
            Assert.AreEqual(false, SpecialMobileOperator.correctNumber("(11111111-11-11"));
        }

        //Восьмой или одиннадцатый элемент не -
        [TestMethod]
        public void incorrect8or11Element()
        {
            Assert.AreEqual(false, SpecialMobileOperator.correctNumber("(111)111111-11"));
        }

        //Остальные эелементы не числа
        [TestMethod]
        public void incorrectElement()
        {
            Assert.AreEqual(false, SpecialMobileOperator.correctNumber("(111)1к1-11-11"));
        }

        //Восьмой или одиннадцатый элемент не -
        [TestMethod]
        public void correctNumber()
        {
            Assert.AreEqual(true, SpecialMobileOperator.correctNumber("(111)111-11-11"));
        }
    }
}