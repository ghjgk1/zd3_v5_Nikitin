using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class MobileOperator
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
                MessageBox.Show($"Такая услуга для оператора '{mobileOperator.name}' уже записана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Такая услуга для оператора '{name}' уже записана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Такая услуга для оператора '{name}' уже записана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Вывод информации об объекте.
        public virtual void GetInfo(List<SpecialMobileOperator> operatorsList, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var op in operatorsList)
            {
                listBox.Items.Add($"Название: {op.name} Услуга: {op.service} Рейтинг: {op.rating} Качество: {Quality(op, op)}");
            }
        }

        public virtual void GetInfo(List<MobileOperator> operatorsList, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var op in operatorsList)
            {
                listBox.Items.Add($"Название: {op.name} Услуга: {op.service} Рейтинг: {op.rating} Качество: {Quality(op)}");
            }
        }
    }
}
