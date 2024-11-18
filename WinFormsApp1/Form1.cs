using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<MobileOperator> operatorsList = new List<MobileOperator>();
        List<SpecialMobileOperator> specialOperatorsList = new List<SpecialMobileOperator>();
        SpecialMobileOperator specialMobileOperator = new SpecialMobileOperator();

        // Создание словаря операторов
        Dictionary<string, List<SpecialMobileOperator>> operatorsDict = new Dictionary<string, List<SpecialMobileOperator>>();

        MobileOperator mobileOperator = new MobileOperator();

        public Form()
        {
            InitializeComponent();
        }

        public bool correct(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (!char.IsLetterOrDigit(chars[i]) && chars[i] != ' ') return false;

            }
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameComboBox.Text != "" && serviceComboBox.Text != "")
            {
                if (correct(nameComboBox.Text))
                {
                    // Добавление оператора
                    MobileOperator.AddOperator(operatorsList, nameComboBox.Text, Convert.ToDouble(costNumericUpDown.Text), Convert.ToDouble(areaNumericUpDown.Text), serviceComboBox.Text, Convert.ToInt32(ratingNeumericUpDown.Text));
                    mobileOperator.GetInfo(operatorsList, listBox1);
                }
                else MessageBox.Show("Данные введены не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Сначала заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            if (nameComboBox.Text != "" && serviceComboBox.Text != "")
            {
                if (correct(nameComboBox.Text))
                {
                    // Добавление оператора Рейтинг по умолчанию
                    MobileOperator.AddOperator(operatorsList, nameComboBox.Text, Convert.ToDouble(costNumericUpDown.Text), serviceComboBox.Text, Convert.ToDouble(areaNumericUpDown.Text));
                    mobileOperator.GetInfo(operatorsList, listBox1);
                }
                else MessageBox.Show("Данные введены не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Сначала заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            // Удаление оператора по названию
            MobileOperator.RemoveOperator(operatorsList, nameComboBox.Text);
            mobileOperator.GetInfo(operatorsList, listBox1);
        }

        private void indexRemoveButton_Click(object sender, EventArgs e)
        {
            // Удаление оператора по индексу
            MobileOperator.RemoveOperator(operatorsList, Convert.ToInt32(indexNumericUpDown.Text));
            mobileOperator.GetInfo(operatorsList, listBox1);
        }


        private void groupButton_Click(object sender, EventArgs e)
        {
            specialMobileOperator.GetGroupInfo(specialMobileOperator.Group(specialOperatorsList), listBox2);
        }

        private void addSpecialButton_Click(object sender, EventArgs e)
        {
            if (nameComboBox.Text != "" && serviceComboBox.Text != "" && typeComboBox.Text != "" && correctCheckBox.Checked || incorrectCheckBox.Checked && numberTextBox.Text != "")
            {
                if (correct(typeComboBox.Text))
                {
                    if (correctCheckBox.Checked && incorrectCheckBox.Checked) MessageBox.Show("Нельзя выбрать два поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        bool availabilityPayment = false;
                        if (correctCheckBox.Checked) availabilityPayment = true;
                        if (incorrectCheckBox.Checked) availabilityPayment = false;
                        // Добавление оператора
                        SpecialMobileOperator.AddOperator(specialOperatorsList, nameComboBox.Text, Convert.ToDouble(costNumericUpDown.Text), Convert.ToDouble(areaNumericUpDown.Text), serviceComboBox.Text, availabilityPayment, Convert.ToInt32(ratingNeumericUpDown.Text), typeComboBox.Text, numberTextBox.Text, " ");
                        specialMobileOperator.GetInfo(specialOperatorsList, listBox2);
                    }
                }
                else MessageBox.Show("Данные введены не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Сначала заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            specialMobileOperator.GetInfo(specialOperatorsList, listBox2);
            SpecialMobileOperator sp= new SpecialMobileOperator("МТС", 4, 25.0, "Роуминг", true, 0, "2G", "(999)111-11-11", "сбор платежей за свои услуги");
            double s = sp.Quality(sp, sp);
        }
    }
}
