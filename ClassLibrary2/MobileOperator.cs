using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MobileOperator
    {
        public string name { get; set; }
        public double cost { get; set; }
        public double coverage { get; set; }

        // Новое поле: услуга
        public string service { get; set; }

        // Новое поле: рейтинг
        public int rating { get; set; }

        public MobileOperator()
        {

        }

        public MobileOperator(string Name, double Cost, double Coverage, string Service, int Rating)
        {
            name = Name;
            cost = Cost;
            coverage = Coverage;
            service = Service;
            rating = Rating;
        }

        public virtual double Quality(SpecialMobileOperator specialMobileOperator, MobileOperator mobileOperator)
        {
            return 100 * mobileOperator.coverage / mobileOperator.cost;
        }
        public virtual double Quality(MobileOperator mobileOperator)
        {
            return 100 * mobileOperator.coverage / mobileOperator.cost;
        }

        // Метод добавления объекта
        public static void AddOperator(List<MobileOperator> listOperator, MobileOperator mobileOperator)
        {
            int correct = 0;
            foreach (var Operator in listOperator)
            {
                if (Operator.name == mobileOperator.name && Operator.service == mobileOperator.service) correct++;
            }
            //если есть такой элемент
            if (correct == 0) listOperator.Add(mobileOperator);
            else
            {
                //сообщение об ошибке
                listOperator.Add(new MobileOperator());
            }
            listOperator.Add(mobileOperator);
        }

        // Перегрузка метода добавления объекта
        public static void AddOperator(List<MobileOperator> listOperator, string name, double cost, double coverage, string service, int rating)
        {
            int correct = 0;
            foreach (var Operator in listOperator)
            {
                if (Operator.name == name && Operator.service == service) correct++;
            }
            //если есть такой элемент
            if (correct == 0) listOperator.Add(new MobileOperator(name, cost, coverage, service, rating));
            else
            {
                //сообщение об ошибке
                listOperator.Add(new MobileOperator());
            }
        }

        // Перегрузка метода добавления объекта
        public static void AddOperator(List<MobileOperator> listOperator, string name, double cost, string service, double coverage)
        {
            int correct = 0;
            foreach (var Operator in listOperator)
            {
                if (Operator.name == name && Operator.service == service) correct++;
            }
            //если есть такой элемент
            if (correct == 0)
            {
                // Устанавливаем рейтинг по умолчанию
                listOperator.Add(new MobileOperator(name, cost, coverage, service, 0));
            }
            else
            {
                //сообщение об ошибке
                listOperator.Add(new MobileOperator());
            }
        }

        // Метод удаления объекта
        public static void RemoveOperator(List<MobileOperator> list, double cost)
        {
            var operatorToRemove = list.RemoveAll(op => op.cost == cost);
        }

        // Перегрузка метода удаления объекта
        public static void RemoveOperator(List<MobileOperator> list, string name)
        {
            var operatorToRemove = list.RemoveAll(op => op.name == name);
        }

        // Перегрузка метода удаления объекта
        public static void RemoveOperator(List<MobileOperator> list, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
            }
        }

        public string GetInfo(MobileOperator mobileOperator)
        {
            return $"{mobileOperator.name}{mobileOperator.cost}{mobileOperator.coverage}{mobileOperator.service}{mobileOperator.rating}";
        }

    }
}
