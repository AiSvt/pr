namespace pr2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.расчетЗПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вводОтклоненийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетЗПToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hjgjhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.dept_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profess_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отклоненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbox_tabl_name = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчетЗПToolStripMenuItem,
            this.hjgjhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(623, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // расчетЗПToolStripMenuItem
            // 
            this.расчетЗПToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вводОтклоненийToolStripMenuItem,
            this.расчетЗПToolStripMenuItem1});
            this.расчетЗПToolStripMenuItem.Name = "расчетЗПToolStripMenuItem";
            this.расчетЗПToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.расчетЗПToolStripMenuItem.Text = "расчет ЗП";
            // 
            // вводОтклоненийToolStripMenuItem
            // 
            this.вводОтклоненийToolStripMenuItem.Name = "вводОтклоненийToolStripMenuItem";
            this.вводОтклоненийToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.вводОтклоненийToolStripMenuItem.Text = "ввод отклонений";
            // 
            // расчетЗПToolStripMenuItem1
            // 
            this.расчетЗПToolStripMenuItem1.Name = "расчетЗПToolStripMenuItem1";
            this.расчетЗПToolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.расчетЗПToolStripMenuItem1.Text = "расчет ЗП";
            // 
            // hjgjhToolStripMenuItem
            // 
            this.hjgjhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workersToolStripMenuItem,
            this.dept_ToolStripMenuItem,
            this.profess_ToolStripMenuItem,
            this.отклоненияToolStripMenuItem});
            this.hjgjhToolStripMenuItem.Name = "hjgjhToolStripMenuItem";
            this.hjgjhToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.hjgjhToolStripMenuItem.Text = "справочники";
            this.hjgjhToolStripMenuItem.Click += new System.EventHandler(this.hjgjhToolStripMenuItem_Click);
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.workersToolStripMenuItem.Text = "сотрудники";
            this.workersToolStripMenuItem.Click += new System.EventHandler(this.vnnbToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // dept_ToolStripMenuItem
            // 
            this.dept_ToolStripMenuItem.Name = "dept_ToolStripMenuItem";
            this.dept_ToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.dept_ToolStripMenuItem.Text = "отделы";
            // 
            // profess_ToolStripMenuItem
            // 
            this.profess_ToolStripMenuItem.Name = "profess_ToolStripMenuItem";
            this.profess_ToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.profess_ToolStripMenuItem.Text = "должности";
            // 
            // отклоненияToolStripMenuItem
            // 
            this.отклоненияToolStripMenuItem.Name = "отклоненияToolStripMenuItem";
            this.отклоненияToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.отклоненияToolStripMenuItem.Text = "отклонения";
            // 
            // cbox_tabl_name
            // 
            this.cbox_tabl_name.ContextMenuStrip = this.contextMenuStrip1;
            this.cbox_tabl_name.FormattingEnabled = true;
            this.cbox_tabl_name.Location = new System.Drawing.Point(303, 4);
            this.cbox_tabl_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox_tabl_name.Name = "cbox_tabl_name";
            this.cbox_tabl_name.Size = new System.Drawing.Size(23, 24);
            this.cbox_tabl_name.TabIndex = 1;
            this.cbox_tabl_name.SelectedIndexChanged += new System.EventHandler(this.cbox_tabl_name_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(297, 192);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "сотрудники",
            "отделы"});
            this.comboBox1.Location = new System.Drawing.Point(320, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "сотрудники";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 220);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbox_tabl_name);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem hjgjhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dept_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profess_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отклоненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчетЗПToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вводОтклоненийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчетЗПToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbox_tabl_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}