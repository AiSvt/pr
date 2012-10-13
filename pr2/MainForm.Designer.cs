namespace pr2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_passport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_adress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_birth_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_f_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_last_name = new System.Windows.Forms.TextBox();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_proff = new System.Windows.Forms.ComboBox();
            this.tb_fio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.worker_table = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.num_money = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp_entry = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.worker_table.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_money)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tb_passport);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tb_adress);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtp_birth_date);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tb_f_name);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_last_name);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(702, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "о физическом лице";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 13;
            this.button1.Text = "создать запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_passport
            // 
            this.tb_passport.Location = new System.Drawing.Point(190, 236);
            this.tb_passport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_passport.Name = "tb_passport";
            this.tb_passport.Size = new System.Drawing.Size(76, 20);
            this.tb_passport.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "паспортные данные:серия,номер";
            // 
            // tb_adress
            // 
            this.tb_adress.Location = new System.Drawing.Point(118, 167);
            this.tb_adress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(559, 20);
            this.tb_adress.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "место регистрации";
            // 
            // dtp_birth_date
            // 
            this.dtp_birth_date.Location = new System.Drawing.Point(118, 98);
            this.dtp_birth_date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_birth_date.Name = "dtp_birth_date";
            this.dtp_birth_date.Size = new System.Drawing.Size(151, 20);
            this.dtp_birth_date.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "дата рождения";
            // 
            // tb_f_name
            // 
            this.tb_f_name.Location = new System.Drawing.Point(270, 39);
            this.tb_f_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_f_name.Name = "tb_f_name";
            this.tb_f_name.Size = new System.Drawing.Size(133, 20);
            this.tb_f_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // tb_last_name
            // 
            this.tb_last_name.Location = new System.Drawing.Point(92, 39);
            this.tb_last_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(145, 20);
            this.tb_last_name.TabIndex = 0;
            // 
            // cb_dept
            // 
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Location = new System.Drawing.Point(46, 84);
            this.cb_dept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(92, 21);
            this.cb_dept.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "отдел";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "должность";
            // 
            // cb_proff
            // 
            this.cb_proff.FormattingEnabled = true;
            this.cb_proff.Location = new System.Drawing.Point(64, 140);
            this.cb_proff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_proff.Name = "cb_proff";
            this.cb_proff.Size = new System.Drawing.Size(92, 21);
            this.cb_proff.TabIndex = 6;
            // 
            // tb_fio
            // 
            this.tb_fio.Location = new System.Drawing.Point(40, 41);
            this.tb_fio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_fio.Name = "tb_fio";
            this.tb_fio.Size = new System.Drawing.Size(213, 20);
            this.tb_fio.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ФИО";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 186);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "оклад";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 231);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "дата приема";
            // 
            // worker_table
            // 
            this.worker_table.Controls.Add(this.tabPage1);
            this.worker_table.Controls.Add(this.tabPage2);
            this.worker_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worker_table.Location = new System.Drawing.Point(0, 0);
            this.worker_table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.worker_table.Name = "worker_table";
            this.worker_table.SelectedIndex = 0;
            this.worker_table.Size = new System.Drawing.Size(710, 313);
            this.worker_table.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_id);
            this.tabPage2.Controls.Add(this.num_money);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.dtp_entry);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.cb_proff);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cb_dept);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tb_fio);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(702, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "о сотруднике";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(556, 15);
            this.tb_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(76, 20);
            this.tb_id.TabIndex = 13;
            // 
            // num_money
            // 
            this.num_money.Location = new System.Drawing.Point(64, 186);
            this.num_money.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_money.Name = "num_money";
            this.num_money.Size = new System.Drawing.Size(90, 20);
            this.num_money.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(341, 231);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "приказы";
            // 
            // dtp_entry
            // 
            this.dtp_entry.Location = new System.Drawing.Point(82, 231);
            this.dtp_entry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_entry.Name = "dtp_entry";
            this.dtp_entry.Size = new System.Drawing.Size(151, 20);
            this.dtp_entry.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "таб.№(присваивается автоматически";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 313);
            this.Controls.Add(this.worker_table);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.worker_table.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_money)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_passport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_adress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_birth_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_f_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_last_name;
        private System.Windows.Forms.ComboBox cb_dept;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_proff;
        private System.Windows.Forms.TextBox tb_fio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl worker_table;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.NumericUpDown num_money;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_entry;
        private System.Windows.Forms.Label label8;

    }
}