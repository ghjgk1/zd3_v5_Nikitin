namespace WinFormsApp1
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            addButton = new Button();
            costNumericUpDown = new NumericUpDown();
            areaNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ratingNeumericUpDown = new NumericUpDown();
            addButton1 = new Button();
            removeButton = new Button();
            label6 = new Label();
            indexNumericUpDown = new NumericUpDown();
            indexRemoveButton = new Button();
            groupButton = new Button();
            correctCheckBox = new CheckBox();
            incorrectCheckBox = new CheckBox();
            addSpecialButton = new Button();
            label7 = new Label();
            serviceComboBox = new ComboBox();
            nameComboBox = new ComboBox();
            listBox2 = new ListBox();
            label8 = new Label();
            numberTextBox = new TextBox();
            typeComboBox = new ComboBox();
            comboBox1 = new ComboBox();
            label9 = new Label();
            getInfoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)costNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)areaNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ratingNeumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indexNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(360, 16);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(876, 184);
            listBox1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(14, 212);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(109, 53);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // costNumericUpDown
            // 
            costNumericUpDown.DecimalPlaces = 2;
            costNumericUpDown.Location = new Point(154, 55);
            costNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            costNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            costNumericUpDown.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            costNumericUpDown.Name = "costNumericUpDown";
            costNumericUpDown.Size = new Size(200, 27);
            costNumericUpDown.TabIndex = 4;
            costNumericUpDown.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // areaNumericUpDown
            // 
            areaNumericUpDown.DecimalPlaces = 2;
            areaNumericUpDown.Location = new Point(153, 93);
            areaNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            areaNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            areaNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            areaNumericUpDown.Name = "areaNumericUpDown";
            areaNumericUpDown.Size = new Size(201, 27);
            areaNumericUpDown.TabIndex = 5;
            areaNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 20);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 57);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 8;
            label2.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 96);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 9;
            label3.Text = "Площадь покрытия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 490);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 10;
            label4.Text = "Тип сети";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 173);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 12;
            label5.Text = "Рейтинг";
            // 
            // ratingNeumericUpDown
            // 
            ratingNeumericUpDown.Location = new Point(154, 171);
            ratingNeumericUpDown.Margin = new Padding(3, 4, 3, 4);
            ratingNeumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ratingNeumericUpDown.Name = "ratingNeumericUpDown";
            ratingNeumericUpDown.Size = new Size(200, 27);
            ratingNeumericUpDown.TabIndex = 11;
            // 
            // addButton1
            // 
            addButton1.Location = new Point(129, 212);
            addButton1.Margin = new Padding(3, 4, 3, 4);
            addButton1.Name = "addButton1";
            addButton1.Size = new Size(109, 53);
            addButton1.TabIndex = 13;
            addButton1.Text = "Добавить без рейтинга";
            addButton1.UseVisualStyleBackColor = true;
            addButton1.Click += addButton1_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(245, 212);
            removeButton.Margin = new Padding(3, 4, 3, 4);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(109, 53);
            removeButton.TabIndex = 15;
            removeButton.Text = "Удалить по названию";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 288);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 17;
            label6.Text = "Индекс для удаления";
            // 
            // indexNumericUpDown
            // 
            indexNumericUpDown.Location = new Point(168, 286);
            indexNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            indexNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            indexNumericUpDown.Name = "indexNumericUpDown";
            indexNumericUpDown.Size = new Size(138, 27);
            indexNumericUpDown.TabIndex = 16;
            // 
            // indexRemoveButton
            // 
            indexRemoveButton.Location = new Point(96, 336);
            indexRemoveButton.Margin = new Padding(3, 4, 3, 4);
            indexRemoveButton.Name = "indexRemoveButton";
            indexRemoveButton.Size = new Size(109, 53);
            indexRemoveButton.TabIndex = 18;
            indexRemoveButton.Text = "Удалить по индексу";
            indexRemoveButton.UseVisualStyleBackColor = true;
            indexRemoveButton.Click += indexRemoveButton_Click;
            // 
            // groupButton
            // 
            groupButton.Location = new Point(579, 650);
            groupButton.Margin = new Padding(3, 4, 3, 4);
            groupButton.Name = "groupButton";
            groupButton.Size = new Size(188, 53);
            groupButton.TabIndex = 19;
            groupButton.Text = "Сгруппировать по наличию платы\r\n";
            groupButton.UseVisualStyleBackColor = true;
            groupButton.Click += groupButton_Click;
            // 
            // correctCheckBox
            // 
            correctCheckBox.AutoSize = true;
            correctCheckBox.Location = new Point(6, 425);
            correctCheckBox.Name = "correctCheckBox";
            correctCheckBox.Size = new Size(361, 24);
            correctCheckBox.TabIndex = 21;
            correctCheckBox.Text = "Имеется наличие платы за каждое соединение";
            correctCheckBox.UseVisualStyleBackColor = true;
            // 
            // incorrectCheckBox
            // 
            incorrectCheckBox.AutoSize = true;
            incorrectCheckBox.Location = new Point(6, 455);
            incorrectCheckBox.Name = "incorrectCheckBox";
            incorrectCheckBox.Size = new Size(382, 24);
            incorrectCheckBox.TabIndex = 22;
            incorrectCheckBox.Text = "Не имеется наличие платы за каждое соединение";
            incorrectCheckBox.UseVisualStyleBackColor = true;
            // 
            // addSpecialButton
            // 
            addSpecialButton.Location = new Point(129, 602);
            addSpecialButton.Margin = new Padding(3, 4, 3, 4);
            addSpecialButton.Name = "addSpecialButton";
            addSpecialButton.Size = new Size(163, 53);
            addSpecialButton.TabIndex = 23;
            addSpecialButton.Text = "Добавить больше инфомации";
            addSpecialButton.UseVisualStyleBackColor = true;
            addSpecialButton.Click += addSpecialButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 132);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 25;
            label7.Text = "Услуги";
            // 
            // serviceComboBox
            // 
            serviceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            serviceComboBox.FormattingEnabled = true;
            serviceComboBox.Items.AddRange(new object[] { "Голосовой звонок;", "Автоответчик;", "Роуминг;", "АОН (Автоматический определитель номера);", "Приём и передача коротких текстовых сообщений (SMS);", "Приём и передача мультимедийных сообщений", "Мобильный банк (услуга);", "Доступ в Интернет;", "Видеозвонок и видеоконференция" });
            serviceComboBox.Location = new Point(153, 132);
            serviceComboBox.Name = "serviceComboBox";
            serviceComboBox.Size = new Size(201, 28);
            serviceComboBox.TabIndex = 26;
            // 
            // nameComboBox
            // 
            nameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nameComboBox.FormattingEnabled = true;
            nameComboBox.Items.AddRange(new object[] { "Тинькофф Мобайл", "МТС", "Билайн", "tele2", "Мотив", "Ростелеком", "Yota" });
            nameComboBox.Location = new Point(154, 16);
            nameComboBox.Name = "nameComboBox";
            nameComboBox.Size = new Size(200, 28);
            nameComboBox.TabIndex = 27;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(439, 425);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(808, 184);
            listBox2.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 525);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 30;
            label8.Text = "Телефон";
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(168, 521);
            numberTextBox.Margin = new Padding(3, 4, 3, 4);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(248, 27);
            numberTextBox.TabIndex = 29;
            // 
            // typeComboBox
            // 
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "2G", "3G", "4G", "5G", "LTE", "E" });
            typeComboBox.Location = new Point(169, 487);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(247, 28);
            typeComboBox.TabIndex = 31;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "разработка условий обслуживания", "сбор платежей за свои услуги", "предоставление технической поддержки", "маркетинговые усилия для продвижения услуг на рынке", "разработка стратегического плана развития сети", "технологическое совершенствование инфраструктуры,", "рефарминг используемых радиочастот" });
            comboBox1.Location = new Point(168, 555);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 558);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 32;
            label9.Text = "Цели";
            // 
            // getInfoButton
            // 
            getInfoButton.Location = new Point(836, 650);
            getInfoButton.Margin = new Padding(3, 4, 3, 4);
            getInfoButton.Name = "getInfoButton";
            getInfoButton.Size = new Size(153, 53);
            getInfoButton.TabIndex = 34;
            getInfoButton.Text = "Вывести информацию\r\n";
            getInfoButton.UseVisualStyleBackColor = true;
            getInfoButton.Click += getInfoButton_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 750);
            Controls.Add(getInfoButton);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(typeComboBox);
            Controls.Add(label8);
            Controls.Add(numberTextBox);
            Controls.Add(listBox2);
            Controls.Add(nameComboBox);
            Controls.Add(serviceComboBox);
            Controls.Add(label7);
            Controls.Add(addSpecialButton);
            Controls.Add(incorrectCheckBox);
            Controls.Add(correctCheckBox);
            Controls.Add(groupButton);
            Controls.Add(indexRemoveButton);
            Controls.Add(label6);
            Controls.Add(indexNumericUpDown);
            Controls.Add(removeButton);
            Controls.Add(addButton1);
            Controls.Add(label5);
            Controls.Add(ratingNeumericUpDown);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(areaNumericUpDown);
            Controls.Add(costNumericUpDown);
            Controls.Add(addButton);
            Controls.Add(listBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)costNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)areaNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ratingNeumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)indexNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button addButton;
        private NumericUpDown costNumericUpDown;
        private NumericUpDown areaNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown ratingNeumericUpDown;
        private Button addButton1;
        private Button removeButton;
        private Label label6;
        private NumericUpDown indexNumericUpDown;
        private Button indexRemoveButton;
        private Button groupButton;
        private CheckBox correctCheckBox;
        private CheckBox incorrectCheckBox;
        private Button addSpecialButton;
        private Label label7;
        private ComboBox serviceComboBox;
        private ComboBox nameComboBox;
        private ListBox listBox2;
        private Label label8;
        private TextBox numberTextBox;
        private ComboBox typeComboBox;
        private ComboBox comboBox1;
        private Label label9;
        private Button getInfoButton;
    }
}
