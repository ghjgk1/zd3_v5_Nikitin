using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SpecialMobileOperator : MobileOperator
    {
        public bool availabilityPayment { get; set; }

        // Дополнительные свойства
        public string networkType { get; set; }
        public string number { get; set; }
        public string objective { get; set; }


        //Конструктор по умолчанию
        public SpecialMobileOperator()
        {
        }
        //Конструктор заполнения
        public SpecialMobileOperator(string name, double cost, double coverage, string service, bool availabilityPayment, int rating, string networkType, string number, string objective) : base(name, cost, coverage, service, rating)
        {
            this.availabilityPayment = availabilityPayment;
            this.networkType = networkType;
            this.number = number;
            this.objective = objective;
        }

        //Функция, которая определяет качество объекта
        public override double Quality(SpecialMobileOperator specialMobileOperator, MobileOperator mobileOperator)
        {
            if (specialMobileOperator.availabilityPayment == true) return 0.7 * base.Quality(specialMobileOperator, mobileOperator);
            else return 1.5 * base.Quality(specialMobileOperator, mobileOperator);
        }

        public static bool correctNumber(string phone)
        {
            //если номер равен 14 символов
            if (phone.Length == 14)
            {
                char[] ch = phone.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    //если нулевой элемент (
                    if (i == 0)
                        if (ch[0] != '(') return false;
                        else;
                    //если четвертый элемент )
                    else if (i == 4)
                        if (ch[4] != ')') return false;
                        else;
                    //если восьмой и одиннадцатый элемент -
                    else if (i == 8 || i == 11)
                        if (ch[8] != '-' || ch[11] != '-') return false;
                        else;
                    //если остальные символы числа
                    else
                        if (!char.IsDigit(ch[i])) return false;
                }
            }
            else return false;
            return true;
        }

        public static void AddOperator(List<SpecialMobileOperator> listSpecialOperator, string name, double cost, double coverage, string service, bool availabilityPayment, int rating, string networkType, string number, string q3)
        {
            int correct = 0;
            foreach (var Operator in listSpecialOperator)
            {
                if (Operator.name == name && Operator.service == service) correct++;
            }
            //если есть такой элемент
            if (correct == 0)
            {
                if (SpecialMobileOperator.correctNumber(number))
                {
                    // Устанавливаем рейтинг по умолчанию
                    listSpecialOperator.Add(new SpecialMobileOperator(name, cost, coverage, service, availabilityPayment, rating, networkType, number, q3));
                }
                else
                {
                    //сообщение об ошибке
                    listSpecialOperator.Add(new SpecialMobileOperator());
                }
            }
            else
            {
                //сообщение об ошибке
                listSpecialOperator.Add(new SpecialMobileOperator());
            }
        }
        //Добавил свою функцию для класса потомка (группировка)
        public Dictionary<bool, List<SpecialMobileOperator>> Group(List<SpecialMobileOperator> mobileOperators)
        {
            // Группировка операторов по стоимости
            return mobileOperators
                .GroupBy(op => op.availabilityPayment)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        //Вывод информации об объекте.
        public string GetInfo(SpecialMobileOperator mobileOperator)
        {
            return $"{mobileOperator.name}{mobileOperator.cost}{mobileOperator.coverage}{mobileOperator.service}{mobileOperator.rating}{mobileOperator.availabilityPayment}{mobileOperator.networkType}{mobileOperator.number}{mobileOperator.objective}";
        }

        // Перегрузка метода удаления объекта
        public static void RemoveOperator(List<SpecialMobileOperator> list, string name)
        {
            var operatorToRemove = list.RemoveAll(op => op.name == name);
        }

        // Перегрузка метода удаления объекта
        public static void RemoveOperator(List<SpecialMobileOperator> list, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
            }
        }
    }
}
