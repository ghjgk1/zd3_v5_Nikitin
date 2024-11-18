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

        //���������� ���������� (�������� �����)
        [TestMethod]
        public void Add()
        {
            List<SpecialMobileOperator> expetedList = new List<SpecialMobileOperator>()
            {
                new SpecialMobileOperator("���", 25, 1, "�������", true, 0, "2G", "(999)111-11-11", "���� �������� �� ���� ������")
            };
            List<SpecialMobileOperator> actualList = new List<SpecialMobileOperator>();
            SpecialMobileOperator.AddOperator(actualList, "���", 25, 1, "�������", true, 0, "2G", "(999)111-11-11", "���� �������� �� ���� ������");
            Assert.AreEqual(SpecialMobileOperator.GetInfo(expetedList[0]), SpecialMobileOperator.GetInfo(actualList[0]));
        }

        //�������� ���������� (�������� �����)
        [TestMethod]
        public void firstOverloadRemove()
        {
            List<SpecialMobileOperator> expetedList = new List<SpecialMobileOperator>()
            {
                new SpecialMobileOperator("���", 25, 1, "�������", true, 0, "2G", "(999)111-11-11", "���� �������� �� ���� ������"),
            };
            List<SpecialMobileOperator> actualList = new List<SpecialMobileOperator>()
            {
                new SpecialMobileOperator("���", 25, 1, "�������", true, 0, "2G", "(999)111-11-11", "���� �������� �� ���� ������"),
                new SpecialMobileOperator("������", 25, 1, "�������", true, 0, "2G", "(999)111-11-11", "���� �������� �� ���� ������")
            };
            SpecialMobileOperator.RemoveOperator(actualList, "������");
            Assert.AreEqual(expetedList.Count, actualList.Count);
        }

        //�������� ���������� (�������� �����)
        [TestMethod]
        public void secondOverloadRemove()
        {
            List<SpecialMobileOperator> expetedList = new List<SpecialMobileOperator>()
            {
                new SpecialMobileOperator("���", 25, 1, "�������", true, 0, "2G", "(999)111-11-11", "���� �������� �� ���� ������"),
            };
            List<SpecialMobileOperator> actualList = new List<SpecialMobileOperator>()
            {
                new SpecialMobileOperator("���", 25, 1, "�������", true, 0, "2G", "(999)111-11-11", "���� �������� �� ���� ������"),
                new SpecialMobileOperator("������", 25, 1, "�������", true, 0, "2G", "(999)111-11-11", "���� �������� �� ���� ������")
            };
            SpecialMobileOperator.RemoveOperator(actualList, 1);
            Assert.AreEqual(expetedList.Count, actualList.Count);
        }

        //������� �������� ���� ���� ������� ����� �� ������ ���������� (�������� �����)
        [TestMethod]
        public void QualityTrue()
        {
            SpecialMobileOperator = new SpecialMobileOperator("���", 4, 25.0, "�������", true, 0, "2G", "(999)111-11-11", "���� �������� �� ���� ������");

            Assert.AreEqual(0.7 * (100 * 25 / 4), SpecialMobileOperator.Quality(SpecialMobileOperator, SpecialMobileOperator));
        }

        //������� �������� ���� ��� ������� ����� �� ������ ���������� (�������� �����)
        [TestMethod]
        public void QualityFalse()
        {
            SpecialMobileOperator = new SpecialMobileOperator("���", 4, 25, "�������", false, 0, "2G", "(999)111-11-11", "���� �������� �� ���� ������");

            Assert.AreEqual(1.5 * (100 * 25 / 4), SpecialMobileOperator.Quality(SpecialMobileOperator, SpecialMobileOperator));
        }

        //����� ����������(�������� �����)
        [TestMethod]
        public void GetInfo()
        {
            SpecialMobileOperator SpecialMobileOperator = new SpecialMobileOperator("���", 25, 1, "�������", true, 0, "2G", "(999)111-11-11", "���� �������� �� ���� ������");
            Assert.AreEqual("���251�������0True2G(999)111-11-11���� �������� �� ���� ������", SpecialMobileOperator.GetInfo(SpecialMobileOperator));
        }

        //���������� ���������� (������� �����)
        [TestMethod]
        public void mainAdd()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("���", 25, 1, "�������", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>();
            MobileOperator.AddOperator(actualList, new MobileOperator("���", 25, 1, "�������", 0));
            Assert.AreEqual(MobileOperator.GetInfo(expetedList[0]), MobileOperator.GetInfo(actualList[0]));
        }

        //���������� ���������� (������� �����) ����������
        [TestMethod]
        public void firstOverloadAdd()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("���", 25, 1, "�������", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>();
            MobileOperator.AddOperator(actualList, new MobileOperator("���", 25, 1, "�������", 0));
            Assert.AreEqual(SpecialMobileOperator.GetInfo(expetedList[0]), SpecialMobileOperator.GetInfo(actualList[0]));
        }

        //���������� ���������� (������� �����) ����������
        [TestMethod]
        public void secondOverloadAdd()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("���", 25, 1, "�������", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>();
            MobileOperator.AddOperator(actualList, "���", 25, "�������", 1);
            Assert.AreEqual(MobileOperator.GetInfo(expetedList[0]), MobileOperator.GetInfo(actualList[0]));
        }

        //�������� ���������� (������� �����)
        [TestMethod]
        public void mainRemove()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("���", 25, 1, "�������", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>()
            {
                new MobileOperator("���", 25, 1, "�������", 0),
                new MobileOperator("������", 25, 1, "�������", 0)
            };
            MobileOperator.RemoveOperator(actualList, "������");
            Assert.AreEqual(expetedList.Count, actualList.Count);
        }

        //�������� ���������� (������� �����) ����������
        [TestMethod]
        public void firstMainOverloadRemove()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("���", 25, 1, "�������", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>()
            {
                new MobileOperator("���", 25, 1, "�������", 0),
                new MobileOperator("������", 25, 1, "�������", 0)
            };
            MobileOperator.RemoveOperator(actualList, 1);
            Assert.AreEqual(expetedList.Count, actualList.Count);
        }

        //�������� ���������� (������� �����) ����������
        [TestMethod]
        public void secondMainOverloadRemove()
        {
            List<MobileOperator> expetedList = new List<MobileOperator>()
            {
                new MobileOperator("���", 25, 1, "�������", 0)
            };
            List<MobileOperator> actualList = new List<MobileOperator>()
            {
                new MobileOperator("���", 25, 1, "�������", 0),
                new MobileOperator("������", 26, 1, "�������", 0)
            };
            MobileOperator.RemoveOperator(actualList, 26.0);
            Assert.AreEqual(expetedList.Count, actualList.Count);
        }

        //������� �������� (������� �����)
        [TestMethod]
        public void mainQuality()
        {
            MobileOperator = new MobileOperator("���", 4, 25, "�������", 0);

            Assert.AreEqual(100 * 25 / 4, MobileOperator.Quality(SpecialMobileOperator, MobileOperator));
        }

        //����� ����������(������� �����)
        [TestMethod]
        public void mainGetInfo()
        {
            MobileOperator MobileOperator = new MobileOperator("���", 25, 1, "�������", 0);
            Assert.AreEqual("���251�������0", MobileOperator.GetInfo(MobileOperator));
        }

        //����� ������ �� ������
        [TestMethod]
        public void incorrectLength()
        {
            Assert.AreEqual(false, SpecialMobileOperator.correctNumber("1111111-11-11"));
        }

        //������� ������� ������ �� (
        [TestMethod]
        public void incorrect0Element()
        {
            Assert.AreEqual(false, SpecialMobileOperator.correctNumber("1111)111-11-11"));
        }

        //��������� ������� ������ �� )
        [TestMethod]
        public void incorrect4Element()
        {
            Assert.AreEqual(false, SpecialMobileOperator.correctNumber("(11111111-11-11"));
        }

        //������� ��� ������������ ������� �� -
        [TestMethod]
        public void incorrect8or11Element()
        {
            Assert.AreEqual(false, SpecialMobileOperator.correctNumber("(111)111111-11"));
        }

        //��������� ��������� �� �����
        [TestMethod]
        public void incorrectElement()
        {
            Assert.AreEqual(false, SpecialMobileOperator.correctNumber("(111)1�1-11-11"));
        }

        //������� ��� ������������ ������� �� -
        [TestMethod]
        public void correctNumber()
        {
            Assert.AreEqual(true, SpecialMobileOperator.correctNumber("(111)111-11-11"));
        }
    }
}