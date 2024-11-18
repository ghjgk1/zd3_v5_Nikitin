using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class SpecialMobileOperator : MobileOperator
    {
        public bool availabilityPayment { get; set; }

        // Дополнительные свойства
        public string networkType { get; set; }
        public string number { get; set; }
        public string q3 { get; set; }


        //Конструктор по умолчанию
        public SpecialMobileOperator()
        {
        }
        //Конструктор заполнения
        public SpecialMobileOperator(string name, double cost, double coverage, string service, bool availabilityPayment, int rating, string networkType, string number, string q3) : base(name, cost, coverage, service, rating)
        {
            this.availabilityPayment = availabilityPayment;
            this.networkType = networkType;
            this.number = number;
            this.q3 = q3;
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
                    //если первый элемент (
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
                    listSpecialOperator.Add(new SpecialMobileOperator(name, cost, coverage, service, availabilityPayment, rating, networkType, number, ""));
                }
                else
                {
                    //сообщение об ошибке
                    MessageBox.Show($"Номер введен не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //сообщение об ошибке
                MessageBox.Show($"Такая услуга для оператора '{name}' уже записана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //Вывод группированных объетов
        public void GetGroupInfo(Dictionary<bool, List<SpecialMobileOperator>> groupedOperators, ListBox listBox1)
        {
            listBox1.Items.Clear();
            foreach (var group in groupedOperators)
            {
                if (group.Key) listBox1.Items.Add($"Имеется наличие платы за каждое соединение");
                else listBox1.Items.Add($"Не имеется наличия платы за каждое соединение");
                foreach (var op in group.Value)
                {
                    listBox1.Items.Add($"  - {op.name} {op.service} ");
                }
            }
        }

        //Вывод информации об объекте.
        public void GetInfo(List<SpecialMobileOperator> operatorsList, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var op in operatorsList)
            {
                listBox.Items.Add($"Название: {op.name} Услуга: {op.service} Рейтинг: {op.rating} Качество: {Quality(op, op)} Тип сети: {op.networkType}");
                listBox.Items.Add($"Услуга: {op.service}");
                listBox.Items.Add($"Номер: {op.number}");
                if (op.availabilityPayment) listBox.Items.Add($"Имеется наличие платы за каждое соединение");
                else listBox.Items.Add($"Не имеется наличия платы за каждое соединение");
            }
        }
    }
}
