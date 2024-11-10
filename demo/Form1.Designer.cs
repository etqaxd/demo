namespace demo
{
    partial class Form1
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            code_partner = new DataGridViewTextBoxColumn();
            Partner_type = new DataGridViewTextBoxColumn();
            Name_partner = new DataGridViewTextBoxColumn();
            Director = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            Phone_number = new DataGridViewTextBoxColumn();
            yur_address = new DataGridViewTextBoxColumn();
            inn = new DataGridViewTextBoxColumn();
            Rating = new DataGridViewTextBoxColumn();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            code_produkcia = new DataGridViewTextBoxColumn();
            Production = new DataGridViewTextBoxColumn();
            Partner_name = new DataGridViewTextBoxColumn();
            quantity_prod = new DataGridViewTextBoxColumn();
            min_val = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 209);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 0;
            button1.Text = "Загрузить поставщиков";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { code_partner, Partner_type, Name_partner, Director, email, Phone_number, yur_address, inn, Rating });
            dataGridView1.Location = new Point(3, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(785, 191);
            dataGridView1.TabIndex = 1;
            // 
            // code_partner
            // 
            code_partner.HeaderText = "Код";
            code_partner.Name = "code_partner";
            // 
            // Partner_type
            // 
            Partner_type.HeaderText = "Тип партнера";
            Partner_type.Name = "Partner_type";
            // 
            // Name_partner
            // 
            Name_partner.HeaderText = "Наимнование партнера";
            Name_partner.Name = "Name_partner";
            // 
            // Director
            // 
            Director.HeaderText = "Директор";
            Director.Name = "Director";
            // 
            // email
            // 
            email.HeaderText = "Электронная почта партнера";
            email.Name = "email";
            // 
            // Phone_number
            // 
            Phone_number.HeaderText = "Телефон партнера";
            Phone_number.Name = "Phone_number";
            // 
            // yur_address
            // 
            yur_address.HeaderText = "Юридический адрес партнера";
            yur_address.Name = "yur_address";
            // 
            // inn
            // 
            inn.HeaderText = "ИНН";
            inn.Name = "inn";
            // 
            // Rating
            // 
            Rating.HeaderText = "Рейтинг";
            Rating.Name = "Rating";
            // 
            // button2
            // 
            button2.Location = new Point(3, 415);
            button2.Name = "button2";
            button2.Size = new Size(114, 23);
            button2.TabIndex = 2;
            button2.Text = "Загрузить товары";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { code_produkcia, Production, Partner_name, quantity_prod, min_val });
            dataGridView2.Location = new Point(3, 259);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(785, 150);
            dataGridView2.TabIndex = 3;
            // 
            // code_produkcia
            // 
            code_produkcia.HeaderText = "Код";
            code_produkcia.Name = "code_produkcia";
            // 
            // Production
            // 
            Production.HeaderText = "Тип продукции";
            Production.Name = "Production";
            // 
            // Partner_name
            // 
            Partner_name.HeaderText = "Наименование продукции";
            Partner_name.Name = "Partner_name";
            // 
            // quantity_prod
            // 
            quantity_prod.HeaderText = "Артикул";
            quantity_prod.Name = "quantity_prod";
            // 
            // min_val
            // 
            min_val.HeaderText = "Минимальная стоимость для партнера";
            min_val.Name = "min_val";
            // 
            // button3
            // 
            button3.Location = new Point(159, 209);
            button3.Name = "button3";
            button3.Size = new Size(113, 23);
            button3.TabIndex = 4;
            button3.Text = "Добавить запись";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(123, 415);
            button4.Name = "button4";
            button4.Size = new Size(116, 23);
            button4.TabIndex = 5;
            button4.Text = "Добавить запись";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(278, 209);
            button5.Name = "button5";
            button5.Size = new Size(120, 23);
            button5.TabIndex = 6;
            button5.Text = "Изменить данные";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(245, 415);
            button6.Name = "button6";
            button6.Size = new Size(120, 23);
            button6.TabIndex = 7;
            button6.Text = "Изменить данные";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(404, 209);
            button7.Name = "button7";
            button7.Size = new Size(103, 23);
            button7.TabIndex = 8;
            button7.Text = "Удалить данные";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(371, 415);
            button8.Name = "button8";
            button8.Size = new Size(103, 23);
            button8.TabIndex = 9;
            button8.Text = "Удалить данные";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView2);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridView dataGridView2;
        private Button button3;
        private DataGridViewTextBoxColumn code_produkcia;
        private DataGridViewTextBoxColumn Production;
        private DataGridViewTextBoxColumn Partner_name;
        private DataGridViewTextBoxColumn quantity_prod;
        private DataGridViewTextBoxColumn min_val;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private DataGridViewTextBoxColumn code_partner;
        private DataGridViewTextBoxColumn Partner_type;
        private DataGridViewTextBoxColumn Name_partner;
        private DataGridViewTextBoxColumn Director;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn Phone_number;
        private DataGridViewTextBoxColumn yur_address;
        private DataGridViewTextBoxColumn inn;
        private DataGridViewTextBoxColumn Rating;
    }
}
